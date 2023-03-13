using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise01
{
    public partial class Form1 : Form
    {
        StudentSystem studentSystem;
        GradeSystem gradeSystem;

        public Form1()
        {
            InitializeComponent();
            studentSystem = new StudentSystem();
            gradeSystem = new GradeSystem();

            PrintStudentsList();
            PrintGradesList();
        }

        private void PrintStudentsList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentSystem.GetList();
        }

        private void PrintGradesList()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = gradeSystem.GetList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student newStudent = new Student((int)numericUpDown1.Value, textBox1.Text);
                studentSystem.Add(newStudent);
                PrintStudentsList();

                numericUpDown1.Value = 0;
                textBox1.Text = "";
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Grade newGrade = new Grade((int)numericUpDown2.Value, (int)numericUpDown3.Value);
                gradeSystem.Add(newGrade);
                PrintGradesList();

                numericUpDown2.Value = 0;
                numericUpDown3.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> studentList = studentSystem.Order();
                List<Grade> gradeList = gradeSystem.Order();

                for(int i = 0; i <= studentList.Count - 1; i++)
                {
                    int studentId = studentList[i].Id;
                    string studentName = studentList[i].Name;
                    decimal gradeAverage = 0;
                    int count = 0;
                    int total = 0;
                    
                    for(int j = 0; j <= gradeList.Count - 1; j++)
                    {
                        if (studentId == gradeList[j].Id)
                        {
                            total += gradeList[j].Calif;
                            count++;
                        }
                    }

                    gradeAverage = (decimal)total / (decimal)count;
                    dataGridView3.Rows.Add(new string[] {$"{studentName}", $"{gradeAverage}"});
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
