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

namespace Gameshop_Netfx_Dapper
{
    public partial class IgreEdit : Form
    {
        public IgreEdit()
        {
            InitializeComponent();
        }

        public int Id { get; set; }
        //public Game Igra { get; set; }

        private void PostaviComboBox()
        {
            /*var developeri = DohvatiKompanije();
            var izdavaci = DohvatiKompanije();
            var vrste = DohvatiVrste();
            cboDeveloper.DataSource = developeri;
            cboDeveloper.DisplayMember = "Name";
            cboDeveloper.ValueMember = "Id";
            cboDeveloper.FormattingEnabled = true;
            cboIzdavac.DataSource = izdavaci;
            cboIzdavac.DisplayMember = "Name";
            cboIzdavac.ValueMember = "Id";
            cboIzdavac.FormattingEnabled = true;
            cboVrsta.DataSource = vrste;
            cboVrsta.DisplayMember = "Name";
            cboVrsta.ValueMember = "Id";
            cboVrsta.FormattingEnabled = true;*/
        }

        /*private List<Company> DohvatiKompanije()
        {
            
        }

        private List<Genre> DohvatiVrste()
        {
            
        }

        private Game DohvatiIgru(int id)
        {
            
        }*/

        private void AzurirajIgru()
        {
            
        }

        private int KreirajNovu()
        {
            return 0;
        }

        private void IgreEdit_Load(object sender, EventArgs e)
        {
            PostaviComboBox();
            /*if (Id > 0)
            {

                Igra = DohvatiIgru(Id);
            }
            else
            {
                Igra = new Game();
            }
            txtId.DataBindings.Add(new Binding("Text", Igra, "Id"));
            txtNaziv.DataBindings.Add(new Binding("Text", Igra, "Title"));
            txtCijena.DataBindings.Add(new Binding("Text", Igra, "Price", true));
            txtDatumIzdavanja.DataBindings.Add(new Binding("Text", Igra, "ReleaseDate", true));
            cboDeveloper.DataBindings.Add(new Binding("SelectedValue", Igra, "IdDeveloper", true));
            cboIzdavac.DataBindings.Add(new Binding("SelectedValue", Igra, "IdPublisher", true));
            cboVrsta.DataBindings.Add(new Binding("SelectedValue", Igra, "IdGenre", true));*/
        }
    }
}
