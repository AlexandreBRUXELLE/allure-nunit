﻿using System;
using NUnit.Framework;

namespace NUnit.Allure.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class AllureTagAttribute : NUnitAttribute
    {
        public AllureTagAttribute(params string[] tags)
        {
            Tags = tags;
        }

        internal string[] Tags { get; }
    }
}