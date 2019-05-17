using System;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace SimpleChatBySignalR.NETClient
{
    public partial class Form1 : Form
    {
      private  HubConnection connection;
       private IHubProxy chatHub;
        public Form1()
        {
            connection = new HubConnection("http://localhost:56273/signalr");
             chatHub = connection.CreateHubProxy("ChatHub");
            connection.Start();
            InitializeComponent();
            chatHub.On<string, string>("onMessage",
                (name, message) => lst_show.Invoke(new Action(() => lst_show.Items.Add(name + " : " + message))));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string message = txt_mess.Text;
            chatHub.Invoke("newMessage", name, message);

        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string gname = txt_gname.Text;
            chatHub.Invoke("JoinGroup", name, gname);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_gsend_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string gname = txt_gname.Text;
            string message = txt_mess.Text;

            chatHub.Invoke("SendToGroup", name, gname, message);
        }
    }
}
