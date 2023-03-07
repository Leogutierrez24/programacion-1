namespace exercise01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnqueueBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.DequeueWBtn = new System.Windows.Forms.Button();
            this.DequeueMBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // EnqueueBtn
            // 
            this.EnqueueBtn.Location = new System.Drawing.Point(40, 64);
            this.EnqueueBtn.Name = "EnqueueBtn";
            this.EnqueueBtn.Size = new System.Drawing.Size(84, 26);
            this.EnqueueBtn.TabIndex = 4;
            this.EnqueueBtn.Text = "Enqueue";
            this.EnqueueBtn.UseVisualStyleBackColor = true;
            this.EnqueueBtn.Click += new System.EventHandler(this.EnqueueBtn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(142, 197);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // DivideBtn
            // 
            this.DivideBtn.Location = new System.Drawing.Point(40, 321);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(84, 37);
            this.DivideBtn.TabIndex = 6;
            this.DivideBtn.Text = "Divide List";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Women list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Men list";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(205, 118);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(142, 197);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(364, 118);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(142, 197);
            this.listView3.TabIndex = 10;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            // 
            // DequeueWBtn
            // 
            this.DequeueWBtn.Location = new System.Drawing.Point(205, 321);
            this.DequeueWBtn.Name = "DequeueWBtn";
            this.DequeueWBtn.Size = new System.Drawing.Size(84, 37);
            this.DequeueWBtn.TabIndex = 11;
            this.DequeueWBtn.Text = "Dequeue";
            this.DequeueWBtn.UseVisualStyleBackColor = true;
            this.DequeueWBtn.Click += new System.EventHandler(this.DequeueWBtn_Click);
            // 
            // DequeueMBtn
            // 
            this.DequeueMBtn.Location = new System.Drawing.Point(364, 321);
            this.DequeueMBtn.Name = "DequeueMBtn";
            this.DequeueMBtn.Size = new System.Drawing.Size(84, 37);
            this.DequeueMBtn.TabIndex = 12;
            this.DequeueMBtn.Text = "Dequeue";
            this.DequeueMBtn.UseVisualStyleBackColor = true;
            this.DequeueMBtn.Click += new System.EventHandler(this.DequeueMBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "General List";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MAN",
            "WOMAN"});
            this.comboBox1.Location = new System.Drawing.Point(57, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 400);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DequeueMBtn);
            this.Controls.Add(this.DequeueWBtn);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.EnqueueBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnqueueBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button DequeueWBtn;
        private System.Windows.Forms.Button DequeueMBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

