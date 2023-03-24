namespace AppMultiDistributrice
{
    partial class FrmInventaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMachines = new System.Windows.Forms.ListBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMachines
            // 
            this.lstMachines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.Location = new System.Drawing.Point(15, 12);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMachines.Size = new System.Drawing.Size(222, 95);
            this.lstMachines.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(168, 117);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(69, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 156);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lstMachines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMachines;
        private System.Windows.Forms.Button btnFermer;
    }
}