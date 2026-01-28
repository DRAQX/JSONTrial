using System.Configuration;
using System.Text.Json;

namespace JSONTrial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            string fileName = "people.json";
            string jsonString = File.ReadAllText(fileName);
            richTextBox1.Text = jsonString;
            var listing = JsonSerializer.Deserialize<List<People>>(jsonString);
            dataGridView1.DataSource = listing;
        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            string currentdata = JsonSerializer.Serialize(dataGridView1.DataSource);
            richTextBox2.Text = currentdata;
        }
    }

    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
