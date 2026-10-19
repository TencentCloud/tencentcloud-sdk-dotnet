/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BashEventsInfoNew : AbstractModel
    {
        
        /// <summary>
        /// <p>数据ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>主机安全ID</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>主机ID</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>主机内网IP</p>
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// <p>平台类型</p>
        /// </summary>
        [JsonProperty("Platform")]
        public ulong? Platform{ get; set; }

        /// <summary>
        /// <p>执行命令</p>
        /// </summary>
        [JsonProperty("BashCmd")]
        public string BashCmd{ get; set; }

        /// <summary>
        /// <p>规则ID,等于0表示已规则已被删除或生效范围已修改</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则等级：1-高 2-中 3-低</p>
        /// </summary>
        [JsonProperty("RuleLevel")]
        public ulong? RuleLevel{ get; set; }

        /// <summary>
        /// <p>处理状态： 0 = 待处理 1= 已处理, 2 = 已加白， 3= 已忽略</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>发生时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>主机名</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>进程名称</p>
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// <p>处理时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>规则类别  0=系统规则，1=用户规则</p>
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// <p>自动生成的正则表达式</p>
        /// </summary>
        [JsonProperty("RegexBashCmd")]
        public string RegexBashCmd{ get; set; }

        /// <summary>
        /// <p>进程树 json  pid:进程id，exe:文件路径 ，account:进程所属用组和用户 ,cmdline:执行命令，ssh_service: SSH服务ip, ssh_soure:登录源</p>
        /// </summary>
        [JsonProperty("PsTree")]
        public string PsTree{ get; set; }

        /// <summary>
        /// <p>建议方案</p>
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>参考链接</p>
        /// </summary>
        [JsonProperty("References")]
        public string[] References{ get; set; }

        /// <summary>
        /// <p>主机外网ip</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>主机在线状态 OFFLINE  ONLINE</p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>登录用户</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>进程号</p>
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// <p>0:普通 1:专业版 2:旗舰版</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public long? MachineType{ get; set; }

        /// <summary>
        /// <p>检测来源 0:bash日志 1:实时监控</p>
        /// </summary>
        [JsonProperty("DetectBy")]
        public long? DetectBy{ get; set; }

        /// <summary>
        /// <p>执行命令(解码后)</p>
        /// </summary>
        [JsonProperty("BashCmdDecoded")]
        public string BashCmdDecoded{ get; set; }

        /// <summary>
        /// <p>告警次数：同一聚合维度当天的告警命中次数，老数据为空</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// <p>首次发现时间（格式 yyyy-MM-dd HH:mm:ss）</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间（格式 yyyy-MM-dd HH:mm:ss）</p>
        /// </summary>
        [JsonProperty("LatestDetectTime")]
        public string LatestDetectTime{ get; set; }

        /// <summary>
        /// <p>进程MD5（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileProcessMd5")]
        public string FileProcessMd5{ get; set; }

        /// <summary>
        /// <p>动作：进程对文件的操作，如 读/写/重命名/删除/清空内容（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileAction")]
        public string FileAction{ get; set; }

        /// <summary>
        /// <p>文件路径（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>文件MD5（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// <p>文件名称（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件大小（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public string FileSize{ get; set; }

        /// <summary>
        /// <p>文件修改时间（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FileModifyTime")]
        public string FileModifyTime{ get; set; }

        /// <summary>
        /// <p>文件权限（文件监控行为独有）</p>
        /// </summary>
        [JsonProperty("FilePermission")]
        public string FilePermission{ get; set; }

        /// <summary>
        /// <p>文件访问时间</p>
        /// </summary>
        [JsonProperty("FileAccessTime")]
        public string FileAccessTime{ get; set; }

        /// <summary>
        /// <p>高危命令事件类型</p><p>枚举值：</p><ul><li>filemon： 文件监控事件</li><li>connect： 外联行为事件</li><li>process： 进程启动事件</li></ul>
        /// </summary>
        [JsonProperty("BashType")]
        public string BashType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "BashCmd", this.BashCmd);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "RegexBashCmd", this.RegexBashCmd);
            this.SetParamSimple(map, prefix + "PsTree", this.PsTree);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "DetectBy", this.DetectBy);
            this.SetParamSimple(map, prefix + "BashCmdDecoded", this.BashCmdDecoded);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LatestDetectTime", this.LatestDetectTime);
            this.SetParamSimple(map, prefix + "FileProcessMd5", this.FileProcessMd5);
            this.SetParamSimple(map, prefix + "FileAction", this.FileAction);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileModifyTime", this.FileModifyTime);
            this.SetParamSimple(map, prefix + "FilePermission", this.FilePermission);
            this.SetParamSimple(map, prefix + "FileAccessTime", this.FileAccessTime);
            this.SetParamSimple(map, prefix + "BashType", this.BashType);
        }
    }
}

