namespace WinFormsApp
{
    partial class FrmStart
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
            this.components = new System.ComponentModel.Container();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(137, 18);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(164, 128);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "10";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(185, 179);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(45, 179);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 2;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 255);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblStart);
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStart;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtName;
    }
}