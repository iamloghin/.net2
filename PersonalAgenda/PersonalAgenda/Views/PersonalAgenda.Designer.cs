namespace PersonalAgenda.Views
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    partial class PersonalAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static Dictionary<Type, Action<Control>> allContactInputFields = 
            new Dictionary<Type, Action<Control>>()
                {
                    {typeof(TextBox), c => ((TextBox)c).Clear()}
                };
            
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsBox = new System.Windows.Forms.GroupBox();
            this.contactsView = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newContact = new System.Windows.Forms.GroupBox();
            this.removeContact = new System.Windows.Forms.Button();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.othersBox = new System.Windows.Forms.RichTextBox();
            this.othersLabel = new System.Windows.Forms.Label();
            this.resetFields = new System.Windows.Forms.Button();
            this.saveContact = new System.Windows.Forms.Button();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameInput = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.infoContact = new System.Windows.Forms.GroupBox();
            this.moreInfoBox = new System.Windows.Forms.RichTextBox();
            this.contactsBox.SuspendLayout();
            this.newContact.SuspendLayout();
            this.infoContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsBox
            // 
            this.contactsBox.Controls.Add(this.contactsView);
            this.contactsBox.Location = new System.Drawing.Point(12, 12);
            this.contactsBox.Name = "contactsBox";
            this.contactsBox.Size = new System.Drawing.Size(317, 426);
            this.contactsBox.TabIndex = 2;
            this.contactsBox.TabStop = false;
            this.contactsBox.Text = "Contacts";
            // 
            // contactsView
            // 
            this.contactsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsView.BackColor = System.Drawing.SystemColors.Control;
            this.contactsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.Phone});
            this.contactsView.FullRowSelect = true;
            this.contactsView.GridLines = true;
            this.contactsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contactsView.Location = new System.Drawing.Point(3, 16);
            this.contactsView.Name = "contactsView";
            this.contactsView.Size = new System.Drawing.Size(311, 407);
            this.contactsView.TabIndex = 0;
            this.contactsView.UseCompatibleStateImageBehavior = false;
            this.contactsView.View = System.Windows.Forms.View.Details;
            this.contactsView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.ContactsViewColumnWidthChanging);
            this.contactsView.Click += new System.EventHandler(this.ContactsViewSelected);
            this.contactsView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactsViewSelected);
            this.contactsView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ContactsViewSelected);
            // 
            // fullName
            // 
            this.fullName.Text = "Name";
            this.fullName.Width = 190;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // newContact
            // 
            this.newContact.Controls.Add(this.removeContact);
            this.newContact.Controls.Add(this.phoneInput);
            this.newContact.Controls.Add(this.phoneLabel);
            this.newContact.Controls.Add(this.othersBox);
            this.newContact.Controls.Add(this.othersLabel);
            this.newContact.Controls.Add(this.resetFields);
            this.newContact.Controls.Add(this.saveContact);
            this.newContact.Controls.Add(this.emailInput);
            this.newContact.Controls.Add(this.emailLabel);
            this.newContact.Controls.Add(this.birthDateLabel);
            this.newContact.Controls.Add(this.birthDatePicker);
            this.newContact.Controls.Add(this.lastNameInput);
            this.newContact.Controls.Add(this.lastNameLabel);
            this.newContact.Controls.Add(this.firstNameInput);
            this.newContact.Controls.Add(this.firstNameLabel);
            this.newContact.Location = new System.Drawing.Point(335, 146);
            this.newContact.Name = "newContact";
            this.newContact.Size = new System.Drawing.Size(281, 292);
            this.newContact.TabIndex = 3;
            this.newContact.TabStop = false;
            this.newContact.Text = "Add Contact";
            // 
            // removeContact
            // 
            this.removeContact.Location = new System.Drawing.Point(6, 263);
            this.removeContact.Name = "removeContact";
            this.removeContact.Size = new System.Drawing.Size(60, 23);
            this.removeContact.TabIndex = 18;
            this.removeContact.Text = "Remove";
            this.removeContact.UseVisualStyleBackColor = true;
            this.removeContact.Click += new System.EventHandler(this.RemoveContactClick);
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.SystemColors.Control;
            this.phoneInput.Location = new System.Drawing.Point(75, 71);
            this.phoneInput.MaxLength = 25;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(200, 20);
            this.phoneInput.TabIndex = 9;
            this.phoneInput.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneInputValidating);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(10, 74);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone:";
            // 
            // othersBox
            // 
            this.othersBox.BackColor = System.Drawing.SystemColors.Control;
            this.othersBox.Location = new System.Drawing.Point(75, 152);
            this.othersBox.MaxLength = 1000;
            this.othersBox.Name = "othersBox";
            this.othersBox.Size = new System.Drawing.Size(200, 90);
            this.othersBox.TabIndex = 15;
            this.othersBox.Text = "";
            // 
            // othersLabel
            // 
            this.othersLabel.AutoSize = true;
            this.othersLabel.Location = new System.Drawing.Point(10, 152);
            this.othersLabel.Name = "othersLabel";
            this.othersLabel.Size = new System.Drawing.Size(41, 13);
            this.othersLabel.TabIndex = 14;
            this.othersLabel.Text = "Others:";
            // 
            // resetFields
            // 
            this.resetFields.Location = new System.Drawing.Point(217, 263);
            this.resetFields.Name = "resetFields";
            this.resetFields.Size = new System.Drawing.Size(58, 23);
            this.resetFields.TabIndex = 17;
            this.resetFields.Text = "Reset";
            this.resetFields.UseVisualStyleBackColor = true;
            this.resetFields.Click += new System.EventHandler(this.ResetFieldsClick);
            // 
            // saveContact
            // 
            this.saveContact.Location = new System.Drawing.Point(72, 263);
            this.saveContact.Name = "saveContact";
            this.saveContact.Size = new System.Drawing.Size(139, 23);
            this.saveContact.TabIndex = 16;
            this.saveContact.Text = "Save Contact";
            this.saveContact.UseVisualStyleBackColor = true;
            this.saveContact.Click += new System.EventHandler(this.SaveContactClick);
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.SystemColors.Control;
            this.emailInput.Location = new System.Drawing.Point(75, 123);
            this.emailInput.MaxLength = 50;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(200, 20);
            this.emailInput.TabIndex = 13;
            this.emailInput.Validating += new System.ComponentModel.CancelEventHandler(this.EmailInputValidating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(9, 126);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(9, 101);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(57, 13);
            this.birthDateLabel.TabIndex = 10;
            this.birthDateLabel.Text = "Birth Date:";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.birthDatePicker.Location = new System.Drawing.Point(75, 97);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePicker.TabIndex = 11;
            this.birthDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDateValidating);
            // 
            // lastNameInput
            // 
            this.lastNameInput.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameInput.Location = new System.Drawing.Point(75, 45);
            this.lastNameInput.MaxLength = 25;
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(200, 20);
            this.lastNameInput.TabIndex = 7;
            this.lastNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.NameInputValidating);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(9, 48);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameInput
            // 
            this.firstNameInput.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameInput.Location = new System.Drawing.Point(75, 19);
            this.firstNameInput.MaxLength = 25;
            this.firstNameInput.Name = "firstNameInput";
            this.firstNameInput.Size = new System.Drawing.Size(200, 20);
            this.firstNameInput.TabIndex = 5;
            this.firstNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.NameInputValidating);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name:";
            // 
            // infoContact
            // 
            this.infoContact.Controls.Add(this.moreInfoBox);
            this.infoContact.Location = new System.Drawing.Point(335, 12);
            this.infoContact.Name = "infoContact";
            this.infoContact.Size = new System.Drawing.Size(281, 128);
            this.infoContact.TabIndex = 4;
            this.infoContact.TabStop = false;
            this.infoContact.Text = "More Info:";
            // 
            // moreInfoBox
            // 
            this.moreInfoBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moreInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moreInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moreInfoBox.Location = new System.Drawing.Point(3, 16);
            this.moreInfoBox.Name = "moreInfoBox";
            this.moreInfoBox.ReadOnly = true;
            this.moreInfoBox.Size = new System.Drawing.Size(275, 109);
            this.moreInfoBox.TabIndex = 0;
            this.moreInfoBox.Text = "";
            // 
            // PersonalAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 448);
            this.Controls.Add(this.infoContact);
            this.Controls.Add(this.newContact);
            this.Controls.Add(this.contactsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonalAgenda";
            this.Text = "Personal Agenda - Laboratorul 1";
            this.Closed += new System.EventHandler(this.MainViewClosed);
            this.Load += new System.EventHandler(this.MainViewLoaded);
            this.contactsBox.ResumeLayout(false);
            this.newContact.ResumeLayout(false);
            this.newContact.PerformLayout();
            this.infoContact.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label birthDateLabel;
        private Label emailLabel;
        private Label othersLabel;
        private GroupBox contactsBox;
        private GroupBox newContact;
        private TextBox lastNameInput;
        private TextBox firstNameInput;
        private TextBox emailInput;
        private DateTimePicker birthDatePicker;
        private Button resetFields;
        private Button saveContact;
        private RichTextBox othersBox;
        private GroupBox infoContact;
        private TextBox phoneInput;
        private Label phoneLabel;
        private ListView contactsView;
        private ColumnHeader fullName;
        private ColumnHeader Phone;
        private Button removeContact;
        private RichTextBox moreInfoBox;
    }
}

