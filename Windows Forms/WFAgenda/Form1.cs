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
using TodoListConsole;

namespace WFAgenda
{
    public partial class Form1 : Form
    {
        private List<AgendaObject> listOfAgendaObjects;

        public List<AgendaObject> ListOfAgendaObjects
        {
            get
            {
                return this.listOfAgendaObjects;
            }
            set
            {
                this.listOfAgendaObjects = value;
            }
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPriority.Enabled = false;
            comboBoxExtDuration.Enabled = false;
            this.listOfAgendaObjects = new List<AgendaObject>();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTaskType_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Goal
            //Meeting
            //Note
            //Task
            //Birthday

            if (comboBoxTaskType.SelectedItem == "")
            {
                groupBoxBirthday.Visible = false;
                groupBoxEnd.Visible = false;
                groupBoxStart.Visible = false;
                comboBoxExtDuration.Enabled = false;
                comboBoxPriority.Enabled = false;
                comboBoxExtDuration.Visible = false;
                comboBoxPriority.Visible = false;
                label4.Visible = false;
                label6.Visible = false;

                this.Size = new Size(437, 375);
                
            }
            else if (comboBoxTaskType.SelectedItem == "Birthday")
            {
                this.Size = new Size(792, 375);
                groupBoxEnd.Visible = false;
                groupBoxStart.Visible = false;
                groupBoxBirthday.Visible = true;

                groupBoxBirthday.Location = new Point(6, 19);
            }
            else if (comboBoxTaskType.SelectedItem == "Goal")
            {
                this.Size = new Size(792, 375);
                groupBoxEnd.Visible = false;
                groupBoxStart.Visible = false;
                groupBoxBirthday.Visible = false;
                comboBoxExtDuration.Enabled = true;
                comboBoxPriority.Enabled = true;
                comboBoxPriority.Visible = true;
                comboBoxExtDuration.Visible = true;

                label4.Visible = true;
                label6.Visible = true;
                label4.Location = new Point(16, 19);
                label6.Location = new Point(16, 50);
                comboBoxPriority.Location = new Point(120, 19);
                comboBoxExtDuration.Location = new Point(120, 50);
            }
            else if (comboBoxTaskType.SelectedItem == "Meeting")
            {
                this.Size = new Size(792, 375);
                groupBoxStart.Visible = true;
                groupBoxStart.Location = new Point(6, 19);

                groupBoxEnd.Visible = true;
                groupBoxEnd.Location = new Point(6, 113);

                groupBoxBirthday.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
            }
            else if (comboBoxTaskType.SelectedItem == "Note")
            {
                this.Size = new Size(437,375);
                groupBoxBirthday.Visible = false;
                groupBoxEnd.Visible  = false;
                groupBoxStart.Visible  = false;
                comboBoxExtDuration.Enabled = false;
                comboBoxPriority.Enabled = false;
                comboBoxExtDuration.Visible = false;
                comboBoxPriority.Visible = false;
                label4.Visible = false;
                label6.Visible = false;
            }
            else if (comboBoxTaskType.SelectedItem == "Task")
            {
                this.Size = new Size(792, 375);
                label4.Visible = true;
                label4.Location = new Point(16, 19);
                comboBoxPriority.Visible = true;
                comboBoxPriority.Enabled = true;
                comboBoxPriority.Location = new Point(120, 19);
                groupBoxBirthday.Visible = false;
                groupBoxEnd.Visible = false;
                comboBoxExtDuration.Visible = false;
                comboBoxExtDuration.Enabled = false;
                label6.Visible = false;
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            richTextBoxDescription.Text = "";
            textBoxTitle.Text = "";
            comboBoxTaskType.SelectedIndex = 0;
            comboBoxExtDuration.SelectedIndex = 0;
            comboBoxPriority.SelectedIndex = 0;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.listOfAgendaObjects.Add(AddNewAgenda(comboBoxTaskType.Text));
            
        }

        public AgendaObject AddNewAgenda(string agendaType)
        {
            switch (agendaType)
            {
                case "Goal":
                    {
                        switch (comboBoxPriority.SelectedIndex)
                        {
                            case 0:
                                break;
                            case 1:
                                {
                                    return new Goal(textBoxTitle.Text, richTextBoxDescription.Text, Priority.None);
                                }
                            case 2:
                                {
                                    return new Goal(textBoxTitle.Text, richTextBoxDescription.Text, Priority.Important);
                                }
                            case 3:
                                {
                                    return new Goal(textBoxTitle.Text, richTextBoxDescription.Text, Priority.Important);
                                }
                            default:
                                break; //todo to implement exception
                        }
                    }
                    break;
                case "Meeting":
                    {
                        //start time
                        int startYear = Convert.ToInt32(comboBoxStartYear.Text);
                        int startMonth = Convert.ToInt32(comboBoxStartMonth.Text);
                        int startDay = Convert.ToInt32(comboBoxStartDay.Text);

                        int startHours = Convert.ToInt32(comboBoxStartHrs.Text);
                        int startMins = Convert.ToInt32(comboBoxStartMins.Text);
                        int startSecs = Convert.ToInt32(comboBoxStartSecs.Text);

                        DateTime startTime = new DateTime(startYear, startMonth, startDay, startHours, startMins, startSecs);

                        //end time
                        int endYear = Convert.ToInt32(comboBoxEndYear.Text);
                        int endMonth = Convert.ToInt32(comboBoxEndMonth.Text);
                        int endDay = Convert.ToInt32(comboBoxEndDay.Text);

                        int endHours = Convert.ToInt32(comboBoxEndHrs.Text);
                        int endMins = Convert.ToInt32(comboBoxEndMins.Text);
                        int endSecs = Convert.ToInt32(comboBoxEndSecs.Text);

                        DateTime endTime = new DateTime(endYear, endMonth, endDay, endHours, endMins, endSecs);

                        return new Meeting(textBoxTitle.Text, richTextBoxDescription.Text, startTime, endTime);
                    }
                    break;

                case "Note":
                    {
                        return new Note(textBoxTitle.Text, richTextBoxDescription.Text);
                    }
                    break;

                case "Task":
                    {
                        switch (comboBoxPriority.SelectedIndex)
                        {
                            case 0:
                                break;
                            case 1:
                                {
                                    return new AgendaBackend.Task(textBoxTitle.Text, richTextBoxDescription.Text, Priority.None);
                                }
                            case 2:
                                {
                                    return new AgendaBackend.Task(textBoxTitle.Text, richTextBoxDescription.Text, Priority.Important);
                                }
                            case 3:
                                {
                                    return new AgendaBackend.Task(textBoxTitle.Text, richTextBoxDescription.Text, Priority.Important);
                                }
                            default:
                                break; //todo to implement exception
                        }
                    }
                    break;
                case "Birthday":
                    {
                        //start time
                        int year = Convert.ToInt32(comboBoxStartYear.Text);
                        int month = Convert.ToInt32(comboBoxStartMonth.Text);
                        int day = Convert.ToInt32(comboBoxStartDay.Text);

                        DateTime startTime = new DateTime(year, month, day);

                        return new BirthdayReminder(DateTime.Now, textBoxTitle.Text, richTextBoxDescription.Text, richTextBoxDescription.Text, 2,
                            startTime);
                    }
                    break;
                default:
                    return null;
            }
            return null;
        }

        private void tabControlBirthDay_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlBirthDay.SelectedIndex.ToString() == "6")
            {
                this.Size = new Size(437, 375);
            }
            else
            {
                this.Size = new Size(792, 375);
            }

            if (tabControlBirthDay.SelectedIndex.ToString() == "0")
            {
                if (this.listOfAgendaObjects.Count > 0)
                {
                    foreach (var agendaObject in this.listOfAgendaObjects)
                    {
                        this.listBox1.Items.Add(agendaObject);
                    }
                }
            }
        }
    }
}
