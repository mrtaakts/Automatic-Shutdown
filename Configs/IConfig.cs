using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Shutdown.Configs
{
    public interface IConfig
    {
        MaterialSkinManager MaterialSetting(MaterialSkinManager materialSkinManager);
        string SwitchTheme(MaterialSkinManager materialSkinManager);
        int ConvertTime(string hours, string minutes, string seconds);
        List<string[]> SetValueForComboboxes();
        void SetDefaultValues(MaterialComboBox comboBox);
        (TimeSpan, double) CountDown(TimeSpan span, ProgressBar bar, double passingsecond, double closingsecond, MaterialLabel label);
    }
}
