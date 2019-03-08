namespace PersonalAgenda.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using PersonalAgenda.Common;

    public class Contact
    {
        private static int index = 0;
        private static List<Person> contactsList;

        public Contact()
        {
            contactsList = new List<Person>();
        }

        public bool RemoveContact(int personId)
        {
            try
            {
                contactsList.RemoveAt(personId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddContact(Person person)
        {
            try
            {
                person.Id = index++;
                contactsList.Add(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateContact(Person person)
        {
            try
            {
                var hypo = contactsList.FirstOrDefault(x => x.Id == person.Id);

                if (hypo == null) return false;

                hypo.DateOfBirth = person.DateOfBirth;
                hypo.Email = person.Email;
                hypo.FirstName = person.FirstName;
                hypo.LastName = person.LastName;
                hypo.Others = person.Others;
                hypo.Phone = person.Phone;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ListContacts()
        {
            var temp = new StringBuilder();
            foreach (var person in contactsList)
            {
                temp.Append($"\t{person.Id} : {person.FirstName}-{person.LastName}\n");
            }
            return temp.ToString();
        }

        public string ListContact(int personId)
        {
            try
            {
                var person = contactsList.ElementAt(personId);
                return $"FirstName: {person.FirstName}\nLastName: {person.LastName}\n"
                       + $"Phone: {person.Phone}\nEmail: {person.Email}\n"
                       + $"Birth date: {person.DateOfBirth}\nOthers: {person.Others}";

            }
            catch (Exception)
            {
                return "Something went wrong...";
            }
        }

        public List<Person> RestoreAgenda()
        {
            try
            {
                var agendaList = Utilities.ReadFromBinaryFile<List<Person>>($"{AppDomain.CurrentDomain.BaseDirectory}/saveData.bin");
                contactsList.InsertRange(0, agendaList);
                return agendaList;
            }
            catch (Exception)
            {
                return new List<Person>();
            }
        }

        public void SaveCurrentAgenda()
        {
            Utilities.WriteToBinaryFile<List<Person>>($"{AppDomain.CurrentDomain.BaseDirectory}/saveData.bin", contactsList);
        }

        public Person GetPersonById(int personId)
        {
            try
            {
                return contactsList.ElementAt(personId);
            }
            catch (Exception)
            {
                return new Person();
            }
        }

    }
}
