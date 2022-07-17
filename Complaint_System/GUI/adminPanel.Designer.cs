
namespace Complaint_System.GUI
{
    partial class adminPanel
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
            this.admin_panel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Radio_Forwarded = new System.Windows.Forms.RadioButton();
            this.Radio_Pending = new System.Windows.Forms.RadioButton();
            this.radio_resolved = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.admin_panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.tabPage1);
            this.admin_panel.Controls.Add(this.tabPage2);
            this.admin_panel.Controls.Add(this.tabPage3);
            this.admin_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.SelectedIndex = 0;
            this.admin_panel.Size = new System.Drawing.Size(804, 453);
            this.admin_panel.TabIndex = 0;
            this.admin_panel.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Delete_Btn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(796, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(286, 255);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(81, 39);
            this.Delete_Btn.TabIndex = 9;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(604, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.Radio_Forwarded);
            this.tabPage2.Controls.Add(this.Radio_Pending);
            this.tabPage2.Controls.Add(this.radio_resolved);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(796, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(109, 273);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(379, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(231, 269);
            this.dataGridView2.TabIndex = 3;
            // 
            // Radio_Forwarded
            // 
            this.Radio_Forwarded.AutoSize = true;
            this.Radio_Forwarded.Location = new System.Drawing.Point(240, 250);
            this.Radio_Forwarded.Name = "Radio_Forwarded";
            this.Radio_Forwarded.Size = new System.Drawing.Size(75, 17);
            this.Radio_Forwarded.TabIndex = 2;
            this.Radio_Forwarded.TabStop = true;
            this.Radio_Forwarded.Text = "Forwarded";
            this.Radio_Forwarded.UseVisualStyleBackColor = true;
            // 
            // Radio_Pending
            // 
            this.Radio_Pending.AutoSize = true;
            this.Radio_Pending.Location = new System.Drawing.Point(240, 206);
            this.Radio_Pending.Name = "Radio_Pending";
            this.Radio_Pending.Size = new System.Drawing.Size(64, 17);
            this.Radio_Pending.TabIndex = 1;
            this.Radio_Pending.TabStop = true;
            this.Radio_Pending.Text = "Pending";
            this.Radio_Pending.UseVisualStyleBackColor = true;
            // 
            // radio_resolved
            // 
            this.radio_resolved.AutoSize = true;
            this.radio_resolved.Location = new System.Drawing.Point(240, 161);
            this.radio_resolved.Name = "radio_resolved";
            this.radio_resolved.Size = new System.Drawing.Size(70, 17);
            this.radio_resolved.TabIndex = 0;
            this.radio_resolved.TabStop = true;
            this.radio_resolved.Text = "Resolved";
            this.radio_resolved.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(796, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Complaints";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(104, 48);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(588, 282);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_panel);
            this.Name = "adminPanel";
            this.Text = "admin_Form";
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.admin_panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admin_panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton Radio_Forwarded;
        private System.Windows.Forms.RadioButton Radio_Pending;
        private System.Windows.Forms.RadioButton radio_resolved;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}