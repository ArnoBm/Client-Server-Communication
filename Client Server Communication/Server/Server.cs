using SimpleTCP;
using System.Text;

namespace Client_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void Server_Load(object sender, EventArgs e)
        { 
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            StatusTb.Invoke((MethodInvoker)delegate ()
            {
                StatusTb.Text += e.MessageString;
                e.ReplyLine(string.Format("You Said: {0}", e.MessageString));
            });
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StatusTb.Text += "Server Starting...";
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(HostTb.Text);
                int port = Convert.ToInt32(PortTb.Text);
                server.Start(ip, port);
                StatusTb.Text += "Server started successfully.";
            }
            catch (FormatException ex)
            {
                StatusTb.Text += $"Error: Invalid IP address or port number. {ex.Message}";
            }
            catch (Exception ex)
            {
                StatusTb.Text += $"An error occurred: {ex.Message}";
            }
        }


        private void StopBtn_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
                server.Stop();
        }
    }
}
