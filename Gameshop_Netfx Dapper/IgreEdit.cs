using Dapper;
using Gameshop_Netfx_Dapper.Db;
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
        public Game Igra { get; set; }

        private void PostaviComboBox()
        {
            var developeri = DohvatiKompanije();
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
            cboVrsta.FormattingEnabled = true;
        }

        private List<Company> DohvatiKompanije()
        {
            using(var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                return conn.Query<Company>("SELECT * FROM Company").ToList();
            }
        }

        private List<Genre> DohvatiVrste()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                return conn.Query<Genre>("SELECT * FROM Genre").ToList();
            }
        }

        private Game DohvatiIgru(int id)
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                return conn.QueryFirst<Game>("SELECT * FROM Game WHERE id = @id", new { id });
            }
        }

        private void AzurirajIgru()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                conn.Execute(@"UPDATE Game SET [title] = @title,[idGenre] = @idGenre,[idPublisher] = @idPublisher,[price] = @price, idDeveloper = @idDeveloper, 
                    [releaseDate] = @releaseDate,[image] = @image WHERE id = @id", Igra);
            }
        }

        private int KreirajNovu()
        {
            using (var conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                return conn.ExecuteScalar<int>(@"INSERT INTO Game ([title],[idGenre],[idPublisher],[price],[idDeveloper],[releaseDate],[image]) 
                            OUTPUT inserted.id VALUES(@title, @idGenre, @idPublisher, @price,@idDeveloper, @releaseDate, @image)", Igra);
            }
        }


        private void IgreEdit_Load(object sender, EventArgs e)
        {
            PostaviComboBox();
            if (Id > 0)
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
            cboVrsta.DataBindings.Add(new Binding("SelectedValue", Igra, "IdGenre", true));
        }

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            if (Igra.Id > 0)
            {
                AzurirajIgru();
            }
            else
            {
                Igra.Id = KreirajNovu();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
