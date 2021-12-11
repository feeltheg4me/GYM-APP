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
    public partial class NouveauMembre : Form
    {
        public NouveauMembre()
        {
            InitializeComponent();
        }

        private void NouveauMembre_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String prenom = textPrenom.Text;
            String nom = textNom.Text;
            String telephone = textTelephone.Text;
            String email = textEmail.Text;
            String adresse = textAdresse.Text;
            String dateEntree = dateTimePicker1.Text;
            String sexe= "";
            int membership;
            if (!int.TryParse(comboBox1.Text, out membership)) membership = 0; 
            int age;
            if (!int.TryParse(textage.Text, out age)) age = 0;
           
            if(radioButton1.Checked)
            {
                sexe = radioButton1.Text;
            }
            else
            {
                sexe = radioButton2.Text;
            }
            if ( (prenom=="")|| (nom == "") || (telephone == "")  || (sexe == "") || (age == 0) ||
                    (comboBox1.Text == "") || (comboBox1.Text == "Mois")  )
                    {
                MessageBox.Show("Données manquantes !");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Membre (Prenom,Nom,Age,Sexe,Telephone,Email,DateEntree,Adresse,Membership) values('" + prenom +"','" + nom + "','" + age + "','" + sexe + "','" + telephone + "','" + email + "','" + dateEntree + "','" + adresse + "','" + membership + "')";
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                MessageBox.Show("Data saved !");
            }
            



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            textage.Clear();
            textAdresse.Clear();
            textEmail.Clear();
            textNom.Clear();
            textPrenom.Clear();
            textTelephone.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            textPrenom.Focus();
        }

        private void textage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
