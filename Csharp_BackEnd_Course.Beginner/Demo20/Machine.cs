using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Example7._1._2
{
    public delegate void TempChanged(double prev, double current);

    public class Machine
    {
        private double _currentTemp = 36;
        private TempChanged _tempChanged;

        public double CurrentTemp
        {
            get
            {
                return _currentTemp;
            }
            set
            {
                if (_currentTemp != value)
                {
                    var prev = _currentTemp;
                    _currentTemp = value;
                    OnTempChanged(prev, value);
                }
            }
        }

        public void TurnOn()
        {
            while (CurrentTemp < 100)
            {
                Thread.Sleep(1000);
                CurrentTemp++;
            }
        }

        public void RegisterTempWatcher(TempChanged watcher)
        {
            _tempChanged += watcher;
        }

        private void OnTempChanged(double prev, double current)
        {
            if(_tempChanged != null)
            {
                _tempChanged(prev, current);
            }
        }

    }
}
