using Flax.Build;

public class PluginLinksEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("PluginLinks");
        Modules.Add("PluginLinksEditor");
    }
}
