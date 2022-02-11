
namespace CarRent
{
    partial class ManageVehicalWindow
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgwVehical = new System.Windows.Forms.DataGridView();
            this.pb_vehical = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vehical)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(150, 471);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(369, 471);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(138, 42);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(622, 471);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(138, 42);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(853, 471);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 42);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dgwVehical
            // 
            this.dgwVehical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVehical.Location = new System.Drawing.Point(12, 120);
            this.dgwVehical.Name = "dgwVehical";
            this.dgwVehical.Size = new System.Drawing.Size(1071, 329);
            this.dgwVehical.TabIndex = 4;
            // 
            // pb_vehical
            // 
            this.pb_vehical.Image = global::CarRent.Properties.Resources.carRent;
            this.pb_vehical.Location = new System.Drawing.Point(12, 5);
            this.pb_vehical.Name = "pb_vehical";
            this.pb_vehical.Size = new System.Drawing.Size(1071, 109);
            this.pb_vehical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_vehical.TabIndex = 5;
            this.pb_vehical.TabStop = false;
            // 
            // ManageVehicalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 550);
            this.Controls.Add(this.pb_vehical);
            this.Controls.Add(this.dgwVehical);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageVehicalWindow";
            this.Text = "ManageVehicalWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dgwVehical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vehical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dgwVehical;
        private System.Windows.Forms.PictureBox pb_vehical;
    }
}