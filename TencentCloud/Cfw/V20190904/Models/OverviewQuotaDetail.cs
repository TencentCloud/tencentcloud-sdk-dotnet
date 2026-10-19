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

    public class OverviewQuotaDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>已使用公网 IP 数量。</p>
        /// </summary>
        [JsonProperty("PublicIpUsed")]
        public long? PublicIpUsed{ get; set; }

        /// <summary>
        /// <p>公网 IP 总配额数量。</p>
        /// </summary>
        [JsonProperty("PublicIpTotal")]
        public long? PublicIpTotal{ get; set; }

        /// <summary>
        /// <p>通用实例总配额数量。</p>
        /// </summary>
        [JsonProperty("CommonInstanceTotal")]
        public long? CommonInstanceTotal{ get; set; }

        /// <summary>
        /// <p>通用实例剩余配额数量。</p>
        /// </summary>
        [JsonProperty("CommonInstanceRemain")]
        public long? CommonInstanceRemain{ get; set; }

        /// <summary>
        /// <p>通用实例已使用数量。</p>
        /// </summary>
        [JsonProperty("CommonInstanceUsed")]
        public long? CommonInstanceUsed{ get; set; }

        /// <summary>
        /// <p>访问控制规则已使用数量。</p>
        /// </summary>
        [JsonProperty("AccessControlRuleUsed")]
        public long? AccessControlRuleUsed{ get; set; }

        /// <summary>
        /// <p>访问控制规则总配额数量。</p>
        /// </summary>
        [JsonProperty("AccessControlRuleTotal")]
        public long? AccessControlRuleTotal{ get; set; }

        /// <summary>
        /// <p>已使用串行地域数量。</p>
        /// </summary>
        [JsonProperty("SerialRegionUsed")]
        public long? SerialRegionUsed{ get; set; }

        /// <summary>
        /// <p>已使用 NAT 防火墙实例数量。</p>
        /// </summary>
        [JsonProperty("NatInstanceUsed")]
        public long? NatInstanceUsed{ get; set; }

        /// <summary>
        /// <p>已使用 VPC 防火墙实例数量。</p>
        /// </summary>
        [JsonProperty("VpcInstanceUsed")]
        public long? VpcInstanceUsed{ get; set; }

        /// <summary>
        /// <p>边界规则配额详情。</p>
        /// </summary>
        [JsonProperty("BorderRuleQuota")]
        public OverviewCommonRuleQuotaDetail BorderRuleQuota{ get; set; }

        /// <summary>
        /// <p>NAT 规则配额详情。</p>
        /// </summary>
        [JsonProperty("NatRuleQuota")]
        public OverviewCommonRuleQuotaDetail NatRuleQuota{ get; set; }

        /// <summary>
        /// <p>VPC 规则配额详情。</p>
        /// </summary>
        [JsonProperty("VpcRuleQuota")]
        public OverviewVpcRuleQuotaDetail VpcRuleQuota{ get; set; }

        /// <summary>
        /// <p>封禁列表配额统计信息。</p>
        /// </summary>
        [JsonProperty("BlockListQuota")]
        public OverviewBlockListQuota BlockListQuota{ get; set; }

        /// <summary>
        /// <p>封禁 IP 总数量。</p>
        /// </summary>
        [JsonProperty("BlockIpCount")]
        public long? BlockIpCount{ get; set; }

        /// <summary>
        /// <p>已使用封禁 IP 数量。</p>
        /// </summary>
        [JsonProperty("BlockIpUsed")]
        public long? BlockIpUsed{ get; set; }

        /// <summary>
        /// <p>封禁 IP 总配额数量。</p>
        /// </summary>
        [JsonProperty("BlockIpTotal")]
        public long? BlockIpTotal{ get; set; }

        /// <summary>
        /// <p>封禁列表基础包与扩容包配额详情。</p>
        /// </summary>
        [JsonProperty("BlockListQuotaDetail")]
        public OverviewBlockListQuotaDetail BlockListQuotaDetail{ get; set; }

        /// <summary>
        /// <p>安全组规则已使用数量。</p>
        /// </summary>
        [JsonProperty("SgRuleQuotaUsed")]
        public long? SgRuleQuotaUsed{ get; set; }

        /// <summary>
        /// <p>安全组规则总配额数量。</p>
        /// </summary>
        [JsonProperty("SgRuleQuotaTotal")]
        public long? SgRuleQuotaTotal{ get; set; }

        /// <summary>
        /// <p>总扩容资源已使用数量。</p>
        /// </summary>
        [JsonProperty("TotalExtensionUsed")]
        public long? TotalExtensionUsed{ get; set; }

        /// <summary>
        /// <p>总扩容资源配额数量。</p>
        /// </summary>
        [JsonProperty("TotalExtensionNum")]
        public long? TotalExtensionNum{ get; set; }

        /// <summary>
        /// <p>地址模板已使用数量。</p>
        /// </summary>
        [JsonProperty("AddressTemplateUsed")]
        public long? AddressTemplateUsed{ get; set; }

        /// <summary>
        /// <p>地址模板总配额数量。</p>
        /// </summary>
        [JsonProperty("AddressTemplateTotal")]
        public long? AddressTemplateTotal{ get; set; }

        /// <summary>
        /// <p>蜜罐已使用数量。</p>
        /// </summary>
        [JsonProperty("HoneyPotUsed")]
        public long? HoneyPotUsed{ get; set; }

        /// <summary>
        /// <p>蜜罐总配额数量。</p>
        /// </summary>
        [JsonProperty("HoneyPotTotal")]
        public long? HoneyPotTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicIpUsed", this.PublicIpUsed);
            this.SetParamSimple(map, prefix + "PublicIpTotal", this.PublicIpTotal);
            this.SetParamSimple(map, prefix + "CommonInstanceTotal", this.CommonInstanceTotal);
            this.SetParamSimple(map, prefix + "CommonInstanceRemain", this.CommonInstanceRemain);
            this.SetParamSimple(map, prefix + "CommonInstanceUsed", this.CommonInstanceUsed);
            this.SetParamSimple(map, prefix + "AccessControlRuleUsed", this.AccessControlRuleUsed);
            this.SetParamSimple(map, prefix + "AccessControlRuleTotal", this.AccessControlRuleTotal);
            this.SetParamSimple(map, prefix + "SerialRegionUsed", this.SerialRegionUsed);
            this.SetParamSimple(map, prefix + "NatInstanceUsed", this.NatInstanceUsed);
            this.SetParamSimple(map, prefix + "VpcInstanceUsed", this.VpcInstanceUsed);
            this.SetParamObj(map, prefix + "BorderRuleQuota.", this.BorderRuleQuota);
            this.SetParamObj(map, prefix + "NatRuleQuota.", this.NatRuleQuota);
            this.SetParamObj(map, prefix + "VpcRuleQuota.", this.VpcRuleQuota);
            this.SetParamObj(map, prefix + "BlockListQuota.", this.BlockListQuota);
            this.SetParamSimple(map, prefix + "BlockIpCount", this.BlockIpCount);
            this.SetParamSimple(map, prefix + "BlockIpUsed", this.BlockIpUsed);
            this.SetParamSimple(map, prefix + "BlockIpTotal", this.BlockIpTotal);
            this.SetParamObj(map, prefix + "BlockListQuotaDetail.", this.BlockListQuotaDetail);
            this.SetParamSimple(map, prefix + "SgRuleQuotaUsed", this.SgRuleQuotaUsed);
            this.SetParamSimple(map, prefix + "SgRuleQuotaTotal", this.SgRuleQuotaTotal);
            this.SetParamSimple(map, prefix + "TotalExtensionUsed", this.TotalExtensionUsed);
            this.SetParamSimple(map, prefix + "TotalExtensionNum", this.TotalExtensionNum);
            this.SetParamSimple(map, prefix + "AddressTemplateUsed", this.AddressTemplateUsed);
            this.SetParamSimple(map, prefix + "AddressTemplateTotal", this.AddressTemplateTotal);
            this.SetParamSimple(map, prefix + "HoneyPotUsed", this.HoneyPotUsed);
            this.SetParamSimple(map, prefix + "HoneyPotTotal", this.HoneyPotTotal);
        }
    }
}

