namespace KanBanDemo.Models
{
    public class KanBanSections
    {
        public string Name { get; init; }
        public bool NewTaskOpen { get; set; }
        public string NewTaskName { get; set; }

        public KanBanSections(string name, bool newTaskOpen, string newTaskName)
        {
            Name = name;
            NewTaskOpen = newTaskOpen;
            NewTaskName = newTaskName;
        }
    }

}
