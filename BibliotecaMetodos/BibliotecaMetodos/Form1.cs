using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesBD;

namespace BibliotecaMetodos
{
    public partial class Form1 : Form
    {
        #region atributos

        //path que va a contener los productos guardados en la BBDD
        private const String PATH_XML_PRODUCTOS = @"C:\archivos\DataTableProductosDatos.xml";
        //path que va a contener el esqueleto de mi Data Table. 
        private const String PATH_XML_PRODUCTOS_SCHEMA = @"C:\archivos\DataTableProductosSchema.xml";

        //dependiente del procesador de BBDD, es el Data Adapter.
        protected SqlDataAdapter da;
        //independiente del procesador de BBDD, es el Data Table.
        protected DataTable dt;

        #endregion

        #region constructor

        public Form1()
        {
            InitializeComponent();

            //if (!this.ConfigurarDataAdapter())
            //{
            //    MessageBox.Show("ERROR AL CONFIGURAR EL DATAADAPTER!!!");
            //    this.Close();
            //}

            //this.CrearDataTable();

            //try
            //{
            //    this.da.Fill(this.dt);

            //    this.ConfigurarGrilla();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region eventos

        private void btnCrearDataTable_Click(object sender, EventArgs e)
        {
            if(CrearDataTable())
            {
                MessageBox.Show("Se creo el Data Table!");
            }
            else
            {
                MessageBox.Show("Fallo la creacion del Data Table!");
            }
        }

        private void btnConfigurarGrilla_Click(object sender, EventArgs e)
        {
            if(ConfigurarGrilla())
            {
                MessageBox.Show("Se configuro la grilla correctamente!");
            }
            else
            {
                MessageBox.Show("Error al configurar la grilla!");
            }
        }

        private void btnConfigurarDataAdapter_Click(object sender, EventArgs e)
        {
            if(ConfigurarDataAdapter())
            {
                MessageBox.Show("El Data Adapter se configuro correctamente!");
            }
            else
            {
                MessageBox.Show("Error al configurar el DataAdapter!");
            }
        }

        private void btnCargarGrilla_Click(object sender, EventArgs e)
        {
            if (CargarGrilla())
            {
                MessageBox.Show("Grilla cargada con exito!");
            }
            else
            {
                MessageBox.Show("Error al cargar la grilla!");
            }
        }

        private void btnCheckRowState_Click(object sender, EventArgs e)
        {
            if(MostrarRowState())
            {
                MessageBox.Show("RowState generado correctamente!");
            }
            else
            {
                MessageBox.Show("Error al intentar mostrar el RowState del Data Table!");
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(GuardarCambios())
            {
                MessageBox.Show("Se ha guardado todo correctamente!");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar!");
            }
        }

        private void btnDeshacerCambios_Click(object sender, EventArgs e)
        {
            if (DeshacerCambios())
            {
                MessageBox.Show("Los cambios se dehicieron correctamente!");
            }
            else
            {
                MessageBox.Show("Hubo un error al deshacer los cambios!");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!AgregarObjeto())
            {
                MessageBox.Show("Error al intentar agregar el objeto!");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!Modificar())
            {
                MessageBox.Show("Error al intentar modificar el registro!");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(!Eliminar())
            {
                MessageBox.Show("Error al intentar eliminar el registro!");
            }
        }

        
        private void btnGuardarXml_Click(object sender, EventArgs e)
        {
            if (GuardarXml())
            {
                MessageBox.Show("Se generaron correctamente los archivos XML!");
            }
            else
            {
                MessageBox.Show("Error al generar los archivos!");
            }
        }

        private void btnCargarXml_Click(object sender, EventArgs e)
        {
            if (!AbrirXml())
            {
                MessageBox.Show("Ocurrio un error al carcar uno o mas archivos!");
            }
        }

        #endregion

        #region metodos

        #region DataTable

        private bool CrearDataTable()
        {
            bool res = true;

            try
            {
                this.dt = new DataTable("Producto");

                this.dt.Columns.Add("id", typeof(int));
                this.dt.Columns.Add("producto", typeof(string));
                this.dt.Columns.Add("precio", typeof(double));

                this.dt.PrimaryKey = new DataColumn[] { this.dt.Columns[0] };

                this.dt.Columns["id"].AutoIncrement = true;
                this.dt.Columns["id"].AutoIncrementSeed = 1;
                this.dt.Columns["id"].AutoIncrementStep = 1;
            }
            catch
            {
                res = false;
            }

            return res;
        }

        #endregion

        #region DataGridView

        private bool ConfigurarGrilla()
        {
            bool res = true;

            try
            {
                //Color de fondo para las filas
                this.dgvGrilla.RowsDefaultCellStyle.BackColor = Color.Coral;

                //Defino las caracteristicas de los encabezados
                this.dgvGrilla.ColumnHeadersDefaultCellStyle.Font = new Font(dgvGrilla.Font, FontStyle.Bold);
                this.dgvGrilla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Color de las lineas de separacion
                this.dgvGrilla.GridColor = Color.Black;

                //Evito la multiseleccion
                this.dgvGrilla.MultiSelect = false;

                //Genero que solo se pueda editar a traves de codigo (no graficamente)
                this.dgvGrilla.EditMode = DataGridViewEditMode.EditProgrammatically;
                
                //Selecciono toda la grilla a la vez
                this.dgvGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                //Saco los encabezados de las filas
                this.dgvGrilla.RowHeadersVisible = false;

                //Hago que se ajusten automaticamente en tamaño
                this.dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.dgvGrilla.DataSource = this.dt;
            }
            catch
            {
                res = false;
            }

            return res;
        }

        private bool CargarGrilla()
        {
            bool res = true;

            try
            {
                this.da.Fill(this.dt);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;            
        }

        #endregion

        #region DataAdapter

        private bool ConfigurarDataAdapter()
        {
            bool rta = true;

            try
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.Conexion);

                this.da = new SqlDataAdapter();

                this.da.SelectCommand = new SqlCommand("SELECT * FROM tablaProducto", cn);
                this.da.InsertCommand = new SqlCommand("INSERT INTO tablaProducto (producto, precio) VALUES (@producto, @precio)", cn);
                this.da.UpdateCommand = new SqlCommand("UPDATE tablaProducto SET producto=@producto, precio=@precio WHERE id=@id", cn);
                this.da.DeleteCommand = new SqlCommand("DELETE FROM tablaProducto WHERE id=@id", cn);

                this.da.InsertCommand.Parameters.Add("@producto", SqlDbType.VarChar, 50, "producto");
                this.da.InsertCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");

                this.da.UpdateCommand.Parameters.Add("@producto", SqlDbType.VarChar, 50, "producto");
                this.da.UpdateCommand.Parameters.Add("@precio", SqlDbType.Float, 10, "precio");
                this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");

                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 10, "id");
            }
            catch (Exception e)
            {
                rta = false;
                MessageBox.Show(e.Message);
            }

            return rta;            

        }


        #endregion

        #region RowState

        private bool MostrarRowState()
        {
            bool res = true;

            try
            {
                RowState rs = new RowState(this.dt);

                rs.StartPosition = FormStartPosition.CenterScreen;

                rs.ShowDialog();
            }
            catch (Exception e)
            {
                res = true;
                MessageBox.Show(e.Message);
            }

            return res;
                       
        }

        #endregion

        #region Guardar Cambios

        private bool GuardarCambios()
        {
            bool res = true;

            try
            {
                this.da.Update(this.dt);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }


        #endregion

        #region Deshacer Cambios

        private bool DeshacerCambios()
        {
            bool res = true;

            try
            {
                this.dt.RejectChanges();
                this.da.Update(this.dt);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }

        #endregion

        #region ABM

        #region Agregar

        private bool AgregarObjeto()
        {
            bool res = true;

            try
            {
                frmProducto fp = new frmProducto();
                
                if(fp.ShowDialog() == DialogResult.OK)
                {
                    DataRow fila = this.dt.NewRow();

                    fila["producto"] = fp.Producto.Nombre;
                    fila["precio"] = fp.Producto.Precio;

                    this.dt.Rows.Add(fila);
                }
            }
            catch(Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }



        #endregion

        #region Modificar

        private bool Modificar()
        {
            bool res = true;

            try
            {
                int indice = this.dgvGrilla.SelectedRows[0].Index;

                DataRow fila = this.dt.Rows[indice];

                int id = int.Parse(fila["id"].ToString());
                string producto = fila["producto"].ToString();
                Single precio = Single.Parse(fila["precio"].ToString());

                Producto p = new Producto(id, producto, precio);

                frmProducto fp = new frmProducto(p);

                if(fp.ShowDialog() == DialogResult.OK)
                {
                    fila["producto"] = fp.Producto.Nombre;
                    fila["precio"] = fp.Producto.Precio;
                }
            }
            catch(Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }
        #endregion

        #region Eliminar

        private bool Eliminar()
        {
            bool res = true;

            try
            {
                int indice = this.dgvGrilla.SelectedRows[0].Index;

                DataRow fila = this.dt.Rows[indice];

                int id = int.Parse(fila["id"].ToString());
                string producto = fila["producto"].ToString();
                Single precio = Single.Parse(fila["precio"].ToString());

                Producto p = new Producto(id, producto, precio);

                frmProducto fp = new frmProducto(p);

                if (fp.ShowDialog() == DialogResult.OK)
                {
                    fila.Delete();
                }
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }
        #endregion

        #endregion

        #region Archivo Xml

        #region guardar 

        private bool GuardarXml()
        {
            bool res = true;

            try
            {
                this.dt.WriteXmlSchema(PATH_XML_PRODUCTOS_SCHEMA);
                this.dt.WriteXml(PATH_XML_PRODUCTOS);
            }
            catch (Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }

        #endregion

        #region abrir

        private bool AbrirXml()
        {
            bool res = true;

            try
            {

                MessageBox.Show("Ahora seleccionar el SCHEMA");
                
                DialogResult rtaSchema = ofdCargarXml.ShowDialog();

                if(rtaSchema == DialogResult.OK)
                {
                    this.dt.ReadXmlSchema(ofdCargarXml.FileName);
                }

                MessageBox.Show("Ahora seleccionar el archivo de DATOS");

                DialogResult rtaDatos = ofdCargarXml.ShowDialog();

                if (rtaDatos == DialogResult.OK)
                {
                    this.dt.ReadXml(ofdCargarXml.FileName);
                }

                this.dgvGrilla.DataSource = this.dt;

            }
            catch(Exception e)
            {
                res = false;
                MessageBox.Show(e.Message);
            }

            return res;
        }



        #endregion

        #endregion

        #endregion

        
    }
}
