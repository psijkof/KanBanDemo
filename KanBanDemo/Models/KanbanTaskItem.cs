using KanBanDemo.Models.Abstractions;

namespace KanBanDemo.Models
{
    public class KanbanTaskItem : IKanbanTaskItem
    {
        public KanbanTaskItem(string name, string status, int order)
        {
            Name = name;
            OrderInSection = order;
            Status = status;
        }

        public string Name { get; set; }
        public int OrderInSection { get; set; }
        public string Status { get; set; }
    }
}