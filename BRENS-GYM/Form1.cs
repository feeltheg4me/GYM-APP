using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRENS_GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        NouveauMembre nm;
       
        private void nouveauMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
             nm = new NouveauMembre();
            nm.Show();
                
          
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EffacerMembre em;
        private void effacerMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
             em = new EffacerMembre();
            em.Show();
           
        }
        RechercherMembre rm;
        private void rechercheMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
             rm = new RechercherMembre();
            rm.Show();
           
        }

        Staff s;
        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                s = new Staff();
                s.Show();
           
        }
    }
}
