
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_Detail_Competition
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
            this.label1 = new System.Windows.Forms.Label();
            this.Grid_Recherche = new System.Windows.Forms.DataGridView();
            this.numComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Recherche)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro de compétition";
            // 
            // Grid_Recherche
            // 
            this.Grid_Recherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Recherche.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numComp,
            this.numLicence,
            this.note});
            this.Grid_Recherche.Location = new System.Drawing.Point(3, 204);
            this.Grid_Recherche.Name = "Grid_Recherche";
            this.Grid_Recherche.RowHeadersWidth = 51;
            this.Grid_Recherche.RowTemplate.Height = 24;
            this.Grid_Recherche.Size = new System.Drawing.Size(637, 169);
            this.Grid_Recherche.TabIndex = 4;
            // 
            // numComp
            // 
            this.numComp.HeaderText = "NUM_COMPETITION";
            this.numComp.MinimumWidth = 6;
            this.numComp.Name = "numComp";
            this.numComp.Width = 125;
            // 
            // numLicence
            // 
            this.numLicence.HeaderText = "NUM_LICENCE";
            this.numLicence.MinimumWidth = 6;
            this.numLicence.Name = "numLicence";
            this.numLicence.Width = 125;
            // 
            // note
            // 
            this.note.HeaderText = "NOTE_GLOBAL";
            this.note.MinimumWidth = 6;
            this.note.Name = "note";
            this.note.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Frm_Detail_Competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Grid_Recherche);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Detail_Competition";
            this.Text = "Frm_Detail_Competition";
            this.Load += new System.EventHandler(this.Frm_Detail_Competition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Recherche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Recherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn numComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}