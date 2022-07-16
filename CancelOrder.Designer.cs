namespace PointOfSales
{
    partial class CancelOrder
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
            System.Windows.Forms.Panel panel1;
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTransno = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVoid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCancelledBy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.cbAddToInventory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.udCancelQty = new System.Windows.Forms.NumericUpDown();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.picClose);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(793, 50);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cancel order details";
            // 
            // picClose
            // 
            this.picClose.Image = global::PointOfSales.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(763, 2);
            this.picClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 50);
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "id :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(122, 87);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 22);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(519, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(179, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtTransno
            // 
            this.txtTransno.Enabled = false;
            this.txtTransno.Location = new System.Drawing.Point(519, 83);
            this.txtTransno.Name = "txtTransno";
            this.txtTransno.Size = new System.Drawing.Size(179, 22);
            this.txtTransno.TabIndex = 5;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(519, 196);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(68, 22);
            this.txtQty.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(122, 196);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 50);
            this.txtDescription.TabIndex = 7;
            // 
            // txtPCode
            // 
            this.txtPCode.Enabled = false;
            this.txtPCode.Location = new System.Drawing.Point(122, 135);
            this.txtPCode.Name = "txtPCode";
            this.txtPCode.Size = new System.Drawing.Size(193, 22);
            this.txtPCode.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "product code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "description :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "transcaction :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "qty/discount :";
            // 
            // txtDisc
            // 
            this.txtDisc.Enabled = false;
            this.txtDisc.Location = new System.Drawing.Point(630, 199);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(68, 22);
            this.txtDisc.TabIndex = 14;
            this.txtDisc.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "sold item";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cancel item(s)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtVoid
            // 
            this.txtVoid.Location = new System.Drawing.Point(136, 321);
            this.txtVoid.Name = "txtVoid";
            this.txtVoid.Size = new System.Drawing.Size(179, 22);
            this.txtVoid.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "void by:";
            // 
            // txtCancelledBy
            // 
            this.txtCancelledBy.Enabled = false;
            this.txtCancelledBy.Location = new System.Drawing.Point(136, 364);
            this.txtCancelledBy.Name = "txtCancelledBy";
            this.txtCancelledBy.Size = new System.Drawing.Size(179, 22);
            this.txtCancelledBy.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "cancelled by :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "add to inventory :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "cancel qty :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(369, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "reason(s) :";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(519, 383);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(179, 50);
            this.txtReason.TabIndex = 26;
            // 
            // cbAddToInventory
            // 
            this.cbAddToInventory.FormattingEnabled = true;
            this.cbAddToInventory.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbAddToInventory.Location = new System.Drawing.Point(191, 410);
            this.cbAddToInventory.Name = "cbAddToInventory";
            this.cbAddToInventory.Size = new System.Drawing.Size(121, 23);
            this.cbAddToInventory.TabIndex = 27;
            this.cbAddToInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAddToInventory_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(527, 464);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 38);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "cancel order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(519, 243);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(179, 22);
            this.txtTotal.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(369, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 30;
            this.label15.Text = "total :";
            // 
            // udCancelQty
            // 
            this.udCancelQty.Location = new System.Drawing.Point(519, 319);
            this.udCancelQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udCancelQty.Name = "udCancelQty";
            this.udCancelQty.Size = new System.Drawing.Size(68, 22);
            this.udCancelQty.TabIndex = 31;
            this.udCancelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 543);
            this.Controls.Add(this.udCancelQty);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTransno);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbAddToInventory);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCancelledBy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVoid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPCode);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CancelOrder_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCancelQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtTransno;
        public System.Windows.Forms.TextBox txtQty;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtPCode;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.TextBox txtCancelledBy;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtVoid;
        public System.Windows.Forms.TextBox txtReason;
        public System.Windows.Forms.ComboBox cbAddToInventory;
        public System.Windows.Forms.NumericUpDown udCancelQty;
    }
}