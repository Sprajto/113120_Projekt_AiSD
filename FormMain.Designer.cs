namespace _113120_Projekt
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addTaskBtn = new Button();
            removeTaskBtn = new Button();
            taskPriorityInput = new ComboBox();
            taskTitleInput = new TextBox();
            boxOfCurrentTasks = new RichTextBox();
            SuspendLayout();
            // 
            // addTaskBtn
            // 
            addTaskBtn.Font = new Font("Comic Sans MS", 8F, FontStyle.Bold | FontStyle.Italic);
            addTaskBtn.Location = new Point(71, 31);
            addTaskBtn.Name = "addTaskBtn";
            addTaskBtn.Size = new Size(139, 51);
            addTaskBtn.TabIndex = 1;
            addTaskBtn.Text = "ADD TASK";
            addTaskBtn.UseVisualStyleBackColor = true;
            addTaskBtn.Click += addTaskBtn_Click;
            // 
            // removeTaskBtn
            // 
            removeTaskBtn.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            removeTaskBtn.Location = new Point(71, 88);
            removeTaskBtn.Name = "removeTaskBtn";
            removeTaskBtn.Size = new Size(139, 56);
            removeTaskBtn.TabIndex = 2;
            removeTaskBtn.Text = "REMOVE LAST TASK";
            removeTaskBtn.UseVisualStyleBackColor = true;
            removeTaskBtn.Click += removeTaskBtn_Click;
            // 
            // taskPriorityInput
            // 
            taskPriorityInput.DropDownStyle = ComboBoxStyle.DropDownList;
            taskPriorityInput.FormattingEnabled = true;
            taskPriorityInput.Items.AddRange(new object[] { "critical", "high", "highest", "low", "lowest", "medium" });
            taskPriorityInput.Location = new Point(506, 31);
            taskPriorityInput.Name = "taskPriorityInput";
            taskPriorityInput.Size = new Size(209, 28);
            taskPriorityInput.TabIndex = 3;
            // 
            // taskTitleInput
            // 
            taskTitleInput.Location = new Point(507, 74);
            taskTitleInput.MaxLength = 150;
            taskTitleInput.Name = "taskTitleInput";
            taskTitleInput.PlaceholderText = "wprowadź nazwę zadania";
            taskTitleInput.Size = new Size(208, 27);
            taskTitleInput.TabIndex = 4;
            // 
            // boxOfCurrentTasks
            // 
            boxOfCurrentTasks.Location = new Point(509, 126);
            boxOfCurrentTasks.Name = "boxOfCurrentTasks";
            boxOfCurrentTasks.Size = new Size(206, 300);
            boxOfCurrentTasks.TabIndex = 5;
            boxOfCurrentTasks.Text = "";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boxOfCurrentTasks);
            Controls.Add(taskTitleInput);
            Controls.Add(taskPriorityInput);
            Controls.Add(removeTaskBtn);
            Controls.Add(addTaskBtn);
            Name = "FormMain";
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addTaskBtn;
        private Button removeTaskBtn;
        private ComboBox taskPriorityInput;
        private TextBox taskTitleInput;
        private RichTextBox boxOfCurrentTasks;
    }
}
