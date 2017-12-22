using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extentions
{
    public static class RegexHelper
    {
        /// <summary>
        /// 得到匹配字符串 没有找到返回 new List&lt;string>() {string.Empty};
        /// </summary>
        /// <param name="content"></param>
        /// <param name="pattern"></param>
        /// <param name="multi">是否是多个</param>
        /// <returns></returns>
        public static List<string> GetStringByPattern(string content, string pattern, bool multi)
        {
            if (string.IsNullOrEmpty(content) || string.IsNullOrEmpty(pattern))
                return new List<string>() { string.Empty };
            RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;
            Match match = null;
            try
            {
                match = Regex.Match(content, pattern, options);
            }
            catch (Exception ex)
            {
                return new List<string>() { string.Empty };
            }
            string result = GetStringFromMatch(match);
            var resultArray = new List<string> { result };
            while (multi)
            {
                match = match.NextMatch();
                result = GetStringFromMatch(match);
                if (string.IsNullOrEmpty(result)) break;
                resultArray.Add(result);
            }
            return resultArray;
        }

        private static string GetStringFromMatch(Match match)
        {
            string result = string.Empty;
            if (match.Groups.Count > 0)
            {
                result = match.Groups[match.Groups.Count - 1].Value;
                //Console.WriteLine("正则:{0},最终匹配结果:{1}", pattern, result);
            }
            return result;
        }
    }
}
