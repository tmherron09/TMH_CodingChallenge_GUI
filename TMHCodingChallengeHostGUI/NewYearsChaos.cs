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
                return CalculateBribesGeneric();
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
        // Used when assumed Line starts in numerical order.
        public string CalculateBribesGeneric()
        {
            if (!IsValid)
            {
                return "Invalid Queues.";
            }
            string result = "";
            int bribeCount = 0; ;
            for (int i = 0; i < QueueLength - 1; i++)
            {
                int chaoticCount = 0;
                for (int j = i + 1; j < QueueLength; j++)
                {
                    if (FinalQueue[i] > FinalQueue[j])
                    {
                        bribeCount++;
                        chaoticCount++;
                    }
                }
                if (chaoticCount > 2)
                {
                    result = "Too Chaotic ";
                }
            }

            result += $"Total Bribes: {bribeCount}";

            return result;
        }

        public string CalculateBribesOptimized()
        {

            if (!IsValid)
            {
                return "Invalid Queues.";
            }
            string result = "";
            int bribeCount = 0;
            for (int i = 0; i < FinalQueue.Length; i++)
            {
                if(FinalQueue[i] - (i + 1) > 2)
                { 
                    result = "Too Chaotic ";
                }
                for (int j = FinalQueue[i] - 2; j < i ; j++)
                {
                    
                    if (FinalQueue[j] > FinalQueue[i])
                    {
                        bribeCount++;
                    }
                }
            }

            result += $"Total Bribes: {bribeCount}";

            return result;

        }


        public int[] QueueStateUpdate(int[] queueState, int index, int change)
        {
            while (change > 0)
            {
                int temp = queueState[index];
                queueState[index] = queueState[index - 1];
                queueState[index - 1] = temp;
                index--;
                change--;
            }
            return queueState;
        }

    }
}
