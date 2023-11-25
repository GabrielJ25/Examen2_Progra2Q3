using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace MiTiendaWeb {

  public class Producto {
    public int Id {get;set;}
    public string Nombre {get;set;}
    public decimal Precio {get;set;}
    public string Descripcion {get;set;} 
  }

  public class Orden {
    public int Id {get;set;}
    public int UsuarioId {get;set;}
    public decimal Total {get;set;}
    public List<DetalleOrden> Detalles {get;set;}
  }

  public class DetalleOrden {
    public int OrdenId {get;set;}
    public int ProductoId {get;set;}
    public int Cantidad {get;set;}
  }

  public class Usuario {
    public int Id {get;set;}
    public string Nombre {get;set;}
    public string Email {get;set;} 
  }

  public class ConexionDB {

    private string cadenaConexion;

    public ConexionDB() {
      this.cadenaConexion = "Data Source=MI_SERVIDOR;Initial Catalog=TIENDA;Integrated Security=True";
    }

    public SqlConnection ObtenerConexion() {
      return new SqlConnection(cadenaConexion);
    }

  }  

  public class ProductosDAO {
    
    private ConexionDB conexion;

    public ProductosDAO() {
      conexion = new ConexionDB();
    }

    public List<Producto> ObtenerProductos() {
      // Código para consultar productos de la BD
    }

    public void GuardarProducto(Producto p) {
      // Código para insertar un producto nuevo
    }    

  }

  public class UsuariosDAO {

    private ConexionDB conexion;
    
    public UsuariosDAO() {
      conexion = new ConexionDB();
    }

    public List<Usuario> ObtenerUsuarios() {
      // Código para consultar usuarios
    }

    public void RegistrarUusario(Usuario usuario) {
     // Código para insertar usuario
    }

  }

  public class OrdenesDAO {

    private ConexionDB conexion;  

    public OrdenesDAO()  {
      conexion = new ConexionDB();
    }

    public void RegistrarOrden(Orden orden) {
      // Código para insertar orden y detalles 
    }

  }

  public class ProductosController : Controller {

    public ActionResult Index() {
      ProductosDAO dao = new ProductosDAO();
      List<Producto> productos = dao.ObtenerProductos();    
      return View(productos);
    }

  }  

}