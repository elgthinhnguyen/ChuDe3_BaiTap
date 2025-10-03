namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    partial class Form4
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
            this.btnTXT = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn định dạng file:";
            // 
            // btnTXT
            // 
            this.btnTXT.Location = new System.Drawing.Point(38, 68);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(112, 72);
            this.btnTXT.TabIndex = 1;
            this.btnTXT.Text = ".TXT";
            this.btnTXT.UseVisualStyleBackColor = true;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(202, 68);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(112, 72);
            this.btnXML.TabIndex = 1;
            this.btnXML.Text = ".XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(365, 68);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(112, 72);
            this.btnJSON.TabIndex = 1;
            this.btnJSON.Text = ".JSON";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 187);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTXT;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
    }
}