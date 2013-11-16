using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaBackend;

namespace WFAgenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPriority.Enabled = false;
            comboBoxExtDuration.Enabled = false;
            textBoxEnd.Enabled = false;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTaskType.SelectedItem != "Note" &&
                comboBoxTaskType.SelectedItem != "")
            {
                comboBoxPriority.Enabled = true;
                comboBoxExtDuration.Enabled = true;
                textBoxEnd.Enabled = true;

            }
            else
            {
                comboBoxPriority.Enabled = false;
                comboBoxExtDuration.Enabled = false;
                textBoxEnd.Enabled = false;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            richTextBoxDescription.Text = "";
            textBoxTitle.Text = "";
            comboBoxTaskType.SelectedIndex = 0;
            comboBoxExtDuration.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 0;
            textBoxEnd.Text = "";
        }

        private void buttonSortByDateCreated_Click(object sender, EventArgs e)
        {
            List<AgendaObject> listOfAgendaObjects = new List<AgendaObject>();

            foreach (var element in listBoxGetAllByTags.Items)
            {
                listOfAgendaObjects.Add((AgendaObject)element);
            }

            AgendaObject.SortByTitle(listOfAgendaObjects);

        }



    }
}
