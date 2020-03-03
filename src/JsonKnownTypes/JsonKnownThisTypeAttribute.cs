﻿using System;

namespace JsonKnownTypes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class JsonKnownThisTypeAttribute : Attribute
    {
        public string Discriminator { get; }

        public JsonKnownThisTypeAttribute()
        { }

        public JsonKnownThisTypeAttribute(string discriminator)
        {
            Discriminator = discriminator;
        }
    }
}
