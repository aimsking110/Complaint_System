
namespace Complaint_System.GUI
{
    partial class CustomerPanel
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
            this.tc_newcomplain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_dep = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_complainID = new System.Windows.Forms.TextBox();
            this.tc_newcomplain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_newcomplain
            // 
            this.tc_newcomplain.Controls.Add(this.tabPage1);
            this.tc_newcomplain.Controls.Add(this.tabPage2);
            this.tc_newcomplain.Controls.Add(this.tabPage3);
            this.tc_newcomplain.Location = new System.Drawing.Point(25, 12);
            this.tc_newcomplain.Name = "tc_newcomplain";
            this.tc_newcomplain.SelectedIndex = 0;
            this.tc_newcomplain.Size = new System.Drawing.Size(763, 426);
            this.tc_newcomplain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_complainID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_status);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_confirm);
            this.tabPage1.Controls.Add(this.lb_welcome);
            this.tabPage1.Controls.Add(this.txt_des);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb_dep);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Complain";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txt_status
            // 
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(276, 245);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(177, 24);
            this.txt_status.TabIndex = 8;
            this.txt_status.Text = "New";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm.Location = new System.Drawing.Point(419, 298);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.Size = new System.Drawing.Size(89, 34);
            this.txt_confirm.TabIndex = 6;
            this.txt_confirm.Text = "Confirm";
            this.txt_confirm.UseVisualStyleBackColor = true;
            this.txt_confirm.Click += new System.EventHandler(this.txt_confirm_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Location = new System.Drawing.Point(567, 22);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(74, 17);
            this.lb_welcome.TabIndex = 5;
            this.lb_welcome.Text = "Welcome: ";
            this.lb_welcome.UseMnemonic = false;
            // 
            // txt_des
            // 
            this.txt_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_des.Location = new System.Drawing.Point(276, 155);
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(283, 65);
            this.txt_des.TabIndex = 4;
            this.txt_des.Text = "";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(149, 175);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(83, 18);
            this.Description.TabIndex = 3;
            this.Description.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Complaint Type";
            // 
            // cb_dep
            // 
            this.cb_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dep.FormattingEnabled = true;
            this.cb_dep.Items.AddRange(new object[] {
            "Broad Band",
            "Wireless",
            "Charji",
            "Land Line"});
            this.cb_dep.Location = new System.Drawing.Point(276, 110);
            this.cb_dep.Name = "cb_dep";
            this.cb_dep.Size = new System.Drawing.Size(177, 26);
            this.cb_dep.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Track Complain";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(755, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FeedBack";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Complain ID";
            // 
            // txt_complainID
            // 
            this.txt_complainID.Location = new System.Drawing.Point(276, 75);
            this.txt_complainID.Name = "txt_complainID";
            this.txt_complainID.Size = new System.Drawing.Size(177, 22);
            this.txt_complainID.TabIndex = 10;
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tc_newcomplain);
            this.Name = "CustomerPanel";
            this.Text = "CustomerPanel";
            this.Load += new System.EventHandler(this.CustomerPanel_Load);
            this.tc_newcomplain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_newcomplain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox txt_des;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_dep;
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txt_confirm;
        private System.Windows.Forms.TextBox txt_complainID;
        private System.Windows.Forms.Label label3;
    }
}