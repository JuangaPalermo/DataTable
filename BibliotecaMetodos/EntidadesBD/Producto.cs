using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBD
{
    public class Producto
    {
        #region atributos

        int id;
        string nombre;
        float precio;

        #endregion

        #region propiedades

        public Int32 ID
        {
            get
            {
                return this.id;
            }
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Single Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        #endregion

        #region constructor

        public Producto(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto(int id, string nombre, float precio)
            :this(nombre,precio)
        {
            this.id = id;
        }

        #endregion
    }
}
