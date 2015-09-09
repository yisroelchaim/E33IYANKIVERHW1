namespace PoliceDispatcherClient
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
            this.CallButton = new System.Windows.Forms.Button();
            this.OfficerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OfficerButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.StateCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DefaultCombo = new System.Windows.Forms.ComboBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CallButton
            // 
            this.CallButton.Location = new System.Drawing.Point(230, 198);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(75, 23);
            this.CallButton.TabIndex = 25;
            this.CallButton.Text = "Call";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // OfficerTextBox
            // 
            this.OfficerTextBox.Location = new System.Drawing.Point(230, 167);
            this.OfficerTextBox.Name = "OfficerTextBox";
            this.OfficerTextBox.Size = new System.Drawing.Size(100, 20);
            this.OfficerTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Officer:";
            // 
            // OfficerButton
            // 
            this.OfficerButton.Location = new System.Drawing.Point(230, 99);
            this.OfficerButton.Name = "OfficerButton";
            this.OfficerButton.Size = new System.Drawing.Size(170, 23);
            this.OfficerButton.TabIndex = 22;
            this.OfficerButton.Text = "Locate Nearest Officer";
            this.OfficerButton.UseVisualStyleBackColor = true;
            this.OfficerButton.Click += new System.EventHandler(this.OfficerButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.Location = new System.Drawing.Point(230, 43);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(75, 23);
            this.LogButton.TabIndex = 21;
            this.LogButton.Text = "Log Incident";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // StateCombo
            // 
            this.StateCombo.FormattingEnabled = true;
            this.StateCombo.Location = new System.Drawing.Point(28, 369);
            this.StateCombo.Name = "StateCombo";
            this.StateCombo.Size = new System.Drawing.Size(121, 21);
            this.StateCombo.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "State";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(31, 304);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Street Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Incident Type:";
            // 
            // DefaultCombo
            // 
            this.DefaultCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultCombo.FormattingEnabled = true;
            this.DefaultCombo.Location = new System.Drawing.Point(12, 43);
            this.DefaultCombo.Name = "DefaultCombo";
            this.DefaultCombo.Size = new System.Drawing.Size(121, 21);
            this.DefaultCombo.TabIndex = 14;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(28, 239);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.OfficerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OfficerButton);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.StateCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefaultCombo);
            this.Controls.Add(this.StreetTextBox);
            this.Name = "Form1";
            this.Text = "Police Dispatcher Client Igor Yankiver HW1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.TextBox OfficerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OfficerButton;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.ComboBox StateCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DefaultCombo;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

