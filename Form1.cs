using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airflot
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        IFlights _flights;
        

    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
            {
                try
                {
                    Flights flights = new Flights { FlyId = textBox1.Text, Arrival = textBox2.Text, Departure = textBox3.Text, FlyType = textBox4.Text, Price = Convert.ToDecimal(textBox5.Text) };
                    _flights.Add(flights);
                    dataGridView1.DataSource = _flights.AllFlights.ToList();
                }
                catch
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные");
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _flights = new RepositoryFlights(new AppDbContext());
            dataGridView1.DataSource = _flights.AllFlights.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = _flights.Seacrh(textBox3.Text, textBox1.Text).ToList();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _flights.AllFlights.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Flights> Sort = (List<Flights>)dataGridView1.DataSource;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Sorted.SortPrice(Sort).ToList();
           
        }
    }
}
