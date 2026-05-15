namespace HotelManagerApp
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBoxRegistration = new GroupBox();
            btnRegisret = new Button();
            cmbLoyalty = new ComboBox();
            txtPhone = new TextBox();
            txtPassport = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtFullName = new TextBox();
            groupBoxSearch = new GroupBox();
            btnFindRoom = new Button();
            numCapacity = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cmbRoomClass = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpDeparture = new DateTimePicker();
            dtpArrival = new DateTimePicker();
            dgvCheckouts = new TabPage();
            btnDelay = new Button();
            btnCheckout = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            dtpCheckoutDate = new DateTimePicker();
            label10 = new Label();
            tabPage3 = new TabPage();
            lblNoResults = new Label();
            dgvSearchResults = new DataGridView();
            btnSearch = new Button();
            cmbSearchCategory = new ComboBox();
            dtpSearchDate = new DateTimePicker();
            txtSearchKeyword = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            tabPage4 = new TabPage();
            btnGenerateReport = new Button();
            lblAnalyticsReport = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBoxRegistration.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            dgvCheckouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(dgvCheckouts);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(744, 470);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBoxRegistration);
            tabPage1.Controls.Add(groupBoxSearch);
            tabPage1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(736, 442);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поселення";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBoxRegistration
            // 
            groupBoxRegistration.Controls.Add(btnRegisret);
            groupBoxRegistration.Controls.Add(cmbLoyalty);
            groupBoxRegistration.Controls.Add(txtPhone);
            groupBoxRegistration.Controls.Add(txtPassport);
            groupBoxRegistration.Controls.Add(label9);
            groupBoxRegistration.Controls.Add(label8);
            groupBoxRegistration.Controls.Add(label7);
            groupBoxRegistration.Controls.Add(label6);
            groupBoxRegistration.Controls.Add(txtFullName);
            groupBoxRegistration.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxRegistration.Location = new Point(6, 182);
            groupBoxRegistration.Name = "groupBoxRegistration";
            groupBoxRegistration.Size = new Size(709, 243);
            groupBoxRegistration.TabIndex = 1;
            groupBoxRegistration.TabStop = false;
            groupBoxRegistration.Text = "                                                            Реєстрація";
            // 
            // btnRegisret
            // 
            btnRegisret.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRegisret.Location = new Point(192, 184);
            btnRegisret.Name = "btnRegisret";
            btnRegisret.Size = new Size(334, 38);
            btnRegisret.TabIndex = 8;
            btnRegisret.Text = "[Оформити поселення]";
            btnRegisret.UseVisualStyleBackColor = true;
            // 
            // cmbLoyalty
            // 
            cmbLoyalty.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbLoyalty.FormattingEnabled = true;
            cmbLoyalty.Location = new Point(364, 127);
            cmbLoyalty.Name = "cmbLoyalty";
            cmbLoyalty.Size = new Size(339, 31);
            cmbLoyalty.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPhone.Location = new Point(9, 127);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(331, 31);
            txtPhone.TabIndex = 6;
            // 
            // txtPassport
            // 
            txtPassport.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassport.Location = new Point(364, 67);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(339, 31);
            txtPassport.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label9.Location = new Point(364, 101);
            label9.Name = "label9";
            label9.Size = new Size(152, 23);
            label9.TabIndex = 4;
            label9.Text = "Рівень лояльності";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label8.Location = new Point(9, 101);
            label8.Name = "label8";
            label8.Size = new Size(77, 23);
            label8.TabIndex = 3;
            label8.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label7.Location = new Point(364, 41);
            label7.Name = "label7";
            label7.Size = new Size(309, 23);
            label7.TabIndex = 2;
            label7.Text = "Серія та номер паспорту(Обов'якове)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(9, 41);
            label6.Name = "label6";
            label6.Size = new Size(142, 23);
            label6.TabIndex = 1;
            label6.Text = "ПІБ(Обов'якове)";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtFullName.Location = new Point(9, 67);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(331, 31);
            txtFullName.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(btnFindRoom);
            groupBoxSearch.Controls.Add(numCapacity);
            groupBoxSearch.Controls.Add(label5);
            groupBoxSearch.Controls.Add(label4);
            groupBoxSearch.Controls.Add(cmbRoomClass);
            groupBoxSearch.Controls.Add(label3);
            groupBoxSearch.Controls.Add(label2);
            groupBoxSearch.Controls.Add(label1);
            groupBoxSearch.Controls.Add(dtpDeparture);
            groupBoxSearch.Controls.Add(dtpArrival);
            groupBoxSearch.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxSearch.Location = new Point(9, 14);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(706, 162);
            groupBoxSearch.TabIndex = 0;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "                                                     Підбір Номера";
            groupBoxSearch.Enter += groupBoxSearch_Enter;
            // 
            // btnFindRoom
            // 
            btnFindRoom.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnFindRoom.Location = new Point(189, 108);
            btnFindRoom.Name = "btnFindRoom";
            btnFindRoom.Size = new Size(334, 38);
            btnFindRoom.TabIndex = 9;
            btnFindRoom.Text = "[Знайти вільний номер]";
            btnFindRoom.UseVisualStyleBackColor = true;
            btnFindRoom.Click += btnFindRoom_Click;
            // 
            // numCapacity
            // 
            numCapacity.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numCapacity.Location = new Point(544, 61);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(156, 31);
            numCapacity.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(544, 35);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 7;
            label5.Text = "Кількість місць";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(361, 35);
            label4.Name = "label4";
            label4.Size = new Size(112, 23);
            label4.TabIndex = 6;
            label4.Text = "Клас номера";
            label4.Click += label4_Click;
            // 
            // cmbRoomClass
            // 
            cmbRoomClass.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbRoomClass.FormattingEnabled = true;
            cmbRoomClass.Location = new Point(361, 61);
            cmbRoomClass.Name = "cmbRoomClass";
            cmbRoomClass.Size = new Size(162, 31);
            cmbRoomClass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(189, 35);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 4;
            label3.Text = "Дата ви'їзду";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 3;
            label2.Text = "Дата приїзду";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(41, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 2;
            // 
            // dtpDeparture
            // 
            dtpDeparture.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpDeparture.Format = DateTimePickerFormat.Short;
            dtpDeparture.Location = new Point(189, 61);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(158, 31);
            dtpDeparture.TabIndex = 1;
            // 
            // dtpArrival
            // 
            dtpArrival.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpArrival.Format = DateTimePickerFormat.Short;
            dtpArrival.Location = new Point(6, 61);
            dtpArrival.Name = "dtpArrival";
            dtpArrival.Size = new Size(162, 31);
            dtpArrival.TabIndex = 0;
            // 
            // dgvCheckouts
            // 
            dgvCheckouts.Controls.Add(btnDelay);
            dgvCheckouts.Controls.Add(btnCheckout);
            dgvCheckouts.Controls.Add(dataGridView1);
            dgvCheckouts.Controls.Add(dtpCheckoutDate);
            dgvCheckouts.Controls.Add(label10);
            dgvCheckouts.Location = new Point(4, 24);
            dgvCheckouts.Name = "dgvCheckouts";
            dgvCheckouts.Padding = new Padding(3);
            dgvCheckouts.Size = new Size(736, 442);
            dgvCheckouts.TabIndex = 1;
            dgvCheckouts.Text = "Ві'їзд";
            dgvCheckouts.UseVisualStyleBackColor = true;
            // 
            // btnDelay
            // 
            btnDelay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelay.Location = new Point(534, 369);
            btnDelay.Name = "btnDelay";
            btnDelay.Size = new Size(170, 41);
            btnDelay.TabIndex = 4;
            btnDelay.Text = "[Оформити затримку]";
            btnDelay.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCheckout.Location = new Point(340, 369);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(175, 41);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "[Звільнити номер]";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(9, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(706, 254);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Гість";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Номер";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Дата заїзду";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Дата вид'їзду";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Затримка виїзду";
            Column5.Name = "Column5";
            // 
            // dtpCheckoutDate
            // 
            dtpCheckoutDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpCheckoutDate.Format = DateTimePickerFormat.Short;
            dtpCheckoutDate.Location = new Point(115, 41);
            dtpCheckoutDate.Name = "dtpCheckoutDate";
            dtpCheckoutDate.Size = new Size(165, 27);
            dtpCheckoutDate.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label10.Location = new Point(23, 41);
            label10.Name = "label10";
            label10.Size = new Size(96, 21);
            label10.TabIndex = 0;
            label10.Text = "Дата виїзду:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lblNoResults);
            tabPage3.Controls.Add(dgvSearchResults);
            tabPage3.Controls.Add(btnSearch);
            tabPage3.Controls.Add(cmbSearchCategory);
            tabPage3.Controls.Add(dtpSearchDate);
            tabPage3.Controls.Add(txtSearchKeyword);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(736, 442);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Пошук";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblNoResults
            // 
            lblNoResults.AutoSize = true;
            lblNoResults.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblNoResults.Location = new Point(231, 129);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(287, 21);
            lblNoResults.TabIndex = 8;
            lblNoResults.Text = "За вашим запитом нічого не знайдено";
            lblNoResults.Visible = false;
            lblNoResults.Click += lblNoResults_Click;
            // 
            // dgvSearchResults
            // 
            dgvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResults.Location = new Point(32, 164);
            dgvSearchResults.Name = "dgvSearchResults";
            dgvSearchResults.Size = new Size(665, 228);
            dgvSearchResults.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(248, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(231, 34);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "[Шукати]";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new Point(559, 45);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new Size(138, 29);
            cmbSearchCategory.TabIndex = 5;
            // 
            // dtpSearchDate
            // 
            dtpSearchDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dtpSearchDate.Format = DateTimePickerFormat.Short;
            dtpSearchDate.Location = new Point(378, 45);
            dtpSearchDate.Name = "dtpSearchDate";
            dtpSearchDate.Size = new Size(140, 29);
            dtpSearchDate.TabIndex = 4;
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSearchKeyword.Location = new Point(32, 45);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(293, 29);
            txtSearchKeyword.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label13.Location = new Point(559, 21);
            label13.Name = "label13";
            label13.Size = new Size(138, 21);
            label13.TabIndex = 2;
            label13.Text = "Категорія кімнати";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label12.Location = new Point(378, 21);
            label12.Name = "label12";
            label12.Size = new Size(45, 21);
            label12.TabIndex = 1;
            label12.Text = "Дати";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(32, 21);
            label11.Name = "label11";
            label11.Size = new Size(242, 21);
            label11.TabIndex = 0;
            label11.Text = "Пошук за ознакою(ПІБ,Паспорт)";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnGenerateReport);
            tabPage4.Controls.Add(lblAnalyticsReport);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(736, 442);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Аналітика";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnGenerateReport.Location = new Point(233, 45);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(255, 59);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "[Сформувати звіт]";
            btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // lblAnalyticsReport
            // 
            lblAnalyticsReport.BorderStyle = BorderStyle.FixedSingle;
            lblAnalyticsReport.Location = new Point(47, 123);
            lblAnalyticsReport.Name = "lblAnalyticsReport";
            lblAnalyticsReport.Size = new Size(640, 281);
            lblAnalyticsReport.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 581);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBoxRegistration.ResumeLayout(false);
            groupBoxRegistration.PerformLayout();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            dgvCheckouts.ResumeLayout(false);
            dgvCheckouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResults).EndInit();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage dgvCheckouts;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private GroupBox groupBoxSearch;
        private DateTimePicker dtpDeparture;
        private DateTimePicker dtpArrival;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numCapacity;
        private Label label5;
        private Label label4;
        private ComboBox cmbRoomClass;
        private GroupBox groupBoxRegistration;
        private Button btnFindRoom;
        private TextBox txtFullName;
        private Label label7;
        private Label label6;
        private Label label9;
        private Label label8;
        private TextBox txtPhone;
        private TextBox txtPassport;
        private ComboBox cmbLoyalty;
        private Button btnRegisret;
        private DataGridView dataGridView1;
        private DateTimePicker dtpCheckoutDate;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnDelay;
        private Button btnCheckout;
        private Label label12;
        private DateTimePicker dtpSearchDate;
        private TextBox txtSearchKeyword;
        private DataGridView dgvSearchResults;
        private Button btnSearch;
        private ComboBox cmbSearchCategory;
        private Label lblNoResults;
        private Label lblAnalyticsReport;
        private Button btnGenerateReport;
        private Label label11;
        private Label label13;
       
    }
}
