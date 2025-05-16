using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using ShadUI.Themes;

namespace ShadUI.Controls;

/// <summary>
///     Represents a card control with header, footer, and shadow properties.
/// </summary>
public class Card : ContentControl
{
    /// <summary>
    ///     Defines the <see cref="Header" /> property.
    /// </summary>
    public static readonly StyledProperty<object?> HeaderProperty =
        AvaloniaProperty.Register<Card, object?>(nameof(Header));

    /// <summary>
    ///     Gets or sets the header content of the card.
    /// </summary>
    public object? Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }

    /// <summary>
    ///     Defines the <see cref="Footer" /> property.
    /// </summary>
    public static readonly StyledProperty<object?> FooterProperty =
        AvaloniaProperty.Register<Card, object?>(nameof(Footer));

    /// <summary>
    ///     Gets or sets the footer content of the card.
    /// </summary>
    public object? Footer
    {
        get => GetValue(FooterProperty);
        set => SetValue(FooterProperty, value);
    }

    /// <summary>
    ///     Defines the <see cref="HasShadow" /> property.
    /// </summary>
    public static readonly StyledProperty<bool> HasShadowProperty =
        AvaloniaProperty.Register<Card, bool>(nameof(HasShadow));

    /// <summary>
    ///     Gets or sets a value indicating whether the card has a shadow.
    /// </summary>
    public bool HasShadow
    {
        get => GetValue(HasShadowProperty);
        set => SetValue(HasShadowProperty, value);
    }

    /// <summary>
    ///     Defines the <see cref="AcrylicOpacity" /> property.
    /// </summary>
    public static readonly StyledProperty<double> TintOpacityProperty =
        AvaloniaProperty.Register<Card, double>(nameof(TintOpacity), 0.1d);

    /// <summary>
    ///     Gets or sets the opacity of the tint effect on the card.
    /// </summary>
    public double TintOpacity
    {
        get => GetValue(TintOpacityProperty);
        set => SetValue(TintOpacityProperty, value);
    }

    /// <summary>
    ///     Defines the <see cref="AcrylicOpacity" /> property.
    /// </summary>
    public static readonly StyledProperty<double> AcrylicOpacityProperty =
        AvaloniaProperty.Register<Card, double>(nameof(AcrylicOpacity), 0.2d);

    /// <summary>
    ///     Gets or sets the opacity of the acrylic effect on the card.
    /// </summary>
    public double AcrylicOpacity
    {
        get => GetValue(AcrylicOpacityProperty);
        set => SetValue(AcrylicOpacityProperty, value);
    }

    /// <inheritdoc cref="OnApplyTemplate"/>
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        if (e.NameScope.Find<ExperimentalAcrylicBorder>("PART_AcrylicBorder") is { } acrylicBorder)
        {
            acrylicBorder.IsVisible =
                ActualThemeVariant == ThemeVariants.AcrylicDark ||
                ActualThemeVariant == ThemeVariants.AcrylicLight;
            ActualThemeVariantChanged += delegate
            {
                acrylicBorder.IsVisible =
                    ActualThemeVariant == ThemeVariants.AcrylicDark ||
                    ActualThemeVariant == ThemeVariants.AcrylicLight;
            };
        }
    }
}