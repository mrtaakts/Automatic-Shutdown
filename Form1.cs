using MaterialSkin;
using MaterialSkin.Controls;
using SharedLibrary.Models.Enums;
using SharedLibrary.Services;
using Timer = System.Windows.Forms.Timer;

namespace Automatic_Shutdown
{
    public partial class Form1 : MaterialForm
    {

        public Form1(ITimerService timerService, IConfig config)
        {
            _timerService = timerService;
            _config = config;
            InitializeComponent();
            Material_Settings();
            //set value for combobox
            SetValueForComboboxes();
            SetDefaultValues();

        }

        #region Settings
        private IConfig _config;
        private MaterialSkinManager materialSkinManager;
        private readonly ITimerService _timerService;
        TimeSpan span = new TimeSpan();
        Timer timer2;
        Timer timer1;
        ProcessName process ;
        double passingsecond = 0;
        double closingsecond = 0;
        public void SetValueForComboboxes()
        {
            var lists = _config.SetValueForComboboxes();
            hourComboBox.Items.AddRange(lists[0]);
            minuteComboBox.Items.AddRange(lists[1]);
            secondComboBox.Items.AddRange(lists[2]);
            processComboBox.Items.AddRange(lists[3]);
        }

        public void SetDefaultValues()
        {
            _config.SetDefaultValues(hourComboBox);
            _config.SetDefaultValues(minuteComboBox);
            _config.SetDefaultValues(secondComboBox);
            _config.SetDefaultValues(processComboBox);
        }

        public void Material_Settings()
        {
            materialSkinManager = _config.MaterialSetting(materialSkinManager);
            materialSkinManager.AddFormToManage(this);
        }

        private void ButtonEnable()
        {
            hourComboBox.Enabled = false;
            minuteComboBox.Enabled = false;
            secondComboBox.Enabled = false;
            processComboBox.Enabled = false;
            timerButton.Enabled = false;
            cancelButton.Enabled = true;
        }

        private void ButtonDisable()
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

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            materialSwitch1.Text = _config.SwitchTheme(materialSkinManager);
        }
        private void SetCountdownTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += OnCountdownEvent;
        }
        private void SetTimer(int closingTime)
        {
            timer2 = new Timer();
            timer2.Interval = closingTime;
            timer2.Enabled = true;
            timer2.Tick += OnTimerEvent;
        }

        #endregion

        private void OnCountdownEvent(object? sender, EventArgs e)
        {
            (span, passingsecond) = _timerService.CountDown(span, ProgressBar, passingsecond, closingsecond, CountdownLabel);
        }

        private void OnTimerEvent(object? sender, EventArgs e)
        {
           string result = _timerService.SelectProcess(process);
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            var validationResult = _timerService.CheckTimerVariables(hourComboBox.Text, minuteComboBox.Text, secondComboBox.Text);
            if (validationResult.Status)
            {
                ButtonEnable();
                process = (ProcessName)Enum.Parse(typeof(ProcessName), processComboBox.Text);
                int closingTime = _config.ConvertTime(hourComboBox.Text, minuteComboBox.Text, secondComboBox.Text); // just math
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
            ButtonDisable();
        }


    }
}