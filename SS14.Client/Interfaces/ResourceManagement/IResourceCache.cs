﻿using SS14.Client.ResourceManagement;
using SS14.Shared.Interfaces.Resources;
using SS14.Shared.Utility;

namespace SS14.Client.Interfaces.ResourceManagement
{
    public interface IResourceCache : IResourceManager
    {
        T GetResource<T>(string path, bool useFallback = true)
            where T : BaseResource, new();

        T GetResource<T>(ResourcePath path, bool useFallback = true)
            where T : BaseResource, new();

        bool TryGetResource<T>(string path, out T resource)
            where T : BaseResource, new();

        bool TryGetResource<T>(ResourcePath path, out T resource)
            where T : BaseResource, new();

        void ReloadResource<T>(string path)
            where T : BaseResource, new();

        void ReloadResource<T>(ResourcePath path)
            where T : BaseResource, new();

        void CacheResource<T>(string path, T resource)
            where T : BaseResource, new();

        void CacheResource<T>(ResourcePath path, T resource)
            where T : BaseResource, new();

        T GetFallback<T>()
            where T : BaseResource, new();
    }

    internal interface IResourceCacheInternal : IResourceCache, IResourceManagerInternal
    {
        void LoadBaseResources();
    }
}
