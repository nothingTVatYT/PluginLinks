using System;
using FlaxEngine;

namespace PluginLinks
{
    /// <summary>
    /// The sample game plugin.
    /// </summary>
    /// <seealso cref="FlaxEngine.GamePlugin" />
    public class PluginLinks : GamePlugin
    {
        /// <inheritdoc />
        public PluginLinks()
        {
            _description = new PluginDescription
            {
                Name = "PluginLinks",
                Category = "Utility",
                Author = "nothingTVatYT",
                AuthorUrl = null,
                HomepageUrl = null,
                RepositoryUrl = "https://github.com/nothingTVatYT/PluginLinks",
                Description = "An experimental Flax plugin links list plugin",
                Version = new Version(0, 1),
                IsAlpha = false,
                IsBeta = true,
            };
        }

        /// <inheritdoc />
        public override void Initialize()
        {
            base.Initialize();

            Debug.Log("Hello from plugin code!");
        }

        /// <inheritdoc />
        public override void Deinitialize()
        {
            // Use it to cleanup data

            base.Deinitialize();
        }
    }
}
