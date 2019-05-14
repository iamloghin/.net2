namespace PersonalAgenda.Common
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public class Utilities
    {
        public static void ResetAllControls(GroupBox form)
        {
            foreach (Control control in form.Controls)
            {
                switch (control)
                {
                    case TextBox textBox1:
                        textBox1.Text = null;
                        break;
                    case DateTimePicker timePicker:
                        timePicker.ResetText();
                        break;
                    case ListBox listBox:
                        listBox.ClearSelected();
                        break;
                    case RichTextBox textBox2:
                        textBox2.Clear();
                        break;
                }
            }
        }
        
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                try
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    return (T)binaryFormatter.Deserialize(stream);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}
