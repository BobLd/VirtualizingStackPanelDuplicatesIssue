using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace VirtualizingStackPanelDuplicatesIssue.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    [ObservableProperty] private int _selectedPageIndex;

    [ObservableProperty] private bool _isPaneOpen;

    [ObservableProperty] private ObservableCollection<ItemViewModel> _pages = new();

    [RelayCommand]
    private void TogglePane()
    {
        IsPaneOpen = !IsPaneOpen;
    }

    [RelayCommand]
    private void ScrollDown()
    {
        SelectedPageIndex++;
    }

    private void FillList()
    {
        int i = 0;
        foreach (var animal in new string[] { "cat", "camel", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra", "cow", "chameleon", "mouse", "lion", "zebra" })
        {
            _pages.Add(new ItemViewModel()
            {
                Number = i++,
                Text = animal,
                Width = Random.Shared.Next(100, 250),
                Height = Random.Shared.Next(200, 300)
            });
        }
    }

    public MainViewModel()
    {
        Task.Run(FillList);
    }
}
