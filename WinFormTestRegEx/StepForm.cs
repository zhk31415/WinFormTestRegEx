using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Extentions;
using Models;

namespace WinFormTestRegEx
{
    public partial class StepForm : BaseForm
    {
        /// <summary>
        /// 替换数字字符串
        /// </summary>
        public const string NumReplace = "{num}";

        /// <summary>
        /// 当前选择ID
        /// </summary>
        private int Id { get; set; }

        /// <summary>
        /// 主窗体
        /// </summary>
        private MainForm _mainForm;

        /// <summary>
        /// 单个
        /// </summary>
        public const string Single = "单个";

        /// <summary>
        /// 多个
        /// </summary>
        public const string Multi = "多个";

        /// <summary>
        /// 获取到的内容
        /// </summary>
        public const string FromSourceContent = "获取到的内容";

        /// <summary>
        /// URL地址
        /// </summary>
        public const string FromSourceUrl = "URL地址";

        /// <summary>
        /// 单个多个
        /// </summary>
        private static List<string> _cmbList = new List<string>() { Single, Multi };

        public StepForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void StepForm_Load(object sender, EventArgs e)
        {
            //保存方式
            EnumSaveTypeColumn1.Items.Clear();
            Dictionary<int, string> dic = EnumSaveType.直接存入.ToDic();
            EnumSaveTypeColumn1.Items.AddRange(dic.Select(m => m.Value).ToArray<object>());

            cmbMulti.Items.AddRange(_cmbList.ToArray<object>());
            cmbMulti2.Items.AddRange(_cmbList.ToArray<object>());

            this.FromSourceColumn1.Items.AddRange(new object[]
            {
                FromSourceContent,
                FromSourceUrl
            });
            this.MultiColumn1.Items.AddRange(_cmbList.ToArray<object>());
            this.Multi2Column1.Items.AddRange(_cmbList.ToArray<object>());

            LoadList();
            this.txtName.Focus();
        }

