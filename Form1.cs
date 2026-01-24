using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {   private Queue<string> queue =new Queue<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {   string name = nameTextBox.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                queue.Enqueue(name);
                int positionNumber =queue.Count;
                listBox1.Items.Add($"{positionNumber} {name}");
                nameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter your name: ");

            }
        }

        private void serveButton_Click(object sender, EventArgs e)
        {
            //Check if queue is empty 
            if (queue.Count ==0)
            {
                MessageBox.Show("No one is waiting in the queue");
                return;
            }
            
            //remove first person from the queue
             string currentPerson= queue.Dequeue();

            //remove first name from the list 
            listBox1.Items.RemoveAt(0);


        }

    }
}
