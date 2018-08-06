#1、打开腾讯云 3.0 .net sdk代码使用什么 IDE ？
腾讯云 3.0 .net sdk代码 支持.net framework 4.5 和 .netstandard 2.0，代码使用visual studio 2017 或者visual studio code 进行编辑，使用.netcore cli 工具dotnet 。如果你的是先开发的.应用程序，.netstandard 2.0可以支持.net core 2.0/2.1,推荐使用.net core 2.1, 通过.netcore可以跨平台运行在windows和linux平台上。

#2、如何引用腾讯云 3.0 SDK？
通过nuget 安装 3.0 sdk，可以通过多种途径进行引用，使用过程中发现问题欢迎在github上面提交issue

#3、如何处理引用版本冲突？
3.0 sdk 依赖两个包 Newtonsoft.Json 和 Pathoschild.Http.FluentClient ; 有可能和你的项目中引用的不同不同版本的包冲突。 如果使用visual studio 2017，在项目的Project 里面添加 <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>  ，具体参考 https://docs.microsoft.com/zh-cn/dotnet/framework/configure-apps/how-to-enable-and-disable-automatic-binding-redirection
