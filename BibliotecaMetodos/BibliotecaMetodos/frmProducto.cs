using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesBD;

namespace BibliotecaMetodos
{
    public partial class frmProducto : Form
    {
        protected Producto p;

        public Producto Producto
        {
            get { return this.p; }
        }

        public frmProducto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmProducto(Producto p)
            :this()
        {
            this.p = p;

            this.txtNombre.Text = p.Nombre;
            this.txtPrecio.Text = p.Precio.ToString();
            this.txtID.Text = p.ID.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;

            id = id == "" ? "0" : id;

            this.p = new Producto(int.Parse(id), this.txtNombre.Text, float.Parse(this.txtPrecio.Text));

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
