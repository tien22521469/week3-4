using SuperSimpleTcp;
using System.Text;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new(ipTxt.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;
            sendBtn.Enabled = false;
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"Server disconnected .{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                sendBtn.Enabled = true;
                connectBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (client.IsConnected) 
            {
                if (!string.IsNullOrEmpty(messTxt.Text)) 
                {
                    client.Send(messTxt.Text);
                    infoTxt.Text += $"Me: {messTxt.Text}{Environment.NewLine}";
                    messTxt.Text = string.Empty;
                }
            }
        }
    }
}
