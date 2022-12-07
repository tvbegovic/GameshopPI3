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
using Gameshop_Netfx_Dapper.Db;
using Dapper;

namespace Gameshop_Netfx_Dapper
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
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                igre = conn.Query<Game>("SELECT * FROM Game").ToList();
                dgvIgre.DataSource = igre;
            }
        }

        private void ObrisiIgru(int id)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                conn.Execute("DELETE FROM Game WHERE id = @id", new { id });                
            }
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
                igre.RemoveAt(dgvIgre.CurrentRow.Index);
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
