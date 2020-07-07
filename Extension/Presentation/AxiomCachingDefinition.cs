using Sitecore.Mvc.Presentation;

namespace Axiom.SitecoreCustom.Cache.Extension.Presentation
{
    public class AxiomCachingDefinition : RenderingCachingDefinition
    {
        public AxiomCachingDefinition(Rendering rendering)
         : base(rendering)
        {
        }

        public bool VaryByPage
        {
            get
            {
                if (this.Rendering.RenderingItem.Parameters.Length > 0)
                {

                    if (this.Rendering.RenderingItem.Parameters.Contains("vbpg=1"))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}