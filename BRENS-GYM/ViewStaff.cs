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
    public partial class ViewStaff : Form
    {
        int id = 0;
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gYMDataSet2.Staff'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.staffTableAdapter1.Fill(this.gYMDataSet2.Staff);
            // TODO: cette ligne de code charge les données dans la table 'gYMDataSet1.Staff'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }
        public void Showdata()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Staff", conn);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if ((id != 0) && (MessageBox.Show("Ce staff membre va etre éffacé ! , confirmer ?", "Effacer", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\GYM.mdf;Integrated Security=True;Connect Timeout=30";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from Staff where Id= " + id + "";

                    cmd.ExecuteNonQuery();
                    dataGridView1.Refresh();
                    MessageBox.Show("Staff membre effacé.");
                    conn.Close();
                    Showdata();
                    id = 0;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Sélectionner un membre du staff.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur !");
            }
            
        }

        
    }
}
