namespace example
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModifyStudentBtn = new System.Windows.Forms.Button();
            this.RemoveStudentBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.StudentIdInput = new System.Windows.Forms.NumericUpDown();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.AddGradeBtn = new System.Windows.Forms.Button();
            this.GradeIdInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModifyGradeBtn = new System.Windows.Forms.Button();
            this.RemoveGradeBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.DateInput = new System.Windows.Forms.DateTimePicker();
            this.GradeInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeIdInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModifyStudentBtn);
            this.groupBox1.Controls.Add(this.RemoveStudentBtn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // ModifyStudentBtn
            // 
            this.ModifyStudentBtn.Location = new System.Drawing.Point(194, 176);
            this.ModifyStudentBtn.Name = "ModifyStudentBtn";
            this.ModifyStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyStudentBtn.TabIndex = 7;
            this.ModifyStudentBtn.Text = "Modify";
            this.ModifyStudentBtn.UseVisualStyleBackColor = true;
            this.ModifyStudentBtn.Click += new System.EventHandler(this.ModifyStudentBtn_Click);
            // 
            // RemoveStudentBtn
            // 
            this.RemoveStudentBtn.Location = new System.Drawing.Point(275, 176);
            this.RemoveStudentBtn.Name = "RemoveStudentBtn";
            this.RemoveStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveStudentBtn.TabIndex = 7;
            this.RemoveStudentBtn.Text = "Remove";
            this.RemoveStudentBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentBtn.Click += new System.EventHandler(this.RemoveStudentBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(431, 29);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(142, 20);
            this.NameText.TabIndex = 3;
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(431, 52);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(142, 20);
            this.SurnameText.TabIndex = 4;
            // 
            // StudentIdInput
            // 
            this.StudentIdInput.Location = new System.Drawing.Point(431, 77);
            this.StudentIdInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.StudentIdInput.Name = "StudentIdInput";
            this.StudentIdInput.Size = new System.Drawing.Size(142, 20);
            this.StudentIdInput.TabIndex = 5;
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(431, 103);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(75, 23);
            this.AddStudentBtn.TabIndex = 6;
            this.AddStudentBtn.Text = "Add";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // AddGradeBtn
            // 
            this.AddGradeBtn.Location = new System.Drawing.Point(431, 327);
            this.AddGradeBtn.Name = "AddGradeBtn";
            this.AddGradeBtn.Size = new System.Drawing.Size(75, 23);
            this.AddGradeBtn.TabIndex = 14;
            this.AddGradeBtn.Text = "Add";
            this.AddGradeBtn.UseVisualStyleBackColor = true;
            this.AddGradeBtn.Click += new System.EventHandler(this.AddGradeBtn_Click);
            // 
            // GradeIdInput
            // 
            this.GradeIdInput.Location = new System.Drawing.Point(431, 301);
            this.GradeIdInput.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.GradeIdInput.Name = "GradeIdInput";
            this.GradeIdInput.Size = new System.Drawing.Size(142, 20);
            this.GradeIdInput.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModifyGradeBtn);
            this.groupBox2.Controls.Add(this.RemoveGradeBtn);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 214);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grades";
            // 
            // ModifyGradeBtn
            // 
            this.ModifyGradeBtn.Location = new System.Drawing.Point(194, 176);
            this.ModifyGradeBtn.Name = "ModifyGradeBtn";
            this.ModifyGradeBtn.Size = new System.Drawing.Size(75, 23);
            this.ModifyGradeBtn.TabIndex = 7;
            this.ModifyGradeBtn.Text = "Modify";
            this.ModifyGradeBtn.UseVisualStyleBackColor = true;
            this.ModifyGradeBtn.Click += new System.EventHandler(this.ModifyGradeBtn_Click);
            // 
            // RemoveGradeBtn
            // 
            this.RemoveGradeBtn.Location = new System.Drawing.Point(275, 176);
            this.RemoveGradeBtn.Name = "RemoveGradeBtn";
            this.RemoveGradeBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveGradeBtn.TabIndex = 7;
            this.RemoveGradeBtn.Text = "Remove";
            this.RemoveGradeBtn.UseVisualStyleBackColor = true;
            this.RemoveGradeBtn.Click += new System.EventHandler(this.RemoveGradeBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade:";
            // 
            // DateInput
            // 
            this.DateInput.Location = new System.Drawing.Point(431, 275);
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(142, 20);
            this.DateInput.TabIndex = 15;
            // 
            // GradeInput
            // 
            this.GradeInput.Location = new System.Drawing.Point(431, 250);
            this.GradeInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GradeInput.Name = "GradeInput";
            this.GradeInput.Size = new System.Drawing.Size(142, 20);
            this.GradeInput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 457);
            this.Controls.Add(this.GradeInput);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.AddGradeBtn);
            this.Controls.Add(this.GradeIdInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.StudentIdInput);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeIdInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ModifyStudentBtn;
        private System.Windows.Forms.Button RemoveStudentBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.NumericUpDown StudentIdInput;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button AddGradeBtn;
        private System.Windows.Forms.NumericUpDown GradeIdInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ModifyGradeBtn;
        private System.Windows.Forms.Button RemoveGradeBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateInput;
        private System.Windows.Forms.NumericUpDown GradeInput;
    }
}

