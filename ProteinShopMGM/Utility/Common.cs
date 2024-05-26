using ProteinShopMGM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static ProteinShopMGM.Utility.Common;

namespace ProteinShopMGM.Utility
{
    /// <summary>
    /// All common supporting functionalities are defined here.
    /// </summary>
    public static class Common
    {
        public class LoggedInUser
        {
            public Guid UserId { get; set; }
            public string Username { get; set; }
            public DateTime LoggedInDateTime { get; set; }
        }

        public struct STATUSCODES
        {
            // Compare this with 'statusbit' field in database.
            public const int STATUS_ACTIVE = 1; // Status code for the Active record.
            public const int STATUS_DELETED = 2; // Status code for the Deleted record.
            public const int STATUS_OBSOLETE = 3; // Status code for the obsolete record.
        }

        public struct SUPPLIERTYPES
        {
            public const int COMPANY = 1;
            public const int DISTRIBUTER = 2;

            public static string GetText(int suppliertype)            
            {
                string value = string.Empty;

                switch (suppliertype)
                {
                    case 1:
                        value = "Company";
                        break;
                    case 2:
                        value = "Distributor";
                        break;
                }

                return value;
            }

            public static List<KeyValuePair<int, string>> GetList()
            {
                List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

                KeyValuePair<int, string> value = new KeyValuePair<int, string>(COMPANY, GetText(COMPANY));
                list.Add(value);
                value = new KeyValuePair<int, string>(DISTRIBUTER, GetText(DISTRIBUTER));
                list.Add(value);

                return list;
            }
        }

        public struct CUSTOMERTYPES
        {
            public const int TRAINER = 1;
            public const int REGULAR = 2;

            public static string GetText(int customertype)
            {
                string value = string.Empty;

                switch (customertype)
                {
                    case 1:
                        value = "Trainer";
                        break;
                    case 2:
                        value = "Regular";
                        break;
                }

                return value;
            }

            public static List<KeyValuePair<int, string>> GetList()
            {
                List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

                KeyValuePair<int, string> value = new KeyValuePair<int, string>(TRAINER, GetText(TRAINER));
                list.Add(value);
                value = new KeyValuePair<int, string>(REGULAR, GetText(REGULAR));
                list.Add(value);

                return list;
            }
        }

        public struct PURCHASESTATUS
        {
            public const int INPROCESS = 1;
            public const int RECEIVED = 2;
            public const int CANCELLED = 3;

            public static string GetText(int puchaseStatus)
            {
                string value = string.Empty;

                switch (puchaseStatus)
                {
                    case 1:
                        value = "In Process";
                        break;
                    case 2:
                        value = "Received";
                        break;
                    case 3:
                        value = "Cancelled";
                        break;
                }

                return value;
            }

            public static bool IsMember(int status)
            {
                bool returnValue = false;

                switch (status)
                {
                    case 1:
                    case 2:
                    case 3:
                        returnValue = true;
                        break;
                }

                return returnValue;
            }

            public static List<KeyValuePair<int, string>> GetList()
            {
                List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

                KeyValuePair<int, string> value = new KeyValuePair<int, string>(INPROCESS, GetText(INPROCESS));
                list.Add(value);
                value = new KeyValuePair<int, string>(RECEIVED, GetText(RECEIVED));
                list.Add(value);
                value = new KeyValuePair<int, string>(CANCELLED, GetText(CANCELLED));
                list.Add(value);

                return list;
            }
        }

        /// <summary>
        /// All validation related common tasks are defined here.
        /// </summary>
        public static class Validation
        {
            public static bool IsNotEmpty(string value)
            {
                return value != null && value.Trim() != string.Empty;
            }

            public static bool IsNotEmpty(TextBox textBox)
            {
                return textBox != null && textBox.Text.Trim() != string.Empty;
            }

            public static bool IsValidContactNumber(string contactNumber)
            {
               
                Regex pattern = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
                return IsNotEmpty(contactNumber) && pattern.IsMatch(contactNumber) && contactNumber.Length >=10;
               
            }     
            
        }

        public static class Utility
        {
            /// <summary>
            /// This method will clear or reset all the controls in the given form.
            /// </summary>
            /// <param name="panel"></param>
            public static void ResetControls(Panel panel)
            {
                // Validate.
                if (panel == null)
                {
                    return;
                }

                // Reset all textboxes if any.
                List<TextBox> textBoxes = panel.Controls.OfType<TextBox>().ToList();
                if (textBoxes.Any())
                {
                    foreach (TextBox textBox in textBoxes)
                    {
                        textBox.Text = string.Empty;
                    }
                }

                // Reset all comboboxes if any.
                List<ComboBox> comboBoxes = panel.Controls.OfType<ComboBox>().ToList();
                if (comboBoxes.Any())
                {
                    foreach (ComboBox comboBox in comboBoxes)
                    {
                        if (comboBox.Items.Count > 0)
                        {
                            comboBox.SelectedIndex = 0;
                        }
                    }
                }

                // Reset all date pickers if any.
                List<DateTimePicker> dateTimePickers = panel.Controls.OfType<DateTimePicker>().ToList();
                if (dateTimePickers.Any())
                {
                    foreach (DateTimePicker dateTimePicker in dateTimePickers)
                    {
                        dateTimePicker.Value = DateTime.Now;
                    }
                }

                // Similarly do the same for other types of controls if any.
            }

            public static string ConvertToString(object obj)
            {
                return obj == null ? string.Empty : obj.ToString();
            }

            public static int ConvertToInt(object obj) 
            {
                return obj == null ? throw new ArgumentNullException() : Int32.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// This structure specifies the commonly used strings in the system. 
        /// </summary>
        public struct STRINGS
        {
            public const string VALIDATION_ERROR = "Validation Error";
            public const string AUTH_ERROR = "Auth Failed";
            public const string SAVE_ERROR = "Error on Save";
            public const string SAVE_ERROR_MESSAGE = "Something went wrong while saving the data.";
            public const string SAVED = "Saved";
            public const string DELETE_ERROR = "Error on Delete";
            public const string DELETE_ERROR_MESSAGE = "Something went wrong while deleting the data.";
            public const string DELETED = "Deleted";
        }
    }
}
