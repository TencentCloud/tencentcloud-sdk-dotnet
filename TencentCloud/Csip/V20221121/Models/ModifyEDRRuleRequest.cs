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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEDRRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略类型 / Rule Type: 0-系统策略/System Rule, 1-自定义策略/Custom Rule</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>执行动作 / Action: 0-告警/Alert, 1-放行/Allow, 2-告警并拦截/Alert and Block</p>
        /// </summary>
        [JsonProperty("AlertAction")]
        public long? AlertAction{ get; set; }

        /// <summary>
        /// <p>生效资产 / Effective Scope: 0-指定主机/Specified Hosts, 1-全部主机/All Hosts, 2-专业版/Professional, 3-旗舰版/Flagship, 4-专业版+旗舰版/Professional+Flagship     QUUIDS        []string json:&quot;QUUIDS&quot;                                      // 主机列表 / Host QUUIDS (when Scope=0)</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>容器生效镜像范围 / Container Image Scope: 0-指定镜像/Specified Images, 1-全部镜像/All Images</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>开关 / Status: 0-开启/Enabled, 1-关闭/Disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>内容类型 / Content Type: md5-文件MD5/File MD5, cmdline-命令行/Command Line, dns-DNS, ip_inbound-入站IP/Inbound IP, ip_outbound-出站IP/Outbound IP, custom_file-自定义文件/Custom File, process_network-进程网络/Process Network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>告警等级 / Alert Level: 1-高危/High, 2-中危/Medium, 3-低危/Low, 4-提示/Reminder</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>检测模式 / Detect Mode: 0-精准/Precise, 1-均衡/Balanced, 2-深度/Deep</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public long? DetectMode{ get; set; }

        /// <summary>
        /// <p>攻击阶段</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>策略</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>处理历史告警 / Handle Old Events: 0-否/No, 1-是/Yes</p>
        /// </summary>
        [JsonProperty("DealOldEvents")]
        public long? DealOldEvents{ get; set; }

        /// <summary>
        /// <p>ContentType=md5 时传入的 MD5 列表</p>
        /// </summary>
        [JsonProperty("Md5List")]
        public string[] Md5List{ get; set; }

        /// <summary>
        /// <p>ContentType=custom_file 时传入的文件名列表(Base64编码)</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string[] FileName{ get; set; }

        /// <summary>
        /// <p>ContentType=custom_file 时传入的文件目录列表(Base64编码)</p>
        /// </summary>
        [JsonProperty("FileDirectory")]
        public string[] FileDirectory{ get; set; }

        /// <summary>
        /// <p>ContentType=cmdline 时传入的命令行规则，Process/PProcess/AProcess 的 Exe/Cmdline 字段需要 Base64 编码</p>
        /// </summary>
        [JsonProperty("CmdLineRules")]
        public RuleContentCmdLine CmdLineRules{ get; set; }

        /// <summary>
        /// <p>ContentType=dns 时传入的域名列表(Base64编码)</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>ContentType=ip_outbound 时传入的出站IP列表(Base64编码)</p>
        /// </summary>
        [JsonProperty("OutboundIP")]
        public string[] OutboundIP{ get; set; }

        /// <summary>
        /// <p>ContentType=ip_inbound 时传入的入站IP列表(Base64编码)</p>
        /// </summary>
        [JsonProperty("InboundIP")]
        public string[] InboundIP{ get; set; }

        /// <summary>
        /// <p>镜像ID列表 / Image IDs (when TCSSScope=0)</p>
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// <p>ContentType=process_network 时传入的进程网络规则</p>
        /// </summary>
        [JsonProperty("ProcessNetworkRules")]
        public RuleContentProcessNetwork ProcessNetworkRules{ get; set; }

        /// <summary>
        /// <p>选择的多账号的APPID</p>
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>告警的加白目标机器信息</p>
        /// </summary>
        [JsonProperty("Target")]
        public EdrAlertTarget Target{ get; set; }

        /// <summary>
        /// <p>自选资产对应的实例ID和APPID</p>
        /// </summary>
        [JsonProperty("InstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] InstanceIDsWithAppId{ get; set; }

        /// <summary>
        /// <p>全选资产排除的实例ID和APPID</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDsWithAppId")]
        public InstanceIDWithAppIdItem[] ExcludeInstanceIDsWithAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "AlertAction", this.AlertAction);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DealOldEvents", this.DealOldEvents);
            this.SetParamArraySimple(map, prefix + "Md5List.", this.Md5List);
            this.SetParamArraySimple(map, prefix + "FileName.", this.FileName);
            this.SetParamArraySimple(map, prefix + "FileDirectory.", this.FileDirectory);
            this.SetParamObj(map, prefix + "CmdLineRules.", this.CmdLineRules);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "OutboundIP.", this.OutboundIP);
            this.SetParamArraySimple(map, prefix + "InboundIP.", this.InboundIP);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamObj(map, prefix + "ProcessNetworkRules.", this.ProcessNetworkRules);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamObj(map, prefix + "Target.", this.Target);
            this.SetParamArrayObj(map, prefix + "InstanceIDsWithAppId.", this.InstanceIDsWithAppId);
            this.SetParamArrayObj(map, prefix + "ExcludeInstanceIDsWithAppId.", this.ExcludeInstanceIDsWithAppId);
        }
    }
}

