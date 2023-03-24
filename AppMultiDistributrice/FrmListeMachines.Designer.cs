namespace AppMultiDistributrice
{
    partial class FrmListeMachines
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.numTotalCannettes = new System.Windows.Forms.NumericUpDown();
            this.btnFermer = new System.Windows.Forms.Button();
            this.chkMachinesPleines = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCannettes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMachines
            // 
            this.lstMachines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.Location = new System.Drawing.Point(12, 46);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstMachines.Size = new System.Drawing.Size(292, 95);
            this.lstMachines.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total  de cannettes :";
            // 
            // numTotalCannettes
            // 
            this.numTotalCannettes.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numTotalCannettes.Location = new System.Drawing.Point(114, 154);
            this.numTotalCannettes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTotalCannettes.Name = "numTotalCannettes";
            this.numTotalCannettes.ReadOnly = true;
            this.numTotalCannettes.Size = new System.Drawing.Size(45, 20);
            this.numTotalCannettes.TabIndex = 2;
            this.numTotalCannettes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(194, 151);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(110, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // chkMachinesPleines
            // 
            this.chkMachinesPleines.AutoSize = true;
            this.chkMachinesPleines.Location = new System.Drawing.Point(12, 23);
            this.chkMachinesPleines.Name = "chkMachinesPleines";
            this.chkMachinesPleines.Size = new System.Drawing.Size(159, 17);
            this.chkMachinesPleines.TabIndex = 6;
            this.chkMachinesPleines.Text = "Machines pleines seulement";
            this.chkMachinesPleines.UseVisualStyleBackColor = true;
            this.chkMachinesPleines.CheckedChanged += new System.EventHandler(this.chkMachinesPleines_CheckedChanged);
            // 
            // FrmListeMachines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 189);
            this.Controls.Add(this.chkMachinesPleines);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.numTotalCannettes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstMachines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListeMachines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventaire des machines";
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCannettes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMachines;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numTotalCannettes;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.CheckBox chkMachinesPleines;
    }
}