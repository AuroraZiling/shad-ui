﻿using Avalonia;
using Avalonia.Controls;

namespace ShadUI.Breakpoints;

/// <summary>
///     Represents a view that can change its layout based on breakpoints.
/// </summary>
public class View : Grid
{
    /// <summary>
    ///     Defines the <see cref="Breakpoint" /> property.
    /// </summary>
    public static readonly StyledProperty<Breakpoint> BreakpointProperty =
        AvaloniaProperty.Register<ViewPort, Breakpoint>(nameof(Breakpoint));

    /// <summary>
    ///     Gets or sets the breakpoint for the view.
    /// </summary>
    public Breakpoint Breakpoint
    {
        get => GetValue(BreakpointProperty);
        set => SetValue(BreakpointProperty, value);
    }

    /// <summary>
    ///     Defines the <see cref="Invert" /> property.
    /// </summary>
    public static readonly StyledProperty<bool> InvertProperty = AvaloniaProperty.Register<ViewPort, bool>(
        nameof(Invert));

    /// <summary>
    ///     Gets or sets a value indicating whether to invert the breakpoint logic.
    /// </summary>
    public bool Invert
    {
        get => GetValue(InvertProperty);
        set => SetValue(InvertProperty, value);
    }
}