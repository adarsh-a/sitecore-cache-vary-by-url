using Axiom.SitecoreCustom.Cache.Extension.Presentation;
using Sitecore.Mvc.Pipelines.Response.RenderRendering;

namespace Axiom.SitecoreCustom.Cache.Pipelines.MvcRendering
{
    public class ExtendCacheKey : RenderRenderingProcessor
    {
        public override void Process(RenderRenderingArgs args)
        {
            AxiomCachingDefinition cachingDefinition = new AxiomCachingDefinition(args.Rendering);
            if (args.Rendered || !args.Cacheable || !cachingDefinition.VaryByURL)
                return;
            args.CacheKey = (args.CacheKey ?? string.Empty) + "_#id:" + args.Rendering.UniqueId.ToString();
        }
    }
}