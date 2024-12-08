namespace systemmanagment
{
    partial class FormPersons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxusersearch = new System.Windows.Forms.TextBox();
            this.BtnUserCancel = new System.Windows.Forms.Button();
            this.BtnUserEdit = new System.Windows.Forms.Button();
            this.BtnUserAdd = new System.Windows.Forms.Button();
            this.BtnUserSave = new System.Windows.Forms.Button();
            this.BtnPrsonsPrint = new System.Windows.Forms.Button();
            this.panelgriduser = new System.Windows.Forms.Panel();
            this.dataGridViewpersons = new System.Windows.Forms.DataGridView();
            this.paneltextboxperson = new System.Windows.Forms.Panel();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxcodm = new System.Windows.Forms.TextBox();
            this.textBoxaddress = new System.Windows.Forms.TextBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.textBoxfamily = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelgriduser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersons)).BeginInit();
            this.paneltextboxperson.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxusersearch, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserAdd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPrsonsPrint, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1225, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::systemmanagment.Properties.Resources.delete_2;
            this.button1.Location = new System.Drawing.Point(100, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 65);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.pictureBox1.Image = global::systemmanagment.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1156, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxusersearch
            // 
            this.textBoxusersearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxusersearch.Location = new System.Drawing.Point(689, 47);
            this.textBoxusersearch.Name = "textBoxusersearch";
            this.textBoxusersearch.Size = new System.Drawing.Size(460, 26);
            this.textBoxusersearch.TabIndex = 5;
            this.textBoxusersearch.TextChanged += new System.EventHandler(this.textBoxusersearch_TextChanged);
            // 
            // BtnUserCancel
            // 
            this.BtnUserCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserCancel.Image = global::systemmanagment.Properties.Resources.back;
            this.BtnUserCancel.Location = new System.Drawing.Point(7, 3);
            this.BtnUserCancel.Name = "BtnUserCancel";
            this.BtnUserCancel.Size = new System.Drawing.Size(75, 65);
            this.BtnUserCancel.TabIndex = 8;
            this.BtnUserCancel.UseVisualStyleBackColor = false;
            this.BtnUserCancel.Click += new System.EventHandler(this.BtnUserCancel_Click);
            // 
            // BtnUserEdit
            // 
            this.BtnUserEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserEdit.Image = global::systemmanagment.Properties.Resources.edit;
            this.BtnUserEdit.Location = new System.Drawing.Point(283, 3);
            this.BtnUserEdit.Name = "BtnUserEdit";
            this.BtnUserEdit.Size = new System.Drawing.Size(63, 65);
            this.BtnUserEdit.TabIndex = 1;
            this.BtnUserEdit.UseVisualStyleBackColor = false;
            this.BtnUserEdit.Click += new System.EventHandler(this.BtnUserEdit_Click);
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserAdd.BackColor = System.Drawing.Color.Lime;
            this.BtnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserAdd.Image = global::systemmanagment.Properties.Resources.add_user;
            this.BtnUserAdd.Location = new System.Drawing.Point(188, 3);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(73, 65);
            this.BtnUserAdd.TabIndex = 0;
            this.BtnUserAdd.UseVisualStyleBackColor = false;
            this.BtnUserAdd.Click += new System.EventHandler(this.BtnUserAdd_Click);
            // 
            // BtnUserSave
            // 
            this.BtnUserSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserSave.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnUserSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserSave.Enabled = false;
            this.BtnUserSave.Image = global::systemmanagment.Properties.Resources.save;
            this.BtnUserSave.Location = new System.Drawing.Point(369, 3);
            this.BtnUserSave.Name = "BtnUserSave";
            this.BtnUserSave.Size = new System.Drawing.Size(72, 65);
            this.BtnUserSave.TabIndex = 7;
            this.BtnUserSave.UseVisualStyleBackColor = false;
            this.BtnUserSave.Click += new System.EventHandler(this.BtnUserSave_Click_1);
            // 
            // BtnPrsonsPrint
            // 
            this.BtnPrsonsPrint.BackColor = System.Drawing.Color.Silver;
            this.BtnPrsonsPrint.Image = global::systemmanagment.Properties.Resources.print_2;
            this.BtnPrsonsPrint.Location = new System.Drawing.Point(453, 3);
            this.BtnPrsonsPrint.Name = "BtnPrsonsPrint";
            this.BtnPrsonsPrint.Size = new System.Drawing.Size(75, 65);
            this.BtnPrsonsPrint.TabIndex = 10;
            this.BtnPrsonsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnPrsonsPrint.UseVisualStyleBackColor = false;
            this.BtnPrsonsPrint.Click += new System.EventHandler(this.BtnPrsonsPrint_Click);
            // 
            // panelgriduser
            // 
            this.panelgriduser.Controls.Add(this.dataGridViewpersons);
            this.panelgriduser.Controls.Add(this.paneltextboxperson);
            this.panelgriduser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgriduser.Location = new System.Drawing.Point(0, 76);
            this.panelgriduser.Name = "panelgriduser";
            this.panelgriduser.Padding = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.panelgriduser.Size = new System.Drawing.Size(1225, 628);
            this.panelgriduser.TabIndex = 1;
            this.panelgriduser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgriduser_Paint);
            // 
            // dataGridViewpersons
            // 
            this.dataGridViewpersons.AllowUserToAddRows = false;
            this.dataGridViewpersons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewpersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewpersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewpersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewpersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewpersons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewpersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewpersons.ColumnHeadersHeight = 50;
            this.dataGridViewpersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(164)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewpersons.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewpersons.EnableHeadersVisualStyles = false;
            this.dataGridViewpersons.Location = new System.Drawing.Point(10, 114);
            this.dataGridViewpersons.Name = "dataGridViewpersons";
            this.dataGridViewpersons.ReadOnly = true;
            this.dataGridViewpersons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewpersons.RowHeadersVisible = false;
            this.dataGridViewpersons.RowHeadersWidth = 62;
            this.dataGridViewpersons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.dataGridViewpersons.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(164)))), ((int)(((byte)(150)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.RowTemplate.Height = 28;
            this.dataGridViewpersons.RowTemplate.ReadOnly = true;
            this.dataGridViewpersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewpersons.Size = new System.Drawing.Size(1205, 511);
            this.dataGridViewpersons.TabIndex = 23;
            this.dataGridViewpersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpersons_CellContentClick_1);
            // 
            // paneltextboxperson
            // 
            this.paneltextboxperson.Controls.Add(this.label5);
            this.paneltextboxperson.Controls.Add(this.label4);
            this.paneltextboxperson.Controls.Add(this.label3);
            this.paneltextboxperson.Controls.Add(this.label2);
            this.paneltextboxperson.Controls.Add(this.label1);
            this.paneltextboxperson.Controls.Add(this.labelid);
            this.paneltextboxperson.Controls.Add(this.textBoxname);
            this.paneltextboxperson.Controls.Add(this.textBoxid);
            this.paneltextboxperson.Controls.Add(this.textBoxcodm);
            this.paneltextboxperson.Controls.Add(this.textBoxaddress);
            this.paneltextboxperson.Controls.Add(this.textBoxphone);
            this.paneltextboxperson.Controls.Add(this.textBoxfamily);
            this.paneltextboxperson.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltextboxperson.Location = new System.Drawing.Point(10, 3);
            this.paneltextboxperson.Name = "paneltextboxperson";
            this.paneltextboxperson.Size = new System.Drawing.Size(1205, 105);
            this.paneltextboxperson.TabIndex = 22;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(196, 19);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(208, 26);
            this.textBoxname.TabIndex = 15;
            // 
            // textBoxid
            // 
            this.textBoxid.Enabled = false;
            this.textBoxid.Location = new System.Drawing.Point(46, 19);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(50, 26);
            this.textBoxid.TabIndex = 21;
            // 
            // textBoxcodm
            // 
            this.textBoxcodm.Location = new System.Drawing.Point(196, 64);
            this.textBoxcodm.Name = "textBoxcodm";
            this.textBoxcodm.Size = new System.Drawing.Size(208, 26);
            this.textBoxcodm.TabIndex = 16;
            // 
            // textBoxaddress
            // 
            this.textBoxaddress.Location = new System.Drawing.Point(506, 67);
            this.textBoxaddress.Name = "textBoxaddress";
            this.textBoxaddress.Size = new System.Drawing.Size(460, 26);
            this.textBoxaddress.TabIndex = 20;
            // 
            // textBoxphone
            // 
            this.textBoxphone.Location = new System.Drawing.Point(779, 22);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(187, 26);
            this.textBoxphone.TabIndex = 19;
            // 
            // textBoxfamily
            // 
            this.textBoxfamily.Location = new System.Drawing.Point(506, 19);
            this.textBoxfamily.Name = "textBoxfamily";
            this.textBoxfamily.Size = new System.Drawing.Size(187, 26);
            this.textBoxfamily.TabIndex = 18;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(14, 25);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(26, 20);
            this.labelid.TabIndex = 22;
            this.labelid.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Family";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Codm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone";
            // 
            // FormPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1225, 704);
            this.Controls.Add(this.panelgriduser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPersons";
            this.Text = "FormPersons";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelgriduser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersons)).EndInit();
            this.paneltextboxperson.ResumeLayout(false);
            this.paneltextboxperson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelgriduser;
        private System.Windows.Forms.Button BtnUserEdit;
        private System.Windows.Forms.TextBox textBoxusersearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnUserSave;
        private System.Windows.Forms.Button BtnUserCancel;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxaddress;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.TextBox textBoxfamily;
        private System.Windows.Forms.TextBox textBoxcodm;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Panel paneltextboxperson;
        private System.Windows.Forms.DataGridView dataGridViewpersons;
        private System.Windows.Forms.Button BtnUserAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPrsonsPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}