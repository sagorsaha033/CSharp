namespace BBMS
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.empSaveBtn = new System.Windows.Forms.Button();
            this.empPass = new System.Windows.Forms.TextBox();
            this.viewEmpGV = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.empEditBtn = new System.Windows.Forms.Button();
            this.empDeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label14.Location = new System.Drawing.Point(952, 562);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 85;
            this.label14.Text = "Password";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empSaveBtn
            // 
            this.empSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.empSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empSaveBtn.FlatAppearance.BorderSize = 0;
            this.empSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empSaveBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSaveBtn.ForeColor = System.Drawing.Color.White;
            this.empSaveBtn.Location = new System.Drawing.Point(724, 661);
            this.empSaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.empSaveBtn.Name = "empSaveBtn";
            this.empSaveBtn.Size = new System.Drawing.Size(145, 43);
            this.empSaveBtn.TabIndex = 87;
            this.empSaveBtn.Text = "Save";
            this.empSaveBtn.UseVisualStyleBackColor = false;
            this.empSaveBtn.Click += new System.EventHandler(this.empSaveBtn_Click);
            // 
            // empPass
            // 
            this.empPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPass.Location = new System.Drawing.Point(957, 597);
            this.empPass.Margin = new System.Windows.Forms.Padding(4);
            this.empPass.Multiline = true;
            this.empPass.Name = "empPass";
            this.empPass.Size = new System.Drawing.Size(227, 31);
            this.empPass.TabIndex = 83;
            // 
            // viewEmpGV
            // 
            this.viewEmpGV.AllowUserToAddRows = false;
            this.viewEmpGV.AllowUserToDeleteRows = false;
            this.viewEmpGV.AllowUserToResizeColumns = false;
            this.viewEmpGV.AllowUserToResizeRows = false;
            this.viewEmpGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewEmpGV.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewEmpGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewEmpGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewEmpGV.ColumnHeadersVisible = false;
            this.viewEmpGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.viewEmpGV.Location = new System.Drawing.Point(519, 217);
            this.viewEmpGV.Margin = new System.Windows.Forms.Padding(4);
            this.viewEmpGV.MultiSelect = false;
            this.viewEmpGV.Name = "viewEmpGV";
            this.viewEmpGV.RowHeadersVisible = false;
            this.viewEmpGV.RowHeadersWidth = 51;
            this.viewEmpGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.viewEmpGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewEmpGV.RowTemplate.Height = 30;
            this.viewEmpGV.RowTemplate.ReadOnly = true;
            this.viewEmpGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.viewEmpGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewEmpGV.Size = new System.Drawing.Size(872, 290);
            this.viewEmpGV.TabIndex = 90;
            this.viewEmpGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewEmpGV_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel8.Location = new System.Drawing.Point(957, 629);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(227, 5);
            this.panel8.TabIndex = 82;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel9.Location = new System.Drawing.Point(679, 626);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(227, 5);
            this.panel9.TabIndex = 81;
            // 
            // EmpName
            // 
            this.EmpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.Location = new System.Drawing.Point(677, 597);
            this.EmpName.Margin = new System.Windows.Forms.Padding(4);
            this.EmpName.Multiline = true;
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(227, 31);
            this.EmpName.TabIndex = 84;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label17.Location = new System.Drawing.Point(672, 567);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 23);
            this.label17.TabIndex = 86;
            this.label17.Text = "Name";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(65, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(79, 794);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Logout";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(72, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 5);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 739);
            this.panel1.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label16.Location = new System.Drawing.Point(867, 91);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 32);
            this.label16.TabIndex = 79;
            this.label16.Text = "Employees";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 70);
            this.panel2.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // empEditBtn
            // 
            this.empEditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.empEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empEditBtn.FlatAppearance.BorderSize = 0;
            this.empEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empEditBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empEditBtn.ForeColor = System.Drawing.Color.White;
            this.empEditBtn.Location = new System.Drawing.Point(877, 661);
            this.empEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.empEditBtn.Name = "empEditBtn";
            this.empEditBtn.Size = new System.Drawing.Size(145, 43);
            this.empEditBtn.TabIndex = 87;
            this.empEditBtn.Text = "Edit";
            this.empEditBtn.UseVisualStyleBackColor = false;
            this.empEditBtn.Click += new System.EventHandler(this.empEditBtn_Click);
            // 
            // empDeleteBtn
            // 
            this.empDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.empDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empDeleteBtn.FlatAppearance.BorderSize = 0;
            this.empDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.empDeleteBtn.Location = new System.Drawing.Point(1031, 661);
            this.empDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.empDeleteBtn.Name = "empDeleteBtn";
            this.empDeleteBtn.Size = new System.Drawing.Size(145, 43);
            this.empDeleteBtn.TabIndex = 87;
            this.empDeleteBtn.Text = "Delete";
            this.empDeleteBtn.UseVisualStyleBackColor = false;
            this.empDeleteBtn.Click += new System.EventHandler(this.empDeleteBtn_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 739);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.empPass);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.viewEmpGV);
            this.Controls.Add(this.empDeleteBtn);
            this.Controls.Add(this.empEditBtn);
            this.Controls.Add(this.empSaveBtn);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.viewEmpGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button empSaveBtn;
        private System.Windows.Forms.TextBox empPass;
        private System.Windows.Forms.DataGridView viewEmpGV;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empEditBtn;
        private System.Windows.Forms.Button empDeleteBtn;
        private System.Windows.Forms.Label label2;
    }
}