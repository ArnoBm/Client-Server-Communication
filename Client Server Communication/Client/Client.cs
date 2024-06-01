using SimpleTCP;
using System;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Client : Form
    {
        private SimpleTcpClient client;

        public Client()
        {
            InitializeComponent();
            this.Load += new EventHandler(Client_Load); // Ensure Client_Load is connected to the form's Load event
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(HostTb.Text, Convert.ToInt32(PortTb.Text));
                ConnectBtn.Enabled = false;
                StatusTb.Text += "Connected to the server.\n";
            }
            catch (Exception ex)
            {
                StatusTb.Text += $"Error connecting to the server: {ex.Message}\n";
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            StatusTb.Invoke((MethodInvoker)delegate ()
            {
                StatusTb.Text += e.MessageString + "\n";
            });
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (client.TcpClient != null && client.TcpClient.Connected)
            {
                try
                {
                    var reply = client.WriteLineAndGetReply(MessageTb.Text, TimeSpan.FromSeconds(3));
                    StatusTb.Text += $"Reply: {reply.MessageString}\n";
                }
                catch (Exception ex)
                {
                    StatusTb.Text += $"Error sending message: {ex.Message}\n";
                }
            }
            else
            {
                StatusTb.Text += "Error: Client is not connected.\n";
            }
        }
    }
}