        private void LoadList()
        {
            cmbWebTypeId.Items.Clear();
            var webTypeList = DbEntityAccess.GetList<WebType>(" and EnumDic=" + (int)EnumDic.WebType);
            cmbWebTypeId.Items.AddRange(webTypeList.ToArray());
            if (cmbWebTypeId.Items.Count > 0)
            {
                cmbWebTypeId.SelectedIndex = 0;
            }
            cmbData.Items.Clear();
            string[] tempList = Config.SuitTblName.Split(',').Where(m => !string.IsNullOrEmpty(m)).ToArray();
            cmbData.Items.AddRange(tempList);
            if (cmbData.Items.Count > 0)
            {
                cmbData.SelectedIndex = 0;
            }

            lsbMain.Items.Clear();
            lsbMain.Items.Add("加载中...");
            this.Refresh();
            lsbMain.Items.Clear();
            List<StepSetting> list = DbEntityAccess.GetList<StepSetting>();
            foreach (StepSetting item in list)
            {
                item.StepDetailSetting = DbEntityAccess.GetList<StepDetailSetting>(" and StepSettingId=" + item.Id);
            }
            lsbMain.Items.AddRange(list.ToArray());
            if (lsbMain.Items.Count > 0)
            {
                lsbMain.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 数据将要保存的类型
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="notShowProperties"></param>
        /// <returns></returns>
        private Type GetTheSaveDataType(out string msg, ref string[] notShowProperties)
        {
            string tblName = cmbData.SelectedItem as string;
            if (string.IsNullOrEmpty(tblName))
            {
                msg = "没有选择保存类型";
                return null;
            }
            int index = tblName.IndexOf('[');
            bool has = index != -1;
            string fullTypeName = "Models." + (has ? tblName.Substring(0, index) : tblName);
            notShowProperties = has ? tblName.Replace("]", "").Substring(index + 1).Split('|') : new string[] { };
            Type type = null;
            try
            {
                type = typeof(StepSetting).Assembly.GetType(fullTypeName, true, true);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return null;
            }
            msg = string.Empty;
            return type;
        }

        private void cmbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //加载dgvMain的数据
            string msg;
            string[] notShowProperties = null;
            Type type = GetTheSaveDataType(out msg, ref notShowProperties);
            if (type == null)
            {
                ShowMsg(msg);
                return;
            }
            List<StepDetailSetting> list = new List<StepDetailSetting>();
            PropertyInfo[] ps = type.GetProperties();
            foreach (PropertyInfo item in ps)
            {
                if (notShowProperties.Contains(item.Name))
                {
                    continue;
                }
                var stepDetail = new StepDetailSetting();
                stepDetail.PropertyName = item.Name;
                stepDetail.FromSource = FromSourceContent;
                stepDetail.Multi = "单";
                stepDetail.Multi2 = "单";
                list.Add(stepDetail);
            }
            dgvMain.DataSource = list;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void lsbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            StepSetting s = lsbMain.SelectedItem as StepSetting;
            if (s == null) return;
            //设置到文本框里
            Id = s.Id;
            SetData2(s);
        }

        private void SetData2(StepSetting o)
        {
            Action<StepSetting> a =
                p =>
                {
                    if (cmbWebTypeId.Items.Count > 0)
                    {
                        if (p.WebTypeId == 0)
                        {
                            p.WebTypeId = 1;
                        }
                        var webTypeList = cmbWebTypeId.Items.Cast<WebType>().ToList();
                        var first = webTypeList.FirstOrDefault(m => m.Id == p.WebTypeId) ?? webTypeList.FirstOrDefault();
                        cmbWebTypeId.SelectedItem = first;
                    }
                    if (cmbData.Items.Count > 0)
                    {
                        if (string.IsNullOrEmpty(p.SuitTblName))
                        {
                            p.SuitTblName = cmbData.Items.Cast<string>().FirstOrDefault();
                        }
                        var tempList = cmbData.Items.Cast<string>().ToList();
                        var first = tempList.FirstOrDefault(m => m == p.SuitTblName) ?? tempList.FirstOrDefault();
                        cmbData.SelectedItem = first;
                    }
                    if (p.StepDetailSetting.Count > 0)
                    {
                        //设置数据到界面
                        dgvMain.DataSource = p.StepDetailSetting;
                    }
                };
            this.SetData(o, a);
        }

        private StepSetting GetData2()
        {
            Action<StepSetting> a =
                p =>
                {
                    if (cmbWebTypeId.Items.Count > 0)
                    {
                        var webTypeList = cmbWebTypeId.Items.Cast<WebType>().ToList();
                        var selectItem = cmbWebTypeId.SelectedItem as WebType ?? webTypeList.FirstOrDefault();
                        p.WebTypeId = selectItem == null ? 1 : selectItem.Id;
                    }
                    if (cmbData.Items.Count > 0)
                    {
                        var tempList = cmbData.Items.Cast<string>().ToList();
                        var first = cmbData.SelectedItem as string ?? tempList.FirstOrDefault();
                        p.SuitTblName = first;
                    }
                    //得到界面数据
                    List<StepDetailSetting> list = dgvMain.DataSource as List<StepDetailSetting>;
                    list.ForEach(m => m.OpDate = DateTime.Now);
                    p.StepDetailSetting = list;
                };
            var model = this.GetData(a);
            return model;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = this.GetData2();
            model.Id = Id;
            string error = Validate(model);
            if (!string.IsNullOrEmpty(error))
            {
                ShowMsg(error);
                return;
            }
            int id = model.Id;
            if (id == 0)
            {
                id = DbEntityAccess.Add(model);
            }
            else
            {
                DbEntityAccess.Update(model);
            }
            bool isSuccess = id > 0;
            if (model.StepDetailSetting.Count > 0)
            {
                DbEntityAccess.DeleteByOnly<StepDetailSetting>(id);
                foreach (StepDetailSetting item in model.StepDetailSetting)
                {
                    item.StepSettingId = id;
                    DbEntityAccess.Add<StepDetailSetting>(item);
                }
            }
            if (isSuccess)
            {
                LoadList();
            }
        }

        private string Validate(StepSetting model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return "名称不能为空";
            }
            model.OpDate = DateTime.Now;
            return null;
        }

