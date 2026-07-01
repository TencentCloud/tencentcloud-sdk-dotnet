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

    public class EdrAlertDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>主键ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>租户ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>告警唯一标识</p>
        /// </summary>
        [JsonProperty("AlertId")]
        public string AlertId{ get; set; }

        /// <summary>
        /// <p>告警大类（英文枚举：VIRUS_TROJAN/ABNORMAL_LOGIN/HOST_BEHAVIOR/NETWORK_BEHAVIOR/LINK_ENGINE）</p>
        /// </summary>
        [JsonProperty("AlertCategory")]
        public string AlertCategory{ get; set; }

        /// <summary>
        /// <p>告警子类型（英文枚举：MALWARE_FILE/MALWARE_PROCESS/RISK_LOGIN/BRUTE_FORCE/DNS/BASH/PRIV_ESCALATION/REVERSE_SHELL/NET_ATTACK/VUL_DEFENCE/MEMORY_SHELL_INJECT/MEMORY_SHELL_SCAN/MULTI_BEHAVIOR_ATTACK）</p>
        /// </summary>
        [JsonProperty("AlertSubType")]
        public string AlertSubType{ get; set; }

        /// <summary>
        /// <p>关联规则ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>规则类型: 0-系统规则 1-用户自定义</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>告警等级（英文枚举：CRITICAL/HIGH/MEDIUM/LOW/INFO）</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>处理状态（英文枚举：PENDING/PROCESSED/WHITELISTED/ISOLATED/CLEANED/IGNORED/ISOLATING/RESTORING/BLOCKED/DELETED）</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>ATT&amp;CK攻击阶段</p>
        /// </summary>
        [JsonProperty("AttackStage")]
        public string AttackStage{ get; set; }

        /// <summary>
        /// <p>检测模式（英文枚举：PRECISE/BALANCED/DEEP）</p>
        /// </summary>
        [JsonProperty("DetectMode")]
        public string DetectMode{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>主机UUID</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>聚合事件数</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>是否付费版</p>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public long? IsProVersion{ get; set; }

        /// <summary>
        /// <p>告警来源（英文枚举：HOST/CONTAINER/K8S/CSIP）</p>
        /// </summary>
        [JsonProperty("AlertSource")]
        public string AlertSource{ get; set; }

        /// <summary>
        /// <p>容器镜像ID（保留字段，恒为空串）</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>容器ID（保留字段，恒为空串）</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>集群ID（保留字段，恒为空串）</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>首次发现时间</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间</p>
        /// </summary>
        [JsonProperty("LatestDetectTime")]
        public string LatestDetectTime{ get; set; }

        /// <summary>
        /// <p>规则名称（规则富化）</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>内容类型: md5/cmdline/dns/ip_inbound/ip_outbound/custom_file/process_network</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>实例名（资产富化）</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>公网IP（资产富化）</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>内网IP（资产富化）</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>告警详情JSON字符串（前端通过JSON.parse解析，空值为&quot;{}&quot;）</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>告警名称（子类型中英文名）</p>
        /// </summary>
        [JsonProperty("AlertName")]
        public string AlertName{ get; set; }

        /// <summary>
        /// <p>安全中心标签</p>
        /// </summary>
        [JsonProperty("CSIPTags")]
        public CSIPTag[] CSIPTags{ get; set; }

        /// <summary>
        /// <p>危害描述（统一字段，合并原各子类型独立字段）</p>
        /// </summary>
        [JsonProperty("HarmDesc")]
        public string HarmDesc{ get; set; }

        /// <summary>
        /// <p>修复建议（统一字段）</p>
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// <p>数据来源: vuldb/vdc/intel/default</p>
        /// </summary>
        [JsonProperty("HarmDescSource")]
        public string HarmDescSource{ get; set; }

        /// <summary>
        /// <p>统一威胁情报标签（按子类型路由不同情报源）</p>
        /// </summary>
        [JsonProperty("ThreatTags")]
        public string[] ThreatTags{ get; set; }

        /// <summary>
        /// <p>Base64解码后的命令（高危命令子类型独有）</p>
        /// </summary>
        [JsonProperty("BashCmdDecoded")]
        public string BashCmdDecoded{ get; set; }

        /// <summary>
        /// <p>漏洞名称（网络攻击子类型独有）</p>
        /// </summary>
        [JsonProperty("NetVulName")]
        public string NetVulName{ get; set; }

        /// <summary>
        /// <p>CVE编号（网络攻击子类型独有）</p>
        /// </summary>
        [JsonProperty("NetCVEId")]
        public string NetCVEId{ get; set; }

        /// <summary>
        /// <p>异常行为（网络攻击子类型独有）</p>
        /// </summary>
        [JsonProperty("NetAbnormalAction")]
        public string NetAbnormalAction{ get; set; }

        /// <summary>
        /// <p>IP情报信息（为空时不返回）</p>
        /// </summary>
        [JsonProperty("IPIntel")]
        public IPIntelInfo IPIntel{ get; set; }

        /// <summary>
        /// <p>多行为攻击规则类型分类: sequence/threshold/command</p>
        /// </summary>
        [JsonProperty("MultiBehaviorDetectionMode")]
        public string MultiBehaviorDetectionMode{ get; set; }

        /// <summary>
        /// <p>告警来源描述（按子类型派生，描述哪个引擎/规则检出）</p>
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// <p>处理时间参数格式：2026-05-26 19:45:48</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>情报富化结果来源（标识本次详情是否成功命中外部情报）；取值 &quot;VDC&quot; / &quot;IPAnalysis&quot; / &quot;BreakingTI&quot; / 空串</p>
        /// </summary>
        [JsonProperty("IntelSource")]
        public string IntelSource{ get; set; }

        /// <summary>
        /// <p>综合研判，中英文已翻译，中：恶意/安全/未知；英：Malicious/Safe/Unknown</p>
        /// </summary>
        [JsonProperty("Verdict")]
        public string Verdict{ get; set; }

        /// <summary>
        /// <p>研判依据</p>
        /// </summary>
        [JsonProperty("VerdictBasis")]
        public string VerdictBasis{ get; set; }

        /// <summary>
        /// <p>病毒名称</p>
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// <p>病毒家族</p>
        /// </summary>
        [JsonProperty("VirusFamily")]
        public string VirusFamily{ get; set; }

        /// <summary>
        /// <p>NetResponsePayload 响应数据包（base64 编码后的字符串）</p>
        /// </summary>
        [JsonProperty("NetResponsePayload")]
        public string NetResponsePayload{ get; set; }

        /// <summary>
        /// <p>服务进程信息（base64 编码后的 JSON 字符串）</p>
        /// </summary>
        [JsonProperty("NetSvcPs")]
        public string NetSvcPs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AlertId", this.AlertId);
            this.SetParamSimple(map, prefix + "AlertCategory", this.AlertCategory);
            this.SetParamSimple(map, prefix + "AlertSubType", this.AlertSubType);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AttackStage", this.AttackStage);
            this.SetParamSimple(map, prefix + "DetectMode", this.DetectMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "AlertSource", this.AlertSource);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LatestDetectTime", this.LatestDetectTime);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "AlertName", this.AlertName);
            this.SetParamArrayObj(map, prefix + "CSIPTags.", this.CSIPTags);
            this.SetParamSimple(map, prefix + "HarmDesc", this.HarmDesc);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "HarmDescSource", this.HarmDescSource);
            this.SetParamArraySimple(map, prefix + "ThreatTags.", this.ThreatTags);
            this.SetParamSimple(map, prefix + "BashCmdDecoded", this.BashCmdDecoded);
            this.SetParamSimple(map, prefix + "NetVulName", this.NetVulName);
            this.SetParamSimple(map, prefix + "NetCVEId", this.NetCVEId);
            this.SetParamSimple(map, prefix + "NetAbnormalAction", this.NetAbnormalAction);
            this.SetParamObj(map, prefix + "IPIntel.", this.IPIntel);
            this.SetParamSimple(map, prefix + "MultiBehaviorDetectionMode", this.MultiBehaviorDetectionMode);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "IntelSource", this.IntelSource);
            this.SetParamSimple(map, prefix + "Verdict", this.Verdict);
            this.SetParamSimple(map, prefix + "VerdictBasis", this.VerdictBasis);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "VirusFamily", this.VirusFamily);
            this.SetParamSimple(map, prefix + "NetResponsePayload", this.NetResponsePayload);
            this.SetParamSimple(map, prefix + "NetSvcPs", this.NetSvcPs);
        }
    }
}

