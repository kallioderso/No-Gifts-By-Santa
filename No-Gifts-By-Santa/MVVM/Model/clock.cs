using Task = System.Threading.Tasks.Task;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace No_Gifts_By_Santa.MVVM.Model
{
    public class clock
    {
        public int _hours;
        public int _minutes;
        private bool _isPaused;

        public clock()
        {
            _hours = 9;
            _minutes = 0;
        }

        public void StartClock()
        {
            _isPaused = false;
            Task.Run(TimeLoop);
        }
        public void PauseClock() { _isPaused = true; }
        public void ResumeClock() { _isPaused = false; }

        private async Task TimeLoop()
        {
            while(_hours < 20 || _minutes != 0)
            {
                await Task.Delay(4000);
                if (!_isPaused)
                {
                    if (_minutes == 55)
                    { 
                        _hours++;
                        _minutes = 00; 
                    }
                    else
                        _minutes += 5;
                }
            }
        }
    }
}