using System;
using FlaxEditor;
using FlaxEditor.GUI.ContextMenu;

namespace PluginLinksEditor;

/// <summary>
/// Plugin to show plugins
/// </summary>
public class PluginLinksEditor : EditorPlugin
{
    /// <inheritdoc />
    public override Type GamePluginType => typeof(PluginLinks.PluginLinks);

    private ContextMenuChildMenu _menu;

    /// <inheritdoc />
    public override void InitializeEditor()
    {
        base.InitializeEditor();
        _menu = Editor.UI.MenuTools.ContextMenu.AddChildMenu("Plugin Link List");
        var button = _menu.ContextMenu.AddButton("Community Plugins");
        button.Clicked += ShowList;
    }

    /// <inheritdoc />
    public override void DeinitializeEditor()
    {
        base.DeinitializeEditor();
        if (_menu != null)
        {
            _menu.Dispose();
            _menu = null;
        }
    }

    private void ShowList()
    {
        var window = new PluginLinksWindow();
        window.Window.Title = "Flax Plugins";
        window.Show();
    }
}