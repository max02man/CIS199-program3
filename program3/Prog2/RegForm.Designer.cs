namespace Prog2
{
    partial class RegForm
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
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.RegLbl = new System.Windows.Forms.Label();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.standingGrpBox = new System.Windows.Forms.GroupBox();
            this.freshBtn = new System.Windows.Forms.RadioButton();
            this.sophBtn = new System.Windows.Forms.RadioButton();
            this.juniorBtn = new System.Windows.Forms.RadioButton();
            this.seniorBtn = new System.Windows.Forms.RadioButton();
            this.standingGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(180, 36);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(132, 22);
            this.lastNameTxt.TabIndex = 1;
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(99, 180);
            this.findRegTimeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(132, 28);
            this.findRegTimeBtn.TabIndex = 2;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(176, 16);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(78, 17);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Last name:";
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Location = new System.Drawing.Point(63, 212);
            this.RegLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(210, 17);
            this.RegLbl.TabIndex = 5;
            this.RegLbl.Text = "The earliest you may register is:";
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.AutoSize = true;
            this.dateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.Location = new System.Drawing.Point(63, 228);
            this.dateTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(0, 17);
            this.dateTimeLbl.TabIndex = 6;
            // 
            // standingGrpBox
            // 
            this.standingGrpBox.Controls.Add(this.freshBtn);
            this.standingGrpBox.Controls.Add(this.sophBtn);
            this.standingGrpBox.Controls.Add(this.juniorBtn);
            this.standingGrpBox.Controls.Add(this.seniorBtn);
            this.standingGrpBox.Location = new System.Drawing.Point(17, 16);
            this.standingGrpBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.standingGrpBox.Name = "standingGrpBox";
            this.standingGrpBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.standingGrpBox.Size = new System.Drawing.Size(136, 144);
            this.standingGrpBox.TabIndex = 0;
            this.standingGrpBox.TabStop = false;
            this.standingGrpBox.Text = "Class Standing";
            // 
            // freshBtn
            // 
            this.freshBtn.AutoSize = true;
            this.freshBtn.Location = new System.Drawing.Point(8, 110);
            this.freshBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.freshBtn.Name = "freshBtn";
            this.freshBtn.Size = new System.Drawing.Size(92, 21);
            this.freshBtn.TabIndex = 3;
            this.freshBtn.TabStop = true;
            this.freshBtn.Text = "Freshman";
            this.freshBtn.UseVisualStyleBackColor = true;
            // 
            // sophBtn
            // 
            this.sophBtn.AutoSize = true;
            this.sophBtn.Location = new System.Drawing.Point(9, 81);
            this.sophBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sophBtn.Name = "sophBtn";
            this.sophBtn.Size = new System.Drawing.Size(102, 21);
            this.sophBtn.TabIndex = 2;
            this.sophBtn.TabStop = true;
            this.sophBtn.Text = "Sophomore";
            this.sophBtn.UseVisualStyleBackColor = true;
            // 
            // juniorBtn
            // 
            this.juniorBtn.AutoSize = true;
            this.juniorBtn.Location = new System.Drawing.Point(9, 53);
            this.juniorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.juniorBtn.Name = "juniorBtn";
            this.juniorBtn.Size = new System.Drawing.Size(68, 21);
            this.juniorBtn.TabIndex = 1;
            this.juniorBtn.TabStop = true;
            this.juniorBtn.Text = "Junior";
            this.juniorBtn.UseVisualStyleBackColor = true;
            // 
            // seniorBtn
            // 
            this.seniorBtn.AutoSize = true;
            this.seniorBtn.Location = new System.Drawing.Point(9, 25);
            this.seniorBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seniorBtn.Name = "seniorBtn";
            this.seniorBtn.Size = new System.Drawing.Size(70, 21);
            this.seniorBtn.TabIndex = 0;
            this.seniorBtn.TabStop = true;
            this.seniorBtn.Text = "Senior";
            this.seniorBtn.UseVisualStyleBackColor = true;
            // 
            // RegForm
            // 
            this.AcceptButton = this.findRegTimeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 257);
            this.Controls.Add(this.standingGrpBox);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegForm";
            this.Text = "Program 3";
            this.standingGrpBox.ResumeLayout(false);
            this.standingGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label dateTimeLbl;
        private System.Windows.Forms.GroupBox standingGrpBox;
        private System.Windows.Forms.RadioButton freshBtn;
        private System.Windows.Forms.RadioButton sophBtn;
        private System.Windows.Forms.RadioButton juniorBtn;
        private System.Windows.Forms.RadioButton seniorBtn;
    }
}

