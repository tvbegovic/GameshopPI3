using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gameshop_Netfx_Core.Db;


namespace Gameshop_Netfx_Core
{
    public partial class IgreLista : Form
    {
        List<Game> igre = new List<Game>();

        public IgreLista()
        {
            InitializeComponent();
        }

        private void UcitajIgre()
        {
            
        }

        private void ObrisiIgru(int id)
        {
            
        }

        private void tsbNovi_Click(object sender, EventArgs e)
        {
            var igraEdit = new IgreEdit();
            igraEdit.Id = 0;
            var rezultat = igraEdit.ShowDialog();
            if(rezultat == DialogResult.OK)
            {
                UcitajIgre();
            }

        }

        private void tsbUredi_Click(object sender, EventArgs e)
        {
            var igraEdit = new IgreEdit();
            igraEdit.Id = Convert.ToInt32(dgvIgre.CurrentRow.Cells[0].Value);
            var rezultat = igraEdit.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                UcitajIgre();
            }
        }

        private void tsbObrisi_Click(object sender, EventArgs e)
        {
            var yesno = MessageBox.Show("Obrisati zapis?", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {
                ObrisiIgru(Convert.ToInt32(dgvIgre.CurrentRow.Cells[0].Value));
                igre.Remove((Game)dgvIgre.CurrentRow.DataBoundItem);
                dgvIgre.DataSource = null;
                dgvIgre.DataSource = igre;
            }
            
        }

        private void IgreLista_Load(object sender, EventArgs e)
        {
            //Učitati sve zapise
            UcitajIgre();
        }
    }
}
