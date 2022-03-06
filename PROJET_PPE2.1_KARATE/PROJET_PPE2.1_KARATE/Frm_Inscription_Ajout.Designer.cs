
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_Inscription_Ajout
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
            this.Grid_Comp = new System.Windows.Forms.DataGridView();
            this.numCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Membre = new System.Windows.Forms.DataGridView();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Ajout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Comp
            // 
            this.Grid_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCompetition,
            this.num_CLUB,
            this.Column1});
            this.Grid_Comp.Location = new System.Drawing.Point(12, 184);
            this.Grid_Comp.Name = "Grid_Comp";
            this.Grid_Comp.RowHeadersWidth = 51;
            this.Grid_Comp.RowTemplate.Height = 24;
            this.Grid_Comp.Size = new System.Drawing.Size(740, 150);
            this.Grid_Comp.TabIndex = 74;
            // 
            // numCompetition
            // 
            this.numCompetition.HeaderText = "NUM_COMPETITION";
            this.numCompetition.MinimumWidth = 6;
            this.numCompetition.Name = "numCompetition";
            this.numCompetition.Width = 125;
            // 
            // num_CLUB
            // 
            this.num_CLUB.HeaderText = "NUM_CLUB";
            this.num_CLUB.MinimumWidth = 6;
            this.num_CLUB.Name = "num_CLUB";
            this.num_CLUB.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DATE_COMPETITION";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Grid_Membre
            // 
            this.Grid_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Membre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLicence,
            this.column,
            this.Column2,
            this.Column3});
            this.Grid_Membre.Location = new System.Drawing.Point(12, 12);
            this.Grid_Membre.Name = "Grid_Membre";
            this.Grid_Membre.RowHeadersWidth = 51;
            this.Grid_Membre.RowTemplate.Height = 24;
            this.Grid_Membre.Size = new System.Drawing.Size(740, 150);
            this.Grid_Membre.TabIndex = 73;
            // 
            // numLicence
            // 
            this.numLicence.HeaderText = "NUM_LICENCE";
            this.numLicence.MinimumWidth = 6;
            this.numLicence.Name = "numLicence";
            this.numLicence.Width = 125;
            // 
            // column
            // 
            this.column.HeaderText = "NUM_CLUB";
            this.column.MinimumWidth = 6;
            this.column.Name = "column";
            this.column.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOM_MEMBRE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRENOM_MEMBRE";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.Location = new System.Drawing.Point(251, 340);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(274, 29);
            this.btn_Ajout.TabIndex = 75;
            this.btn_Ajout.Text = "Ajouter une inscription";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.btn_Ajout_Click);
            // 
            // Frm_Inscription_Ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 415);
            this.Controls.Add(this.btn_Ajout);
            this.Controls.Add(this.Grid_Comp);
            this.Controls.Add(this.Grid_Membre);
            this.Name = "Frm_Inscription_Ajout";
            this.Text = "Frm_Inscription_Ajout";
            this.Load += new System.EventHandler(this.Frm_Inscription_Ajout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView Grid_Membre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_Ajout;
    }
}