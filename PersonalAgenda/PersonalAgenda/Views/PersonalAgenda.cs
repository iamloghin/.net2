namespace PersonalAgenda.Views
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using global::PersonalAgenda.Common;
    using global::PersonalAgenda.Model;

    public partial class PersonalAgenda : Form
    {
        public readonly Contact Contacts;

        public PersonalAgenda()
        {
            this.Contacts = new Contact();
            this.InitializeComponent();
        }

        private void MainViewLoaded(object sender, EventArgs e)
        {
            // this.InsertMockData();
            var contactsList = this.Contacts.RestoreAgenda();

            foreach (var newContact in contactsList)
            {
                var person = new[] { $"{newContact.FirstName} {newContact.LastName}", newContact.Phone, newContact.Id.ToString() };
                var listView = new ListViewItem(person);
                this.contactsView.Items.Add(listView);
            }
        }

        private void MainViewClosed(object sender, EventArgs e) {
            this.Contacts.SaveCurrentAgenda();
        }

        private void NameInputValidating(object sender, EventArgs e)
        {
            var textInput = (TextBox)sender;
            var regexName = new Regex(@"[A-Z][a-z]+");
            if (textInput.Text == string.Empty)
            {
                throw new Exception("Please enter a name!");
            }
            if (!regexName.IsMatch(textInput.Text))
            {
                throw new Exception("Use only characters, please !");
            }
        }

        private void EmailInputValidating(object sender, EventArgs e)
        {
            var textInput = (TextBox)sender;
            var regexEmail = new Regex(@"[\w]+@[\w]+[.][\w]+");
            if (textInput.Text == string.Empty)
            {
                throw new Exception("Please enter a name!");
            }
            if (!regexEmail.IsMatch(textInput.Text))
            {
                throw new Exception("Please enter a valid email.");
            }
        }

        private void BirthDateValidating(object sender, EventArgs e)
        {
            var dateInput = (DateTimePicker)sender;

            var selectedDate = DateTime.Parse(dateInput.Text);
            var currentDate = DateTime.Today;

            if (selectedDate > currentDate)
            {
                throw new Exception("Please enter a valid date.");
            }
        }
        private void PhoneInputValidating(object sender, EventArgs e)
        {
            var phoneInput = (TextBox)sender;
            var regexPhone = new Regex(@"[0-9]{10}");

            if (phoneInput.Text == string.Empty)
            {
                throw new Exception("Please enter a phone number!");
            }
            if (!regexPhone.IsMatch(phoneInput.Text))
            {
                throw new Exception("Please enter a valid phone number.");
            }
        }

        private void SaveContactClick(object sender, EventArgs e)
        {
            try
            {
                this.ValidateChildren();

                var newContact = new Person
                                     {
                                         FirstName = this.firstNameInput.Text,
                                         LastName = this.lastNameInput.Text,
                                         DateOfBirth = DateTime.Parse(this.birthDatePicker.Text),
                                         Phone = this.phoneInput.Text,
                                         Email = this.emailInput.Text,
                                         Others = this.othersBox.Text,
                                     };

                this.Contacts.UpdateContact(newContact);
                
                this.Contacts.AddContact(newContact);
                this.contactsView.Items.Add(
                    new ListViewItem(
                        new[]
                            {
                                $"{newContact.FirstName} {newContact.LastName}",
                                newContact.Phone
                            }));
                
                this.contactsView.Refresh();
                Utilities.ResetAllControls(this.newContact);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private int GetIndexFromSelectedContact()
        {
            var firstSelectedItem = this.contactsView.SelectedItems[0];
            return this.contactsView.Items.IndexOf(firstSelectedItem);
        }

        private void ResetFieldsClick(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this.newContact);
            Utilities.ResetAllControls(this.infoContact);
            this.ChangeInputFieldsReadOnlyStare(false);
        }

        private void ContactsViewSelected(object sender, EventArgs e)
        {
            this.moreInfoBox.Text = this.Contacts.ListContact(GetIndexFromSelectedContact());
            this.PopulateNewContactBoxFields();
            this.ChangeInputFieldsReadOnlyStare(true);
        }

        private void RemoveContactClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.contactsView.SelectedItems)
            {
                var index = this.contactsView.Items.IndexOf(item);
                this.contactsView.Items.RemoveAt(this.contactsView.Items.IndexOf(item));
                this.Contacts.RemoveContact(index);
            }

            Utilities.ResetAllControls(this.infoContact);
            Utilities.ResetAllControls(this.newContact);
            // MessageBox.Show(this.Contacts.ListContacts());
        }

        private void ChangeInputFieldsReadOnlyStare(bool lockState)
        {
            this.firstNameInput.ReadOnly = lockState;
            this.lastNameInput.ReadOnly = lockState;
            this.birthDatePicker.Enabled = !lockState;
        }

        private void PopulateNewContactBoxFields()
        {
            var hypo = this.Contacts.GetPersonById(GetIndexFromSelectedContact());
            Utilities.ResetAllControls(this.newContact);
            this.firstNameInput.Text = hypo.FirstName;
            this.lastNameInput.Text = hypo.LastName;
            this.phoneInput.Text = hypo.Phone;
            this.emailInput.Text = hypo.Email;
            this.othersBox.Text = hypo.Others;
            this.birthDatePicker.Value = hypo.DateOfBirth;
        }

        private void InsertMockData()
        {
            var counter = 0;
            while (counter++ < 30)
            {
                var newContact = 
                    new Person
                        {
                            FirstName = "Mock",
                            LastName = $"Data {counter}",
                            Phone = "+40123456789",
                            Email = "mockData@domain.com",
                            DateOfBirth = DateTime.Today,
                            Others = "Contact for test."
                        };

                this.Contacts.AddContact(newContact);

                var person = new[] { $"{newContact.FirstName} {newContact.LastName}", newContact.Phone, counter.ToString() };
                var listView = new ListViewItem(person);
                this.contactsView.Items.Add(listView);
            }

        }

        private void ContactsViewColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.contactsView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

    }
}
