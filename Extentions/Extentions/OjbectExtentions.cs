using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class OjbectExtentions
    {
        /// <summary>
        /// 相同属性赋值到这个对象中(只赋值属性过来)
        /// </summary>
        /// <param name="target">赋值到的目标</param>
        /// <param name="copyFromObj">赋值从的目标</param>
        /// <param name="attributeType">copyFromObj属性里的特性,包含此则不赋值,默认为 typeof(IgnoreCopyAttribute) 不支持继承的父类</param>
        public static void ToCopyFromObj(this object target, object copyFromObj, Type attributeType = null)
        {
            if (target == null || copyFromObj == null) return;
            if (attributeType == null) attributeType = typeof(IgnoreCopyAttribute);
            var ps = target.GetType().GetProperties();
            var copyType = copyFromObj.GetType();
            foreach (var item in ps)
            {
                if (item == null || string.IsNullOrEmpty(item.Name)) continue;
                if (item.CanWrite == false) continue;
                var copyProperty = copyType.GetProperty(item.Name);
                if (copyProperty == null) continue;
                var attrs = copyProperty.GetCustomAttributes(attributeType, false);
                if (attrs.Length > 0 && attrs[0].GetType() == attributeType) continue;
                if (copyProperty.PropertyType != item.PropertyType) continue;
                var val = copyProperty.GetValue(copyFromObj, null);
                item.SetValue(target, val, null);
            }
        }

        private static readonly JsonSerializerSettings Setting = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static string ToJson(this object target)
        {
            if (target == null) return string.Empty;
            var result = JsonConvert.SerializeObject(target, Formatting.None, Setting);
            return result;
        }

        public static T DeserializeObject<T>(string json)
        {
            T t = JsonConvert.DeserializeObject<T>(json);
            return t;
        }

        public static object DeserializeObject(string json)
        {
            var t = JsonConvert.DeserializeObject(json);
            return t;
        }

        /// <summary>
        /// 复制值,json序列化反序列化来实现的深拷贝
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static T Clone<T>(this T target)
        {
            string json = target.ToJson();
            T result = DeserializeObject<T>(json);
            return result;
        }
    }
}
