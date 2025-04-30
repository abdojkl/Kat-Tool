namespace KAT
{
    partial class KAT
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
            this.file_path_tx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show_img_bt = new System.Windows.Forms.Button();
            this.export_file_bt = new System.Windows.Forms.Button();
            this.column_compo = new System.Windows.Forms.ComboBox();
            this.search_value_tx = new System.Windows.Forms.TextBox();
            this.img_compo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.open_bt = new System.Windows.Forms.Button();
            this.account_type_comp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kobo_account_tx = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.img_compo2 = new System.Windows.Forms.ComboBox();
            this.file_path_tx2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.search_value2 = new System.Windows.Forms.TextBox();
            this.account_type_comp2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kobo_account_tx2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_path_tx
            // 
            this.file_path_tx.Location = new System.Drawing.Point(149, 41);
            this.file_path_tx.Name = "file_path_tx";
            this.file_path_tx.Size = new System.Drawing.Size(237, 20);
            this.file_path_tx.TabIndex = 0;
            this.file_path_tx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ": إختر عمود البحث ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = ": القيمة المراد البحث عنها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ": اختر عمود الصورة";
            // 
            // show_img_bt
            // 
            this.show_img_bt.Location = new System.Drawing.Point(195, 271);
            this.show_img_bt.Name = "show_img_bt";
            this.show_img_bt.Size = new System.Drawing.Size(100, 23);
            this.show_img_bt.TabIndex = 6;
            this.show_img_bt.Text = "عرض الصورة";
            this.show_img_bt.UseVisualStyleBackColor = true;
            this.show_img_bt.Click += new System.EventHandler(this.show_img_bt_Click);
            // 
            // export_file_bt
            // 
            this.export_file_bt.Location = new System.Drawing.Point(175, 219);
            this.export_file_bt.Name = "export_file_bt";
            this.export_file_bt.Size = new System.Drawing.Size(154, 23);
            this.export_file_bt.TabIndex = 7;
            this.export_file_bt.Text = "HTML تصدير الصور الى ملف ";
            this.export_file_bt.UseVisualStyleBackColor = true;
            this.export_file_bt.Click += new System.EventHandler(this.export_file_bt_Click);
            // 
            // column_compo
            // 
            this.column_compo.FormattingEnabled = true;
            this.column_compo.Location = new System.Drawing.Point(171, 115);
            this.column_compo.Name = "column_compo";
            this.column_compo.Size = new System.Drawing.Size(237, 21);
            this.column_compo.TabIndex = 8;
            this.column_compo.SelectedIndexChanged += new System.EventHandler(this.column_compo_SelectedIndexChanged);
            // 
            // search_value_tx
            // 
            this.search_value_tx.Location = new System.Drawing.Point(270, 178);
            this.search_value_tx.Name = "search_value_tx";
            this.search_value_tx.Size = new System.Drawing.Size(121, 20);
            this.search_value_tx.TabIndex = 10;
            // 
            // img_compo
            // 
            this.img_compo.FormattingEnabled = true;
            this.img_compo.Location = new System.Drawing.Point(175, 126);
            this.img_compo.Name = "img_compo";
            this.img_compo.Size = new System.Drawing.Size(237, 21);
            this.img_compo.TabIndex = 11;
            this.img_compo.SelectedIndexChanged += new System.EventHandler(this.img_compo_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 341);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.open_bt);
            this.tabPage1.Controls.Add(this.img_compo);
            this.tabPage1.Controls.Add(this.account_type_comp);
            this.tabPage1.Controls.Add(this.export_file_bt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.kobo_account_tx);
            this.tabPage1.Controls.Add(this.file_path_tx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تصدير روابط الصور";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // open_bt
            // 
            this.open_bt.Location = new System.Drawing.Point(408, 38);
            this.open_bt.Name = "open_bt";
            this.open_bt.Size = new System.Drawing.Size(103, 23);
            this.open_bt.TabIndex = 15;
            this.open_bt.Text = "اضغط لإختيار الملف";
            this.open_bt.UseVisualStyleBackColor = true;
            this.open_bt.Click += new System.EventHandler(this.open_bt_Click_1);
            // 
            // account_type_comp
            // 
            this.account_type_comp.FormattingEnabled = true;
            this.account_type_comp.Items.AddRange(new object[] {
            "https://kc.kobotoolbox.org/",
            "https://kobo.humanitarianresponse.info/"});
            this.account_type_comp.Location = new System.Drawing.Point(7, 106);
            this.account_type_comp.MaxDropDownItems = 2;
            this.account_type_comp.Name = "account_type_comp";
            this.account_type_comp.Size = new System.Drawing.Size(120, 21);
            this.account_type_comp.TabIndex = 14;
            this.account_type_comp.SelectedIndexChanged += new System.EventHandler(this.account_type_comp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "نوع الحساب";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ادخل حساب الكوبو";
            // 
            // kobo_account_tx
            // 
            this.kobo_account_tx.Location = new System.Drawing.Point(22, 41);
            this.kobo_account_tx.Name = "kobo_account_tx";
            this.kobo_account_tx.Size = new System.Drawing.Size(89, 20);
            this.kobo_account_tx.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.img_compo2);
            this.tabPage2.Controls.Add(this.file_path_tx2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.search_value2);
            this.tabPage2.Controls.Add(this.account_type_comp2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.kobo_account_tx2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.column_compo);
            this.tabPage2.Controls.Add(this.show_img_bt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "البحث عن صورة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // img_compo2
            // 
            this.img_compo2.FormattingEnabled = true;
            this.img_compo2.Location = new System.Drawing.Point(174, 211);
            this.img_compo2.Name = "img_compo2";
            this.img_compo2.Size = new System.Drawing.Size(237, 21);
            this.img_compo2.TabIndex = 26;
            this.img_compo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // file_path_tx2
            // 
            this.file_path_tx2.Location = new System.Drawing.Point(157, 45);
            this.file_path_tx2.Name = "file_path_tx2";
            this.file_path_tx2.Size = new System.Drawing.Size(251, 20);
            this.file_path_tx2.TabIndex = 25;
            this.file_path_tx2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = ": إختر عمود الصورة";
            // 
            // search_value2
            // 
            this.search_value2.Location = new System.Drawing.Point(241, 164);
            this.search_value2.Name = "search_value2";
            this.search_value2.Size = new System.Drawing.Size(153, 20);
            this.search_value2.TabIndex = 22;
            // 
            // account_type_comp2
            // 
            this.account_type_comp2.FormattingEnabled = true;
            this.account_type_comp2.Items.AddRange(new object[] {
            "https://kc.kobotoolbox.org/",
            "https://kobo.humanitarianresponse.info/"});
            this.account_type_comp2.Location = new System.Drawing.Point(7, 115);
            this.account_type_comp2.MaxDropDownItems = 2;
            this.account_type_comp2.Name = "account_type_comp2";
            this.account_type_comp2.Size = new System.Drawing.Size(120, 21);
            this.account_type_comp2.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "نوع الحساب";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ادخل حساب الكوبو";
            // 
            // kobo_account_tx2
            // 
            this.kobo_account_tx2.Location = new System.Drawing.Point(18, 48);
            this.kobo_account_tx2.Name = "kobo_account_tx2";
            this.kobo_account_tx2.Size = new System.Drawing.Size(89, 20);
            this.kobo_account_tx2.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "اضغط لإختيار الملف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.search_value_tx);
            this.Name = "KAT";
            this.Text = "KAT (Kobo Attachment Tool)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_path_tx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button show_img_bt;
        private System.Windows.Forms.Button export_file_bt;
        private System.Windows.Forms.ComboBox column_compo;
        private System.Windows.Forms.TextBox search_value_tx;
        private System.Windows.Forms.ComboBox img_compo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button open_bt;
        private System.Windows.Forms.ComboBox account_type_comp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kobo_account_tx;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_value2;
        private System.Windows.Forms.ComboBox account_type_comp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kobo_account_tx2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox file_path_tx2;
        private System.Windows.Forms.ComboBox img_compo2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

