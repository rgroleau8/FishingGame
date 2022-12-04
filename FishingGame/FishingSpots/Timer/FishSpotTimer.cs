using System.Timers;

namespace FishingGame.FishingSpots
{
    public class FishSpotTimer : IFishSpotTimer
    {
        /// <summary>
        /// Timer doesnt need to fire repeated events because a new instance is created each time, so autoreset is always set to false
        /// The interval of the timer is different each time
        /// </summary>
        private System.Timers.Timer _activeTimer = new System.Timers.Timer();
        private System.Timers.Timer _deactivatedTimer = new System.Timers.Timer();


        private int _activeMin;
        private int _activeMax;
        private int _deactiveMin;
        private int _deactiveMax;

        public FishSpotTimer()
        {
            
            
        }

        public void SetupAndStart(int activeMinTime, int activeMaxTime, int deactiveMinTime, int deactiveMaxTime)
        {
            _activeMin = activeMinTime;
            _activeMax = activeMaxTime;
            _deactiveMin = deactiveMinTime;
            _deactiveMax = deactiveMaxTime;

            _activeTimer = SetUpTimer(_activeMin, _activeMax, ActiveTimerElapsedEvent);

            _activeTimer.Start();
        }



        

        public bool IsAFishingSpotAvailable()
        {
            if (_activeTimer != null)
            {
                if (_activeTimer.Enabled == false)
                {
                    return false;
                }
                return true;
            }

            return false;
        }

        private System.Timers.Timer SetUpTimer(int minTime, int maxTime, ElapsedEvent elapsedEvent)
        {
            System.Timers.Timer output = new System.Timers.Timer();


            output.Interval = getRandomInterval(minTime, maxTime);

            output.Elapsed += elapsedEvent.Invoke;

            output.Enabled = true;

            output.AutoReset = false;

            return output;
        }

        private int getRandomInterval(int min, int max)
        {

            Random random = new Random();

            int output = random.Next(min, max);

            return output;

        }

        #region "Elapsed Delagate"

        public delegate void ElapsedEvent(Object source, System.Timers.ElapsedEventArgs e);

        #endregion


        #region "Timer Elapsed Event"

        private void ActiveTimerElapsedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            _activeTimer.Stop();

            _activeTimer.Enabled = false;

            _deactivatedTimer.Dispose();

            _deactivatedTimer = SetUpTimer(_deactiveMin, _deactiveMax, DeactiveTimerElapsedEvent);

            _deactivatedTimer.Start();

        }

        private void DeactiveTimerElapsedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {

            _deactivatedTimer.Stop();

            _deactivatedTimer.Enabled = false;

            _activeTimer.Dispose();

            _activeTimer = SetUpTimer(_activeMin, _activeMax, ActiveTimerElapsedEvent);

            _activeTimer.Start();

        }

        #endregion



    }
}
