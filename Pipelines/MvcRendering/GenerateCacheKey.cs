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
                str = $"{str}_{System.Web.HttpContext.Current.Request.Url.AbsolutePath}_#uid:{args.Rendering.UniqueId.ToString()}";
            return str;
        }
    }
}