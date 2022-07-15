
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.txtcnic = new System.Windows.Forms.TextBox();
            this.Decline_Btn = new System.Windows.Forms.Button();
            this.Accept_Btn = new System.Windows.Forms.Button();
            this.admin_panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_panel
            // 
            this.admin_panel.Controls.Add(this.tabPage1);
            this.admin_panel.Controls.Add(this.tabPage2);
            this.admin_panel.Controls.Add(this.tabPage3);
            this.admin_panel.Location = new System.Drawing.Point(73, 41);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.SelectedIndex = 0;
            this.admin_panel.Size = new System.Drawing.Size(654, 344);
            this.admin_panel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Accept_Btn);
            this.tabPage1.Controls.Add(this.Decline_Btn);
            this.tabPage1.Controls.Add(this.txtcnic);
            this.tabPage1.Controls.Add(this.txtPhn);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cust Verify";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Complaint Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Complaints";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(166, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone no:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(89, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(89, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtPhn
            // 
            this.txtPhn.Location = new System.Drawing.Point(89, 153);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(158, 20);
            this.txtPhn.TabIndex = 7;
            // 
            // txtcnic
            // 
            this.txtcnic.Location = new System.Drawing.Point(89, 210);
            this.txtcnic.Name = "txtcnic";
            this.txtcnic.Size = new System.Drawing.Size(158, 20);
            this.txtcnic.TabIndex = 8;
            // 
            // Decline_Btn
            // 
            this.Decline_Btn.Location = new System.Drawing.Point(89, 275);
            this.Decline_Btn.Name = "Decline_Btn";
            this.Decline_Btn.Size = new System.Drawing.Size(75, 23);
            this.Decline_Btn.TabIndex = 9;
            this.Decline_Btn.Text = "Decline";
            this.Decline_Btn.UseVisualStyleBackColor = true;
            // 
            // Accept_Btn
            // 
            this.Accept_Btn.Location = new System.Drawing.Point(172, 275);
            this.Accept_Btn.Name = "Accept_Btn";
            this.Accept_Btn.Size = new System.Drawing.Size(75, 23);
            this.Accept_Btn.TabIndex = 10;
            this.Accept_Btn.Text = "Accept";
            this.Accept_Btn.UseVisualStyleBackColor = true;
            // 
            // admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_panel);
            this.Name = "admin_Form";
            this.Text = "admin_Form";
            this.admin_panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl admin_panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Accept_Btn;
        private System.Windows.Forms.Button Decline_Btn;
        private System.Windows.Forms.TextBox txtcnic;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}