using KanBanDemo.Models.Abstractions;

namespace KanBanDemo.Models
{
    public class CombinedKanbanTaskItems : IKanbanTaskItem
    {
        public CombinedKanbanTaskItems(IKanbanTaskItem kanbanTaskItem)
        {
            SelectedKanbanTaskItems.Add(kanbanTaskItem);
        }

        public List<IKanbanTaskItem> SelectedKanbanTaskItems { get; set; } = new();

        public string Name
        {
            get => SelectedKanbanTaskItems.Any() ? SelectedKanbanTaskItems.First().Name : string.Empty;
            set => throw new System.NotImplementedException();
        }

        public string Status
        {
            get => SelectedKanbanTaskItems.Any() ? SelectedKanbanTaskItems.First().Status : string.Empty;
            set => SelectedKanbanTaskItems.ForEach(t => t.Status = value);
        }
        public int OrderInSection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ResetSelected()
        {
            throw new NotImplementedException();
        }
    }

}
