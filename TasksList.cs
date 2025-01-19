using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
// next = n+1, previous = n-1
namespace _113120_Projekt
{
    internal class TasksList
    {
        public Task firstTask;
        public Task lastTask;
        private int numberOfTasks;
    
        public TasksList() 
        {
            this.firstTask = null;
            this.lastTask = null;
            numberOfTasks = 0;
        }

        public void addTaskAsLastElement(string title, string priority)
        {
            Task taskToAdd = new Task(title, priority);



            if (this.numberOfTasks == 0)
            {
                this.firstTask = taskToAdd;
                this.lastTask = taskToAdd;
                this.firstTask.previous = null;
                this.lastTask.next = null;
            }
            else 
            {
                taskToAdd.previous = this.lastTask;
                this.lastTask.next = taskToAdd;
                this.lastTask = taskToAdd;
            }
            this.numberOfTasks++;
        }
        public void removeFirstTask() //TODO refaktor usuwanie pierwszego elementu ma wykonywać się po zmianie statusu z inprogress na done
        {
            // TODO obsługa błędu 
            {
                try
                {
                    if (this.firstTask != null)
                    {
                        this.firstTask = this.firstTask.next;
                        if (this.firstTask != null)
                        {
                            this.firstTask.previous.next = null;
                            this.firstTask.previous = null;
                        }
                        this.numberOfTasks--;
                        // GC.Collect();
                        // GC.Collect(this.firstTask.previous); TODO - wyjebunek na amen zrobić
                    }
                }
                catch (System.NullReferenceException) 
                {
                    this.firstTask = null;
                    this.lastTask = null;
                    this.numberOfTasks = 0;
                }
            }
        }
        //TODO remove z listy obojętnie którego po popupie z potwierdzeniem usunięcia,
        //flaga isDeleted=true i przesuniećie do sublisty
        public string ToString()
        {
            string tmpStr = "";
            Task tmp= this.firstTask;
            while (tmp != null)
            {
                tmpStr += tmp.ToString()+"\n";
                tmp = tmp.next;
            }
            return tmpStr;
        }
    }
}
