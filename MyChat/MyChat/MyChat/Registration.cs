using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Http.Headers;
using Backend.Models;
using System.Net.Http;
namespace MyChat
{
   public partial class Registration : MaterialForm
    {
        public Registration()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
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
		
		 public void CloseMessageBox()
        {
            System.Threading.Thread.Sleep(700);
            Microsoft.VisualBasic.Interaction.AppActivate(
                 System.Diagnostics.Process.GetCurrentProcess().Id);
            System.Windows.Forms.SendKeys.SendWait(" ");
        }

		
		
		  private async Task PostRequest(String jsonPost)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.PostAsync("http://mapp.azurewebsites.net/api/User", new StringContent(jsonPost));
                         
                String text = await response.Content.ReadAsStringAsync();
               
				
				(new System.Threading.Thread(CloseMessageBox)).Start();
                MessageBox.Show("Saved Successfully");
				 
            }
            catch(Exception e)
            {
                MessageBox.Show("Save failed: " + e.Message);
            }
			this.Close();
            Application.Restart();
        }

		
        private async void SignUp_Click(object sender, EventArgs e)
        {

            {
                User p = new User(0, txtusername.Text, txtfirstname.Text, txtlastname.Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                String jsonPost = js.Serialize(p);

                await PostRequest(jsonPost);
            }



        }
    }
}
