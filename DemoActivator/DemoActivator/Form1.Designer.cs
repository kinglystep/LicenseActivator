namespace DemoActivator
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
            this.txtHardwareId = new System.Windows.Forms.TextBox();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Vanara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "HardwareID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer Vanara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 388);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 86);
            this.label2.TabIndex = 1;
            this.label2.Text = "ProductKey :";
            // 
            // txtHardwareId
            // 
            this.txtHardwareId.Font = new System.Drawing.Font("Khmer Vanara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHardwareId.Location = new System.Drawing.Point(508, 217);
            this.txtHardwareId.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtHardwareId.Name = "txtHardwareId";
            this.txtHardwareId.Size = new System.Drawing.Size(951, 79);
            this.txtHardwareId.TabIndex = 2;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Font = new System.Drawing.Font("Khmer Vanara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductKey.Location = new System.Drawing.Point(508, 388);
            this.txtProductKey.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(951, 79);
            this.txtProductKey.TabIndex = 3;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Font = new System.Drawing.Font("Khmer Vanara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKey.Location = new System.Drawing.Point(508, 566);
            this.btnGenerateKey.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(481, 151);
            this.btnGenerateKey.TabIndex = 4;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer Vanara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 108);
            this.label3.TabIndex = 5;
            this.label3.Text = "ACTIVATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 794);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtHardwareId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHardwareId;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Label label3;
    }
}

