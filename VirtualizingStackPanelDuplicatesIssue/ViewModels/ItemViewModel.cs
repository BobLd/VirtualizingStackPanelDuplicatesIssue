using CommunityToolkit.Mvvm.ComponentModel;

namespace VirtualizingStackPanelDuplicatesIssue.ViewModels
{
    public partial class ItemViewModel : ViewModelBase
    {
        [ObservableProperty] private int _width;

        [ObservableProperty] private int _height;

        [ObservableProperty] private string _text;

        [ObservableProperty] private int _number;
    }
}
