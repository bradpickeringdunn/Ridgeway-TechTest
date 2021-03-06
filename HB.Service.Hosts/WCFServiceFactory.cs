﻿using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Unity.Wcf;

namespace HB.Service.Hosts
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {        protected override void ConfigureContainer(IUnityContainer container)
        {
            container.LoadConfiguration();
        }
    }    
}