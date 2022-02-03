
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
            this.Grid_Modifier_Supprimer = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_LICENCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTE_GLOBALE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Modifier_Supprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // Cmd_Modifier
            // 
            this.Cmd_Modifier.Location = new System.Drawing.Point(181, 343);
            this.Cmd_Modifier.Name = "Cmd_Modifier";
            this.Cmd_Modifier.Size = new System.Drawing.Size(133, 55);
            this.Cmd_Modifier.TabIndex = 0;
            this.Cmd_Modifier.Text = "Modifier";
            this.Cmd_Modifier.UseVisualStyleBackColor = true;
            this.Cmd_Modifier.Click += new System.EventHandler(this.Cmd_Modifier_Click);
            // 
            // Cmd_Sup
            // 
            this.Cmd_Sup.Location = new System.Drawing.Point(430, 343);
            this.Cmd_Sup.Name = "Cmd_Sup";
            this.Cmd_Sup.Size = new System.Drawing.Size(133, 55);
            this.Cmd_Sup.TabIndex = 1;
            this.Cmd_Sup.Text = "Supprimer";
            this.Cmd_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Sup.Click += new System.EventHandler(this.Cmd_Sup_Click);
            // 
            // Grid_Modifier_Supprimer
            // 
            this.Grid_Modifier_Supprimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Modifier_Supprimer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_LICENCE,
            this.NOTE_GLOBALE});
            this.Grid_Modifier_Supprimer.Location = new System.Drawing.Point(12, 12);
            this.Grid_Modifier_Supprimer.Name = "Grid_Modifier_Supprimer";
            this.Grid_Modifier_Supprimer.RowHeadersWidth = 51;
            this.Grid_Modifier_Supprimer.RowTemplate.Height = 24;
            this.Grid_Modifier_Supprimer.Size = new System.Drawing.Size(776, 325);
            this.Grid_Modifier_Supprimer.TabIndex = 2;
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
            // Frm_Modifier_Supprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grid_Modifier_Supprimer);
            this.Controls.Add(this.Cmd_Sup);
            this.Controls.Add(this.Cmd_Modifier);
            this.Name = "Frm_Modifier_Supprimer";
            this.Text = "Frm_Modifier_Supprimer";
            this.Load += new System.EventHandler(this.Frm_Modifier_Supprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Modifier_Supprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Modifier;
        private System.Windows.Forms.Button Cmd_Sup;
        private System.Windows.Forms.DataGridView Grid_Modifier_Supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_LICENCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTE_GLOBALE;
    }
}