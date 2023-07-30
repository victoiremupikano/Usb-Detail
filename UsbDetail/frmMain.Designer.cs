namespace UsbDetail
{
    partial class frmMain
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
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDriveFormat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDriveType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIsReady = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalSpace = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Drive Format :";
            // 
            // lblDriveFormat
            // 
            this.lblDriveFormat.AutoSize = true;
            this.lblDriveFormat.Location = new System.Drawing.Point(103, 91);
            this.lblDriveFormat.Name = "lblDriveFormat";
            this.lblDriveFormat.Size = new System.Drawing.Size(0, 13);
            this.lblDriveFormat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Drive Type :";
            // 
            // lblDriveType
            // 
            this.lblDriveType.AutoSize = true;
            this.lblDriveType.Location = new System.Drawing.Point(103, 118);
            this.lblDriveType.Name = "lblDriveType";
            this.lblDriveType.Size = new System.Drawing.Size(0, 13);
            this.lblDriveType.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Is Ready :";
            // 
            // lblIsReady
            // 
            this.lblIsReady.AutoSize = true;
            this.lblIsReady.Location = new System.Drawing.Point(103, 149);
            this.lblIsReady.Name = "lblIsReady";
            this.lblIsReady.Size = new System.Drawing.Size(0, 13);
            this.lblIsReady.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total Space :";
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.AutoSize = true;
            this.lblTotalSpace.Location = new System.Drawing.Point(103, 175);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.Size = new System.Drawing.Size(0, 13);
            this.lblTotalSpace.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Free Space :";
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(103, 204);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(0, 13);
            this.lblFreeSpace.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(96, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(229, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Get";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 430);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotalSpace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIsReady);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDriveType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDriveFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Drive detail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDriveFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDriveType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIsReady;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalSpace;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.Button btnSubmit;
    }
}

