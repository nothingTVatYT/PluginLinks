using FlaxEditor;
using FlaxEditor.CustomEditors;
using FlaxEngine.GUI;

namespace PluginLinksEditor;

/// <summary>
/// custom editor window showing the plugins
/// </summary>
public class PluginLinksWindow : CustomEditorWindow
{
    /// <inheritdoc />
    public override void Initialize(LayoutElementsContainer layout)
    {
        var linkListsGroup = layout.Group("Link Lists");
        var inputPanel = linkListsGroup.HorizontalPanel();
        inputPanel.Panel.Height = TextBoxBase.DefaultHeight + inputPanel.Panel.Margin.Height;
        inputPanel.Label("Link list");
        var listInput = inputPanel.TextBox();
        listInput.TextBox.Width = 250;
        var addButton = inputPanel.Button("Add");
        addButton.Button.Height = listInput.TextBox.Height;
        addButton.Button.Width = 80;
    }
}