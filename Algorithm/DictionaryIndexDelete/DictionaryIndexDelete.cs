using Algorithm.Utils;

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.DictionaryIndexDeleted
{
    //给定一个以字符串表示的非负整数 num，移除这个数中的 k 位数字，使得剩下的数字最小。

    //注意:

    //num 的长度小于 10002 且  ≥ k。
    //num 不会包含任何前导零。

    //示例 1 :

    //输入: num = "1432219", k = 3
    //输出: "1219"
    //解释: 移除掉三个数字 4, 3, 和 2 形成一个新的最小的数字 1219。
    //示例 2 :

    //输入: num = "10200", k = 1
    //输出: "200"
    //解释: 移掉首位的 1 剩下的数字为 200. 注意输出不能有任何前导零。
    //示例 3 :

    //输入: num = "10", k = 2
    //输出: "0"
    //解释: 从原数字移除所有的数字，剩余为空就是 0。
    public class DictionaryIndexDelete
    {
        //初始随机数
        private uint randomNum;  //长度小于10002 且 >= k

        //输入的值 表示需要去除的位数
        private uint key;

        public void InitRandomNum()
        {
            System.Random random = new Random();

            randomNum = (uint)random.Next(100, 999999999);
        }

        public void GetInputKey(uint inputValue)
        {
            key = inputValue;
        }


        //执行算法
        public uint ExecuteAlgorithm()
        {
            System.Console.WriteLine("初始化到的数字为{0}", randomNum);
            //获取数字的长度
            var splitStack = Utility.SplitNums(randomNum);
            uint numLength = (uint)splitStack.Count;

            if (numLength <= key)
            {
                System.Console.WriteLine("当前输入的删除位数，大于整个数字的最大长度");
                return 0;
            }

            ExecuteMethod(splitStack, numLength);

            uint result = 0;
            uint remainLength = numLength - key;
            if (splitStack.Count >= remainLength)
            {
                uint abandonCount = (uint)splitStack.Count - remainLength;
                while (splitStack.Count > abandonCount)
                {
                    result *= 10;
                    result += splitStack.Pop();
                }
            }

            return result;
        }

        /// <summary>
        /// 执行方法
        /// </summary>
        private void ExecuteMethod(Stack<byte> tempStack, uint numLength)
        {
            int count = tempStack.Count;
            while (tempStack.Count > numLength - key && count > 0)
            {
                byte a = tempStack.Pop();
                byte b = tempStack.Pop();
                if (a < b)
                {
                    tempStack.Push(a);
                }
                else
                {
                    tempStack.Push(b);
                }
                count--;
            }
        }

    }
}
