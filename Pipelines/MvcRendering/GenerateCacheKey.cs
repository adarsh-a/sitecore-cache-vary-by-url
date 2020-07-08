using Axiom.SitecoreCustom.Cache.Extension.Presentation;
using Sitecore.Mvc.Pipelines.Response.RenderRendering;
using Sitecore.Mvc.Presentation;

namespace Axiom.SitecoreCustom.Cache.Pipelines.MvcRendering
{
    public class GenerateCacheKey : Sitecore.Mvc.Pipelines.Response.RenderRendering.GenerateCacheKey
    {
        protected override string GenerateKey(Rendering rendering, RenderRenderingArgs args)
        {
            string str = base.GenerateKey(rendering, args);
            if (!string.IsNullOrEmpty(str) && new AxiomCachingDefinition(rendering).VaryByURL)
                str = string.Format("{0}_{1}", (object)str, System.Web.HttpContext.Current.Request.Url.AbsolutePath);
            return str;
        }
    }
}