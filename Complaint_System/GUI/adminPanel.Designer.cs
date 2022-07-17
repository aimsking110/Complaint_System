
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
            this.admin_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.SelectedIndex = 0;
            this.admin_panel.Size = new System.Drawing.Size(865, 539);
            this.admin_panel.TabIndex = 0;
            this.admin_panel.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Delete_Btn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(857, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(381, 314);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(108, 48);
            this.Delete_Btn.TabIndex = 9;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(805, 213);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(857, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(474, 413);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 28);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 8);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(793, 331);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Radio_Forwarded
            // 
            this.Radio_Forwarded.AutoSize = true;
            this.Radio_Forwarded.Location = new System.Drawing.Point(582, 369);
            this.Radio_Forwarded.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Radio_Forwarded.Name = "Radio_Forwarded";
            this.Radio_Forwarded.Size = new System.Drawing.Size(96, 21);
            this.Radio_Forwarded.TabIndex = 2;
            this.Radio_Forwarded.Text = "Forwarded";
            this.Radio_Forwarded.UseVisualStyleBackColor = true;
            // 
            // Radio_Pending
            // 
            this.Radio_Pending.AutoSize = true;
            this.Radio_Pending.Location = new System.Drawing.Point(474, 369);
            this.Radio_Pending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Radio_Pending.Name = "Radio_Pending";
            this.Radio_Pending.Size = new System.Drawing.Size(81, 21);
            this.Radio_Pending.TabIndex = 1;
            this.Radio_Pending.Text = "Pending";
            this.Radio_Pending.UseVisualStyleBackColor = true;
            // 
            // radio_resolved
            // 
            this.radio_resolved.AutoSize = true;
            this.radio_resolved.Checked = true;
            this.radio_resolved.Location = new System.Drawing.Point(363, 369);
            this.radio_resolved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_resolved.Name = "radio_resolved";
            this.radio_resolved.Size = new System.Drawing.Size(88, 21);
            this.radio_resolved.TabIndex = 0;
            this.radio_resolved.TabStop = true;
            this.radio_resolved.Text = "Resolved";
            this.radio_resolved.UseVisualStyleBackColor = true;
            this.radio_resolved.CheckedChanged += new System.EventHandler(this.radio_resolved_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1060, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Complaints";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(139, 59);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(784, 347);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 533);
            this.Controls.Add(this.admin_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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