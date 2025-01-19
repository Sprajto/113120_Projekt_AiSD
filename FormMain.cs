namespace _113120_Projekt
{
    public partial class FormMain : Form
    {
        TasksList KanbanList = new TasksList();

        public FormMain()
        {
            InitializeComponent();
            //TODO import danych xml?
        }
        void showTasksInBox()
        {
        boxOfCurrentTasks.Text = KanbanList.ToString();
        }
        void clearInputs()
        {
            taskTitleInput.Text = "";
            taskPriorityInput.Text = null;
        }
        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            if ((taskTitleInput.Text == "") || (taskPriorityInput.Text == ""))
            {
                MessageBox.Show("W celu dodania zadania nale�y wprowadzi� tytu� zadania oraz wybra� priorytet", 
                "Niepoprawne warto�ci",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                KanbanList.addTaskAsLastElement(taskTitleInput.Text, taskPriorityInput.Text);
                clearInputs();
                showTasksInBox();
            }
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {
            KanbanList.removeFirstTask();
            //clearInputs();
            showTasksInBox();
        }
    }
}
