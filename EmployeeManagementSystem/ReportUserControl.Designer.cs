namespace EmployeeManagementSystem
{
    partial class ReportUserControl
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
            this.label1A = new System.Windows.Forms.Label();
            this.ReportSerachBox = new System.Windows.Forms.TextBox();
            this.Edetailsbtn = new System.Windows.Forms.Button();
            this.ESalarybtn = new System.Windows.Forms.Button();
            this.EleaveBtn = new System.Windows.Forms.Button();
            this.Eattendencebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1A
            // 
            this.label1A.AutoSize = true;
            this.label1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1A.Location = new System.Drawing.Point(436, 13);
            this.label1A.Name = "label1A";
            this.label1A.Size = new System.Drawing.Size(229, 29);
            this.label1A.TabIndex = 132;
            this.label1A.Text = "Employee Reports";
            // 
            // ReportSerachBox
            // 
            this.ReportSerachBox.Location = new System.Drawing.Point(40, 80);
            this.ReportSerachBox.Name = "ReportSerachBox";
            this.ReportSerachBox.Size = new System.Drawing.Size(209, 20);
            this.ReportSerachBox.TabIndex = 148;
            // 
            // Edetailsbtn
            // 
            this.Edetailsbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Edetailsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edetailsbtn.ForeColor = System.Drawing.Color.Black;
            this.Edetailsbtn.Location = new System.Drawing.Point(264, 72);
            this.Edetailsbtn.Name = "Edetailsbtn";
            this.Edetailsbtn.Size = new System.Drawing.Size(178, 32);
            this.Edetailsbtn.TabIndex = 147;
            this.Edetailsbtn.Text = "Employee Details";
            this.Edetailsbtn.UseVisualStyleBackColor = false;
            this.Edetailsbtn.Click += new System.EventHandler(this.Edetailsbtn_Click);
            // 
            // ESalarybtn
            // 
            this.ESalarybtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ESalarybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESalarybtn.ForeColor = System.Drawing.Color.Black;
            this.ESalarybtn.Location = new System.Drawing.Point(816, 72);
            this.ESalarybtn.Name = "ESalarybtn";
            this.ESalarybtn.Size = new System.Drawing.Size(178, 32);
            this.ESalarybtn.TabIndex = 149;
            this.ESalarybtn.Text = "Salary";
            this.ESalarybtn.UseVisualStyleBackColor = false;
            this.ESalarybtn.Click += new System.EventHandler(this.ESalarybtn_Click);
            // 
            // EleaveBtn
            // 
            this.EleaveBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EleaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleaveBtn.ForeColor = System.Drawing.Color.Black;
            this.EleaveBtn.Location = new System.Drawing.Point(632, 72);
            this.EleaveBtn.Name = "EleaveBtn";
            this.EleaveBtn.Size = new System.Drawing.Size(178, 32);
            this.EleaveBtn.TabIndex = 150;
            this.EleaveBtn.Text = "Leave";
            this.EleaveBtn.UseVisualStyleBackColor = false;
            this.EleaveBtn.Click += new System.EventHandler(this.EleaveBtn_Click);
            // 
            // Eattendencebtn
            // 
            this.Eattendencebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Eattendencebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eattendencebtn.ForeColor = System.Drawing.Color.Black;
            this.Eattendencebtn.Location = new System.Drawing.Point(448, 72);
            this.Eattendencebtn.Name = "Eattendencebtn";
            this.Eattendencebtn.Size = new System.Drawing.Size(178, 32);
            this.Eattendencebtn.TabIndex = 151;
            this.Eattendencebtn.Text = "Attendence";
            this.Eattendencebtn.UseVisualStyleBackColor = false;
            this.Eattendencebtn.Click += new System.EventHandler(this.Eattendencebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 152;
            this.label1.Text = "Enter Employee ID :";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(40, 122);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(954, 513);
            this.crystalReportViewer1.TabIndex = 153;
            // 
            // ReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eattendencebtn);
            this.Controls.Add(this.EleaveBtn);
            this.Controls.Add(this.ESalarybtn);
            this.Controls.Add(this.ReportSerachBox);
            this.Controls.Add(this.Edetailsbtn);
            this.Controls.Add(this.label1A);
            this.Name = "ReportUserControl";
            this.Size = new System.Drawing.Size(1093, 655);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1A;
        private System.Windows.Forms.TextBox ReportSerachBox;
        private System.Windows.Forms.Button Edetailsbtn;
        private System.Windows.Forms.Button ESalarybtn;
        private System.Windows.Forms.Button EleaveBtn;
        private System.Windows.Forms.Button Eattendencebtn;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
