using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113120_Projekt
{
    internal class Task
    {
        public Task next; // next to n+1
        public Task previous; // previous to n-1
        private string taskTitle;
        private string taskDescription; //TODO dodać do konstruktora jako opcjonalny argument
        private string createDate; 
        private string taskStatus; //TODO zamienić na słownik
        private string taskPriority; //TODO zawęzić 1-6 , może słownik critical/highest/high/medium/low/lowest
        public Task(string title, string priority)
        {
            this.createDate = DateTime.Now.ToString("G");
            this.taskTitle = title;
            this.taskStatus = "TODO";
            this.taskPriority = priority;
        }
        public override string ToString() 
        {
            return "Tytuł     :"+taskTitle+"\n"+
                   "Priorytet :"+taskPriority+"\n"+
                   "Status    :"+taskStatus+"\n"+
                   "Utworzone :" +createDate+"\n";
        }
    }
}
