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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则域。必填。枚举：border 互联网边界；nat NAT 边界；vpc VPC 间；enterprise_sg 企业安全组；intrusion_prevention 入侵防御。RuleType=intrusion_prevention 时还必须传 ListType。</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// <p>入侵防御列表类型。仅 RuleType=intrusion_prevention 时使用并必填。blocklist 表示封禁列表，whitelist 表示白名单策略，isolate 表示隔离列表。</p>
        /// </summary>
        [JsonProperty("ListType")]
        public string ListType{ get; set; }

        /// <summary>
        /// <p>访问方向过滤。可选。0 表示出站，1 表示入站；不传则不过滤。RuleType=intrusion_prevention 时不支持。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// <p>规则动作过滤。可选。0 表示观察，1 表示阻断，2 表示放行；不传则不过滤。</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public long? RuleAction{ get; set; }

        /// <summary>
        /// <p>启用状态过滤。可选。默认只返回启用规则；传 false 只查询禁用规则。</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>是否同时包含启用和禁用规则。可选。true 表示包含两类；不能和 Enabled 同时使用。</p>
        /// </summary>
        [JsonProperty("IncludeDisabled")]
        public bool? IncludeDisabled{ get; set; }

        /// <summary>
        /// <p>精确规则 ID 过滤。可选。用于按数值规则标识定位单条规则。</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// <p>精确公开规则标识过滤。可选。推荐在用户提供规则标识时使用。</p>
        /// </summary>
        [JsonProperty("RuleUuid")]
        public string RuleUuid{ get; set; }

        /// <summary>
        /// <p>协议过滤。可选。例如 TCP、UDP、ICMP、HTTP、HTTPS、ANY；不传则不过滤。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>源地址或源内容关键字过滤。可选，支持模糊匹配。</p>
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// <p>目的地址、目的域名或目的内容关键字过滤。可选，支持模糊匹配。</p>
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// <p>规则描述关键字过滤。可选。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>入侵防御列表关键字搜索。可选，最大 100 字符。blocklist 搜索 ioc/address/comment/rule_source；whitelist 搜索 rule_name/ioc/comment/src_ip/dst_ip；isolate 搜索实例、公网 IP、内网 IP、VPC、地域。</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>精确实例 ID 过滤。仅 RuleType=intrusion_prevention 且 ListType=isolate 时使用；写操作前后核验应使用该参数而不是 Keyword。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>是否展开模板、资产组、实例等名称。可选，默认 true；传 false 返回原始标识。</p>
        /// </summary>
        [JsonProperty("ExpandNames")]
        public bool? ExpandNames{ get; set; }

        /// <summary>
        /// <p>单页返回规则数。可选，默认 100，最大 1000。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页偏移。可选，默认 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "ListType", this.ListType);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "IncludeDisabled", this.IncludeDisabled);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ExpandNames", this.ExpandNames);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

