﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 回顾C#知识——不同变量类型
        //不同变量类型
        //有符号 sbyte int short long

        //无符号 byte uint ushort ulong

        //浮点 float double decimal

        //特殊 bool char string

        #endregion

        #region 知识点二 回顾C#知识——变量的本质
        //变量的本质是2进制
        //在内存中都以字节的形式存储着
        //1byte = 8bit
        //1bit(位)不是0就是1
        //通过sizeof方法可以看到常用变量类型占用的字节空间长度
        print("有符号");
        print("sbyte" + sizeof(sbyte) + "字节");
        print("int" + sizeof(int) + "字节");
        print("short" + sizeof(short) + "字节");
        print("long" + sizeof(long) + "字节");
        print("无符号");
        print("byte" + sizeof(byte) + "字节");
        print("uint" + sizeof(uint) + "字节");
        print("ushort" + sizeof(ushort) + "字节");
        print("ulong" + sizeof(ulong) + "字节");
        print("浮点");
        print("float" + sizeof(float) + "字节");
        print("double" + sizeof(double) + "字节");
        print("decimal" + sizeof(decimal) + "字节");
        print("特殊");
        print("bool" + sizeof(bool) + "字节");
        print("char" + sizeof(char) + "字节");
        #endregion

        #region 知识点三 2进制文件读写的本质
        //它就是通过将各类型变量转换为字节数组
        //将字节数组直接存储到文件中
        //一般人是看不懂存储的数据的
        //不仅可以节约存储空间，提升效率
        //还可以提升安全性
        //而且在网络通信中我们直接传输的数据也是字节数据（2进制数据）
        #endregion

        #region 知识点四 各类型数据和字节数据相互转换
        //C#提供了一个公共类帮助我们进行转化
        //我们只需要记住API即可
        //类名：BitConverter
        //命名空间：using System

        //1.将各类型转字节
        byte[] bytes = BitConverter.GetBytes(256);

        //2.字节数组转各类型
        int i = BitConverter.ToInt32(bytes, 0);
        print(i);
        #endregion

        #region 知识点五 标准编码格式
        //编码是用预先规定的方法将文字、数字或其它对象编成数码，或将信息、数据转换成规定的电脉冲信号。
        //为保证编码的正确性，编码要规范化、标准化，即需有标准的编码格式。
        //常见的编码格式有ASCII、ANSI、GBK、GB2312、UTF - 8、GB18030和UNICODE等。

        // 说人话
        // 计算机中数据的本质就是2进制数据
        // 编码格式就是用对应的2进制数 对应不同的文字
        // 由于世界上有各种不同的语言，所有会有很多种不同的编码格式
        // 不同的编码格式 对应的规则是不同的

        // 如果在读取字符时采用了不统一的编码格式，可能会出现乱码

        // 游戏开发中常用编码格式 UTF-8
        // 中文相关编码格式 GBK
        // 英文相关编码格式 ASCII

        // 在C#中有一个专门的编码格式类 来帮助我们将字符串和字节数组进行转换

        // 类名：Encoding
        // 需要引用命名空间：using System.Text;

        //1.将字符串以指定编码格式转字节
        byte[] bytes2 = Encoding.UTF8.GetBytes("唐老狮");

        //2.字节数组以指定编码格式转字符串
        string s = Encoding.UTF8.GetString(bytes2);
        print(s);
        #endregion

        #region 总结
        //我们可以通过BitConverter和Encoding类
        //将所有C#提供给我们的数据类型和字节数组之间进行相互转换了
        //我们需要熟练掌握其中的API
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
