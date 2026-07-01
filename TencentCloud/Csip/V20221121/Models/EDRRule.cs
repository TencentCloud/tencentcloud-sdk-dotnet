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

    public class EDRRule : AbstractModel
    {
        
        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>策略类型，0-系统策略/System Rule, 1-自定义策略/Custom Rule</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>内容类型 / Content Type: md5-文件MD5/File MD5, cmdline-命令行/Command Line, dns-DNS, ip_inbound-入站IP/Inbound IP, ip_outbound-出站IP/Outbound IP, custom_file-自定义文件/Custom File, process_network-进程网络/Process Network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>执行动作 / Action: 0-告警/Alert, 1-放行/Allow, 2-告警并拦截/Alert and Block</p>
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// <p>告警等级 / Alert Level: 0-无/None, 1-高危/High, 2-中危/Medium, 3-低危/Low, 4-提示/Reminder</p>
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// <p>检测模式 / Detect Mode: 0-精准/Precise, 1-均衡/Balanced, 2-深度/Deep</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public long? DetectMode{ get; set; }

        /// <summary>
        /// <p>检测方式 / Detect Type: 0-主机检测/Host Detection, 1-网络检测/Network Detection</p>
        /// </summary>
        [JsonProperty("DetectType")]
        public long? DetectType{ get; set; }

        /// <summary>
        /// <p>攻击阶段</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>主机生效资产范围 / Effective Scope: 0-指定主机/Specified Hosts, 1-全部主机/All Hosts, 2-专业版/Professional, 3-旗舰版/Flagship, 4-专业版+旗舰版/Professional+Flagship</p>
        /// </summary>
        [JsonProperty("CWPScope")]
        public long? CWPScope{ get; set; }

        /// <summary>
        /// <p>主机运行时的自选主机</p>
        /// </summary>
        [JsonProperty("QUUIDS")]
        public string[] QUUIDS{ get; set; }

        /// <summary>
        /// <p>状态 / Status: 0-开启/Enabled, 1-关闭/Disabled</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>是否支持拦截 / Support Block: 0-不支持/Not Supported, 1-支持/Supported</p>
        /// </summary>
        [JsonProperty("SupportBlock")]
        public long? SupportBlock{ get; set; }

        /// <summary>
        /// <p>MD5列表,ContentType=md5 时填充</p>
        /// </summary>
        [JsonProperty("Md5List")]
        public string[] Md5List{ get; set; }

        /// <summary>
        /// <p>文件名列表,ContentType=custom_file 时填充</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string[] FileName{ get; set; }

        /// <summary>
        /// <p>文件目录列表,ContentType=custom_file 时填充</p>
        /// </summary>
        [JsonProperty("FileDirectory")]
        public string[] FileDirectory{ get; set; }

        /// <summary>
        /// <p>域名列表,ContentType=dns 时填充</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>出站IP列表,ContentType=ip_outbound 时填充</p>
        /// </summary>
        [JsonProperty("OutboundIP")]
        public string[] OutboundIP{ get; set; }

        /// <summary>
        /// <p>入站IP列表,ContentType=ip_inbound 时填充</p>
        /// </summary>
        [JsonProperty("InboundIP")]
        public string[] InboundIP{ get; set; }

        /// <summary>
        /// <p>命令行规则,ContentType=cmdline 时填充</p>
        /// </summary>
        [JsonProperty("CmdLineRules")]
        public RuleContentCmdLine CmdLineRules{ get; set; }

        /// <summary>
        /// <p>容器生效镜像范围 / Container Image Scope: 0-指定镜像/Specified Images, 1-全部镜像/All Images</p>
        /// </summary>
        [JsonProperty("TCSSScope")]
        public long? TCSSScope{ get; set; }

        /// <summary>
        /// <p>生效镜像ID列表 / Image IDs (when TCSSScope=0)</p>
        /// </summary>
        [JsonProperty("ImageIDs")]
        public string[] ImageIDs{ get; set; }

        /// <summary>
        /// <p>镜像名正则表达式 / Image Names Regex</p>
        /// </summary>
        [JsonProperty("ImageNamesRegex")]
        public string ImageNamesRegex{ get; set; }

        /// <summary>
        /// <p>置信度 / Confidence: 0-低/Low, 1-中/Medium, 2-高/High</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// <p>排除的主机列表 / Excluded Host QUUIDS</p>
        /// </summary>
        [JsonProperty("ExcludeQUUIDS")]
        public string[] ExcludeQUUIDS{ get; set; }

        /// <summary>
        /// <p>排除的镜像ID列表 / Excluded Image IDs</p>
        /// </summary>
        [JsonProperty("ExcludeImageIDs")]
        public string[] ExcludeImageIDs{ get; set; }

        /// <summary>
        /// <p>进程网络规则 / Process network rules</p>
        /// </summary>
        [JsonProperty("ProcessNetworkRules")]
        public RuleContentProcessNetwork ProcessNetworkRules{ get; set; }

        /// <summary>
        /// <p>策略对应APPID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>自选实例ID范围</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>排除实例ID</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "DetectType", this.DetectType);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "CWPScope", this.CWPScope);
            this.SetParamArraySimple(map, prefix + "QUUIDS.", this.QUUIDS);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "SupportBlock", this.SupportBlock);
            this.SetParamArraySimple(map, prefix + "Md5List.", this.Md5List);
            this.SetParamArraySimple(map, prefix + "FileName.", this.FileName);
            this.SetParamArraySimple(map, prefix + "FileDirectory.", this.FileDirectory);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "OutboundIP.", this.OutboundIP);
            this.SetParamArraySimple(map, prefix + "InboundIP.", this.InboundIP);
            this.SetParamObj(map, prefix + "CmdLineRules.", this.CmdLineRules);
            this.SetParamSimple(map, prefix + "TCSSScope", this.TCSSScope);
            this.SetParamArraySimple(map, prefix + "ImageIDs.", this.ImageIDs);
            this.SetParamSimple(map, prefix + "ImageNamesRegex", this.ImageNamesRegex);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "ExcludeQUUIDS.", this.ExcludeQUUIDS);
            this.SetParamArraySimple(map, prefix + "ExcludeImageIDs.", this.ExcludeImageIDs);
            this.SetParamObj(map, prefix + "ProcessNetworkRules.", this.ProcessNetworkRules);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
        }
    }
}

