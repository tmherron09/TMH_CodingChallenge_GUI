
namespace TMHCodingChallengeHostGUI
{
    partial class HomeForm
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
            this.btnDiagDiff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDiagDiff
            // 
            this.btnDiagDiff.AutoSize = true;
            this.btnDiagDiff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiagDiff.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.btnDiagDiff.FlatAppearance.BorderSize = 3;
            this.btnDiagDiff.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiagDiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagDiff.Font = new System.Drawing.Font("Fira Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiagDiff.Location = new System.Drawing.Point(61, 153);
            this.btnDiagDiff.Name = "btnDiagDiff";
            this.btnDiagDiff.Size = new System.Drawing.Size(314, 45);
            this.btnDiagDiff.TabIndex = 0;
            this.btnDiagDiff.Text = "Diagonal Difference";
            this.btnDiagDiff.UseVisualStyleBackColor = false;
            this.btnDiagDiff.Click += new System.EventHandler(this.btnDiagDiff_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiagDiff);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiagDiff;
    }
}