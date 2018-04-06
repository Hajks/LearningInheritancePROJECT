using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritancePROJECT
{
    public class Queen
    {
        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber;
        public bool AssignWork(string job, int shiftsToWork)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(job, shiftsToWork))
                    return true;
            }
            return false;
        }
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string report = "Raport zmiany numer " + shiftNumber + ".\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Robotnica numer " + (i + 1) + " aktualnie nie pracuje.\r\n";
                else
                    if(workers[i].ShiftsLeft == 0)
                    report += "Robotnica numer " + (i + 1) + " zakończy " + "'" + workers[i].CurrentJob + "'" + " po tej zmianie. \r\n";              
                else
                     if (workers[i].ShiftsLeft > 0)
                    report += "Robotnica numer " + (i + 1) + " robi " + "'" + workers[i].CurrentJob + "'" + " jeszcze przez " + workers[i].ShiftsLeft + " zmiany. \r\n";
        


            }
            return report;
        }
        
    }
}
