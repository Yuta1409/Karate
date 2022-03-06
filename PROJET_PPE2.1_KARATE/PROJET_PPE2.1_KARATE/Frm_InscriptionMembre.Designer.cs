
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
            this.Cmd_Modif_Sup = new System.Windows.Forms.Button();
            this.Cmd_Detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmd_Ajouter
            // 
            this.Cmd_Ajouter.Location = new System.Drawing.Point(358, 60);
            this.Cmd_Ajouter.Name = "Cmd_Ajouter";
            this.Cmd_Ajouter.Size = new System.Drawing.Size(394, 150);
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
            // Cmd_Modif_Sup
            // 
            this.Cmd_Modif_Sup.Location = new System.Drawing.Point(358, 372);
            this.Cmd_Modif_Sup.Name = "Cmd_Modif_Sup";
            this.Cmd_Modif_Sup.Size = new System.Drawing.Size(394, 150);
            this.Cmd_Modif_Sup.TabIndex = 79;
            this.Cmd_Modif_Sup.Text = "Modification et Suppression d\'inscription";
            this.Cmd_Modif_Sup.UseVisualStyleBackColor = true;
            this.Cmd_Modif_Sup.Click += new System.EventHandler(this.Cmd_Modif_Sup_Click);
            // 
            // Cmd_Detail
            // 
            this.Cmd_Detail.Location = new System.Drawing.Point(358, 216);
            this.Cmd_Detail.Name = "Cmd_Detail";
            this.Cmd_Detail.Size = new System.Drawing.Size(394, 150);
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
            this.Controls.Add(this.Cmd_Ajouter);
            this.Controls.Add(this.label2);
            this.Name = "Frm_InscriptionMembre";
            this.Text = "FrmInscriptionMembre";
            this.Load += new System.EventHandler(this.Frm_InscriptionMembre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cmd_Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cmd_Modif_Sup;
        private System.Windows.Forms.Button Cmd_Detail;
    }
}