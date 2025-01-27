﻿using Volo.Abp.Reflection;

namespace LINGYUN.Abp.TextTemplating;

public static class AbpTextTemplatingPermissions
{
    public const string GroupName = "AbpTextTemplating";

    public static class TextTemplate
    {
        public const string Default = GroupName + ".TextTemplates";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(AbpTextTemplatingPermissions));
    }
}