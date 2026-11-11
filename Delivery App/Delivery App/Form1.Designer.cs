namespace Delivery_App
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
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RdbSpeed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbNormal = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trackland Deliveries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delivery Address:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(69, 167);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(785, 83);
            this.TxtAddress.TabIndex = 2;
            // 
            // TxtWeight
            // 
            this.TxtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWeight.Location = new System.Drawing.Point(69, 323);
            this.TxtWeight.Name = "TxtWeight";
            this.TxtWeight.Size = new System.Drawing.Size(785, 34);
            this.TxtWeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Parcel Weight(KG):";
            // 
            // CmbBranch
            // 
            this.CmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBranch.FormattingEnabled = true;
            this.CmbBranch.Items.AddRange(new object[] {
            "Colombo",
            "Kurunegala",
            "Mathara",
            "Vavuniya",
            "Monaragala"});
            this.CmbBranch.Location = new System.Drawing.Point(69, 443);
            this.CmbBranch.Name = "CmbBranch";
            this.CmbBranch.Size = new System.Drawing.Size(785, 37);
            this.CmbBranch.TabIndex = 5;
            this.CmbBranch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nearest Branch:";
            // 
            // RdbSpeed
            // 
            this.RdbSpeed.AutoSize = true;
            this.RdbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSpeed.Location = new System.Drawing.Point(256, 51);
            this.RdbSpeed.Name = "RdbSpeed";
            this.RdbSpeed.Size = new System.Drawing.Size(213, 33);
            this.RdbSpeed.TabIndex = 7;
            this.RdbSpeed.TabStop = true;
            this.RdbSpeed.Text = "Speed Delivery";
            this.RdbSpeed.UseVisualStyleBackColor = true;
            this.RdbSpeed.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbNormal);
            this.groupBox1.Controls.Add(this.RdbSpeed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 131);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delivery Type:";
            // 
            // RdbNormal
            // 
            this.RdbNormal.AutoSize = true;
            this.RdbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNormal.Location = new System.Drawing.Point(530, 51);
            this.RdbNormal.Name = "RdbNormal";
            this.RdbNormal.Size = new System.Drawing.Size(221, 33);
            this.RdbNormal.TabIndex = 8;
            this.RdbNormal.TabStop = true;
            this.RdbNormal.Text = "Normal Delivery";
            this.RdbNormal.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCalculate.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(69, 680);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(368, 45);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnClear.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(485, 680);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(368, 45);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            // 
            // TxtCost
            // 
            this.TxtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCost.Location = new System.Drawing.Point(69, 807);
            this.TxtCost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(785, 34);
            this.TxtCost.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 763);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delivery Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(937, 893);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbBranch);
            this.Controls.Add(this.TxtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(955, 940);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curior Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RdbSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbNormal;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.Label label5;
    }
}

