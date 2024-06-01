namespace Client_Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartBtn = new Button();
            label1 = new Label();
            HostTb = new TextBox();
            PortTb = new TextBox();
            label2 = new Label();
            StopBtn = new Button();
            StatusTb = new RichTextBox();
            SuspendLayout();
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.Green;
            StartBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartBtn.ForeColor = Color.White;
            StartBtn.Location = new Point(420, 70);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(83, 33);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 73);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 1;
            label1.Text = "Host:";
            // 
            // HostTb
            // 
            HostTb.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HostTb.Location = new Point(121, 73);
            HostTb.Name = "HostTb";
            HostTb.Size = new Size(141, 29);
            HostTb.TabIndex = 2;
            HostTb.Text = "127.92.1.1";
            HostTb.TextAlign = HorizontalAlignment.Center;
            // 
            // PortTb
            // 
            PortTb.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PortTb.Location = new Point(331, 73);
            PortTb.Name = "PortTb";
            PortTb.Size = new Size(73, 29);
            PortTb.TabIndex = 4;
            PortTb.Text = "8910";
            PortTb.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 3;
            label2.Text = "Port:";
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.Red;
            StopBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBtn.ForeColor = Color.White;
            StopBtn.Location = new Point(519, 70);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(83, 33);
            StopBtn.TabIndex = 5;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += this.StopBtn_Click;
            // 
            // StatusTb
            // 
            StatusTb.Location = new Point(121, 138);
            StatusTb.Name = "StatusTb";
            StatusTb.Size = new Size(481, 263);
            StatusTb.TabIndex = 7;
            StatusTb.Text = "";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(StatusTb);
            Controls.Add(StopBtn);
            Controls.Add(PortTb);
            Controls.Add(label2);
            Controls.Add(HostTb);
            Controls.Add(label1);
            Controls.Add(StartBtn);
            Name = "Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Server";
            Load += Server_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Label label1;
        private TextBox HostTb;
        private TextBox PortTb;
        private Label label2;
        private Button StopBtn;
        private RichTextBox StatusTb;
    }
}
