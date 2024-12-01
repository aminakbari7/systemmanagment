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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUserCancel = new System.Windows.Forms.Button();
            this.BtnUserSave = new System.Windows.Forms.Button();
            this.BtnUserDelete = new System.Windows.Forms.Button();
            this.BtnUserEdit = new System.Windows.Forms.Button();
            this.BtnUserAdd = new System.Windows.Forms.Button();
            this.textBoxusersearch = new System.Windows.Forms.TextBox();
            this.panelgriduser = new System.Windows.Forms.Panel();
            this.dataGridViewpersons = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelgriduser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpersons)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserCancel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserDelete, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnUserAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxusersearch, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.pictureBox1.Image = global::systemmanagment.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1018, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnUserCancel
            // 
            this.BtnUserCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserCancel.Image = global::systemmanagment.Properties.Resources.home0;
            this.BtnUserCancel.Location = new System.Drawing.Point(369, 3);
            this.BtnUserCancel.Name = "BtnUserCancel";
            this.BtnUserCancel.Size = new System.Drawing.Size(72, 65);
            this.BtnUserCancel.TabIndex = 4;
            this.BtnUserCancel.UseVisualStyleBackColor = false;
            // 
            // BtnUserSave
            // 
            this.BtnUserSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserSave.Image = global::systemmanagment.Properties.Resources.save;
            this.BtnUserSave.Location = new System.Drawing.Point(279, 3);
            this.BtnUserSave.Name = "BtnUserSave";
            this.BtnUserSave.Size = new System.Drawing.Size(72, 65);
            this.BtnUserSave.TabIndex = 3;
            this.BtnUserSave.UseVisualStyleBackColor = false;
            // 
            // BtnUserDelete
            // 
            this.BtnUserDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserDelete.Image = global::systemmanagment.Properties.Resources.delete_2;
            this.BtnUserDelete.Location = new System.Drawing.Point(190, 3);
            this.BtnUserDelete.Name = "BtnUserDelete";
            this.BtnUserDelete.Size = new System.Drawing.Size(69, 65);
            this.BtnUserDelete.TabIndex = 2;
            this.BtnUserDelete.UseVisualStyleBackColor = false;
            // 
            // BtnUserEdit
            // 
            this.BtnUserEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserEdit.Image = global::systemmanagment.Properties.Resources.edit;
            this.BtnUserEdit.Location = new System.Drawing.Point(103, 3);
            this.BtnUserEdit.Name = "BtnUserEdit";
            this.BtnUserEdit.Size = new System.Drawing.Size(63, 65);
            this.BtnUserEdit.TabIndex = 1;
            this.BtnUserEdit.UseVisualStyleBackColor = false;
            // 
            // BtnUserAdd
            // 
            this.BtnUserAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(6)))), ((int)(((byte)(56)))));
            this.BtnUserAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserAdd.Image = global::systemmanagment.Properties.Resources.add_user;
            this.BtnUserAdd.Location = new System.Drawing.Point(8, 3);
            this.BtnUserAdd.Name = "BtnUserAdd";
            this.BtnUserAdd.Size = new System.Drawing.Size(73, 65);
            this.BtnUserAdd.TabIndex = 0;
            this.BtnUserAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxusersearch
            // 
            this.textBoxusersearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxusersearch.Location = new System.Drawing.Point(551, 47);
            this.textBoxusersearch.Name = "textBoxusersearch";
            this.textBoxusersearch.Size = new System.Drawing.Size(460, 26);
            this.textBoxusersearch.TabIndex = 5;
            // 
            // panelgriduser
            // 
            this.panelgriduser.Controls.Add(this.dataGridViewpersons);
            this.panelgriduser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelgriduser.Location = new System.Drawing.Point(0, 76);
            this.panelgriduser.Name = "panelgriduser";
            this.panelgriduser.Padding = new System.Windows.Forms.Padding(10, 3, 10, 0);
            this.panelgriduser.Size = new System.Drawing.Size(1067, 542);
            this.panelgriduser.TabIndex = 1;
            this.panelgriduser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgriduser_Paint);
            // 
            // dataGridViewpersons
            // 
            this.dataGridViewpersons.AllowUserToAddRows = false;
            this.dataGridViewpersons.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewpersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewpersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewpersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewpersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewpersons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewpersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewpersons.ColumnHeadersHeight = 50;
            this.dataGridViewpersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewpersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(164)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewpersons.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewpersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewpersons.EnableHeadersVisualStyles = false;
            this.dataGridViewpersons.Location = new System.Drawing.Point(10, 3);
            this.dataGridViewpersons.Name = "dataGridViewpersons";
            this.dataGridViewpersons.ReadOnly = true;
            this.dataGridViewpersons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewpersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewpersons.RowHeadersVisible = false;
            this.dataGridViewpersons.RowHeadersWidth = 62;
            this.dataGridViewpersons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(9)))), ((int)(((byte)(76)))));
            this.dataGridViewpersons.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(164)))), ((int)(((byte)(150)))));
            this.dataGridViewpersons.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.dataGridViewpersons.RowTemplate.Height = 28;
            this.dataGridViewpersons.RowTemplate.ReadOnly = true;
            this.dataGridViewpersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewpersons.Size = new System.Drawing.Size(1047, 539);
            this.dataGridViewpersons.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.FillWeight = 37.01492F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 62;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 53.16515F;
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 54.81925F;
            this.Column2.HeaderText = "Family";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 55.09739F;
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 61.95988F;
            this.Column4.HeaderText = "Birthday";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 337.9434F;
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FormPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 618);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelgriduser;
        private System.Windows.Forms.Button BtnUserCancel;
        private System.Windows.Forms.Button BtnUserSave;
        private System.Windows.Forms.Button BtnUserDelete;
        private System.Windows.Forms.Button BtnUserEdit;
        private System.Windows.Forms.Button BtnUserAdd;
        private System.Windows.Forms.TextBox textBoxusersearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewpersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}