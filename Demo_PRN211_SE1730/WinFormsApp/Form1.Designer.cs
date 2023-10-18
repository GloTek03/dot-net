namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAsa = new System.Windows.Forms.Button();
            this.btnHiru = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsa
            // 
            this.btnAsa.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsa.ForeColor = System.Drawing.Color.Green;
            this.btnAsa.Location = new System.Drawing.Point(59, 74);
            this.btnAsa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAsa.Name = "btnAsa";
            this.btnAsa.Size = new System.Drawing.Size(81, 32);
            this.btnAsa.TabIndex = 0;
            this.btnAsa.Text = "ASA";
            this.btnAsa.UseVisualStyleBackColor = true;
            this.btnAsa.Click += new System.EventHandler(this.btnAsa_Click);
            // 
            // btnHiru
            // 
            this.btnHiru.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHiru.ForeColor = System.Drawing.Color.Red;
            this.btnHiru.Location = new System.Drawing.Point(172, 74);
            this.btnHiru.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHiru.Name = "btnHiru";
            this.btnHiru.Size = new System.Drawing.Size(81, 32);
            this.btnHiru.TabIndex = 1;
            this.btnHiru.Text = "HIRU";
            this.btnHiru.UseVisualStyleBackColor = true;
            this.btnHiru.Click += new System.EventHandler(this.btnHiru_Click);
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBan.Location = new System.Drawing.Point(283, 74);
            this.btnBan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(81, 32);
            this.btnBan.TabIndex = 2;
            this.btnBan.Text = "BAN";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(431, 211);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnHiru);
            this.Controls.Add(this.btnAsa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Event in Winform";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAsa;
        private Button btnHiru;
        private Button btnBan;
    }
}