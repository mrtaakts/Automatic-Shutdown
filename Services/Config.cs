using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Services
{
    public class Config : IConfig
    {
        public MaterialSkinManager MaterialSetting(MaterialSkinManager materialSkinManager)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue400, Primary.Red900, Accent.Pink200, TextShade.WHITE);
            return materialSkinManager;
        }
        public string SwitchTheme(MaterialSkinManager materialSkinManager)
        {
            if (materialSkinManager.Theme is MaterialSkinManager.Themes.DARK)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                return "LIGHT";
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                return "DARK";
            }
        }
        public int ConvertTime(string hours, string minutes, string seconds)
        {
            int hour = int.Parse(hours);
            int minute = int.Parse(minutes);
            int second = int.Parse(seconds);
            int closingTime = hour * 3600 * 1000 + minute * 60 * 1000 + second * 1000;
            return closingTime;
        }
        public List<string[]> SetValueForComboboxes()
        {
            var singularObjects = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var multipleObjects = new List<string> { "1", "2", "3", "4", "5" };
            var hours = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
            var processTypes = new List<string> { "Shutdown", "Hibernate", "Suspend" };
            var minutes = singularObjects.ToList();
            var seconds = singularObjects.ToList();

            for (int i = 0; i < multipleObjects.Count; i++)
            {
                for (int j = 0; j < singularObjects.Count; j++)
                {
                    minutes.Add(multipleObjects[i] + singularObjects[j]);
                    seconds.Add(multipleObjects[i] + singularObjects[j]);
                }
            }
            return new List<string[]> { hours.ToArray(), minutes.ToArray(), seconds.ToArray(), processTypes.ToArray() };
        }
        public void SetDefaultValues(MaterialComboBox comboBox)
        {
            comboBox.Text = comboBox.Items[0].ToString();
        }
    }
}
