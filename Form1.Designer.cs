namespace Presidential
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
            this.label1 = new System.Windows.Forms.Label();
            this.USbornCheckbox = new System.Windows.Forms.CheckBox();
            this.rebelCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alreadyServedCheckbox = new System.Windows.Forms.CheckBox();
            this.yearsLivedinUStextbox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.disqualifiedCheckbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Were you born in the US?";
            // 
            // USbornCheckbox
            // 
            this.USbornCheckbox.AutoSize = true;
            this.USbornCheckbox.Location = new System.Drawing.Point(634, 58);
            this.USbornCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.USbornCheckbox.Name = "USbornCheckbox";
            this.USbornCheckbox.Size = new System.Drawing.Size(22, 21);
            this.USbornCheckbox.TabIndex = 1;
            this.USbornCheckbox.UseVisualStyleBackColor = true;
            // 
            // rebelCheckbox
            // 
            this.rebelCheckbox.AutoSize = true;
            this.rebelCheckbox.Location = new System.Drawing.Point(634, 113);
            this.rebelCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.rebelCheckbox.Name = "rebelCheckbox";
            this.rebelCheckbox.Size = new System.Drawing.Size(22, 21);
            this.rebelCheckbox.TabIndex = 2;
            this.rebelCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Did you rebel against the US?";
            // 
            // alreadyServedCheckbox
            // 
            this.alreadyServedCheckbox.AutoSize = true;
            this.alreadyServedCheckbox.Location = new System.Drawing.Point(634, 234);
            this.alreadyServedCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.alreadyServedCheckbox.Name = "alreadyServedCheckbox";
            this.alreadyServedCheckbox.Size = new System.Drawing.Size(22, 21);
            this.alreadyServedCheckbox.TabIndex = 5;
            this.alreadyServedCheckbox.UseVisualStyleBackColor = true;
            // 
            // yearsLivedinUStextbox
            // 
            this.yearsLivedinUStextbox.Location = new System.Drawing.Point(634, 362);
            this.yearsLivedinUStextbox.Margin = new System.Windows.Forms.Padding(4);
            this.yearsLivedinUStextbox.Name = "yearsLivedinUStextbox";
            this.yearsLivedinUStextbox.Size = new System.Drawing.Size(132, 34);
            this.yearsLivedinUStextbox.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Fuchsia;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(398, 432);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(183, 129);
            this.submit.TabIndex = 8;
            this.submit.Text = "View Your Presidential Eligibilty";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Did you serve two prior terms?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter your birthday.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "How many years did you live in the US?";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(634, 288);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(352, 34);
            this.birthdayPicker.TabIndex = 12;
            // 
            // disqualifiedCheckbox
            // 
            this.disqualifiedCheckbox.AutoSize = true;
            this.disqualifiedCheckbox.Location = new System.Drawing.Point(634, 175);
            this.disqualifiedCheckbox.Name = "disqualifiedCheckbox";
            this.disqualifiedCheckbox.Size = new System.Drawing.Size(22, 21);
            this.disqualifiedCheckbox.TabIndex = 13;
            this.disqualifiedCheckbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Have you ever been disqualified from holding public office?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 608);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.disqualifiedCheckbox);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.yearsLivedinUStextbox);
            this.Controls.Add(this.alreadyServedCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rebelCheckbox);
            this.Controls.Add(this.USbornCheckbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Presidetial Eligiblity";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox USbornCheckbox;
        private System.Windows.Forms.CheckBox rebelCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox alreadyServedCheckbox;
        private System.Windows.Forms.TextBox yearsLivedinUStextbox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.CheckBox disqualifiedCheckbox;
        private System.Windows.Forms.Label label6;
    }
}

