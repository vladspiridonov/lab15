using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace интерфейс
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    class ArithProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;

        public int SetStep(int x)
        {
            step = x;
            return step;
        }
        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;           
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
    class GeomProgression : ISeries
    {
        int startValue;
        int currentValue;
        int step;

        public int SetStep(int x)
        {
            step = x;
            return step;
        }
        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}
