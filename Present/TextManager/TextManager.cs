using System.Collections.Generic;
using System.Linq;

namespace Present.TextManager
{
    public static class TextManager
    {
        private static int index = -1;
        private static bool _isInit = false;
        private static List<string> labelList = new List<string>();
        private static List<string> buttonList = new List<string>();

        /// <summary>
        /// 初始化
        /// </summary>
        private static void Init()
        {
            if (Configure.IS_DEBUG)
            {
                labelList.Add("动画表现时若点击鼠标可能会造成程序假死\n若任务管理器再后台打开可能会造成程序假死\n假死后可多次点击鼠标强制关闭本程序");
                buttonList.Add("继续");
            }
            else
            {
                labelList.Add("警告\n\n本程序运行中请勿关闭计算机\n请勿从任务管理器强制关闭本程序\n请务必按提示运行本程序\n以免损坏计算机");
                buttonList.Add("继续");
                labelList.Add("初始化完毕");
                buttonList.Add("下一步");
                labelList.Add("嗯,当你看到这段话时\n已经无法从菜单栏正常关闭本程序");
                buttonList.Add("试过了,继续");
                labelList.Add("下一页有惊喜");
                buttonList.Add("看看是啥");
                labelList.Add("如果说\n\n\n");
                buttonList.Add("???");
                labelList.Add("如果说\n这是一个木马程序\n\n你信吗?");
                buttonList.Add("??????");
                labelList.Add("惊不惊喜?\n");
                buttonList.Add("......");
                labelList.Add("惊不惊喜?\n意不意外?");
                buttonList.Add("............");
                labelList.Add("哈哈哈\n开个玩笑");
                buttonList.Add("......过......分......");
                labelList.Add("进入下一个页面后\n你可以通过菜单栏或任务管理器关闭本程序\n\n动画表现时若点击鼠标可能会造成程序假死\n若任务管理器再后台打开可能会造成程序假死\n假死后可多次点击鼠标强制关闭本程序");
                buttonList.Add("下一页又是什么幺蛾子");

                //(Ctrl+Shift+Esc或Ctrl+Alt+Delete可打开任务管理器)
            }

            index = 0;
        }
        
        /// <summary>
        /// 获得标签文本
        /// </summary>
        /// <returns></returns>
        public static string GetLabel()
        {
            if (!_isInit)
            {
                Init();
                _isInit = true;
                index = 0;
            }

            return labelList[index];
        }

        /// <summary>
        /// 获得按钮文本
        /// </summary>
        /// <returns></returns>
        public static string GetButton()
        {
            if (!_isInit)
            {
                Init();
                _isInit = true;
                index = 0;
            }
            
            return buttonList[index++];
        }

        /// <summary>
        /// 测试索引是否越界
        /// </summary>
        /// <returns></returns>
        public static bool Test()
        {
            if (index < 0 || (index < labelList.Count() && index < buttonList.Count())) 
            {
                return true;
            }
            return false;
        }
    }
}
