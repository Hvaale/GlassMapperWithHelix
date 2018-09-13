using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using MyHelix.Foundation.GlassMapper.Interfaces;

namespace _NamespacePrefix_._ModuleType_._Name_.Interfaces
{
	[SitecoreType]
  public interface I_Name_ : IGlassBase
  {
    // TODO: Implement model or otherwise remove this file
	
	    [SitecoreField]
        string Title { get; set; }
        [SitecoreField]
        string Text { get; set; }
  }
}