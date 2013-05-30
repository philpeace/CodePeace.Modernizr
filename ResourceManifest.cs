using Orchard.UI.Resources;

namespace CodePeace.Modernizr
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();
            manifest.DefineScript("Modernizr").SetUrl("modernizr-2.6.2.min.js", "modernizr-2.6.2.js").SetVersion("2.6.2");
        }
    }
}
