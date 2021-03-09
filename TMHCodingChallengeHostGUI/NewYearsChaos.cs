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
        private int[] _newQueue;

        public int[] OriginalQueue { 
           get 
            {
                return _originalQueue;
                } 
            set
            {
                if(value.Length == _newQueue.Length)
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
                    _newQueue = new int[_originalQueue.Length];
                }
            }
        }
        public int[] NewQueue { 
            get
            {
                return _newQueue;
            }
            set
            {
                _newQueue = value;
                if(value.Length != _originalQueue.Length)
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
                return OriginalQueue.Length == NewQueue.Length;
            }
        }
        public int QueueLength
        {
            get
            {
                if(IsValid)
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


        public NewYearsChaos(int[] originalQueue, int[] newQueue)
        {
            OriginalQueue = originalQueue;
            NewQueue = newQueue;
        }

        public string CalculateBribes()
        {
            if(!IsValid)
            {
                return "Invalid Queues.";
            }
            string result = "";
            int bribeCount = 0; ;
            int[] queueState = OriginalQueue;

            for(int i = QueueLength; i > 0 ; i--)
            {
                int placeInLine = Array.IndexOf(queueState, NewQueue[i-1]);
                int change = (i + 1) - placeInLine;
                if(change > 2)
                {
                    result = "Too Chaotic";
                } else if(change > 0)
                {
                    bribeCount += change;
                }
                
            }

            return "Not implemented.";
        }
        

        public int[] QueueStateUpdate(int[] queueState, int index, int change)
        {
            if(change !> 0)
            {
                return queueState;
            }
            while(change > 0)
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
