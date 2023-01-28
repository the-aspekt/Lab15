using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    internal class ArithProgression : ISeries
    {
        public int Start { get; set; }
        public int Step { get; set; }
        public int CurrentValue { get; set; }
        public int GetNext()
        {
            CurrentValue += Step;
            return CurrentValue;
        }
        public ArithProgression(int initial, int step)
        {
            Start = initial;
            CurrentValue = initial;
            Step = step;
        }
        public ArithProgression()
        {
        }

        public void Reset()
        {
            CurrentValue = Start;
        }

        public void SetStart(int x)
        {
            Start= x;
        }
    }
    internal class GeomProgression : ISeries
    {
        public int Start { get; set; }
        public int Step { get; set; }
        public int CurrentValue { get; set; }
        public int GetNext()
        {
            CurrentValue *= Step;
            return CurrentValue;
        }
        public GeomProgression(int initial, int step)
        {
            Start = initial;
            CurrentValue = initial;
            Step = step;
        }
        public GeomProgression()
        {
        }

        public void Reset()
        {
            CurrentValue = Start;
        }

        public void SetStart(int x)
        {
            Start = x;
        }
    }

}
