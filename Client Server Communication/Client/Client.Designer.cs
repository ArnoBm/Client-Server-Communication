namespace Client
{
    partial class Client
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
            StatusTb = new TextBox();
            SendBtn = new Button();
            MessageTb = new TextBox();
            PortTb = new TextBox();
            label2 = new Label();
            HostTb = new TextBox();
            label1 = new Label();
            ConnectBtn = new Button();
            SuspendLayout();
            // 
            // StatusTb
            // 
            StatusTb.Location = new Point(151, 218);
            StatusTb.Multiline = true;
            StatusTb.Name = "StatusTb";
            StatusTb.Size = new Size(399, 180);
            StatusTb.TabIndex = 20;
            // 
            // SendBtn
            // 
            SendBtn.BackColor = Color.PaleTurquoise;
            SendBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SendBtn.ForeColor = Color.Black;
            SendBtn.Location = new Point(450, 169);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(100, 33);
            SendBtn.TabIndex = 19;
            SendBtn.Text = "Send";
            SendBtn.UseVisualStyleBackColor = false;
            SendBtn.Click += this.SendBtn_Click;
            // 
            // MessageTb
            // 
            MessageTb.Location = new Point(151, 108);
            MessageTb.Multiline = true;
            MessageTb.Name = "MessageTb";
            MessageTb.Size = new Size(399, 46);
            MessageTb.TabIndex = 18;
            // 
            // PortTb
            // 
            PortTb.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PortTb.Location = new Point(361, 60);
            PortTb.Name = "PortTb";
            PortTb.Size = new Size(73, 29);
            PortTb.TabIndex = 17;
            PortTb.Text = "8910";
            PortTb.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 16;
            label2.Text = "Port:";
            // 
            // HostTb
            // 
            HostTb.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HostTb.Location = new Point(151, 60);
            HostTb.Name = "HostTb";
            HostTb.Size = new Size(141, 29);
            HostTb.TabIndex = 15;
            HostTb.Text = "127.92.1.1";
            HostTb.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 14;
            label1.Text = "Host:";
            // 
            // ConnectBtn
            // 
            ConnectBtn.BackColor = Color.Green;
            ConnectBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConnectBtn.ForeColor = Color.White;
            ConnectBtn.Location = new Point(450, 57);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(100, 33);
            ConnectBtn.TabIndex = 13;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = false;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 450);
            Controls.Add(StatusTb);
            Controls.Add(SendBtn);
            Controls.Add(MessageTb);
            Controls.Add(PortTb);
            Controls.Add(label2);
            Controls.Add(HostTb);
            Controls.Add(label1);
            Controls.Add(ConnectBtn);
            Name = "Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StatusTb;
        private Button SendBtn;
        private TextBox MessageTb;
        private TextBox PortTb;
        private Label label2;
        private TextBox HostTb;
        private Label label1;
        private Button ConnectBtn;
    }
}
