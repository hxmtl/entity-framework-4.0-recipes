﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Data.Objects;

namespace Recipe8
{
    public class ApplyProxyDataContractResolverAttribute : Attribute, IOperationBehavior
    {
        public void AddBindingParameters(OperationDescription description, BindingParameterCollection parameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription description, ClientOperation proxy)
        {
            DataContractSerializerOperationBehavior dataContractSerializerOperationBehavior = description.Behaviors.Find<DataContractSerializerOperationBehavior>();
            dataContractSerializerOperationBehavior.DataContractResolver = new ProxyDataContractResolver();
        }

        public void ApplyDispatchBehavior(OperationDescription description, DispatchOperation dispatch)
        {
            DataContractSerializerOperationBehavior dataContractSerializerOperationBehavior = description.Behaviors.Find<DataContractSerializerOperationBehavior>();
            dataContractSerializerOperationBehavior.DataContractResolver = new ProxyDataContractResolver();
        }

        public void Validate(OperationDescription description)
        {
        }
    }
}