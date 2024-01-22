using Flax.Build;

public class PluginLinksTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("PluginLinks");
    }
}
