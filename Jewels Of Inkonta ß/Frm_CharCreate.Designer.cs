namespace Jewels_Of_Inkonta_ß
{
    partial class Frm_CharCreate
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_LatsGo = new System.Windows.Forms.Label();
            this.Btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(274, 225);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(215, 20);
            this.Txt_Name.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lets A Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_LatsGo
            // 
            this.Lbl_LatsGo.AutoSize = true;
            this.Lbl_LatsGo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LatsGo.Location = new System.Drawing.Point(192, 108);
            this.Lbl_LatsGo.Name = "Lbl_LatsGo";
            this.Lbl_LatsGo.Size = new System.Drawing.Size(381, 47);
            this.Lbl_LatsGo.TabIndex = 2;
            this.Lbl_LatsGo.Text = "WHAT IS THOU NAME?";
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(725, 427);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 4;
            this.Btn_close.Text = "Close";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // Frm_CharCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.Lbl_LatsGo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_CharCreate";
            this.Text = "Frm_CharCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_LatsGo;
        private System.Windows.Forms.Button Btn_close;
    }
}