namespace KanBanDemo.Models.Abstractions
{
    public interface IKanbanTaskItem
    {
        string Name { get; set; }
        string Status { get; set; }
        int OrderInSection { get; set; }
    }

}
