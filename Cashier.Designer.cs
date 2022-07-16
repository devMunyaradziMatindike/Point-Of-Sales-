namespace PointOfSales
{
    partial class Cashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNames = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblVatable = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.dgvCash = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.colReduce = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnDSales = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btTransaction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPass);
            this.panel1.Controls.Add(this.btnDSales);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSettle);
            this.panel1.Controls.Add(this.btnDiscount);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btTransaction);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 570);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(229, 190);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(11, 49);
            this.panelSlide.TabIndex = 4;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelNames);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 184);
            this.panel2.TabIndex = 1;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.ForeColor = System.Drawing.Color.White;
            this.labelNames.Location = new System.Drawing.Point(3, 117);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(33, 20);
            this.labelNames.TabIndex = 7;
            this.labelNames.Text = "Lb";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(244, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(9, 570);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel4.Controls.Add(this.picClose);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lblName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(253, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 49);
            this.panel4.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(75, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name and Role";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQty);
            this.panel5.Controls.Add(this.lblTimer);
            this.panel5.Controls.Add(this.lblVatable);
            this.panel5.Controls.Add(this.lblVat);
            this.panel5.Controls.Add(this.lblDiscount);
            this.panel5.Controls.Add(this.lblSalesTotal);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtBarcode);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.lblDate);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblTransNo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblDisplayTotal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1046, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 521);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(156, 261);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(49, 27);
            this.txtQty.TabIndex = 12;
            this.txtQty.Text = "1";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 472);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(217, 49);
            this.lblTimer.TabIndex = 19;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // lblVatable
            // 
            this.lblVatable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatable.Location = new System.Drawing.Point(141, 450);
            this.lblVatable.Name = "lblVatable";
            this.lblVatable.Size = new System.Drawing.Size(64, 20);
            this.lblVatable.TabIndex = 17;
            this.lblVatable.Text = "0.00";
            this.lblVatable.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblVat
            // 
            this.lblVat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(141, 424);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(64, 20);
            this.lblVat.TabIndex = 18;
            this.lblVat.Text = "0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(141, 387);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(64, 20);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "0.00";
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTotal.Location = new System.Drawing.Point(141, 353);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(64, 20);
            this.lblSalesTotal.TabIndex = 16;
            this.lblSalesTotal.Text = "0.00";
            this.lblSalesTotal.Click += new System.EventHandler(this.lblSalesTotal_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "VAT :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Discount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sub Total :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(8, 261);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(144, 27);
            this.txtBarcode.TabIndex = 11;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Barcode";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(32, 184);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(139, 20);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "0000000000";
            this.lblDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNo.Location = new System.Drawing.Point(32, 116);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(139, 20);
            this.lblTransNo.TabIndex = 8;
            this.lblTransNo.Text = "0000000000";
            this.lblTransNo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transcaction No";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.lblDisplayTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.ForeColor = System.Drawing.Color.White;
            this.lblDisplayTotal.Location = new System.Drawing.Point(0, 0);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(217, 30);
            this.lblDisplayTotal.TabIndex = 0;
            this.lblDisplayTotal.Text = "0.00";
            this.lblDisplayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDisplayTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvCash
            // 
            this.dgvCash.AllowUserToAddRows = false;
            this.dgvCash.BackgroundColor = System.Drawing.Color.White;
            this.dgvCash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCash.ColumnHeadersHeight = 30;
            this.dgvCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.colAdd,
            this.colReduce,
            this.Delete});
            this.dgvCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCash.EnableHeadersVisualStyles = false;
            this.dgvCash.Location = new System.Drawing.Point(253, 49);
            this.dgvCash.Name = "dgvCash";
            this.dgvCash.RowHeadersVisible = false;
            this.dgvCash.RowHeadersWidth = 51;
            this.dgvCash.RowTemplate.Height = 24;
            this.dgvCash.Size = new System.Drawing.Size(793, 521);
            this.dgvCash.TabIndex = 6;
            this.dgvCash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            this.dgvCash.SelectionChanged += new System.EventHandler(this.dgvCash_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 65;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Id";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 48;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "PCode";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 101;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 89;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Qty";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 72;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Discount";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 129;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Total";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 93;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PointOfSales.Properties.Resources.add_20px;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PointOfSales.Properties.Resources.delete_20px;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::PointOfSales.Properties.Resources.remove_20px;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // colAdd
            // 
            this.colAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAdd.HeaderText = "";
            this.colAdd.Image = global::PointOfSales.Properties.Resources.add_20px;
            this.colAdd.MinimumWidth = 6;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 6;
            // 
            // colReduce
            // 
            this.colReduce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colReduce.HeaderText = "";
            this.colReduce.Image = global::PointOfSales.Properties.Resources.minus_20px;
            this.colReduce.MinimumWidth = 6;
            this.colReduce.Name = "colReduce";
            this.colReduce.Width = 6;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::PointOfSales.Properties.Resources.remove_20px;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::PointOfSales.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(974, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(33, 30);
            this.picClose.TabIndex = 7;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSales.Properties.Resources.user_50px;
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::PointOfSales.Properties.Resources.exit_50px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 521);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(244, 49);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LogOut ";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPass
            // 
            this.btnPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.ForeColor = System.Drawing.Color.White;
            this.btnPass.Image = global::PointOfSales.Properties.Resources.password_50px;
            this.btnPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPass.Location = new System.Drawing.Point(0, 478);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(244, 49);
            this.btnPass.TabIndex = 8;
            this.btnPass.Text = "Change Password";
            this.btnPass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnDSales
            // 
            this.btnDSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDSales.FlatAppearance.BorderSize = 0;
            this.btnDSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSales.ForeColor = System.Drawing.Color.White;
            this.btnDSales.Image = global::PointOfSales.Properties.Resources.total_sales_50px;
            this.btnDSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDSales.Location = new System.Drawing.Point(0, 429);
            this.btnDSales.Name = "btnDSales";
            this.btnDSales.Size = new System.Drawing.Size(244, 49);
            this.btnDSales.TabIndex = 7;
            this.btnDSales.Text = "Daily Sales";
            this.btnDSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDSales.UseVisualStyleBackColor = true;
            this.btnDSales.Click += new System.EventHandler(this.btnDSales_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::PointOfSales.Properties.Resources.shopping_cart_50px;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(0, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(244, 49);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettle.FlatAppearance.BorderSize = 0;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.ForeColor = System.Drawing.Color.White;
            this.btnSettle.Image = global::PointOfSales.Properties.Resources.calculator_50px;
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(0, 331);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(244, 49);
            this.btnSettle.TabIndex = 5;
            this.btnSettle.Text = "Settle Payment";
            this.btnSettle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = global::PointOfSales.Properties.Resources.low_price_50px;
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(0, 282);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(244, 49);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "Add Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(244, 49);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Product";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // btTransaction
            // 
            this.btTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btTransaction.FlatAppearance.BorderSize = 0;
            this.btTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransaction.ForeColor = System.Drawing.Color.White;
            this.btTransaction.Image = global::PointOfSales.Properties.Resources.transaction_50px;
            this.btTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTransaction.Location = new System.Drawing.Point(0, 184);
            this.btTransaction.Name = "btTransaction";
            this.btTransaction.Size = new System.Drawing.Size(244, 49);
            this.btTransaction.TabIndex = 2;
            this.btTransaction.Text = "New Transcaction";
            this.btTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTransaction.UseVisualStyleBackColor = true;
            this.btTransaction.Click += new System.EventHandler(this.btTransaction_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PointOfSales.Properties.Resources.ticket_purchase_100px;
            this.pictureBox1.Location = new System.Drawing.Point(61, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 570);
            this.Controls.Add(this.dgvCash);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnDSales;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVatable;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSalesTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.DataGridView dgvCash;
        public System.Windows.Forms.Label lblDisplayTotal;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn colAdd;
        private System.Windows.Forms.DataGridViewImageColumn colReduce;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}