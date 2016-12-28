
namespace Castle.MicroKernel.Lifestyle {
    public class HybridPerWebRequestPerScopeAccessor : HybridPerWebRequestScopeAccessor {
        public HybridPerWebRequestPerScopeAccessor() : 
            base(new LifetimeScopeAccessor()) { }
    }
}