        private void btnStartUrl_Click(object sender, EventArgs e)
        {
            var type = (tabListType.SelectedTab == tabListType1) ? 1 : 2;
            List<string> urlList = new List<string>();
            var index = txtUrl.Text.IndexOf(NumReplace);
            if (type == 1)
            {
                if (index == -1)
                {
                    urlList.Add(txtUrl.Text);
                }
                else
                {
                    var stepSetting = this.GetData2();
                    //int numStart = Convert.ToInt32(txtNumStart.Text);
                    //int numEnd = Convert.ToInt32(txtNumEnd.Text);
                    //int numAdd = Convert.ToInt32(txtNumAdd.Text);
                    //string urlFormate = txtUrl.Text;
                    for (int i = stepSetting.NumStart; i <= stepSetting.NumEnd; i = i + stepSetting.NumAdd)
                    {
                        string url = stepSetting.Url.Replace(NumReplace, i.ToString());
                        urlList.Add(url);
                    }
                }

                lsbUrl.Items.Clear();
                lsbUrl.Items.AddRange(urlList.ToArray<object>());

                lblResult.Text = @"总URL个数:" + lsbUrl.Items.Count.ToString();
                return;
            }

            index = txtUrl2.Text.IndexOf(NumReplace);
            if (index == -1)
            {
                urlList.Add(txtUrl2.Text);
            }
            else
            {
                var stepSetting = this.GetData2();
                //int numStart = Convert.ToInt32(txtNumStart.Text);
                //int numEnd = Convert.ToInt32(txtNumEnd.Text);
                //int numAdd = Convert.ToInt32(txtNumAdd.Text);
                //string urlFormate = txtUrl.Text;
                for (int i = stepSetting.NumStart; i <= stepSetting.NumEnd; i = i + stepSetting.NumAdd)
                {
                    string url = stepSetting.Url2.Replace(NumReplace, i.ToString());
                    urlList.Add(url);
                }
            }
            var htmlList = new List<string>();
            foreach (var item in urlList)
            {
                var html = HttpWebRequestHelper.GetWebContent(item, Config.UserAgent);
                htmlList.Add(html);
            }
            var resultUrlList = new List<string>();
            foreach (var item in htmlList)
            {
                var list = Type2GetUrl(item);
                resultUrlList.AddRange(list);
            }
            lsbUrl.Items.Clear();
            lsbUrl.Items.AddRange(resultUrlList.ToArray<object>());

            lblResult.Text = @"总URL个数:" + lsbUrl.Items.Count.ToString();
        }

        private void btnStartUrlFromPage_Click(object sender, EventArgs e)
        {
            string filePath = Config.CurrentDir + Guid.NewGuid() + ".txt";
            _mainForm.geckoWebBrowser.SaveDocument(filePath);
            var content = System.IO.File.ReadAllText(filePath);
            try
            {
                System.IO.File.Delete(filePath);
            }
            catch
            {
            }
            var list = Type2GetUrl(content);
            lsbUrl.Items.Clear();
            lsbUrl.Items.AddRange(list.ToArray<object>());
        }

        /// <summary>
        /// 方式2,正则表达式
        /// </summary>
        /// <param name="content"></param>
        private List<string> Type2GetUrl(string content)
        {
            var stepSetting = this.GetData2();
            if (stepSetting.ListType != "2")
            {
                ShowMsg(@"不是方式2,不能执行此方法!");
                return new List<string>();
            }
            //正则规则匹配
            var list = new List<string>();
            var list1 = RegexHelper.GetStringByPattern(content, txtPatternUrl.Text, stepSetting.Multi == Multi);
            if (!string.IsNullOrEmpty(txtPatternUrl2.Text))
            {
                foreach (var item in list1)
                {
                    var list2 = RegexHelper.GetStringByPattern(item, txtPatternUrl2.Text, stepSetting.Multi2 == Multi);
                    list2 = list2.Where(m => !string.IsNullOrEmpty(m) && !string.IsNullOrEmpty(m.Trim())).ToList();
                    list.AddRange(list2);
                }
            }
            else
            {
                list.AddRange(list1);
            }
            return list;
        }

