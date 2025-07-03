# Changelog

### [3.0.1208] - 2025-03-26
- fix: 移除对 SSE 响应的过早的 dispose() 调用

### [3.0.1194] - 2025-03-07
- fix: 支持超时

### [3.0.995] - 2024-04-29
- feat: 添加 IsStream 属性，以支持在流上下文中进行非流调用

### [3.0.990] - 2024-04-22
- fix: 支持 SSE API 可选的 JSON 协议

### [3.0.916] - 2023-12-14
- fix: 全面使用 ConfigureAwait(false) (参考：https://devblogs.microsoft.com/dotnet/configureawait-faq/#why-would-i-want-to-use-configureawaitfalse)

### [3.0.910] - 2023-12-06
- feat: 支持 text/event-stream

### [3.0.901] - 2023-11-24
- fix: 修复导致 .NET Framework 中同步调用挂起的错误

### [3.0.892] - 2023-11-15
- feat: 为 TencentCloudSDKException 添加 ErrorCode

### [3.0.878] - 2023-11-01
- feat: 支持 octet-stream

### [3.0.713] - 2023-03-08
- feat: 支持 CommonClient

### [3.0.349] - 2021-08-25
- security fix: Bump System.Text.Encodings.Web to 4.5.1

### [3.0.346] - 2021-08-23
- feat: 添加 Language 参数

### [3.0.135] - 2020-09-02
- 移除 Pathoschild.Http.FluentClient 并重写 HttpConnection

### [3.0.133] - 2020-09-01
- fix: 修复夏令时偏移问题

### [3.0.48] - 2020-04-21
- fix: 通过 HttpWebRequest.Host 属性而非 HttpWebRequest.Headers 集合设置 Host 头值

### [3.0.15] - 2019-03-07
- feat: 支持 TC3-HAMC-SHA256
