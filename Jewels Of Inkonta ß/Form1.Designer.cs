namespace Jewels_Of_Inkonta_ß
{
    partial class Frm_Menu
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
            this.Btn_start = new System.Windows.Forms.Button();
            this.Btn_end = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_start
            // 
            this.Btn_start.Location = new System.Drawing.Point(107, 228);
            this.Btn_start.Name = "Btn_start";
            this.Btn_start.Size = new System.Drawing.Size(159, 92);
            this.Btn_start.TabIndex = 0;
            this.Btn_start.Text = "Start your adventure!";
            this.Btn_start.UseVisualStyleBackColor = true;
            this.Btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // Btn_end
            // 
            this.Btn_end.Location = new System.Drawing.Point(495, 228);
            this.Btn_end.Name = "Btn_end";
            this.Btn_end.Size = new System.Drawing.Size(159, 92);
            this.Btn_end.TabIndex = 1;
            this.Btn_end.Text = "End your adventure!";
            this.Btn_end.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(222, 92);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(344, 50);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "Jewels of Inkonta ß";
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.Btn_end);
            this.Controls.Add(this.Btn_start);
            this.Name = "Frm_Menu";
            this.Text = "Jewels of inkonta ß";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_start;
        private System.Windows.Forms.Button Btn_end;
        private System.Windows.Forms.Label lbl_title;
    }
}

