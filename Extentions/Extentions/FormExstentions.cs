using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// ReSharper disable once CheckNamespace
namespace System.Windows.Forms
{
    public static class FormExstentions
    {
        private static readonly string[] PrefixArray = new string[] { "txt", "tab", "cmb" };

        /// <summary>
        /// 设置值到窗体控件里
        /// </summary>
        /// <param name="form"></param>
        /// <param name="obj">对象</param>
        /// <param name="action">传入的方法</param>
        /// <param name="p"></param>
        public static void SetData<T>(this Form form, T obj, Action<T> action = null, params string[] p)
        {
            if (p == null || p.Length == 0)
            {
                p = PrefixArray;
            }
            var type = obj.GetType();
            var cs = form.Controls;
            var ps = type.GetProperties();
            foreach (var item in ps)
            {
                foreach (var preff in p)
                {
                    var controlName = preff + item.Name;
                    if (controlName == "txtUrl")
                    {
                    }
                    var control = GetControl(controlName, cs);
                    if (control == null) continue;
                    if (control.GetType() == typeof(TextBox))
                    {
                        control.Text = Convert.ToString(item.GetValue(obj, null));
                    }
                    else if (control.GetType() == typeof(TabControl))
                    {
                        TabControl tab = (TabControl)control;
                        string val = Convert.ToString(item.GetValue(obj, null));
                        foreach (TabPage page in tab.TabPages)
                        {
                            if (page.Name == (controlName + val))
                            {
                                tab.SelectedTab = page;
                                break;
                            }
                        }
                    }
                    else if (control.GetType() == typeof(ComboBox))
                    {
                        ComboBox cmb = (ComboBox)control;
                        cmb.SelectedItem = item.GetValue(obj, null);
                    }
                }
            }

            if (action != null) action(obj);
        }

        public static T GetData<T>(this Form form, Action<T> action = null, params string[] p) where T : new()
        {
            T model = new T();
            form.GetData<T>(model, action, p);
            return model;
        }

        public static void GetData<T>(this Form form, T updateModel, Action<T> action = null, params string[] p)
        {
            if (p == null || p.Length == 0)
            {
                p = PrefixArray;
            }
            var type = typeof(T);
            var cs = form.Controls;
            var ps = type.GetProperties();
            foreach (var item in ps)
            {
                foreach (var preff in p)
                {
                    var controlName = preff + item.Name;
                    if (controlName == "tabListType")
                    {
                    }
                    var control = GetControl(controlName, cs);
                    if (control == null) continue;
                    if (control.GetType() == typeof(TextBox))
                    {
                        object val = item.DealSetValue(control.Text);
                        item.SetValue(updateModel, val, null);
                    }
                    else if (control.GetType() == typeof(TabControl))
                    {
                        TabControl tab = (TabControl)control;
                        var selectTab = tab.SelectedTab;
                        string val = string.Empty;
                        if (selectTab != null)
                        {
                            val = selectTab.Name.Substring(selectTab.Name.IndexOf(controlName) + controlName.Length);
                        }
                        item.SetValue(updateModel, val, null);
                    }
                    else if (control.GetType() == typeof(ComboBox))
                    {
                        ComboBox cmb = (ComboBox)control;
                        try
                        {
                            item.SetValue(updateModel, cmb.SelectedItem, null);
                        }
                        catch
                        {
                        }
                    }
                }
            }

            if (action != null) action(updateModel);
        }

        private static readonly Type[] HasControls = new Type[]
        {
            typeof (GroupBox), typeof (TabControl), typeof (TabPage)
        };

        private static Control GetControl(string controlName, Control.ControlCollection cs)
        {
            foreach (Control item in cs)
            {
                if (item.Name == controlName)
                {
                    return item;
                }
                if (HasControls.Contains(item.GetType()))
                {
                    var result = GetControl(controlName, item.Controls);
                    if (result != null) return result;
                }
            }
            return null;
        }
    }
}
