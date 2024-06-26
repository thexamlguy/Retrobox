﻿using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[INotifyPropertyChanged]
public partial class SegaLibraryMenuItemViewModel : ILibraryMenuItemViewModel,
    INotificationHandler<ConfigurationChanged<SegaLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    public SegaLibraryMenuItemViewModel(IMediator mediator,
        SegaLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        mediator.Subscribe(this);

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<SegaLibraryConfiguration> notification, 
        CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}