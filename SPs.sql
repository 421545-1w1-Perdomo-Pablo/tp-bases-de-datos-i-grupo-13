--ESTA CONSULTA DEVUELVE CUAL ES EL TIPO DE CANCHA MÁS PEDIDO, 1: F11, 2: F7, 3: F5

CREATE PROCEDURE sp_tipocancha_mas_pedido
AS
BEGIN
SELECT TOP 1 tc.id_tipo_cancha,
    tc.tipo_cancha,
    COUNT(*) AS CantidadTurnos
FROM Turnos t

JOIN Reservas_turnos rt ON rt.id_turno = t.id_turno
JOIN Canchas C on c.id_cancha = rt.id_cancha
JOIN Tipos_cancha tc ON tc.id_tipo_cancha = c.id_tipo_cancha
GROUP BY tc.id_tipo_cancha, tc.tipo_cancha
ORDER BY CantidadTurnos DESC;
END

--PARA VERIFICAR CANTIDADES
select r.*, c.descripcion_cancha from reservas_turnos r
join Canchas c ON c.id_cancha = r.id_cancha

EXEC sp_tipocancha_mas_pedido

 

--SP QUE DEVUELVE UNA LISTA DE HORAS, Y CUANTAS VECES SE SOLICITO UN TURNO EN ESA HORA, DENTRO DE UN PERIODO
CREATE PROCEDURE sp_HorariosMasConcurridos
    @fechaInicio DATE = NULL,
    @fechaFin DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        t.hora_inicio_turno,
        COUNT(*) AS CantidadTurnos
    FROM Turnos t
    WHERE 
        -- Si se pasan fechas, filtra por el rango
        (@fechaInicio IS NULL OR t.fecha_turno >= @fechaInicio)
        AND (@fechaFin IS NULL OR t.fecha_turno <= @fechaFin)
    GROUP BY t.hora_inicio_turno
    ORDER BY CantidadTurnos DESC;
END
GO

EXEC sp_HorariosMasConcurridos '2025-6-1', '2025-11-30'

--ESTE SP RETORNA UNA LISTA DE LOS CLIENTES MAS FRECUENTES, EN BASE A LA CANTIDAD DE RESERVAS QUE REALIZAN, DURANTE EL ULTIMO AÑO 
--(No el año ACTUAL sino los ultimos 365 días, esto para evitar que al iniciar un nuevo año se reinicie el contador)
ALTER PROCEDURE sp_clientes_mas_frecuentes
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.id_cliente,
        c.nombre_cliente,
        c.apellido_cliente,
        COUNT(*) AS CantidadReservas
    FROM Turnos t
    JOIN Reservas_turnos rt ON rt.id_turno = t.id_turno
    JOIN Clientes c ON c.id_cliente = t.id_cliente
    WHERE t.fecha_turno >= DATEADD(DAY, -365, GETDATE())
    GROUP BY c.id_cliente, c.nombre_cliente, c.apellido_cliente
    ORDER BY CantidadReservas DESC;
END
GO

SELECT * FROM Turnos

EXEC sp_clientes_mas_frecuentes

--SP QUE DEVUELVE LA RECAUDACION DE LAS CLASES, con filtro de fechas
ALTER PROCEDURE sp_recaudacion_clases
    @fecha_inicio DATE = NULL,
    @fecha_fin DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        tc.id_tipo_clase,
        tc.tipo_clase,
        SUM(df.precio_unitario_clases * ISNULL(df.cantidad_clases, 1)) AS TotalRecaudado
    FROM Detalles_facturas_clases df
    INNER JOIN Clases c ON c.id_clase = df.id_clase
    INNER JOIN Tipos_clases tc ON tc.id_tipo_clase = c.id_tipo_clase
    INNER JOIN Facturas_canchas f ON f.id_factura_cancha = df.id_factura_cancha
    WHERE
        (@fecha_inicio IS NULL OR f.fecha_factura_cancha >= @fecha_inicio)
        AND
        (@fecha_fin IS NULL OR f.fecha_factura_cancha <= @fecha_fin)
    GROUP BY tc.id_tipo_clase, tc.tipo_clase
    ORDER BY TotalRecaudado DESC;
END
GO

EXEC sp_recaudacion_clases '2025-1-1', '2025-6-30'


--ESTE SP MUESTRA cuantas unidades se vendieron de un producto en los ultimos 3 veces, esto con la idea de poder preveer el stock necesario
CREATE PROCEDURE sp_tendencia_productos_bar
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id_producto,
        p.nombre_producto,
        YEAR(f.fecha_factura_bar) AS Año,
        MONTH(f.fecha_factura_bar) AS Mes,
        DATENAME(MONTH, f.fecha_factura_bar) AS NombreMes,
        SUM(op.cantidad_producto) AS TotalVendido,
        SUM(op.cantidad_producto * op.precio_unitario_producto) AS TotalRecaudado
    FROM Ordenes_productos op
    INNER JOIN Productos_bar p ON p.id_producto = op.id_producto
    INNER JOIN Ordenes o ON o.id_orden = op.id_orden
    INNER JOIN Facturas_bar f ON f.id_orden = o.id_orden
    WHERE f.fecha_factura_bar >= DATEADD(MONTH, -3, GETDATE())
    GROUP BY 
        p.id_producto, 
        p.nombre_producto, 
        YEAR(f.fecha_factura_bar),
        MONTH(f.fecha_factura_bar),
        DATENAME(MONTH, f.fecha_factura_bar)
    ORDER BY p.nombre_producto, Año, Mes;
END
GO

EXEC sp_tendencia_productos_bar

