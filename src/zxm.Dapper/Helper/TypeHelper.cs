﻿using System;
using System.Reflection;


namespace zxm.Dapper.Helper
{
    internal static class TypeHelper
    {
        public static PropertyInfo GetProperty(Type type, string name)
        {
#if COREFX
            return System.Reflection.TypeExtensions.GetProperty(type, name);
#else
            return type.GetProperty(name);
#endif
        }
    }
}
