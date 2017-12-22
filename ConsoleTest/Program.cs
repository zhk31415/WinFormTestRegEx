using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Extentions;
using Models;

namespace ConsoleTest
{
    class Program
    {
        private static object _sycn = new object();

        private static int _a = 0;

        private static volatile int _b = 0;

        /// <summary>
        /// 测试多线程同步执行
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            bool type = true;//false为原版代码,true为Task多线程执行
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                sw.Reset();
                sw.Start();
                _a = 0;
                _b = 0;
                int maxTaskCount = 1000;
                Task[] tasks = new Task[maxTaskCount];
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (type)
                    {
                        tasks[i] = Task.Factory.StartNew(() =>
                        {
                            _b = _b + 1;
                            Do();
                        });
                    }
                    else
                    {
                        Do();
                    }
                }
                if (type) Task.WaitAll(tasks);
                sw.Stop();
                Console.WriteLine(@"总共{0}个Task,成功了{1}/{3}个任务 耗时:{2}", maxTaskCount, _a, sw.ElapsedMilliseconds, _b);
                Console.WriteLine(@"输入q退出,其它任意字符都会继续");
                var read = Console.ReadLine();
                if (read != null && read.ToUpper() == "Q")
                {
                    break;
                }
            }
        }

        private static void Do()
        {
            lock (_sycn)
            {
                _a = _a + 1;
            }
            Thread.Sleep(1);
        }

        /// <summary>
        /// 测试网络获取
        /// </summary>
        /// <param name="args"></param>
        private static void Main3(string[] args)
        {
            var result = HttpWebRequestHelper.GetWebContent("www.baidu.com", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36");
            Console.WriteLine(result);
            Console.Read();
        }

        /// <summary>
        /// 测试数据库方法
        /// </summary>
        /// <param name="args"></param>
        static void Main2222(string[] args)
        {
            ////新增
            //StepSetting ss = new StepSetting();
            //ss.Name = "必应6";
            //ss.CreateDate = DateTime.Now;
            //ss.Url = "www.bing.com6";
            //ss.Remark = "111";
            //DbEntityAccess.Add(ss);
            //Console.WriteLine("主键ID:" + ss.Id);

            //var newModel = DbEntityAccess.GetModel<StepSetting>(2);
            //Console.WriteLine(@"更改前的值:" + newModel.ToJson());
            ////编辑
            //StepSetting ss = new StepSetting();
            //ss.Id = 2;
            //ss.Name = "必应3213312";
            //ss.CreateDate = DateTime.Now;
            //ss.Url = "cn.bing.com32131231";
            //DbEntityAccess.Update(ss);
            //newModel = DbEntityAccess.GetModel<StepSetting>(2);
            //Console.WriteLine(@"更改后的值:" + newModel.ToJson());

            //删除
            //StepSetting ss = new StepSetting();
            //ss.Name = "测试";
            //ss.CreateDate = DateTime.Now;
            //ss.Url = "www.bing.com";
            //DbEntityAccess.Add(ss);
            //Console.WriteLine(@"新增入的:" + ss.ToJson());
            //DbEntityAccess.Delete<StepSetting>(ss.Id);
            //Console.WriteLine(@"删除刚添加入的主键ID:" + ss.Id);

            var list = DbEntityAccess.GetList<StepSetting>();
            Console.WriteLine(@"总条数:" + list.Count);
            Console.WriteLine(list.ToJson());
            int count = 0;
            var list2 = DbEntityAccess.GetListByPage<StepSetting>(ref count, null, 3, 2, "OpDate", true);
            Console.WriteLine(@"总条数2:" + count);
            Console.WriteLine(list2.ToJson());
            Console.Read();
        }
    }
}
