namespace Weather_Condition_App
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
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxState = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeather
            // 
            this.picWeather.Location = new System.Drawing.Point(155, 200);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(1202, 619);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWeather.TabIndex = 0;
            this.picWeather.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(211, 82);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(336, 31);
            this.txtCity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "State:";
            // 
            // lblWeather
            // 
            this.lblWeather.Location = new System.Drawing.Point(276, 222);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(915, 240);
            this.lblWeather.TabIndex = 7;
            this.lblWeather.Text = "Enter city and state to get weather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(1195, 85);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(161, 57);
            this.btnGetWeather.TabIndex = 3;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1195, 878);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 63);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxState
            // 
            this.cbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxState.FormattingEnabled = true;
            this.cbxState.Location = new System.Drawing.Point(740, 85);
            this.cbxState.Name = "cbxState";
            this.cbxState.Size = new System.Drawing.Size(335, 33);
            this.cbxState.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 1086);
            this.Controls.Add(this.cbxState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetWeather);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.picWeather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxState;
    }
}

