namespace WinFormsApp
{
    partial class FrmGenerateAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.NumericUpDown();
            this.btnCreateText = new System.Windows.Forms.Button();
            this.btnAddCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numText)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number text:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(286, 19);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(139, 23);
            this.numText.TabIndex = 1;
            this.numText.ValueChanged += new System.EventHandler(this.numText_ValueChanged);
            // 
            // btnCreateText
            // 
            this.btnCreateText.Location = new System.Drawing.Point(486, 19);
            this.btnCreateText.Name = "btnCreateText";
            this.btnCreateText.Size = new System.Drawing.Size(75, 23);
            this.btnCreateText.TabIndex = 2;
            this.btnCreateText.Text = "Create text";
            this.btnCreateText.UseVisualStyleBackColor = true;
            this.btnCreateText.Click += new System.EventHandler(this.btnCreateText_Click);
            // 
            // btnAddCheck
            // 
            this.btnAddCheck.Enabled = false;
            this.btnAddCheck.Location = new System.Drawing.Point(12, 415);
            this.btnAddCheck.Name = "btnAddCheck";
            this.btnAddCheck.Size = new System.Drawing.Size(75, 23);
            this.btnAddCheck.TabIndex = 3;
            this.btnAddCheck.Text = "Add check";
            this.btnAddCheck.UseVisualStyleBackColor = true;
            this.btnAddCheck.Click += new System.EventHandler(this.btnAddCheck_Click);
            // 
            // FrmGenerateAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.btnAddCheck);
            this.Controls.Add(this.btnCreateText);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label1);
            this.Name = "FrmGenerateAuto";
            this.Text = "FrmGenerateAuto";
            ((System.ComponentModel.ISupportInitialize)(this.numText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numText;
        private Button btnCreateText;
        private Button btnAddCheck;
    }
}