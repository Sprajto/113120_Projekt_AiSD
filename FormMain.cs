namespace _113120_Projekt
{
    public partial class FormMain : Form
    {
        TasksList KanbanList = new TasksList();
        void clearInputs()
        {
            taskTitleInput.Text = "";
            taskPriorityInput.Text = null;
        }
        public FormMain()
        {
            InitializeComponent();
            //TODO import danych xml?
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            KanbanList.addTaskAsLastElement(taskTitleInput.Text, taskPriorityInput.Text);
            clearInputs();
            boxOfCurrentTasks.Text = KanbanList.ToString(); //TODO do funkcji
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            KanbanList.removeFirstTask();
            //clearInputs();
            boxOfCurrentTasks.Text = KanbanList.ToString(); //TODO do funkcji
        }
    }
}
