using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise01
{

    internal class List
    {
        Patient pointer;

        public List()
        {
            pointer = new Patient();
        }

        public Patient GetInitialValue()
        {
            return pointer.Next;
        }

        private Patient GetLastPatient(Patient somePatient)
        {
            Patient aux = somePatient;
            if (aux.Next != null) aux = GetLastPatient(aux.Next);
            return aux;
        }

        private Patient GetPatientById(string id, Patient somePatient)
        {
            Patient aux = somePatient;
            if (aux.Id != id) aux = GetPatientById(id, aux.Next);
            return aux;
        }

        private int IndexOfPatient(string id, Patient somePatient, int i)
        {
            int index = i;
            if (somePatient.Id != id) index = IndexOfPatient(id, somePatient.Next, i + 1);
            return index;
        }

        private Patient GetPatientByPosition(int position, Patient somePatient, int count)
        {
            Patient toSearchPatient = somePatient;
            if (count != position) toSearchPatient = GetPatientByPosition(position, somePatient.Next, count + 1);
            return toSearchPatient;
        }

        private int Length(Patient somePatient, int count)
        {
            int length = count;
            if (somePatient.Next != null) length = Length(somePatient.Next, count + 1);
            return length;
        }

        public void AddPatient(Patient newPatient)
        {
            if (pointer.Next != null) 
            {
                Patient lastPatient = GetLastPatient(pointer.Next);
                lastPatient.Next = newPatient;
            } else
            {
                pointer.Next = newPatient;
            }
        }

        public Patient RemovePatient(string id)
        {
            int patientPosition = IndexOfPatient(id, pointer.Next, 0);
            int listLength = Length(pointer.Next, 1);
            Patient toDeletePatient = GetPatientById(id, pointer.Next);

            if (patientPosition == 0)
            {
                Patient nextPatient = toDeletePatient.Next;
                pointer.Next = nextPatient;
                
            } else if (patientPosition > 0 && patientPosition < listLength - 1)
            {
                Patient prevPatient = GetPatientByPosition(patientPosition - 1, pointer.Next, 0);
                Patient nextPatient = toDeletePatient.Next;

                prevPatient.Next = nextPatient;
            } else if (toDeletePatient.Next == null)
            {
                Patient prevPatient = GetPatientByPosition(patientPosition - 1, pointer.Next, 0);
                prevPatient.Next = null;
            }

            toDeletePatient.Next = null;

            return toDeletePatient;
        }

        public void UpdatePatient(string id, int value, string data)
        {
            Patient toUpdatePatient = GetPatientById(id, pointer.Next);

            switch (value)
            {
                case 0:
                    toUpdatePatient.Name = data;
                    break;
                case 1:
                    toUpdatePatient.Surname = data;
                    break;
                case 2:
                    toUpdatePatient.Adress = data;
                    break;
                case 3:
                    toUpdatePatient.Phone = data;
                    break;
                default:
                    MessageBox.Show("An error ocurred");
                    break;
            }
        }

        public void InsertPatient(string id, int position)
        {
            Patient toInsertPatient = GetPatientById(id, pointer.Next);
            int indexOf = IndexOfPatient(id, pointer.Next, 0);
            int listLength = Length(pointer.Next, 1);

            if (indexOf != 0)
            {
                Patient prev = GetPatientByPosition(indexOf - 1, pointer.Next, 0);
                Patient next = GetPatientByPosition(indexOf + 1, pointer.Next, 0);

                prev.Next = next;
            } else
            {
                Patient next = GetPatientByPosition(indexOf + 1, pointer.Next, 0);
                pointer.Next = next;
            }

            if (position == 1)
            {
                Patient nextPatient = pointer.Next;
                pointer.Next = toInsertPatient;
                toInsertPatient.Next = nextPatient;
            }
            else if (position != 1 && position <= listLength)
            {
                Patient nextPatient = GetPatientByPosition(position - 1, pointer.Next, 0);
                Patient prevPatient = GetPatientByPosition(position - 2, pointer.Next, 0);
                prevPatient.Next = toInsertPatient;
                toInsertPatient.Next = nextPatient;
            }
            else if (position == listLength + 1)
            {
                Patient prevPatient = GetLastPatient(pointer.Next);
                prevPatient.Next = toInsertPatient;
                toInsertPatient.Next = null;
            }
            else MessageBox.Show("The position indicated is out of the range!!!");
        }
    }
}
