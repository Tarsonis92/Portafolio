using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Contract
{
    interface Metodos_CRUD<T>
    {
       
        List<T> Listar();

        void Agregar_Usuario(string nombre, string apellido, string contrasena, string correo, int id_tipo);
        void Actualizar_Usuario(int id_usuario, string nombre, string apellido, string contrasena, string correo, int id_tipo);
        void Eliminar_Usuario(int id_usuario);



         List<Producto> Listar_producto();

         void Actualizar_Producto(int id_producto, String nombre, int precio, DateTime tiempo_preparacion, string descripcion,/*string imagen,*/int cate_prod_id_categoria);
        void Agregar_Producto(String nombre, int precio, DateTime tiempo_preparacion, string descripcion,/*string imagen,*/int cate_prod_id_categoria);
         void Eliminar_Producto(int id_producto);


         List<Producto> Listar_Deta_producto();

        void Actualizar_Deta_producto(int id_detalle, int cantidad, int ingrediente_id_ingrediente, int producto_id_producto);
        void Agregar_Deta_producto(int cantidad, int ingrediente_id_ingrediente, int producto_id_producto);
        void Eliminar_Deta_producto(int id_detalle);

         List<Proveedor> Listar_Proveedor();

        void  Actualizar_Proveedor(int id_proveedor, String nombre, String direccion, String rut, int telefono, string correo);
        void Agregar_Proveedor(String nombre, String direccion, String rut, int telefono, string correo);
        void Eliminar_Proveedor(int id_proveedor);

         List<Ingrediente> Listar_Ingrediente():

        void Actualizar_Ingrediente(int id_ingrediente, string nombre,DateTime ingreso, DateTime vencimiento);
        void Agregar_Ingrediente(string nombre, DateTime ingreso, DateTime vencimiento);
         void Eliminar_Ingrediente(int id_ingrediente);


         List<DeorComp> Listar_DeorComp()

         void Actualizar_DeorComp(int id_detalle, int cantidad, int total_compra, int ingrediente_id_ingrediente);
         void Agregar_DeorComp(int cantidad, int total_compra, int ingrediente_id_ingrediente);
         void Eliminar_DeorComp(int id_detalle);

        List<Reservacion> Listar_reservacion()

        void Actualizar_Reservacion(int id_reservacion, DateTime fecha_hora,int cantidad_personas, int cliente_id_cliente, int mesa_id_mesa);
        void Agregar_Reservacion(DateTime fecha_hora,int cantidad_personas, int cliente_id_cliente, int mesa_id_mesa);
        void Eliminar_Reservacion(int id_reservacion);

        List<Cliente> Listar_cliente();

        void Actualizar_Cliente(int id_cliente,String rut,String nombre, String apellido);
        void Agregar_Cliente(String rut, String nombre, String apellido);
        void Eliminar_Cliente(int id_cliente);

        List<Comanda> Listar_Comanda();

        void Actualizar_Comanda(int id_comanda, int mesa_id_mesa,DateTime fecha_orden,DateTime hora_entrada,DateTime hora_salida);
         void Agregar_Comanda(int mesa_id_mesa, DateTime fecha_orden, DateTime hora_entrada, DateTime hora_salida);
         void Eliminar_Comanda(int id_comanda);


        List<DetaComan> Listar_DetaComan();

        void Actualizar_DetaComan(int id_detalle, int cantidad,int producto_id_producto,int comanda_id_comanda);
        void Agregar_DetaComan(int cantidad, int producto_id_producto, int comanda_id_comanda);
        void Eliminar_DetaComan(int id_detalle);

        List<Cuenta> Listar_Cuenta();

        void Actualizar_Cuenta(int id_cuenta, DateTime fecha_emision,DateTime fecha_pago,char estado_pago,int vuelto,
            int total_cuenta,int comanda_id_comanda,int cliente_id_cliente,int tipo_pago_id_tipo);
        void Agregar_Cuenta(DateTime fecha_emision, DateTime fecha_pago, char estado_pago, int vuelto,
            int total_cuenta, int comanda_id_comanda, int cliente_id_cliente, int tipo_pago_id_tipo);
         void Eliminar_Cuenta(int id_cuenta);


         List<Tipo_pago> Listar_Tipo_pago();

         void Actualizar_Tipo_pago(int id_tipo, String nombre);
        void Agregar_Tipo_pago(String nombre);
         void Eliminar_Tipo_pago(int tipo_pago);

        List<Orden_Compra> Listar_Orden_Compra();

        void Actualizar_Orden_compra(int id_compra,DateTime fecha_emision,char estado_pago,String observaciones, int proveedor_id_proveedor,
            int usuario_id_usuario,int tipo_pago_id_tipo);
        void Agregar_Orden_compra(DateTime fecha_emision, char estado_pago, String observaciones, int proveedor_id_proveedor,
            int usuario_id_usuario, int tipo_pago_id_tipo);
        void Eliminar_Orden_compra(int id_compra);
    }
}
