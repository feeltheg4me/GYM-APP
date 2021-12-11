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

namespace BRENS_GYM
{
    public partial class RechercherMembre : Form
    {
        int id;
        public RechercherMembre()
        {
            InitializeComponent();
        }

        private void RechercherMembre_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gYMDataSet2.Membre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.membreTableAdapter1.Fill(this.gYMDataSet2.Membre);
            // TODO: cette ligne de code charge les données dans la table 'gYMDataSet.Membre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            

        }

        private void bunifuTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            textRecherche.text="";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if((textRecherche.text!="")&&(textRecherche.text != "Entrer prenom"))
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Membre where Prenom='"+textRecherche.text+"'";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Entrer le prénom du membre.","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void bunifuTextbox1_MouseClick(object sender, EventArgs e)
        {
            textRecherche.text = "";
        }

        private void textRecherche_Enter(object sender, EventArgs e)
        {
            textRecherche.text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textRecherche.Text = id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           
            
        }

        public void Showdata()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Membre", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="Mois")
            {

            
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            String dateEntree = dateTimePicker1.Text;
            int membership;
            if (!int.TryParse(comboBox1.Text, out membership)) membership = 0;

            cmd.CommandText = "update Membre set DateEntree='" + dateEntree + "',Membership='"+membership+"' where Id='"+id+"'";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Membre update validé.");
            conn.Close();
            Showdata();
            }
            else
            {
                MessageBox.Show("Données manquantes.");
            }
        }
    }
}
