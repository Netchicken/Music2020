namespace Music2020
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
            this.DGVOwner = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVCD = new System.Windows.Forms.DataGridView();
            this.DGVTracks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVOwner
            // 
            this.DGVOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOwner.Location = new System.Drawing.Point(3, 3);
            this.DGVOwner.Name = "DGVOwner";
            this.DGVOwner.RowHeadersWidth = 51;
            this.DGVOwner.RowTemplate.Height = 24;
            this.DGVOwner.Size = new System.Drawing.Size(1128, 160);
            this.DGVOwner.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1142, 195);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Bisque;
            this.tabPage1.Controls.Add(this.DGVOwner);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1134, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Owner";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCD);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(491, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVTracks);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(491, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tracks";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVCD
            // 
            this.DGVCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCD.Location = new System.Drawing.Point(3, 3);
            this.DGVCD.Name = "DGVCD";
            this.DGVCD.RowHeadersWidth = 51;
            this.DGVCD.RowTemplate.Height = 24;
            this.DGVCD.Size = new System.Drawing.Size(485, 395);
            this.DGVCD.TabIndex = 0;
            // 
            // DGVTracks
            // 
            this.DGVTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTracks.Location = new System.Drawing.Point(3, 3);
            this.DGVTracks.Name = "DGVTracks";
            this.DGVTracks.RowHeadersWidth = 51;
            this.DGVTracks.RowTemplate.Height = 24;
            this.DGVTracks.Size = new System.Drawing.Size(485, 395);
            this.DGVTracks.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            //            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOwner)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVOwner;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVCD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVTracks;
    }
}
