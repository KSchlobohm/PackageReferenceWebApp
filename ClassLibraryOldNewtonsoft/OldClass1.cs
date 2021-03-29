using System;

namespace ClassLibraryOldUnity
{
    public class OldClass1
    {
        public Unity.IUnityContainer GetContainer()
        {
            return new Unity.UnityContainer();
        }
    }
}
