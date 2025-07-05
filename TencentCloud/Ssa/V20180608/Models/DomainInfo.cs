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
        /// 资产归属
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetLocation")]
        public string AssetLocation{ get; set; }

        /// <summary>
        /// 网络风险
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkRisk")]
        public ulong? NetworkRisk{ get; set; }

        /// <summary>
        /// 网络攻击
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkAttack")]
        public ulong? NetworkAttack{ get; set; }

        /// <summary>
        /// bot访问
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BotVisit")]
        public ulong? BotVisit{ get; set; }

        /// <summary>
        /// 网络访问
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkAccess")]
        public ulong? NetworkAccess{ get; set; }

        /// <summary>
        /// 资产创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// waf状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WafStatus")]
        public ulong? WafStatus{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetId")]
        public string[] AssetId{ get; set; }

        /// <summary>
        /// 资产名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetName")]
        public string[] AssetName{ get; set; }

        /// <summary>
        /// 类别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 是否核心资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNotCore")]
        public ulong? IsNotCore{ get; set; }

        /// <summary>
        /// 是否云外资产
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCloud")]
        public ulong? IsCloud{ get; set; }


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
            this.SetParamSimple(map, prefix + "NetworkRisk", this.NetworkRisk);
            this.SetParamSimple(map, prefix + "NetworkAttack", this.NetworkAttack);
            this.SetParamSimple(map, prefix + "BotVisit", this.BotVisit);
            this.SetParamSimple(map, prefix + "NetworkAccess", this.NetworkAccess);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "WafStatus", this.WafStatus);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamArraySimple(map, prefix + "AssetId.", this.AssetId);
            this.SetParamArraySimple(map, prefix + "AssetName.", this.AssetName);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "IsNotCore", this.IsNotCore);
            this.SetParamSimple(map, prefix + "IsCloud", this.IsCloud);
        }
    }
}

