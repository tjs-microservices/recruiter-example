using Recruiter.Web.Domain;

namespace Recruiter.Web.Areas._Related
{
    public interface IRelated
    {
        void Prepare(List<ThingA> thingsA, _ThingsA model, int totalThingsA, int parentId, string parentName);
        void Prepare(List<ThingB> thingsB, _ThingsB model, int totalThingsB, int parentId, string parentName);
        void Prepare(List<ThingC> thingsC, _ThingsC model, int totalThingsC, int parentId, string parentName);
        void Prepare(List<ThingD> thingsD, _ThingsD model, int totalThingsD, int parentId, string parentName);
        void Prepare(List<ThingE> thingsE, _ThingsE model, int totalThingsE, int parentId, string parentName);
    }
}
