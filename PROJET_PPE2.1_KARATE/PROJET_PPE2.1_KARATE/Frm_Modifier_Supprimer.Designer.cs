
namespace PROJET_PPE2._1_KARATE
{
    partial class Frm_Modifier_Supprimer
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
            this.Cmd_Modifier = new System.Windows.Forms.Button();
            this.Cmd_Sup = new System.Windows.Forms.Button();
            this.Grid_Inscrip = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInscrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inscrip)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Modifier
            // 
            this.Cmd_Modifier.Location = new System.Drawing.Point(319, 353);
            this.Cmd_Modifier.Name = "Cmd_Modifier";
            this.Cmd_Modifier.Size = new System.Drawing.Size(133, 55);
            this.Cmd_Modifier.TabIndex = 0;
            this.Cmd_Modifier.Text = "Modifier";
            this.Cmd_Modifier.UseVisualStyleBackColor = true;
            this.Cmd_Modifier.Click += new System.EventHandler(this.Cmd_Modifier_Click);
            // 
            // Cmd_Sup
            // 
            this.Cmd_Sup.Location = new System.Drawing.Point(458, 353);
            this.Cmd_Sup.Name = "Cmd_Sup";
            this.Cmd_Sup.Size = new System.Drawing.Size(133, 55);
            this.Cmd_Sup.TabIndex = 1;
            this.Cmd_Sup.Text = "Supprimer";
            this.Cmd_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Sup.Click += new System.EventHandler(this.Cmd_Sup_Click);
            // 
            // Grid_Inscrip
            // 
            this.Grid_Inscrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Inscrip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE,
            this.NOTE_GLOBALE});
            this.Grid_Inscrip.Location = new System.Drawing.Point(12, 12);
            this.Grid_Inscrip.Name = "Grid_Inscrip";
            this.Grid_Inscrip.RowHeadersWidth = 51;
            this.Grid_Inscrip.RowTemplate.Height = 24;
            this.Grid_Inscrip.Size = new System.Drawing.Size(776, 325);
            this.Grid_Inscrip.TabIndex = 2;
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 6;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 125;
            // 
            // NUM_LICENCE
            // 
            this.NUM_LICENCE.HeaderText = "NUM_LICENCE";
            this.NUM_LICENCE.MinimumWidth = 6;
            this.NUM_LICENCE.Name = "NUM_LICENCE";
            this.NUM_LICENCE.Width = 125;
            // 
            // NOTE_GLOBALE
            // 
            this.NOTE_GLOBALE.HeaderText = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.MinimumWidth = 6;
            this.NOTE_GLOBALE.Name = "NOTE_GLOBALE";
            this.NOTE_GLOBALE.Width = 125;
            // 
            // txtInscrip
            // 
            this.txtInscrip.Location = new System.Drawing.Point(180, 369);
            this.txtInscrip.Multiline = true;
            this.txtInscrip.Name = "txtInscrip";
            this.txtInscrip.Size = new System.Drawing.Size(133, 29);
            this.txtInscrip.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro de compétition :";
            // 
            // Frm_Modifier_Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInscrip);
            this.Controls.Add(this.Grid_Inscrip);
            this.Controls.Add(this.Cmd_Sup);
            this.Controls.Add(this.Cmd_Modifier);
            this.Name = "Frm_Modifier_Supprimer";
            this.Text = "Frm_Modifier_Supprimer";
            this.Load += new System.EventHandler(this.Frm_Modifier_Supprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Inscrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Modifier;
        private System.Windows.Forms.Button Cmd_Sup;
        private System.Windows.Forms.DataGridView Grid_Inscrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
        private System.Windows.Forms.TextBox txtInscrip;
        private System.Windows.Forms.Label label1;
    }
}