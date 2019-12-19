# 说明
csharp note

# 安装 SDK 和 IDE
	1. 安装 dot net core SDK
	2. 安装 VSCode 

# 新建一个项目
```
dotnet new console -o consoleapp
```

```
using System;
namespace dotnet
{
    class Program
    {
        /*
        Main 方法要求静态
        关键字要求小写，命名要求大写
        */
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

# 在线教程
https://docs.microsoft.com/zh-cn/dotnet/csharp/tutorials/intro-to-csharp/