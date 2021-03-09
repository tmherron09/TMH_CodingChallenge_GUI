using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMHCodingChallengeHostGUI
{
    public class NewYearsChaos
    {
        private int[] _originalQueue;
        private int[] _finalQueue;

        public int[] OriginalQueue
        {
            get
            {
                if (_originalQueue != null)
                {
                    return _originalQueue;
                }
                else if (_finalQueue != null)
                {
                    PopulateOriginalQueueStandard(_finalQueue.Length);
                    return _originalQueue;
                }
                return null;
            }
            set
            {
                if (_finalQueue == null)
                {
                    _originalQueue = value;
                    _finalQueue = new int[value.Length];
                }
                else if (value.Length == _finalQueue.Length)
                {
                    // Replace original queue but keep newQueue Value
                    // For Practice not Practicality.
                    // All, I am open for Work, feel free to contact me for Employment
                    // Email- tmherron09@gmail.com
                    // Visit timherron.dev  For more into. Or view other comments more Self Promotion!
                    _originalQueue = value;
                }
                else
                {
                    _originalQueue = value;
                    // Add Debug Comment here to denote _newQueue is being overwritten.
                    _finalQueue = new int[_originalQueue.Length];
                }
            }
        }
        public int[] FinalQueue
        {
            get
            {
                return _finalQueue;
            }
            set
            {
                _finalQueue = value;
                if (_originalQueue == null || value.Length != _originalQueue.Length)
                {
                    // TODO: Add Debug denoting overwritting of original Queue.
                    _originalQueue = Enumerable.Range(1, value.Length).ToArray();
                }
            }
        }
        // Should now be redundant but still check.
        public bool IsValid
        {
            get
            {
                return OriginalQueue.Length == FinalQueue.Length;
            }
        }
        public int QueueLength
        {
            get
            {
                if (IsValid)
                {
                    return OriginalQueue.Length;
                }
                return -1;
            }
        }
        public string Answer
        {
            get
            {
                return CalculateBribes();
            }
        }

        public NewYearsChaos(int[] finalQueue)
        {
            FinalQueue = finalQueue;

        }

        public NewYearsChaos(int[] originalQueue, int[] finalQueue)
        {
            OriginalQueue = originalQueue;
            FinalQueue = finalQueue;
        }

        public void PopulateOriginalQueueStandard(int length)
        {
            OriginalQueue = Enumerable.Range(1, length).ToArray();
        }
        public string CalculateBribes()
        {
            if (!IsValid)
            {
                return "Invalid Queues.";
            }
            string result = "";
            int bribeCount = 0; ;
            int[] queueState = OriginalQueue;

            for (int i = QueueLength; i > 0; i--)
            {
                int placeInLine = Array.IndexOf(queueState, FinalQueue[i - 1]);
                int change = (i + 1) - placeInLine;
                if (change > 2)
                {
                    result = "Too Chaotic";
                }
                else if (change > 0)
                {
                    bribeCount += change;
                }

            }

            return "Not implemented.";
        }


        public int[] QueueStateUpdate(int[] queueState, int index, int change)
        {
            if (change! > 0)
            {
                return queueState;
            }
            while (change > 0)
            {
                int temp = queueState[index];
                queueState[index] = queueState[index - 1];
                queueState[index - 1] = temp;
                change--;
            }

            return queueState;
        }

    }
}
