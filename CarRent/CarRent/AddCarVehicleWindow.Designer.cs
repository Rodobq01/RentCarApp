
namespace CarRent
{
    partial class AddCarVehicleWindow
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
            this.textBoxLbModel = new System.Windows.Forms.TextBox();
            this.textBoxLbMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLbVin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLbYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLbLicenNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // textBoxLbModel
            // 
            this.textBoxLbModel.Location = new System.Drawing.Point(128, 28);
            this.textBoxLbModel.Name = "textBoxLbModel";
            this.textBoxLbModel.Size = new System.Drawing.Size(153, 20);
            this.textBoxLbModel.TabIndex = 1;
            // 
            // textBoxLbMark
            // 
            this.textBoxLbMark.Location = new System.Drawing.Point(128, 54);
            this.textBoxLbMark.Name = "textBoxLbMark";
            this.textBoxLbMark.Size = new System.Drawing.Size(153, 20);
            this.textBoxLbMark.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mark";
            // 
            // textBoxLbVin
            // 
            this.textBoxLbVin.Location = new System.Drawing.Point(128, 80);
            this.textBoxLbVin.Name = "textBoxLbVin";
            this.textBoxLbVin.Size = new System.Drawing.Size(153, 20);
            this.textBoxLbVin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vin";
            // 
            // textBoxLbYear
            // 
            this.textBoxLbYear.Location = new System.Drawing.Point(128, 106);
            this.textBoxLbYear.Name = "textBoxLbYear";
            this.textBoxLbYear.Size = new System.Drawing.Size(153, 20);
            this.textBoxLbYear.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year";
            // 
            // textBoxLbLicenNumber
            // 
            this.textBoxLbLicenNumber.Location = new System.Drawing.Point(128, 132);
            this.textBoxLbLicenNumber.Name = "textBoxLbLicenNumber";
            this.textBoxLbLicenNumber.Size = new System.Drawing.Size(153, 20);
            this.textBoxLbLicenNumber.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "License number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddCarVehicleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 204);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLbLicenNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLbYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLbVin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLbMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLbModel);
            this.Controls.Add(this.label1);
            this.Name = "AddCarVehicleWindow";
            this.Text = "Add car";
            this.Load += new System.EventHandler(this.AddCarVehicleWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLbModel;
        private System.Windows.Forms.TextBox textBoxLbMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLbVin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLbLicenNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}