using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace NetTester
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void ping_run_ctrl_Click(object sender, EventArgs e)
      {
         ping_result_ctrl.Text = "";
         string result = "";
         string ip = ping_ip_ctrl.Text;

         if (Ping(ip, 1000, 5) == true)
         {
            result = String.Format("Znaleziono urz¹dzenie o adresie {0}", ip);
            ping_result_ctrl.SelectionStart = 0;
            ping_result_ctrl.SelectionLength = result.Length;
            ping_result_ctrl.SelectionColor = Color.Green;
         }
         else
         {
            ping_result_ctrl.SelectionStart = 0;
            ping_result_ctrl.SelectionLength = result.Length;
            ping_result_ctrl.SelectionColor = Color.Red;
            result = String.Format("Nie znaleziono urz¹dzenia o adresie {0}", ip);
         }

         ping_result_ctrl.AppendText(result);
      }

      private void port_run_ctrl_Click(object sender, EventArgs e)
      {
         TcpClient m_Client;

         string m_Ip;
         int m_Port;

         port_result_ctrl.Text = String.Empty;

         try
         {
            m_Ip = port_ip_ctrl.Text.Trim();
            m_Port = Convert.ToInt32(port_port_ctrl.Text.Trim());
         }
         catch (Exception)
         {
            string result = "Niepoprawne dane!!!";
            port_result_ctrl.SelectionStart = 0;
            port_result_ctrl.SelectionLength = result.Length;
            port_result_ctrl.SelectionColor = Color.Red;
            port_result_ctrl.AppendText(result);
            return;
         }

         try
         {
            using (m_Client = new TcpClient(m_Ip, m_Port))
            {
               string result = String.Format("Nawi¹zano po³¹czenie z {0} na porcie {1}", m_Ip, m_Port);
               port_result_ctrl.SelectionStart = 0;
               port_result_ctrl.SelectionLength = result.Length;
               port_result_ctrl.SelectionColor = Color.Green;
               port_result_ctrl.AppendText(result);
            }
         }
         catch (Exception)
         {
            string result = String.Format("Nie uda³o siê nawi¹zaæ po³¹czenia z {0}:{1}", m_Ip, m_Port);
            port_result_ctrl.SelectionStart = 0;
            port_result_ctrl.SelectionLength = result.Length;
            port_result_ctrl.SelectionColor = Color.Red;
            port_result_ctrl.AppendText(result);
            return;
         }

      }


      private bool Ping(string IP, ushort timeout, ushort retryCount)
      {
         Ping pingSender = new Ping();
         PingReply reply;
         int counter = 0;

         try
         {
            do
            {
               reply = pingSender.Send(IP, (int)timeout);

               if (reply.Status == IPStatus.Success)
                  return true;

               if (++counter >= retryCount)
                  break;
            }
            while (true);
         }
         catch (Exception) { }
         return false;
      }

      private void showip_ctrl_Click(object sender, EventArgs e)
      {
         string hostName = Dns.GetHostName();
         var addrList = Dns.GetHostByName(hostName).AddressList;

         string result = "";
         info_result_ctrl.Text = "";

         foreach (var addr in addrList )
         {
            if(ValidateIPv4(addr.ToString()))
            {
               result += addr.ToString() + "\n";
               info_result_ctrl.SelectionStart = 0;
               info_result_ctrl.SelectionLength = result.Length;
               info_result_ctrl.SelectionColor = Color.Green;
               info_result_ctrl.AppendText(result);
               return;
            }
         }

         info_result_ctrl.SelectionStart = 0;
         info_result_ctrl.SelectionLength = result.Length;
         info_result_ctrl.SelectionColor = Color.Red;
         info_result_ctrl.AppendText("Nie uda³o siê pobraæ adres IP komputera");
      }


      private bool ValidateIPv4(string ipString)
      {
         if (String.IsNullOrWhiteSpace(ipString))
         {
            return false;
         }

         string[] splitValues = ipString.Split('.');
         if (splitValues.Length != 4)
         {
            return false;
         }

         byte tempForParsing;

         return splitValues.All(r => byte.TryParse(r, out tempForParsing));
      }
   }
}
