using Automatic_Shutdown.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Reflection;
using Timer = System.Windows.Forms.Timer;

namespace Automatic_Shutdown
{
    public partial class Form1 : MaterialForm
    {
       
        public Form1(ITimerService timerService)
        {
            _timerService = timerService;
            InitializeComponent();
            MaterialSettings();
            //set value for combobox
            SetValueForComboboxes();
            SetDefaultValues();
        }

        #region Settings

        private MaterialSkinManager materialSkinManager;
        private readonly ITimerService _timerService;
        TimeSpan span = new TimeSpan();
        Timer timer2;
        Timer timer1;
        string process = "";
        double passingsecond = 0;
        double closingsecond = 0;
        int closingTime = 0;
        public void SetValueForComboboxes()
        {
            var singularObjects = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var multipleObjects = new List<string> { "1", "2", "3", "4", "5" };
            var hours = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
            var processTypes = new string[] { "Shutdown", "Hibernate", "Suspend" };
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

            hourComboBox.Items.AddRange(hours.ToArray());
            minuteComboBox.Items.AddRange(minutes.ToArray());
            secondComboBox.Items.AddRange(seconds.ToArray());
            processComboBox.Items.AddRange(processTypes);
        }

        public void SetDefaultValues()
        {
            processComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            hourComboBox.Text = hourComboBox.Items[0].ToString();
            minuteComboBox.Text = minuteComboBox.Items[0].ToString();
            secondComboBox.Text = secondComboBox.Items[0].ToString();
            processComboBox.Text = processComboBox.Items[0].ToString();

        }

        public void MaterialSettings()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue400, Primary.Red900, Accent.Pink200, TextShade.WHITE);

        }

        private void SetCountdownTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += OnCountdownEvent;
        }

        private void OnCountdownEvent(object? sender, EventArgs e)
        {
            span = span.Subtract(TimeSpan.FromSeconds(1));
            ProgressBar.Value = (int)Math.Ceiling(Convert.ToDecimal(passingsecond / closingsecond * 100));
            if (span.TotalSeconds > 0)
            {
                CountdownLabel.Text = span.ToString("hh\\:mm\\:ss");
                passingsecond = passingsecond + 1;
            }
            else
            {
                CountdownLabel.Text = "00:00:00";
            }
        }
        private void SetTimer(int closingTime)
        {
            timer2 = new Timer();
            timer2.Interval = closingTime;
            timer2.Enabled = true;
            timer2.Tick += OnTimerEvent;
        }

        private void OnTimerEvent(object? sender, EventArgs e)
        {
            _timerService.SelectProcess(process);
        }


        #endregion

        private void timerButton_Click(object sender, EventArgs e)
        {
            var validationResult = _timerService.CheckTimerVariables(hourComboBox.Text, minuteComboBox.Text, secondComboBox.Text);
            if (validationResult.Status)
            {
                hourComboBox.Enabled = false;
                minuteComboBox.Enabled = false;
                secondComboBox.Enabled = false;
                processComboBox.Enabled = false;
                timerButton.Enabled= false;
                cancelButton.Enabled= true;
                // Required Variables Setted 
                int hour = Int32.Parse(hourComboBox.Text);
                int minute = Int32.Parse(minuteComboBox.Text);
                int second = Int32.Parse(secondComboBox.Text);
                process = processComboBox.Text;
                closingTime = hour * 3600 * 1000 + minute * 60 * 1000 + second * 1000; // just math
                closingsecond = closingTime / 1000;
                span = TimeSpan.FromMilliseconds(closingTime);

                if (closingTime > 0)
                {
                    SetCountdownTimer(); // timer event for Countdown
                    SetTimer(closingTime); // timer event for process

                }
            }
            else MessageBox.Show(validationResult.ErrorMessage);
        }

       
        private void cancelButton_Click(object sender, EventArgs e)
        {
            hourComboBox.Enabled = true;
            minuteComboBox.Enabled = true;
            secondComboBox.Enabled = true;
            processComboBox.Enabled = true;
            timerButton.Enabled = true;
            cancelButton.Enabled = false;
            ProgressBar.Value = 0;
            passingsecond = 0;
            CountdownLabel.Text = "00:00:00";
            span = new TimeSpan();
            timer1.Dispose();
            timer2.Dispose();
        }
    }
}