using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Services
{
    public interface IConfig
    {
        MaterialSkinManager MaterialSetting(MaterialSkinManager materialSkinManager);
        string SwitchTheme(MaterialSkinManager materialSkinManager);
        int ConvertTime(string hours, string minutes, string seconds);
        List<string[]> SetValueForComboboxes();
        void SetDefaultValues(MaterialComboBox comboBox);
    }
}
