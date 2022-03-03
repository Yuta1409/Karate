
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_InscriptionMembre
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
            this.Cmd_Ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Grid_Membre = new System.Windows.Forms.DataGridView();
            this.numLicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid_Comp = new System.Windows.Forms.DataGridView();
            this.numCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmd_Modif_Sup = new System.Windows.Forms.Button();
            this.Cmd_Detail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Ajouter
            // 
            this.Cmd_Ajouter.Location = new System.Drawing.Point(758, 49);
            this.Cmd_Ajouter.Name = "Cmd_Ajouter";
            this.Cmd_Ajouter.Size = new System.Drawing.Size(366, 150);
            this.Cmd_Ajouter.TabIndex = 70;
            this.Cmd_Ajouter.Text = "Ajouter une Inscription";
            this.Cmd_Ajouter.UseVisualStyleBackColor = true;
            this.Cmd_Ajouter.Click += new System.EventHandler(this.Cmd_Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 27);
            this.label2.TabIndex = 69;
            this.label2.Text = "INSCRIPTION D\'UN NOUVEAU MEMBRE A UNE COMPETITION";
            // 
            // Grid_Membre
            // 
            this.Grid_Membre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Membre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numLicence,
            this.column,
            this.Column2,
            this.Column3});
            this.Grid_Membre.Location = new System.Drawing.Point(12, 49);
            this.Grid_Membre.Name = "Grid_Membre";
            this.Grid_Membre.RowHeadersWidth = 51;
            this.Grid_Membre.RowTemplate.Height = 24;
            this.Grid_Membre.Size = new System.Drawing.Size(740, 150);
            this.Grid_Membre.TabIndex = 71;
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
            // Grid_Comp
            // 
            this.Grid_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCompetition,
            this.num_CLUB,
            this.Column1});
            this.Grid_Comp.Location = new System.Drawing.Point(12, 221);
            this.Grid_Comp.Name = "Grid_Comp";
            this.Grid_Comp.RowHeadersWidth = 51;
            this.Grid_Comp.RowTemplate.Height = 24;
            this.Grid_Comp.Size = new System.Drawing.Size(740, 150);
            this.Grid_Comp.TabIndex = 72;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Compétition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Membre";
            // 
            // Cmd_Modif_Sup
            // 
            this.Cmd_Modif_Sup.Location = new System.Drawing.Point(758, 221);
            this.Cmd_Modif_Sup.Name = "Cmd_Modif_Sup";
            this.Cmd_Modif_Sup.Size = new System.Drawing.Size(366, 150);
            this.Cmd_Modif_Sup.TabIndex = 79;
            this.Cmd_Modif_Sup.Text = "Modification et Suppression d\'inscription";
            this.Cmd_Modif_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Modif_Sup.Click += new System.EventHandler(this.Cmd_Modif_Sup_Click);
            // 
            // Cmd_Detail
            // 
            this.Cmd_Detail.Location = new System.Drawing.Point(247, 401);
            this.Cmd_Detail.Name = "Cmd_Detail";
            this.Cmd_Detail.Size = new System.Drawing.Size(156, 57);
            this.Cmd_Detail.TabIndex = 80;
            this.Cmd_Detail.Text = "Détail des compétitions";
            this.Cmd_Detail.UseVisualStyleBackColor = true;
            this.Cmd_Detail.Click += new System.EventHandler(this.Cmd_Detail_Click);
            // 
            // Frm_InscriptionMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 573);
            this.Controls.Add(this.Cmd_Detail);
            this.Controls.Add(this.Cmd_Modif_Sup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_Comp);
            this.Controls.Add(this.Grid_Membre);
            this.Controls.Add(this.Cmd_Ajouter);
            this.Controls.Add(this.label2);
            this.Name = "Frm_InscriptionMembre";
            this.Text = "FrmInscriptionMembre";
            this.Load += new System.EventHandler(this.Frm_InscriptionMembre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Membre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Comp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cmd_Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Grid_Membre;
        private System.Windows.Forms.DataGridView Grid_Comp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCompetition;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_CLUB;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button Cmd_Modif_Sup;
        private System.Windows.Forms.Button Cmd_Detail;
    }
}