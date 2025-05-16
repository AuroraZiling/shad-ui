using Avalonia.Styling;

namespace ShadUI.Themes;

/// <summary>
///     Represents a collection of theme variants.
/// </summary>
public static class ThemeVariants
{
    /// <summary>
    ///     The default theme variant.
    /// </summary>
    public static readonly ThemeVariant Default = ThemeVariant.Default;

    /// <summary>
    ///     The dark theme variant.
    /// </summary>
    public static readonly ThemeVariant Dark = ThemeVariant.Dark;

    /// <summary>
    ///     The light theme variant.
    /// </summary>
    public static readonly ThemeVariant Light = ThemeVariant.Light;

    /// <summary>
    ///     The acrylic dark theme variant.
    /// </summary>
    public static readonly ThemeVariant AcrylicDark = new("AcrylicDark", Dark);

    /// <summary>
    ///     The acrylic light theme variant.
    /// </summary>
    public static readonly ThemeVariant AcrylicLight = new("AcrylicLight", Light);
}