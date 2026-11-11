namespace Billing_App
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
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.TxtUnits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Electricity Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomer.Location = new System.Drawing.Point(85, 178);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(613, 34);
            this.TxtCustomer.TabIndex = 2;
            this.TxtCustomer.Enter += new System.EventHandler(this.TxtCustomer_Enter);
            this.TxtCustomer.Leave += new System.EventHandler(this.TxtCustomer_Leave);
            // 
            // TxtUnits
            // 
            this.TxtUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnits.Location = new System.Drawing.Point(85, 297);
            this.TxtUnits.Name = "TxtUnits";
            this.TxtUnits.Size = new System.Drawing.Size(613, 34);
            this.TxtUnits.TabIndex = 4;
            this.TxtUnits.Enter += new System.EventHandler(this.TxtUnits_Enter);
            this.TxtUnits.Leave += new System.EventHandler(this.TxtUnits_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Units Consumed:";
            // 
            // TxtBill
            // 
            this.TxtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBill.Location = new System.Drawing.Point(85, 585);
            this.TxtBill.Name = "TxtBill";
            this.TxtBill.Size = new System.Drawing.Size(613, 34);
            this.TxtBill.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bill Amount:";
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(119, 411);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(191, 61);
            this.BtnCalculate.TabIndex = 7;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(454, 411);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(190, 61);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(785, 691);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TxtBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUnits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.TextBox TxtUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
    }
}