        private void lsbUrl_DoubleClick(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox == null || listBox.SelectedItem == null) return;
            ShowMsg(listBox.SelectedItem.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                ShowMsg("请先选择一条数据再删除");
                return;
            }
            var step = lsbMain.SelectedItem as StepSetting;
            if (step == null)
            {
                ShowMsg("请先选择一条数据再删除!");
                return;
            }
            if (step.Id != Id)
            {
                ShowMsg("请先选择一条数据再删除!!");
                return;
            }
            var dialog = ShowConfirm("是否要删除" + step.Name + "?");
            if (dialog == DialogResult.Yes)
            {
                var isSuccess = DbEntityAccess.Delete<StepSetting>(Id);
                if (isSuccess)
                {
                    LoadList();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Id = 0;
            StepSetting s = new StepSetting();
            s.NumAdd = 1;
            s.NumStart = 1;
            s.NumEnd = 3;
            lsbMain.SelectedItem = null;
            SetData2(s);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (lsbUrl.SelectedItem == null)
            {
                ShowMsg("请先在URL列表数据集合中选择一条数据!");
                return;
            }
            var url = lsbUrl.SelectedItem.ToString();
            _mainForm.txtUrl.Text = url;
            _mainForm.geckoWebBrowser.Navigate(url);
            //_mainForm.geckoWebBrowser;
        }

        /// <summary>
        /// 开始抓取数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartGetData_Click(object sender, EventArgs e)
        {
            List<StepDetailSetting> stepDetailSettingList = dgvMain.DataSource as List<StepDetailSetting>;
            if (stepDetailSettingList == null || stepDetailSettingList.Count == 0)
            {
                ShowMsg("没有任何绑定字段,无法从页面抓取");
                return;
            }
            string msg;
            string[] notShowProperties = null;
            Type type = GetTheSaveDataType(out msg, ref notShowProperties);
            if (type == null)
            {
                ShowMsg(msg);
                return;
            }
            string filePath = Config.CurrentDir + Guid.NewGuid() + ".txt";
            _mainForm.geckoWebBrowser.SaveDocument(filePath);
            var content = System.IO.File.ReadAllText(filePath);
            try
            {
                System.IO.File.Delete(filePath);
            }
            catch
            {
            }
            string url = _mainForm.geckoWebBrowser.Url.ToString();
            object obj = type.GetConstructor(new Type[0]).Invoke(null);
            PropertyInfo[] ps = type.GetProperties();
            foreach (StepDetailSetting setting in stepDetailSettingList)
            {
                PropertyInfo pi = ps.FirstOrDefault(m => m.Name == setting.PropertyName);
                if (pi == null) continue;
                bool isContent = setting.FromSource == FromSourceContent;
                string fromSource = isContent ? content : url;
                //正则规则匹配
                List<string> list = new List<string>();
                List<string> list1 = RegexHelper.GetStringByPattern(fromSource, setting.Pattern, setting.Multi == Multi);
                if (!string.IsNullOrEmpty(setting.Pattern2))
                {
                    foreach (var item in list1)
                    {
                        var list2 = RegexHelper.GetStringByPattern(item, setting.Pattern, setting.Multi2 == Multi);
                        list2 = list2.Where(m => !string.IsNullOrEmpty(m) && !string.IsNullOrEmpty(m.Trim())).ToList();
                        list.AddRange(list2);
                    }
                }
                else
                {
                    list.AddRange(list1);
                }
                string val = list.ToJoin();
                pi.SetValue(obj, val, null);
            }
            //有特殊属性,则赋值,如:OpDate
            PropertyInfo opDatePi = type.GetProperty("OpDate");
            if (opDatePi != null) opDatePi.SetValue(obj, DateTime.Now, null);
            PropertyInfo stepSettingIdPi = type.GetProperty("StepSettingId");
            if (stepSettingIdPi != null) stepSettingIdPi.SetValue(obj, Id, null);
            txtMain.Text = obj.ToJson();
        }

        private void dgvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
