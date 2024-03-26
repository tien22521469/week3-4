namespace TCPServer
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            ipTxt = new TextBox();
            messTxt = new TextBox();
            infoTxt = new TextBox();
            sendBtn = new Button();
            startBtn = new Button();
            clientIPLst = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 367);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 1;
            label2.Text = "Message:";
            // 
            // ipTxt
            // 
            ipTxt.Location = new Point(110, 19);
            ipTxt.Name = "ipTxt";
            ipTxt.Size = new Size(595, 31);
            ipTxt.TabIndex = 2;
            ipTxt.Text = "192.168.0.102:9000";
            // 
            // messTxt
            // 
            messTxt.Location = new Point(110, 361);
            messTxt.Name = "messTxt";
            messTxt.Size = new Size(595, 31);
            messTxt.TabIndex = 3;
            // 
            // infoTxt
            // 
            infoTxt.Location = new Point(110, 56);
            infoTxt.Multiline = true;
            infoTxt.Name = "infoTxt";
            infoTxt.ReadOnly = true;
            infoTxt.ScrollBars = ScrollBars.Both;
            infoTxt.Size = new Size(595, 299);
            infoTxt.TabIndex = 4;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(511, 409);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(94, 29);
            sendBtn.TabIndex = 5;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // startBtn
            // 
            startBtn.Location = new Point(611, 409);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(94, 29);
            startBtn.TabIndex = 6;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += button2_Click;
            // 
            // clientIPLst
            // 
            clientIPLst.FormattingEnabled = true;
            clientIPLst.ItemHeight = 25;
            clientIPLst.Location = new Point(711, 56);
            clientIPLst.Name = "clientIPLst";
            clientIPLst.Size = new Size(309, 379);
            clientIPLst.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 19);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 8;
            label3.Text = "Client IP:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 459);
            Controls.Add(label3);
            Controls.Add(clientIPLst);
            Controls.Add(startBtn);
            Controls.Add(sendBtn);
            Controls.Add(infoTxt);
            Controls.Add(messTxt);
            Controls.Add(ipTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TCP/IP Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ipTxt;
        private TextBox messTxt;
        private TextBox infoTxt;
        private Button sendBtn;
        private Button startBtn;
        private ListBox clientIPLst;
        private Label label3;
    }
}
