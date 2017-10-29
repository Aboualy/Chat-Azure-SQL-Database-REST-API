using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Backend.Models;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Drawing;
namespace MyChat
{
    public partial class Chat : MaterialForm
    {
        //const int port = 80;
        //const string serverIP = "127.0.0.1";

        public Chat()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private List<string> myList = new List<string>();

        private async Task GetRequest()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("http://mapp.azurewebsites.net/api/User");
                HttpContent content = response.Content;
                String jsonString = await content.ReadAsStringAsync();

                if (!myList.Contains(jsonString))
                {
                    myList.Add(jsonString);
                }

                parseAndShow(jsonString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void message_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                btnSend_Click(btnSend, null);
            }
        }



        private List<User> users = new List<User>();

        public void parseAndShow(String jsonString)
        {
            string txt = textUsername.Text;
            JavaScriptSerializer js = new JavaScriptSerializer();
            users = js.Deserialize<List<User>>(jsonString);
            String[] output = new String[users.Count];

            for (int i = 0; i < output.Length; i++)
            {
                output[i] =  "ID: " + users[i].id + "User Name: " + users[i].username + "First Name: " + users[i].firstname + "Last Name: " + users[i].lastname;
            }
            
            List<string> result = users.Select(user => user.username).Distinct().ToList();

            if (result.Any(txt.Contains))
            {
                if (!onlineUsers.Contains(txt))
                {
                    onlineUsers.Add(txt);
                }
                
                UpdateList();
                AddText(txt + " Joined the chat");
                //Chatting.Items.Add(txt + " Joined the chat");
                textUsername.Text = "";


                (new System.Threading.Thread(CloseMessageBox)).Start();
                MessageBox.Show("You have been successfully logged in");
            }
            else
            {
                (new System.Threading.Thread(CloseMessageBox)).Start();
                MessageBox.Show("Login Failed");
               
                textUsername.Text = "";
            }
        }

        public void CloseMessageBox()
        {
            System.Threading.Thread.Sleep(800);
            Microsoft.VisualBasic.Interaction.AppActivate(
            System.Diagnostics.Process.GetCurrentProcess().Id);
            System.Windows.Forms.SendKeys.SendWait(" ");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
      }
        private async void Login_Click(object sender, EventArgs e)
        {
          await GetRequest(); }

        private List<string> onlineUsers = new List<string>();
        private void UpdateList()
        {
            personList.DataSource = null;
            personList.DataSource = onlineUsers;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            string click = personList.SelectedItem.ToString();
           
            for (int i = personList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                onlineUsers.RemoveAt(personList.SelectedIndices[i]);
                AddText(  personList.Items[personList.SelectedIndices[i]].ToString() + " " +"left the chat" );
            }
                
                UpdateList();}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String txtbox = textBox1.Text;
            if (string.IsNullOrWhiteSpace(txtbox) || !onlineUsers.Contains(txtbox))
            {



                textBox1.ForeColor = Color.Red;
            }
            else
            { textBox1.ForeColor = Color.Black; }
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

                foreach (string name in onlineUsers)
                {
                    autoComplete.Add(name);
                }

                textBox1.AutoCompleteCustomSource = autoComplete;
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            

        }


        private void personList_DoubleClick(object sender, EventArgs e)
        {
            

            string click = personList.SelectedItem.ToString();
            JavaScriptSerializer js = new JavaScriptSerializer();
            string str = string.Join("", myList.ToArray());
            //String json = new Gson().toJson(myList);
            //string json = JsonConvert.SerializeObject(myList);
            users = js.Deserialize<List<User>>(str);

            List<string> newlist = users.Where(user => user.username == click).Select(user => string.Join(" ", user.firstname, user.lastname)).ToList();


            if (personList.SelectedItem != null)
            {

                (new System.Threading.Thread(CloseMessageBox)).Start();
                MessageBox.Show(string.Join(Environment.NewLine, newlist));
                
            }
        }


        private List<Socket> listChat = new List<Socket>();

       private void MessageReceived(object obj)
        {
            Socket soc = (Socket)obj;
            byte[] data = new byte[1024 * 1024];
            while (true)
            {
                int theLen = 0;
                try
                {
                    theLen = soc.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception)
                {
                    AddText("[" + soc.RemoteEndPoint + "] disconnected!");
                    soc.Close();
                    listChat.Remove(soc);
                    break;
                }


                if (theLen <= 0)
                {
                    AddText("[" + soc.RemoteEndPoint + "] disconnected!");
                    soc.Shutdown(SocketShutdown.Both);
                    soc.Close();
                    listChat.Remove(soc);
                    return;
                }

                string textMessage = Encoding.Default.GetString(data);
                AddText("[" + soc.RemoteEndPoint + "]：" + textMessage);
            }
        }

        private void AddText(string txt)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new Action<string>(textMessage =>
                {
                    txtLog.Text = string.Format("{0}\r\n{1}", textMessage, txtLog.Text);
                }), txt);
            }
            else
            {
                txtLog.Text = string.Format("{0}\r\n{1}", txt, txtLog.Text);
            }
        }

        
      

        private void textUsername_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        
            if (e.KeyValue == 13)
            {
                Login_Click(Login, null);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string textMessage = message.Text;
            string receiver = textBox1.Text;
            string send = textBox2.Text;

            if (string.IsNullOrEmpty(send) || string.IsNullOrEmpty(receiver) || !onlineUsers.Contains(receiver)|| !onlineUsers.Contains(send))
            {

                (new System.Threading.Thread(CloseMessageBox)).Start();
                MessageBox.Show(string.Join(Environment.NewLine, "You have to login first"));

            }
            
            else
            {
                
                foreach (Socket soc in listChat)
                {

                    if (soc.Connected)
                    {
                        byte[] data = Encoding.Default.GetBytes("[Sender]：" + send + textMessage + "\r\n" + receiver);
                        soc.Send(data, 0, data.Length, SocketFlags.None);
                    }
                }
                AddText(send + " "+ "says" + " " + textMessage + " " + "to" + " " + receiver );
                message.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String txtbox = textBox2.Text;

            if (string.IsNullOrWhiteSpace(txtbox) || !onlineUsers.Contains(txtbox))
            {



                textBox2.ForeColor = Color.Red;
            }
            else { textBox2.ForeColor = Color.Black; }
                AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

                foreach (string name in onlineUsers)
                {
                    autoComplete.Add(name);
                }

                textBox2.AutoCompleteCustomSource = autoComplete;
                textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource; }
        

        
    }
    }
