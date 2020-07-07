using Axiom.SitecoreCustom.Cache.Extension.Presentation;
using Sitecore.Mvc.Pipelines.Response.RenderRendering;
using Sitecore.Mvc.Presentation;


namespace Axiom.SitecoreCustom.Cache.Pipelines.MvcRendering
{
    public class SetCacheability : Sitecore.Mvc.Pipelines.Response.RenderRendering.SetCacheability
    {
        protected override bool IsCacheable(Rendering rendering, RenderRenderingArgs args)
        {
            if (base.IsCacheable(rendering, args))
                return new AxiomCachingDefinition(rendering).VaryByPage || PageContext.Current.Item != null;
            return false;
        }
    }
}