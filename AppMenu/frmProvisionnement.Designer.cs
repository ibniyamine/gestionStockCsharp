namespace AppMenu
{
    partial class frmProvisionnement
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
            this.lblQte = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatePeremption = new System.Windows.Forms.DateTimePicker();
            this.dgApprovisionnement = new System.Windows.Forms.DataGridView();
            this.lblProduit = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQte
            // 
            this.lblQte.AutoSize = true;
            this.lblQte.Location = new System.Drawing.Point(38, 45);
            this.lblQte.Name = "lblQte";
            this.lblQte.Size = new System.Drawing.Size(63, 18);
            this.lblQte.TabIndex = 0;
            this.lblQte.Text = "Quantite";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(41, 68);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(198, 24);
            this.txtQte.TabIndex = 1;
            this.txtQte.TextChanged += new System.EventHandler(this.txtQte_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de peremption";
            // 
            // txtDatePeremption
            // 
            this.txtDatePeremption.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatePeremption.Location = new System.Drawing.Point(481, 66);
            this.txtDatePeremption.Name = "txtDatePeremption";
            this.txtDatePeremption.Size = new System.Drawing.Size(207, 24);
            this.txtDatePeremption.TabIndex = 3;
            this.txtDatePeremption.ValueChanged += new System.EventHandler(this.txtDatePeremption_ValueChanged);
            // 
            // dgApprovisionnement
            // 
            this.dgApprovisionnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgApprovisionnement.Location = new System.Drawing.Point(41, 151);
            this.dgApprovisionnement.Name = "dgApprovisionnement";
            this.dgApprovisionnement.Size = new System.Drawing.Size(649, 369);
            this.dgApprovisionnement.TabIndex = 4;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProduit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProduit.Location = new System.Drawing.Point(42, 13);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(49, 18);
            this.lblProduit.TabIndex = 5;
            this.lblProduit.Text = "labelle";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(41, 117);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(141, 28);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(207, 117);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(141, 28);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(373, 117);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(141, 28);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmProvisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblProduit);
            this.Controls.Add(this.dgApprovisionnement);
            this.Controls.Add(this.txtDatePeremption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.lblQte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProvisionnement";
            this.Text = "frmProvisionnement";
            this.Load += new System.EventHandler(this.frmProvisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgApprovisionnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQte;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDatePeremption;
        private System.Windows.Forms.DataGridView dgApprovisionnement;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
    }
}