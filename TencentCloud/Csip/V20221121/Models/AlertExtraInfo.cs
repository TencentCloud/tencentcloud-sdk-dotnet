/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlertExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// 相关攻击事件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelateEvent")]
        public RelatedEvent RelateEvent{ get; set; }

        /// <summary>
        /// 泄漏内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeakContent")]
        public string LeakContent{ get; set; }

        /// <summary>
        /// 泄漏API
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeakAPI")]
        public string LeakAPI{ get; set; }

        /// <summary>
        /// secretID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecretID")]
        public string SecretID{ get; set; }

        /// <summary>
        /// 命中规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// 规则描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleDesc")]
        public string RuleDesc{ get; set; }

        /// <summary>
        /// 协议端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtocolPort")]
        public string ProtocolPort{ get; set; }

        /// <summary>
        /// 攻击内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackContent")]
        public string AttackContent{ get; set; }

        /// <summary>
        /// 攻击IP画像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackIPProfile")]
        public string AttackIPProfile{ get; set; }

        /// <summary>
        /// 攻击IP标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackIPTags")]
        public string AttackIPTags{ get; set; }

        /// <summary>
        /// 请求方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestMethod")]
        public string RequestMethod{ get; set; }

        /// <summary>
        /// HTTP日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HttpLog")]
        public string HttpLog{ get; set; }

        /// <summary>
        /// 被攻击域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackDomain")]
        public string AttackDomain{ get; set; }

        /// <summary>
        /// 文件路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// user_agent
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 请求头
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public string RequestHeaders{ get; set; }

        /// <summary>
        /// 登录用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoginUserName")]
        public string LoginUserName{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulnerabilityName")]
        public string VulnerabilityName{ get; set; }

        /// <summary>
        /// 公共漏洞和暴露
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CVE")]
        public string CVE{ get; set; }

        /// <summary>
        /// 服务进程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceProcess")]
        public string ServiceProcess{ get; set; }

        /// <summary>
        /// 文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// 文件MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMD5")]
        public string FileMD5{ get; set; }

        /// <summary>
        /// 文件最近访问时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileLastAccessTime")]
        public string FileLastAccessTime{ get; set; }

        /// <summary>
        /// 文件修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileModifyTime")]
        public string FileModifyTime{ get; set; }

        /// <summary>
        /// 最近访问时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecentAccessTime")]
        public string RecentAccessTime{ get; set; }

        /// <summary>
        /// 最近修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecentModifyTime")]
        public string RecentModifyTime{ get; set; }

        /// <summary>
        /// 病毒名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 病毒文件标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirusFileTags")]
        public string VirusFileTags{ get; set; }

        /// <summary>
        /// 行为特征
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BehavioralCharacteristics")]
        public string BehavioralCharacteristics{ get; set; }

        /// <summary>
        /// 进程名（PID）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessNamePID")]
        public string ProcessNamePID{ get; set; }

        /// <summary>
        /// 进程路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 进程命令行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessCommandLine")]
        public string ProcessCommandLine{ get; set; }

        /// <summary>
        /// 进程权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessPermissions")]
        public string ProcessPermissions{ get; set; }

        /// <summary>
        /// 执行命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutedCommand")]
        public string ExecutedCommand{ get; set; }

        /// <summary>
        /// 受影响文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedFileName")]
        public string AffectedFileName{ get; set; }

        /// <summary>
        /// 诱饵路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DecoyPath")]
        public string DecoyPath{ get; set; }

        /// <summary>
        /// 恶意进程文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousProcessFileSize")]
        public string MaliciousProcessFileSize{ get; set; }

        /// <summary>
        /// 恶意进程文件MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousProcessFileMD5")]
        public string MaliciousProcessFileMD5{ get; set; }

        /// <summary>
        /// 恶意进程名（PID）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousProcessNamePID")]
        public string MaliciousProcessNamePID{ get; set; }

        /// <summary>
        /// 恶意进程路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousProcessPath")]
        public string MaliciousProcessPath{ get; set; }

        /// <summary>
        /// 恶意进程启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousProcessStartTime")]
        public string MaliciousProcessStartTime{ get; set; }

        /// <summary>
        /// 命令内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommandContent")]
        public string CommandContent{ get; set; }

        /// <summary>
        /// 启动用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupUser")]
        public string StartupUser{ get; set; }

        /// <summary>
        /// 用户所属组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// 新增权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewPermissions")]
        public string NewPermissions{ get; set; }

        /// <summary>
        /// 父进程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentProcess")]
        public string ParentProcess{ get; set; }

        /// <summary>
        /// 类名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// 所属类加载器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassLoader")]
        public string ClassLoader{ get; set; }

        /// <summary>
        /// 类文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassFileSize")]
        public string ClassFileSize{ get; set; }

        /// <summary>
        /// 类文件MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassFileMD5")]
        public string ClassFileMD5{ get; set; }

        /// <summary>
        /// 父类名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentClassName")]
        public string ParentClassName{ get; set; }

        /// <summary>
        /// 继承接口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InheritedInterface")]
        public string InheritedInterface{ get; set; }

        /// <summary>
        /// 注释
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 载荷内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayloadContent")]
        public string PayloadContent{ get; set; }

        /// <summary>
        /// 回连地址画像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackAddressPortrait")]
        public string CallbackAddressPortrait{ get; set; }

        /// <summary>
        /// 回连地址标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackAddressTag")]
        public string CallbackAddressTag{ get; set; }

        /// <summary>
        /// 进程MD5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessMD5")]
        public string ProcessMD5{ get; set; }

        /// <summary>
        /// 文件权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePermission")]
        public string FilePermission{ get; set; }

        /// <summary>
        /// 来源于日志分析的信息字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FromLogAnalysisData")]
        public KeyValue[] FromLogAnalysisData{ get; set; }

        /// <summary>
        /// 命中探针
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitProbe")]
        public string HitProbe{ get; set; }

        /// <summary>
        /// 命中蜜罐
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitHoneyPot")]
        public string HitHoneyPot{ get; set; }

        /// <summary>
        /// 命令列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommandList")]
        public string CommandList{ get; set; }

        /// <summary>
        /// 攻击事件描述
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackEventDesc")]
        public string AttackEventDesc{ get; set; }

        /// <summary>
        /// 进程信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessInfo")]
        public string ProcessInfo{ get; set; }

        /// <summary>
        /// 使用用户名&密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserNameAndPwd")]
        public string UserNameAndPwd{ get; set; }

        /// <summary>
        /// 主机防护策略ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyID")]
        public string StrategyID{ get; set; }

        /// <summary>
        /// 主机防护策略名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 主机防护命中策略，是策略ID和策略名称的组合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitStrategy")]
        public string HitStrategy{ get; set; }

        /// <summary>
        /// 进程名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// PID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PID")]
        public string PID{ get; set; }

        /// <summary>
        /// 容器Pod名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// 容器PodID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodID")]
        public string PodID{ get; set; }

        /// <summary>
        /// Http响应
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Response")]
        public string Response{ get; set; }

        /// <summary>
        /// 系统调用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemCall")]
        public string SystemCall{ get; set; }

        /// <summary>
        /// 操作类型verb
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Verb")]
        public string Verb{ get; set; }

        /// <summary>
        /// 日志ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogID")]
        public string LogID{ get; set; }

        /// <summary>
        /// 变更内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Different")]
        public string Different{ get; set; }

        /// <summary>
        /// 事件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 目标地址(容器反弹shell)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAddress")]
        public string TargetAddress{ get; set; }

        /// <summary>
        /// 恶意请求域名(容器恶意外联)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaliciousRequestDomain")]
        public string MaliciousRequestDomain{ get; set; }

        /// <summary>
        /// 规则类型(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 请求资源(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestURI")]
        public string RequestURI{ get; set; }

        /// <summary>
        /// 发起请求用户(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestUser")]
        public string RequestUser{ get; set; }

        /// <summary>
        /// 请求对象(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestObject")]
        public string RequestObject{ get; set; }

        /// <summary>
        /// 响应对象(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseObject")]
        public string ResponseObject{ get; set; }

        /// <summary>
        /// 文件类型(容器文件篡改)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 标签特征(容器恶意外联)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TIType")]
        public string TIType{ get; set; }

        /// <summary>
        /// 来源IP(容器K8sAPI异常请求)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RelateEvent.", this.RelateEvent);
            this.SetParamSimple(map, prefix + "LeakContent", this.LeakContent);
            this.SetParamSimple(map, prefix + "LeakAPI", this.LeakAPI);
            this.SetParamSimple(map, prefix + "SecretID", this.SecretID);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "RuleDesc", this.RuleDesc);
            this.SetParamSimple(map, prefix + "ProtocolPort", this.ProtocolPort);
            this.SetParamSimple(map, prefix + "AttackContent", this.AttackContent);
            this.SetParamSimple(map, prefix + "AttackIPProfile", this.AttackIPProfile);
            this.SetParamSimple(map, prefix + "AttackIPTags", this.AttackIPTags);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "HttpLog", this.HttpLog);
            this.SetParamSimple(map, prefix + "AttackDomain", this.AttackDomain);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "RequestHeaders", this.RequestHeaders);
            this.SetParamSimple(map, prefix + "LoginUserName", this.LoginUserName);
            this.SetParamSimple(map, prefix + "VulnerabilityName", this.VulnerabilityName);
            this.SetParamSimple(map, prefix + "CVE", this.CVE);
            this.SetParamSimple(map, prefix + "ServiceProcess", this.ServiceProcess);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileMD5", this.FileMD5);
            this.SetParamSimple(map, prefix + "FileLastAccessTime", this.FileLastAccessTime);
            this.SetParamSimple(map, prefix + "FileModifyTime", this.FileModifyTime);
            this.SetParamSimple(map, prefix + "RecentAccessTime", this.RecentAccessTime);
            this.SetParamSimple(map, prefix + "RecentModifyTime", this.RecentModifyTime);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusFileTags", this.VirusFileTags);
            this.SetParamSimple(map, prefix + "BehavioralCharacteristics", this.BehavioralCharacteristics);
            this.SetParamSimple(map, prefix + "ProcessNamePID", this.ProcessNamePID);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessCommandLine", this.ProcessCommandLine);
            this.SetParamSimple(map, prefix + "ProcessPermissions", this.ProcessPermissions);
            this.SetParamSimple(map, prefix + "ExecutedCommand", this.ExecutedCommand);
            this.SetParamSimple(map, prefix + "AffectedFileName", this.AffectedFileName);
            this.SetParamSimple(map, prefix + "DecoyPath", this.DecoyPath);
            this.SetParamSimple(map, prefix + "MaliciousProcessFileSize", this.MaliciousProcessFileSize);
            this.SetParamSimple(map, prefix + "MaliciousProcessFileMD5", this.MaliciousProcessFileMD5);
            this.SetParamSimple(map, prefix + "MaliciousProcessNamePID", this.MaliciousProcessNamePID);
            this.SetParamSimple(map, prefix + "MaliciousProcessPath", this.MaliciousProcessPath);
            this.SetParamSimple(map, prefix + "MaliciousProcessStartTime", this.MaliciousProcessStartTime);
            this.SetParamSimple(map, prefix + "CommandContent", this.CommandContent);
            this.SetParamSimple(map, prefix + "StartupUser", this.StartupUser);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "NewPermissions", this.NewPermissions);
            this.SetParamSimple(map, prefix + "ParentProcess", this.ParentProcess);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamSimple(map, prefix + "ClassLoader", this.ClassLoader);
            this.SetParamSimple(map, prefix + "ClassFileSize", this.ClassFileSize);
            this.SetParamSimple(map, prefix + "ClassFileMD5", this.ClassFileMD5);
            this.SetParamSimple(map, prefix + "ParentClassName", this.ParentClassName);
            this.SetParamSimple(map, prefix + "InheritedInterface", this.InheritedInterface);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "PayloadContent", this.PayloadContent);
            this.SetParamSimple(map, prefix + "CallbackAddressPortrait", this.CallbackAddressPortrait);
            this.SetParamSimple(map, prefix + "CallbackAddressTag", this.CallbackAddressTag);
            this.SetParamSimple(map, prefix + "ProcessMD5", this.ProcessMD5);
            this.SetParamSimple(map, prefix + "FilePermission", this.FilePermission);
            this.SetParamArrayObj(map, prefix + "FromLogAnalysisData.", this.FromLogAnalysisData);
            this.SetParamSimple(map, prefix + "HitProbe", this.HitProbe);
            this.SetParamSimple(map, prefix + "HitHoneyPot", this.HitHoneyPot);
            this.SetParamSimple(map, prefix + "CommandList", this.CommandList);
            this.SetParamSimple(map, prefix + "AttackEventDesc", this.AttackEventDesc);
            this.SetParamSimple(map, prefix + "ProcessInfo", this.ProcessInfo);
            this.SetParamSimple(map, prefix + "UserNameAndPwd", this.UserNameAndPwd);
            this.SetParamSimple(map, prefix + "StrategyID", this.StrategyID);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "HitStrategy", this.HitStrategy);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "PID", this.PID);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodID", this.PodID);
            this.SetParamSimple(map, prefix + "Response", this.Response);
            this.SetParamSimple(map, prefix + "SystemCall", this.SystemCall);
            this.SetParamSimple(map, prefix + "Verb", this.Verb);
            this.SetParamSimple(map, prefix + "LogID", this.LogID);
            this.SetParamSimple(map, prefix + "Different", this.Different);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetAddress", this.TargetAddress);
            this.SetParamSimple(map, prefix + "MaliciousRequestDomain", this.MaliciousRequestDomain);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RequestURI", this.RequestURI);
            this.SetParamSimple(map, prefix + "RequestUser", this.RequestUser);
            this.SetParamSimple(map, prefix + "RequestObject", this.RequestObject);
            this.SetParamSimple(map, prefix + "ResponseObject", this.ResponseObject);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "TIType", this.TIType);
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
        }
    }
}

