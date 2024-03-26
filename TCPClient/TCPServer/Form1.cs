using SuperSimpleTcp;
using System.Text;
using System.Xml.Schema;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void button2_Click(object sender, EventArgs e)
        {
            server.Start();
            infoTxt.Text += $"Starting...{Environment.NewLine}";
            startBtn.Enabled = false;
            sendBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sendBtn.Enabled = false;
            server = new SimpleTcpServer(ipTxt.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;

        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"{e.IpPort} disconnect.{Environment.NewLine}";
                clientIPLst.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            //throw new NotImplementedException();
            this.Invoke((MethodInvoker)delegate
            {
                infoTxt.Text += $"{e.IpPort} connect.{Environment.NewLine}";
                clientIPLst.Items.Add(e.IpPort);
            });
            
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (server.IsListening) 
            {
                if(!string.IsNullOrEmpty(messTxt.Text) && clientIPLst.SelectedItems != null) 
                {
                    server.Send(clientIPLst.SelectedItem.ToString(), messTxt.Text);
                    infoTxt.Text += $"Server: {messTxt.Text}{Environment.NewLine}";
                    messTxt.Text = string.Empty;
                }
            }
        }
    }
}
