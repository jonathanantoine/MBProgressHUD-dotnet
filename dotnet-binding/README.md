# Maui iOS binding for MBProgressHUD

[![NuGet version](https://badge.fury.io/nu/com.jonathanantoine.MBProgressHUD.svg)](https://badge.fury.io/nu/com.jonathanantoine.MBProgressHUD)

- Native library: [MBProgressHUD](https://github.com/jdg/MBProgressHUD)

**Support Net 9.0 for iOS (works with Xcode 15 and iOS 17)**

## Nuget

* `Install-Package com.jonathanantoine.MBProgressHUD`
* <https://www.nuget.org/packages/com.jonathanantoine.MBProgressHUD>

## Build

* Run the GH action.

## Usage

```csharp
using MBProgressHUDMaui;

var hub = new MTMBProgressHUD(controller.View)
{
    Mode = MBProgressHUDMode.Text,
    Margin = 10f,
    YOffset = 10f,
    RemoveFromSuperViewOnHide = true,
    UserInteractionEnabled = false,
    LabelText = "text to display"
};

controller.View.AddSubview(hub);
hub.Show(true);

hub.Hide(true, 2);
```

## Contribution
Contribution to [ApiDefinition.cs](ApiDefinition.cs) are welcome, just send PRs.

