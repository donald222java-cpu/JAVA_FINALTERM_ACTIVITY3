namespace JAVA_FINALTERM_ACTIVITY3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.budtxt = new System.Windows.Forms.TextBox();
            this.costtxt = new System.Windows.Forms.TextBox();
            this.lvltxt = new System.Windows.Forms.TextBox();
            this.Importtxt = new System.Windows.Forms.TextBox();
            this.risktxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estimated Cost";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgency Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Importance Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Risk Level";
            // 
            // budtxt
            // 
            this.budtxt.Location = new System.Drawing.Point(146, 19);
            this.budtxt.Name = "budtxt";
            this.budtxt.Size = new System.Drawing.Size(190, 20);
            this.budtxt.TabIndex = 5;
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(146, 60);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(190, 20);
            this.costtxt.TabIndex = 6;
            // 
            // lvltxt
            // 
            this.lvltxt.Location = new System.Drawing.Point(146, 96);
            this.lvltxt.Name = "lvltxt";
            this.lvltxt.Size = new System.Drawing.Size(190, 20);
            this.lvltxt.TabIndex = 7;
            // 
            // Importtxt
            // 
            this.Importtxt.Location = new System.Drawing.Point(146, 132);
            this.Importtxt.Name = "Importtxt";
            this.Importtxt.Size = new System.Drawing.Size(190, 20);
            this.Importtxt.TabIndex = 8;
            // 
            // risktxt
            // 
            this.risktxt.Location = new System.Drawing.Point(146, 160);
            this.risktxt.Name = "risktxt";
            this.risktxt.Size = new System.Drawing.Size(190, 20);
            this.risktxt.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 163);
            this.textBox1.TabIndex = 10;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(412, 207);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(135, 39);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Evaluate";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.risktxt);
            this.Controls.Add(this.Importtxt);
            this.Controls.Add(this.lvltxt);
            this.Controls.Add(this.costtxt);
            this.Controls.Add(this.budtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Life Decision Support System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox budtxt;
        private System.Windows.Forms.TextBox costtxt;
        private System.Windows.Forms.TextBox lvltxt;
        private System.Windows.Forms.TextBox Importtxt;
        private System.Windows.Forms.TextBox risktxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
    }
}

