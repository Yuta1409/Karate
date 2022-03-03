
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
            this.Grid_Detail_Comp = new System.Windows.Forms.DataGridView();
            this.NUM_COMPETITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CLUB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Detail_Comp)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Detail_Comp
            // 
            this.Grid_Detail_Comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Detail_Comp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUM_COMPETITION,
            this.NUM_CLUB});
            this.Grid_Detail_Comp.Location = new System.Drawing.Point(12, 12);
            this.Grid_Detail_Comp.Name = "Grid_Detail_Comp";
            this.Grid_Detail_Comp.RowHeadersWidth = 51;
            this.Grid_Detail_Comp.RowTemplate.Height = 24;
            this.Grid_Detail_Comp.Size = new System.Drawing.Size(409, 315);
            this.Grid_Detail_Comp.TabIndex = 0;
            this.Grid_Detail_Comp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Detail_Comp_CellContentClick);
            // 
            // NUM_COMPETITION
            // 
            this.NUM_COMPETITION.HeaderText = "NUM_COMPETITION";
            this.NUM_COMPETITION.MinimumWidth = 6;
            this.NUM_COMPETITION.Name = "NUM_COMPETITION";
            this.NUM_COMPETITION.Width = 125;
            // 
            // NUM_CLUB
            // 
            this.NUM_CLUB.HeaderText = "NUM_CLUB";
            this.NUM_CLUB.MinimumWidth = 6;
            this.NUM_CLUB.Name = "NUM_CLUB";
            this.NUM_CLUB.Width = 125;
            // 
            // Frm_Detail_Competition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grid_Detail_Comp);
            this.Name = "Frm_Detail_Competition";
            this.Text = "Frm_Detail_Competition";
            this.Load += new System.EventHandler(this.Frm_Detail_Competition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Detail_Comp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Detail_Comp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_COMPETITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CLUB;
    }
}