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

    public class DescribeCfwAnalysisDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 分析场景。必填。full_traffic 表示全流量深度分析；east_west 表示东西向流量分析；alert_comprehensive 表示告警综合分析；asset_exposure 表示资产暴露面分析；access_troubleshoot 表示访问阻断排障分析。
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }

        /// <summary>
        /// 查询开始时间。可选，格式 YYYY-MM-DD HH:MM:SS；不传时默认查询最近 7 天。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间。可选，格式 YYYY-MM-DD HH:MM:SS；不传时默认当前时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 分析对象类型。可选，默认 user；user 表示租户全局，asset 表示资产上下文，vpc 表示 VPC 上下文，domain 表示域名上下文。选择非 user 时建议同时传 ObjectId 以限定具体对象；当前未传 ObjectId 时仍按该对象类型执行宽查询。
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 分析对象标识。ObjectType 为 asset、vpc 或 domain 时可传，用于限定具体 IP、实例 ID、VPC ID 或域名；当前为可选参数，省略时不会按具体对象过滤。
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// 目标 IP 或域名过滤。可选，常用于 access_troubleshoot，也可用于其他 Scenario；传入后优先于 ObjectType/ObjectId，并对该场景全部分析段追加源 IP、目的 IP 或目的域名过滤。
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 需要跳过的分析段名称列表。可选；不传或传空数组时执行该场景全部分析段。full_traffic 支持 beacon、dns_large、dns_dga、dns_dga_fine、dns_tunnel、icmp_tunnel、mining、p2p、remote_tool、file_transfer、high_risk_outbound、lateral_baseline、vpc_sensitive、smb_write、outbound_baseline、inbound_high_risk、tls_expired、tls_self_signed、first_seen_ip、first_seen_country、first_seen_port；east_west 支持 vpc_inter_vpc、subnet_inter、service_port、lateral_baseline、vpc_sensitive、smb_write、database_lateral；alert_comprehensive 支持 outbound_baseline、lateral_baseline、beacon、inbound_high_risk、first_seen_ip、first_seen_country、first_seen_port；asset_exposure 支持 inbound_high_risk、tls_expired、tls_self_signed、high_risk_outbound；access_troubleshoot 支持 acl_border_block、acl_nat_block、acl_vpc_block、ips_block。传入当前 Scenario 不支持的名称会返回 InvalidParameter。
        /// </summary>
        [JsonProperty("SkipSections")]
        public string[] SkipSections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "SkipSections.", this.SkipSections);
        }
    }
}

