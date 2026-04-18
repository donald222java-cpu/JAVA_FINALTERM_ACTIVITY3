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
            this.Importtxt = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            this.cmbRisk = new System.Windows.Forms.ComboBox();
            this.lblAffordabilityResult = new System.Windows.Forms.Label();
            this.lblPriorityResult = new System.Windows.Forms.Label();
            this.lblRiskResult = new System.Windows.Forms.Label();
            this.lblDecisionResult = new System.Windows.Forms.Label();
            this.lblExplanationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estimated Cost";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgency Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Importance Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Risk Level";
            // 
            // budtxt
            // 
            this.budtxt.Location = new System.Drawing.Point(195, 23);
            this.budtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.budtxt.Name = "budtxt";
            this.budtxt.Size = new System.Drawing.Size(252, 22);
            this.budtxt.TabIndex = 5;
            // 
            // costtxt
            // 
            this.costtxt.Location = new System.Drawing.Point(195, 74);
            this.costtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costtxt.Name = "costtxt";
            this.costtxt.Size = new System.Drawing.Size(252, 22);
            this.costtxt.TabIndex = 6;
            // 
            // Importtxt
            // 
            this.Importtxt.Location = new System.Drawing.Point(195, 162);
            this.Importtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Importtxt.Name = "Importtxt";
            this.Importtxt.Size = new System.Drawing.Size(252, 22);
            this.Importtxt.TabIndex = 8;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(549, 255);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(180, 48);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "Evaluate";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 255);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbUrgency.Location = new System.Drawing.Point(195, 117);
            this.cmbUrgency.Name = "cmbUrgency";
            this.cmbUrgency.Size = new System.Drawing.Size(252, 24);
            this.cmbUrgency.TabIndex = 13;
            // 
            // cmbRisk
            // 
            this.cmbRisk.FormattingEnabled = true;
            this.cmbRisk.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbRisk.Location = new System.Drawing.Point(195, 197);
            this.cmbRisk.Name = "cmbRisk";
            this.cmbRisk.Size = new System.Drawing.Size(252, 24);
            this.cmbRisk.TabIndex = 14;
            // 
            // lblAffordabilityResult
            // 
            this.lblAffordabilityResult.AutoSize = true;
            this.lblAffordabilityResult.Location = new System.Drawing.Point(619, 26);
            this.lblAffordabilityResult.Name = "lblAffordabilityResult";
            this.lblAffordabilityResult.Size = new System.Drawing.Size(0, 16);
            this.lblAffordabilityResult.TabIndex = 15;
            // 
            // lblPriorityResult
            // 
            this.lblPriorityResult.AutoSize = true;
            this.lblPriorityResult.Location = new System.Drawing.Point(619, 74);
            this.lblPriorityResult.Name = "lblPriorityResult";
            this.lblPriorityResult.Size = new System.Drawing.Size(0, 16);
            this.lblPriorityResult.TabIndex = 16;
            // 
            // lblRiskResult
            // 
            this.lblRiskResult.AutoSize = true;
            this.lblRiskResult.Location = new System.Drawing.Point(619, 121);
            this.lblRiskResult.Name = "lblRiskResult";
            this.lblRiskResult.Size = new System.Drawing.Size(0, 16);
            this.lblRiskResult.TabIndex = 17;
            // 
            // lblDecisionResult
            // 
            this.lblDecisionResult.AutoSize = true;
            this.lblDecisionResult.Location = new System.Drawing.Point(619, 169);
            this.lblDecisionResult.Name = "lblDecisionResult";
            this.lblDecisionResult.Size = new System.Drawing.Size(0, 16);
            this.lblDecisionResult.TabIndex = 18;
            // 
            // lblExplanationResult
            // 
            this.lblExplanationResult.AutoSize = true;
            this.lblExplanationResult.Location = new System.Drawing.Point(619, 205);
            this.lblExplanationResult.Name = "lblExplanationResult";
            this.lblExplanationResult.Size = new System.Drawing.Size(0, 16);
            this.lblExplanationResult.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 319);
            this.Controls.Add(this.lblExplanationResult);
            this.Controls.Add(this.lblDecisionResult);
            this.Controls.Add(this.lblRiskResult);
            this.Controls.Add(this.lblPriorityResult);
            this.Controls.Add(this.lblAffordabilityResult);
            this.Controls.Add(this.cmbRisk);
            this.Controls.Add(this.cmbUrgency);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Importtxt);
            this.Controls.Add(this.costtxt);
            this.Controls.Add(this.budtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox Importtxt;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbUrgency;
        private System.Windows.Forms.ComboBox cmbRisk;
        private System.Windows.Forms.Label lblAffordabilityResult;
        private System.Windows.Forms.Label lblPriorityResult;
        private System.Windows.Forms.Label lblRiskResult;
        private System.Windows.Forms.Label lblDecisionResult;
        private System.Windows.Forms.Label lblExplanationResult;
    }
}

