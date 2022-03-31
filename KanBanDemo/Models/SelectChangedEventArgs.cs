using KanBanDemo.Components;

namespace KanBanDemo.Models
{
    public record SelectChangedEventArgs(bool IsSelected, KanbanItem KanbanItem);

}
