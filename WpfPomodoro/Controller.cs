using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WpfPomodoro
{
    class Controller : ObservableObject
    {
        private Timer _timer;
        private DateTime _startTime;
        private string _formattedTime = "00:00";
        private bool _timerStarted = false;

        /// <summary>
        /// Code to start the timer when the user presses the Start button.
        /// </summary>
        public void Start()
        {
            if (!_timerStarted)
            {
                _timerStarted = true;
                _startTime = DateTime.Now;
                _timer = new Timer(1000); // 1000ms
                _timer.Elapsed += timer_Elapsed;
                _timer.Enabled = true;
            }
        }

        public void Stop()
        {
            // write testable code
        }

        public void Reset()
        {
            // write testable code
        }

        public string FormattedTime
        {
            get { return _formattedTime; }            
        }

        public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan timeSinceStart = DateTime.Now - _startTime;
            _formattedTime = timeSinceStart.ToString(@"mm\:ss");
            OnPropertyChanged("FormattedTime");
        }
    }
}
