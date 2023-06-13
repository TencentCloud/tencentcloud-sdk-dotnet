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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 解析地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolveAddr")]
        public string[] ResolveAddr{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string[] AssetType{ get; set; }

        /// <summary>
        /// 漏洞风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskVulCount")]
        public ulong? RiskVulCount{ get; set; }

        /// <summary>
        /// 敏感内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveCount")]
        public ulong? SensitiveCount{ get; set; }

        /// <summary>
        /// 挂马暗链
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HorseLinkCount")]
        public ulong? HorseLinkCount{ get; set; }

        /// <summary>
        /// 网页篡改
        /// </summary>
        [JsonProperty("WebModifyCount")]
        public ulong? WebModifyCount{ get; set; }

        /// <summary>
        /// 上次扫描时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 最近发现时间
        /// </summary>
        [JsonProperty("DiscoverTime")]
        public string DiscoverTime{ get; set; }

        /// <summary>
        /// 扫描次数
        /// </summary>
        [JsonProperty("ScanTaskCount")]
        public ulong? ScanTaskCount{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("PortRisk")]
        public ulong? PortRisk{ get; set; }

        /// <summary>
        /// 弱口令
        /// </summary>
        [JsonProperty("WeekPwdCount")]
        public ulong? WeekPwdCount{ get; set; }

        /// <summary>
        /// -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetLocation")]
        public string AssetLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "ResolveAddr.", this.ResolveAddr);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamArraySimple(map, prefix + "AssetType.", this.AssetType);
            this.SetParamSimple(map, prefix + "RiskVulCount", this.RiskVulCount);
            this.SetParamSimple(map, prefix + "SensitiveCount", this.SensitiveCount);
            this.SetParamSimple(map, prefix + "HorseLinkCount", this.HorseLinkCount);
            this.SetParamSimple(map, prefix + "WebModifyCount", this.WebModifyCount);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "DiscoverTime", this.DiscoverTime);
            this.SetParamSimple(map, prefix + "ScanTaskCount", this.ScanTaskCount);
            this.SetParamSimple(map, prefix + "PortRisk", this.PortRisk);
            this.SetParamSimple(map, prefix + "WeekPwdCount", this.WeekPwdCount);
            this.SetParamSimple(map, prefix + "AssetLocation", this.AssetLocation);
        }
    }
}

