using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInheritancePROJECT
{
    public class Worker: Bee
    {
        public Worker (string[] jobsICanDo, double weightMg): base(weightMg) // So we got constructor with string array which containt what kind of job our bee worker is able to do.
        {
            this.jobsICanDo = jobsICanDo;
        }
        const double honeyConsumptionPerShift = .65; // we add const honeyConsumption;
        private int shiftsToWork; //We use encapsulation, to let our program work properly.
        private int shiftsWorked;
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
            
        }
        

        private string[] jobsICanDo;
        public bool DoThisJob(string job, int shiftsToWork) //So if our job match to workers job possibilities and worker is not working currently it will assign new work to him/her
        {
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (job == jobsICanDo[i] && String.IsNullOrEmpty(CurrentJob))
                {
                    currentJob = job;
                    this.shiftsToWork = shiftsToWork;
                    return true;
                }               
            }
            return false;
        }
        public bool DidYouFinish() //If worker bee finished her job it will return true, if not it will rise shiftsWorked and returns false
        {
            if (ShiftsLeft == 0)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftsWorked = 0;
                return true;
            }
            else
                shiftsWorked++;
                return false;
        }
        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyConsumptionPerShift;
            return consumption;
        }

    }
}
