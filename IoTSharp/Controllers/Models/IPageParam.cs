﻿using System;

namespace IoTSharp.Controllers.Models
{
    public class IPageParam
    {
        public int offset { get; set; } = 0;
        public int limit { get; set; } = 10;
        public string order { get; set; } = "desc";
        public string where { get; set; } = "";
    }

    public class DeviceParam : IPageParam
    {
        public Guid TenantId { get; set; }
        public Guid customerId { get; set; }

        public int DeviceType { get; set; }

        public DateTime[] LastActive { get; set; }
        public bool Online { get; set; }
        public string Name { get; set; }
    }

    public class RulePageParam : IPageParam
    {
        public string Name { get; set; }

        public string Creator { get; set; }
        public DateTime[] CreatTime { get; set; }
    }

    public class EventParam : IPageParam
    {
        public string Name { get; set; }

        public string Creator { get; set; }
        public DateTime[] CreatTime { get; set; }
    }

    public class DictionaryParam : IPageParam
    {
        public string DictionaryName { get; set; }
        public int DictionaryGroupId { get; set; }
    }

    public class I18NParam : IPageParam
    {
        public string KeyName { get; set; }
    }

    public class CustomerParam : IPageParam
    {
        public Guid tenantId { get; set; }
    }


    public class ExecutorParam : IPageParam
    {
     
    }


    public class SubscriptionParam : IPageParam
    {
        public string Name { get; set; }
    }
}