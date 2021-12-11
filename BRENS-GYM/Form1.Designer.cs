
namespace BRENS_GYM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Chartreuse;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.nouveauMembreToolStripMenuItem,
            this.rechercheMembreToolStripMenuItem,
            this.effacerMembreToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 61);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 57);
            this.toolStripMenuItem1.Text = "          ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nouveauMembreToolStripMenuItem
            // 
            this.nouveauMembreToolStripMenuItem.AutoSize = false;
            this.nouveauMembreToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.nouveauMembreToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauMembreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauMembreToolStripMenuItem.Image")));
            this.nouveauMembreToolStripMenuItem.Name = "nouveauMembreToolStripMenuItem";
            this.nouveauMembreToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.nouveauMembreToolStripMenuItem.Size = new System.Drawing.Size(170, 46);
            this.nouveauMembreToolStripMenuItem.Text = "Ajouter membre";
            this.nouveauMembreToolStripMenuItem.Click += new System.EventHandler(this.nouveauMembreToolStripMenuItem_Click);
            // 
            // rechercheMembreToolStripMenuItem
            // 
            this.rechercheMembreToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.rechercheMembreToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheMembreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rechercheMembreToolStripMenuItem.Image")));
            this.rechercheMembreToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rechercheMembreToolStripMenuItem.Name = "rechercheMembreToolStripMenuItem";
            this.rechercheMembreToolStripMenuItem.Size = new System.Drawing.Size(256, 57);
            this.rechercheMembreToolStripMenuItem.Text = "   Rechercher membre      ";
            this.rechercheMembreToolStripMenuItem.Click += new System.EventHandler(this.rechercheMembreToolStripMenuItem_Click);
            // 
            // effacerMembreToolStripMenuItem
            // 
            this.effacerMembreToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.effacerMembreToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacerMembreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("effacerMembreToolStripMenuItem.Image")));
            this.effacerMembreToolStripMenuItem.Name = "effacerMembreToolStripMenuItem";
            this.effacerMembreToolStripMenuItem.Size = new System.Drawing.Size(231, 57);
            this.effacerMembreToolStripMenuItem.Text = "   Effacer membre      ";
            this.effacerMembreToolStripMenuItem.Click += new System.EventHandler(this.effacerMembreToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.staffToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.staffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("staffToolStripMenuItem.Image")));
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(195, 57);
            this.staffToolStripMenuItem.Text = "   Staff         ";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.Chartreuse;
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Terminator Two", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(126, 57);
            this.quitterToolStripMenuItem.Text = "    Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Terminator Two", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Chartreuse;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(514, 109);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(286, 37);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "BRENS\' GYM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1056, 574);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Minerva", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BRENS GYM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercheMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

