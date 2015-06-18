using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Ninject;
using IDependencyResolver = System.Web.Mvc.IDependencyResolver;

namespace MCV.Skeleton.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver, System.Web.Http.Dependencies.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;

            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
            // When BeginScope returns 'this', the Dispose method must be a no-op.
        }

        private void AddBindings()
        {
            // Add any bindings in here
        }
    }
}