
namespace QuanLyNhanKhau
{
    partial class UCRestore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRestore));
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestore
            // 
            this.btnRestore.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRestore.Appearance.Options.UseFont = true;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBackup.ImageOptions.Image")));
            this.btnRestore.Location = new System.Drawing.Point(317, 79);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(118, 28);
            this.btnRestore.TabIndex = 7;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.ImageOptions.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(453, 45);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 28);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtfile
            // 
            this.txtfile.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfile.Location = new System.Drawing.Point(119, 45);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(316, 28);
            this.txtfile.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn file";
            // 
            // UCRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.label1);
            this.Name = "UCRestore";
            this.Size = new System.Drawing.Size(699, 153);
            this.Load += new System.EventHandler(this.UCRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label label1;
    }
}
