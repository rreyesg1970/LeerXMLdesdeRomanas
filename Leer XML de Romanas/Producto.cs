using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_XML_de_Romanas
{
    public class Producto
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string IdBodega { get; set; }
        public string NombreBodega { get; set; }
        public decimal Temperatura { get; set; }
        public decimal Peso { get; set; }
        public string Usuario { get; set; }

        //public Producto(string fecha, string hora, string idProducto, string nombreProduto, string categoria, string idBodega,
        //    string nombreBodega, decimal temperatura, decimal peso,string usuario)
        //{
        //    Fecha = fecha;
        //    Hora = hora;
        //    IdProducto = idProducto;
        //    NombreProducto = nombreProduto;
        //    Categoria = categoria;
        //    IdBodega = idBodega;
        //    NombreBodega = nombreBodega;
        //    Temperatura = temperatura;
        //    Peso = peso;
        //    Usuario = usuario;
        //}

        //public Producto(string idProducto, string nombreProduto, string categoria)
        //{
        //    IdProducto = idProducto;
        //    NombreProducto = nombreProduto;
        //    Categoria = categoria;
        //}
    }
}
