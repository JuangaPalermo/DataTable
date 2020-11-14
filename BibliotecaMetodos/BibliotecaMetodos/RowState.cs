using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMetodos
{
    public partial class RowState : Form
    {
        public RowState(DataTable dt)
        {
            InitializeComponent();

            foreach(DataRow item in dt.Rows)
            {
                this.dgvVisor.Rows.Add(item.RowState.ToString());
            }
        }
    }
}
