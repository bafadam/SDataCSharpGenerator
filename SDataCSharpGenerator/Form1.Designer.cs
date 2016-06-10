namespace SDataCSharpGenerator
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
            this.btnLoadTypes = new System.Windows.Forms.Button();
            this.cmbResourceTypes = new System.Windows.Forms.ComboBox();
            this.btnGetTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadTypes
            // 
            this.btnLoadTypes.Location = new System.Drawing.Point(12, 34);
            this.btnLoadTypes.Name = "btnLoadTypes";
            this.btnLoadTypes.Size = new System.Drawing.Size(75, 23);
            this.btnLoadTypes.TabIndex = 0;
            this.btnLoadTypes.Text = "Load Types";
            this.btnLoadTypes.UseVisualStyleBackColor = true;
            this.btnLoadTypes.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbResourceTypes
            // 
            this.cmbResourceTypes.FormattingEnabled = true;
            this.cmbResourceTypes.Location = new System.Drawing.Point(151, 12);
            this.cmbResourceTypes.Name = "cmbResourceTypes";
            this.cmbResourceTypes.Size = new System.Drawing.Size(325, 21);
            this.cmbResourceTypes.TabIndex = 1;
            // 
            // btnGetTemplate
            // 
            this.btnGetTemplate.Location = new System.Drawing.Point(12, 72);
            this.btnGetTemplate.Name = "btnGetTemplate";
            this.btnGetTemplate.Size = new System.Drawing.Size(75, 35);
            this.btnGetTemplate.TabIndex = 2;
            this.btnGetTemplate.Text = "Get Template";
            this.btnGetTemplate.UseVisualStyleBackColor = true;
            this.btnGetTemplate.Click += new System.EventHandler(this.btnGetTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 206);
            this.Controls.Add(this.btnGetTemplate);
            this.Controls.Add(this.cmbResourceTypes);
            this.Controls.Add(this.btnLoadTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadTypes;
        private System.Windows.Forms.ComboBox cmbResourceTypes;
        private System.Windows.Forms.Button btnGetTemplate;
    }
}

