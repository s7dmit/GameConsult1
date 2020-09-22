using GameConsult1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameClient1
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        public PersonForm(MenuForm f)
        {
            InitializeComponent();
            //f.BackColor = Color.Yellow;
        }

        const string _baseAddress = "http://localhost:17774/";

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/People").Result;
                listView1.Items.Clear();
                if (response.IsSuccessStatusCode)
                {
                    Person[] reports = response.Content.ReadAsAsync<Person[]>().Result;

                    foreach (var p in reports)
                    {
                        var item = new ListViewItem(new[] { //p.Player.Name,
                            p.Name,p.Gender.ToString(),
                            //p.Race.Name, p.Class.Name,
                            p.Experience.ToString(),p.Power.ToString(),p.Dexterity.ToString(), p.Intellect.ToString(), p.Wisdom.ToString(), p.Health.ToString(), p.Mana.ToString()});
                        item.Tag = p.Id;
                        listView1.Items.Add(item);
                    }
                }
            }
        }
    }
}
                
