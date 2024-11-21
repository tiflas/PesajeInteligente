using PruebaTecnica_PasajeInteligente.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTecnica_PasajeInteligente
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void FormCompanyList(object formProducto)
        {
            if (this.PanelContenedor.Controls.Count > 0)
            {
                this.PanelContenedor.Controls.Clear();
            }
            FormCompanyList formCompanyList = new FormCompanyList();

            formCompanyList.TopLevel = false;
            formCompanyList.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(formCompanyList);
            this.PanelContenedor.Tag = formCompanyList;
            formCompanyList.Show();
        }
        private void BtCompanyList_Click(object sender, EventArgs e)
        {
            FormCompanyList(new FormCompanyList());
        }

        private void BtCompanyEditor_Click(object sender, EventArgs e)
        {
            FormCompanyList(new FormCompanyList());
        }
    }
}
