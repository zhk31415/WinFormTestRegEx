using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTestRegEx
{
    public class Config
    {
        /// <summary>
        /// 当前目录
        /// </summary>
        public static string CurrentDir = System.AppDomain.CurrentDomain.BaseDirectory;

        #region 得到一个UserAgent

        private static List<string> _userAgentList = new List<string>();

        private static int UserAgentReadType = Convert.ToInt32(ConfigurationManager.AppSettings["userAgentReadType"]);

        /// <summary>
        /// 配置文件的useragent分隔符
        /// </summary>
        public const char SplitUserAgentSign = '^';

        private static List<string> UserAgentList
        {
            get
            {
                if (_userAgentList.Count > 0) return _userAgentList;
                var listString = ConfigurationManager.AppSettings["userAgent"].Split(SplitUserAgentSign);
                _userAgentList.AddRange(
                    listString.Where(m => !string.IsNullOrEmpty(m) && !string.IsNullOrEmpty(m.Trim())).ToList());
                for (int i = 0; i < _userAgentList.Count; i++)
                {
                    _userAgentList[i] = _userAgentList[i].Trim();
                }
                return _userAgentList;
            }
        }

        /// <summary>
        /// 随机对象
        /// </summary>
        public static Random Random = new Random();

        /// <summary>
        /// 从配置里得到浏览器的 UserAgent
        /// </summary>
        public static string UserAgent
        {
            get
            {
                string result;
                if (UserAgentReadType == 0)
                {
                    var index = Random.Next(UserAgentList.Count);
                    result = UserAgentList[index];
                }
                else
                {
                    result = UserAgentList.Count <= UserAgentReadType
                        ? UserAgentList[0]
                        : UserAgentList[UserAgentReadType];
                }
                return result;
            }
        }

        #endregion

        /// <summary>
        /// 主窗体启动加载的文件路径
        /// </summary>
        public static string LoadHtml = ConfigurationManager.AppSettings["loadHtml"];

        /// <summary>
        /// 适用于表,多个以逗号隔开
        /// </summary>
        public static string SuitTblName = ConfigurationManager.AppSettings["SuitTblName"];
    }
}
