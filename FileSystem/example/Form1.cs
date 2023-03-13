using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace example
{
    public partial class Form1 : Form
    {
        StudentFileSystem studentSystem;
        GradeFileSystem gradeSystem;

        public Form1()
        {
            InitializeComponent();
            studentSystem = new StudentFileSystem();
            gradeSystem = new GradeFileSystem();
            PrintStudentsGrid();
            PrintGradesGrid();
        }

        private void PrintStudentsGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentSystem.GetStudentList();
        }

        private void PrintGradesGrid()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = gradeSystem.GetGradesList();
        }

        private void ClearStudentInputs()
        {
            NameText.Text = string.Empty;
            SurnameText.Text = string.Empty;
            StudentIdInput.Value = 0;
        }

        private void ClearGradeInputs()
        {
            GradeInput.Value = 0;
            DateInput.Value = DateTime.Now;
            GradeIdInput.Value = 0;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string studentData = $"{StudentIdInput.Value},{NameText.Text},{SurnameText.Text}";
                Student newStudent = new Student(studentData);
                studentSystem.Add(newStudent);
                ClearStudentInputs();
                PrintStudentsGrid();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Student toDelete = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                    studentSystem.Delete(toDelete.Id);
                    ClearStudentInputs();
                    PrintStudentsGrid();
                } else
                {
                    MessageBox.Show("Select the student row to remove");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifyStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Student toUpdate = (Student)dataGridView1.SelectedRows[0].DataBoundItem;
                    string option = Interaction.InputBox("Choose the property to modify:\n1 -> name\n2 -> surname\n3 -> id");

                    if (option == "1" || option == "2" || option == "3")
                    {
                        string newData = Interaction.InputBox("Write the new information:");
                        studentSystem.Delete(toUpdate.Id);

                        if (option == "1")
                        {
                            toUpdate.Name = newData;
                        }
                        else if (option == "2")
                        {
                            toUpdate.Surname = newData;
                        }
                        else
                        {
                            toUpdate.Id = long.Parse(newData);
                        }

                        studentSystem.Update(toUpdate);
                    } else
                    {
                        MessageBox.Show("Invalid option, please try again.");
                    }
                } else
                {
                    MessageBox.Show("Select the student row to modify.");
                }

                ClearStudentInputs();
                PrintStudentsGrid();
            } catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddGradeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string data = $"{GradeInput.Value},{DateInput.Value.ToShortDateString()},{GradeIdInput.Value}";
                Grade newGrade = new Grade(data);
                gradeSystem.Add(newGrade);
                ClearGradeInputs();
                PrintGradesGrid();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveGradeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    Grade toDelete = (Grade)dataGridView2.SelectedRows[0].DataBoundItem;
                    gradeSystem.Delete(toDelete.Id);
                    ClearGradeInputs();
                    PrintGradesGrid();
                } else
                {
                    MessageBox.Show("Select the grade row to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModifyGradeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 1)
                {
                    Grade toUpdate = (Grade)dataGridView2.SelectedRows[0].DataBoundItem;
                    string option = Interaction.InputBox("Choose the property to modify:\n1 -> grade\n2 -> date\n3 -> id");

                    if (option == "1" || option == "2" || option == "3")
                    {
                        string newData = Interaction.InputBox("Write the new information: (in case of day dd/mm/yyyy)");
                        gradeSystem.Delete(toUpdate.Id);

                        if (option == "1")
                        {
                            toUpdate.Calif = int.Parse(newData);
                        }
                        else if (option == "2")
                        {
                            toUpdate.Date = DateTime.Parse(newData);
                        }
                        else
                        {
                            toUpdate.Id = long.Parse(newData);
                        }

                        gradeSystem.Update(toUpdate);
                    }
                    else
                    {
                        MessageBox.Show("Invalid option, please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Select the grade row to modify.");
                }

                ClearGradeInputs();
                PrintGradesGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
