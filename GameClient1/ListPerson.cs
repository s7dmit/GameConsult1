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
    public partial class ListPerson : Form
    {
        public ListPerson()
        {
            InitializeComponent();
        }

        const string _baseAddress = "http://localhost:17774/";

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        public ListPerson(MenuForm f)
        {
            InitializeComponent();
            //f.BackColor = Color.Yellow;
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
                    GameConsult1.Models.Person[] reports = response.Content.ReadAsAsync<GameConsult1.Models.Person[]>().Result;

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

        private void button2_Click(object sender, EventArgs e)
        {
            PersonForm form = new PersonForm();
            form.Show();
            }
        }
}
