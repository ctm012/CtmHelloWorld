using System;//使用系统
using System.Collections.Generic;//使用系统泛型集合
using System.Linq;////使用系统语言集成查询
using System.Text;//使用系统文本
using System.Threading.Tasks;//使用系统线程任务

/// <summary>
/// CtmHelloWorld【命名空间】
/// </summary>
namespace CtmHelloWorld
{
    /// <summary>
    /// 设置【类】
    /// </summary>
    class 设置
    {
        public void 窗体设置()
        {
            Console.Title = "CtmHelloWorld:" + DateTime.Now.ToString("D");//窗体标题
            Console.WindowWidth = 50;//窗体宽度
            Console.WindowHeight = 25;//窗体高度
            Console.BufferWidth = 50;//窗体缓冲区宽度
            Console.BufferHeight = 25;//窗体缓冲区高度
            Console.ReadLine();//防止程序运行后立刻退出
        }
    }
}