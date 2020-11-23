using System;//使用系统
using System.Collections.Generic;//使用系统泛型集合
using System.Linq;//使用系统语言集成查询
using System.Text;//使用系统文本
using System.Threading.Tasks;//使用系统线程任务

/// <summary>
/// CtmHelloWorld【命名空间】
/// </summary>
namespace CtmHelloWorld
{
    /// <summary>
    /// 程序【类】
    /// </summary>
    class 程序
    {
        /// <summary>
        /// 程序入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Ctm Hello World!");//输出括号里面的内容

            设置 设置 = new 设置();//实例化设置
            设置.窗体设置();
        }
    }
}