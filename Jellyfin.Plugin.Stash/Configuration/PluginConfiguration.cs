using MediaBrowser.Model.Plugins;

namespace Stash.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public PluginConfiguration()
        {
            this.StashEndpoint = "http://localhost:9999";
            this.StashAPIKey = string.Empty;

            this.AddDisambiguation = false;
            this.UseFullPathToSearch = true;
        }

        public string StashEndpoint { get; set; }

        public string StashAPIKey { get; set; }

        public bool AddDisambiguation { get; set; }

        public bool UseFullPathToSearch { get; set; }
    }
}
