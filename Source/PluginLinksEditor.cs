using FlaxEditor;

namespace PluginLinksEditor;

/// <summary>
/// Plugin to show plugins
/// </summary>
public class PluginLinksEditor : EditorPlugin
{
    /// <inheritdoc />
    public override Type GamePluginType => typeof(Pluginlinks.PluginLinks);

    private ContextMenuChildMenu _menu;
    
}