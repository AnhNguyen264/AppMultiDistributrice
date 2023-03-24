namespace AppMultiDistributrice
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.picDistributrice = new System.Windows.Forms.PictureBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichageInventaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAffichageListeDesMachines = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEtat = new System.Windows.Forms.TextBox();
            this.txtNbTheGlace = new System.Windows.Forms.TextBox();
            this.txtNbJusDePommes = new System.Windows.Forms.TextBox();
            this.txtNb7Up = new System.Windows.Forms.TextBox();
            this.txtNbCokes = new System.Windows.Forms.TextBox();
            this.btnRecharger = new System.Windows.Forms.Button();
            this.btnObtenirUnTheGlace = new System.Windows.Forms.Button();
            this.btnObtenirUnJusDePommes = new System.Windows.Forms.Button();
            this.btnObtenirUn7Up = new System.Windows.Forms.Button();
            this.btnObtenirUnCoke = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMachineCourante = new System.Windows.Forms.Label();
            this.cboMachines = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDistributrice)).BeginInit();
            this.mnuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDistributrice
            // 
            this.picDistributrice.BackColor = System.Drawing.Color.White;
            this.picDistributrice.ErrorImage = global::AppMultiDistributrice.Properties.Resources.imageDistributrice;
            this.picDistributrice.Image = ((System.Drawing.Image)(resources.GetObject("picDistributrice.Image")));
            this.picDistributrice.Location = new System.Drawing.Point(5, 3);
            this.picDistributrice.Name = "picDistributrice";
            this.picDistributrice.Size = new System.Drawing.Size(186, 269);
            this.picDistributrice.TabIndex = 2;
            this.picDistributrice.TabStop = false;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAffichage});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(398, 24);
            this.mnuPrincipal.TabIndex = 3;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAffichage
            // 
            this.mnuAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAffichageInventaire,
            this.mnuAffichageListeDesMachines});
            this.mnuAffichage.Name = "mnuAffichage";
            this.mnuAffichage.Size = new System.Drawing.Size(70, 20);
            this.mnuAffichage.Text = "Affichage";
            // 
            // mnuAffichageInventaire
            // 
            this.mnuAffichageInventaire.Name = "mnuAffichageInventaire";
            this.mnuAffichageInventaire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuAffichageInventaire.Size = new System.Drawing.Size(213, 22);
            this.mnuAffichageInventaire.Text = "Inventaire";
            this.mnuAffichageInventaire.Click += new System.EventHandler(this.mnuAffichageInventaire_Click);
            // 
            // mnuAffichageListeDesMachines
            // 
            this.mnuAffichageListeDesMachines.Name = "mnuAffichageListeDesMachines";
            this.mnuAffichageListeDesMachines.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuAffichageListeDesMachines.Size = new System.Drawing.Size(213, 22);
            this.mnuAffichageListeDesMachines.Text = "Liste des machines";
            this.mnuAffichageListeDesMachines.Click += new System.EventHandler(this.mnuAffichageListeDesMachines_Click);
            // 
            // txtEtat
            // 
            this.txtEtat.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtat.Location = new System.Drawing.Point(332, 236);
            this.txtEtat.Name = "txtEtat";
            this.txtEtat.ReadOnly = true;
            this.txtEtat.Size = new System.Drawing.Size(34, 21);
            this.txtEtat.TabIndex = 17;
            this.txtEtat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNbTheGlace
            // 
            this.txtNbTheGlace.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbTheGlace.Location = new System.Drawing.Point(332, 187);
            this.txtNbTheGlace.Name = "txtNbTheGlace";
            this.txtNbTheGlace.ReadOnly = true;
            this.txtNbTheGlace.Size = new System.Drawing.Size(34, 21);
            this.txtNbTheGlace.TabIndex = 16;
            this.txtNbTheGlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNbJusDePommes
            // 
            this.txtNbJusDePommes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbJusDePommes.Location = new System.Drawing.Point(332, 157);
            this.txtNbJusDePommes.Name = "txtNbJusDePommes";
            this.txtNbJusDePommes.ReadOnly = true;
            this.txtNbJusDePommes.Size = new System.Drawing.Size(34, 21);
            this.txtNbJusDePommes.TabIndex = 14;
            this.txtNbJusDePommes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNb7Up
            // 
            this.txtNb7Up.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNb7Up.Location = new System.Drawing.Point(332, 126);
            this.txtNb7Up.Name = "txtNb7Up";
            this.txtNb7Up.ReadOnly = true;
            this.txtNb7Up.Size = new System.Drawing.Size(34, 21);
            this.txtNb7Up.TabIndex = 12;
            this.txtNb7Up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNbCokes
            // 
            this.txtNbCokes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbCokes.Location = new System.Drawing.Point(332, 97);
            this.txtNbCokes.Name = "txtNbCokes";
            this.txtNbCokes.ReadOnly = true;
            this.txtNbCokes.Size = new System.Drawing.Size(34, 21);
            this.txtNbCokes.TabIndex = 10;
            this.txtNbCokes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRecharger
            // 
            this.btnRecharger.Location = new System.Drawing.Point(197, 233);
            this.btnRecharger.Name = "btnRecharger";
            this.btnRecharger.Size = new System.Drawing.Size(129, 27);
            this.btnRecharger.TabIndex = 5;
            this.btnRecharger.Text = "Recharger la machine";
            this.btnRecharger.UseVisualStyleBackColor = true;
            this.btnRecharger.Click += new System.EventHandler(this.btnRecharger_Click);
            // 
            // btnObtenirUnTheGlace
            // 
            this.btnObtenirUnTheGlace.Location = new System.Drawing.Point(197, 185);
            this.btnObtenirUnTheGlace.Name = "btnObtenirUnTheGlace";
            this.btnObtenirUnTheGlace.Size = new System.Drawing.Size(129, 24);
            this.btnObtenirUnTheGlace.TabIndex = 9;
            this.btnObtenirUnTheGlace.Text = "Obtenir un thé glacé";
            this.btnObtenirUnTheGlace.Click += new System.EventHandler(this.btnObtenirUnTheGlace_Click);
            // 
            // btnObtenirUnJusDePommes
            // 
            this.btnObtenirUnJusDePommes.Location = new System.Drawing.Point(197, 155);
            this.btnObtenirUnJusDePommes.Name = "btnObtenirUnJusDePommes";
            this.btnObtenirUnJusDePommes.Size = new System.Drawing.Size(129, 24);
            this.btnObtenirUnJusDePommes.TabIndex = 8;
            this.btnObtenirUnJusDePommes.Text = "Obtenir un jus";
            this.btnObtenirUnJusDePommes.Click += new System.EventHandler(this.btnObtenirUnJusDePommes_Click);
            // 
            // btnObtenirUn7Up
            // 
            this.btnObtenirUn7Up.Location = new System.Drawing.Point(197, 125);
            this.btnObtenirUn7Up.Name = "btnObtenirUn7Up";
            this.btnObtenirUn7Up.Size = new System.Drawing.Size(129, 24);
            this.btnObtenirUn7Up.TabIndex = 7;
            this.btnObtenirUn7Up.Text = "Obtenir un 7up";
            this.btnObtenirUn7Up.Click += new System.EventHandler(this.btnObtenirUn7Up_Click);
            // 
            // btnObtenirUnCoke
            // 
            this.btnObtenirUnCoke.Location = new System.Drawing.Point(197, 95);
            this.btnObtenirUnCoke.Name = "btnObtenirUnCoke";
            this.btnObtenirUnCoke.Size = new System.Drawing.Size(129, 24);
            this.btnObtenirUnCoke.TabIndex = 6;
            this.btnObtenirUnCoke.Text = "Obtenir un Coke";
            this.btnObtenirUnCoke.Click += new System.EventHandler(this.btnObtenirUnCoke_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMachineCourante);
            this.panel1.Controls.Add(this.cboMachines);
            this.panel1.Controls.Add(this.txtEtat);
            this.panel1.Controls.Add(this.btnObtenirUnTheGlace);
            this.panel1.Controls.Add(this.txtNbTheGlace);
            this.panel1.Controls.Add(this.btnObtenirUnJusDePommes);
            this.panel1.Controls.Add(this.btnObtenirUn7Up);
            this.panel1.Controls.Add(this.txtNbJusDePommes);
            this.panel1.Controls.Add(this.btnObtenirUnCoke);
            this.panel1.Controls.Add(this.btnRecharger);
            this.panel1.Controls.Add(this.txtNb7Up);
            this.panel1.Controls.Add(this.picDistributrice);
            this.panel1.Controls.Add(this.txtNbCokes);
            this.panel1.Location = new System.Drawing.Point(7, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 280);
            this.panel1.TabIndex = 10;
            // 
            // lblMachineCourante
            // 
            this.lblMachineCourante.AutoSize = true;
            this.lblMachineCourante.Location = new System.Drawing.Point(194, 13);
            this.lblMachineCourante.Name = "lblMachineCourante";
            this.lblMachineCourante.Size = new System.Drawing.Size(99, 13);
            this.lblMachineCourante.TabIndex = 18;
            this.lblMachineCourante.Text = "Machine courante :";
            // 
            // cboMachines
            // 
            this.cboMachines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMachines.FormattingEnabled = true;
            this.cboMachines.Location = new System.Drawing.Point(197, 29);
            this.cboMachines.Name = "cboMachines";
            this.cboMachines.Size = new System.Drawing.Size(169, 21);
            this.cboMachines.TabIndex = 11;
            this.cboMachines.SelectedIndexChanged += new System.EventHandler(this.cboMachines_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(398, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Distributrice ";
            ((System.ComponentModel.ISupportInitialize)(this.picDistributrice)).EndInit();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox picDistributrice;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.TextBox txtEtat;
        private System.Windows.Forms.TextBox txtNbTheGlace;
        private System.Windows.Forms.TextBox txtNbJusDePommes;
        private System.Windows.Forms.TextBox txtNb7Up;
        private System.Windows.Forms.TextBox txtNbCokes;
        private System.Windows.Forms.Button btnRecharger;
        private System.Windows.Forms.Button btnObtenirUnTheGlace;
        private System.Windows.Forms.Button btnObtenirUnJusDePommes;
        private System.Windows.Forms.Button btnObtenirUn7Up;
        private System.Windows.Forms.Button btnObtenirUnCoke;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMachineCourante;
        private System.Windows.Forms.ComboBox cboMachines;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichage;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichageInventaire;
        private System.Windows.Forms.ToolStripMenuItem mnuAffichageListeDesMachines;
    }
}

