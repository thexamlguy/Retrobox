﻿using CommunityToolkit.Mvvm.ComponentModel;
using Foundation;
using Toolkit.Framework.Foundation;

namespace Retrobox.Framework.Foundation;

[ObservableObject]
public partial class XboxLibraryMenuItemViewModel : ILibraryMenuItemViewModel,
    INotificationHandler<ConfigurationChanged<XboxLibraryConfiguration>>
{
    [ObservableProperty]
    private bool isOn;

    [ObservableProperty]
    private IMediator mediator;

    public XboxLibraryMenuItemViewModel(IMediator mediator,
        XboxLibraryConfiguration configuration)
    {
        this.mediator = mediator;
        mediator.Subscribe(this);

        IsOn = configuration.IsOn;
    }

    public ValueTask Handle(ConfigurationChanged<XboxLibraryConfiguration> notification, 
        CancellationToken cancellationToken)
    {
        IsOn = notification.Configuration.IsOn;
        return default;
    }
}