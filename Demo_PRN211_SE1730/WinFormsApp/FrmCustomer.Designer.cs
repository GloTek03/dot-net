namespace WinFormsApp
{
    partial class FrmCustomer
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
            dgCustomer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_reset = new Button();
            txt_ID = new TextBox();
            txt_birth = new TextBox();
            txt_address = new TextBox();
            txt_name = new TextBox();
            radio_M = new RadioButton();
            radio_Fe = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(21, 293);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.Height = 29;
            dgCustomer.Size = new Size(777, 188);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "CustomerID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Birthdate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 193);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 28);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 4;
            label4.Text = "CustomerName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 113);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Gender:";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(81, 245);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 31);
            btn_add.TabIndex = 6;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(263, 245);
            btn_update.Margin = new Padding(3, 4, 3, 4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(86, 31);
            btn_update.TabIndex = 7;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(451, 245);
            btn_delete.Margin = new Padding(3, 4, 3, 4);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(86, 31);
            btn_delete.TabIndex = 8;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(634, 245);
            btn_reset.Margin = new Padding(3, 4, 3, 4);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(86, 31);
            btn_reset.TabIndex = 9;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = true;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(159, 25);
            txt_ID.Margin = new Padding(3, 4, 3, 4);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(189, 27);
            txt_ID.TabIndex = 10;
            // 
            // txt_birth
            // 
            txt_birth.Location = new Point(159, 103);
            txt_birth.Margin = new Padding(3, 4, 3, 4);
            txt_birth.Name = "txt_birth";
            txt_birth.Size = new Size(189, 27);
            txt_birth.TabIndex = 11;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(159, 183);
            txt_address.Margin = new Padding(3, 4, 3, 4);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(583, 27);
            txt_address.TabIndex = 12;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(553, 25);
            txt_name.Margin = new Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(189, 27);
            txt_name.TabIndex = 13;
            // 
            // radio_M
            // 
            radio_M.AutoSize = true;
            radio_M.Location = new Point(553, 111);
            radio_M.Margin = new Padding(3, 4, 3, 4);
            radio_M.Name = "radio_M";
            radio_M.Size = new Size(63, 24);
            radio_M.TabIndex = 14;
            radio_M.TabStop = true;
            radio_M.Text = "Male";
            radio_M.UseVisualStyleBackColor = true;
            // 
            // radio_Fe
            // 
            radio_Fe.AutoSize = true;
            radio_Fe.Location = new Point(685, 111);
            radio_Fe.Margin = new Padding(3, 4, 3, 4);
            radio_Fe.Name = "radio_Fe";
            radio_Fe.Size = new Size(78, 24);
            radio_Fe.TabIndex = 15;
            radio_Fe.TabStop = true;
            radio_Fe.Text = "Female";
            radio_Fe.UseVisualStyleBackColor = true;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 504);
            Controls.Add(radio_Fe);
            Controls.Add(radio_M);
            Controls.Add(txt_name);
            Controls.Add(txt_address);
            Controls.Add(txt_birth);
            Controls.Add(txt_ID);
            Controls.Add(btn_reset);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmCustomer";
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_reset;
        private TextBox txt_ID;
        private TextBox txt_birth;
        private TextBox txt_address;
        private TextBox txt_name;
        private RadioButton radio_M;
        private RadioButton radio_Fe;
    }
}