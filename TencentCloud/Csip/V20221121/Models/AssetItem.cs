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

    public class AssetItem : AbstractModel
    {
        
        /// <summary>
        /// <p>租户ID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>云厂商</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>云厂商名称</p>
        /// </summary>
        [JsonProperty("ProviderName")]
        public string ProviderName{ get; set; }

        /// <summary>
        /// <p>云账号ID</p>
        /// </summary>
        [JsonProperty("CloudAccountID")]
        public string CloudAccountID{ get; set; }

        /// <summary>
        /// <p>云账号名称</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>资产ID</p>
        /// </summary>
        [JsonProperty("AssetID")]
        public string AssetID{ get; set; }

        /// <summary>
        /// <p>资产名称</p>
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// <p>资产类型</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>资产类型名称</p>
        /// </summary>
        [JsonProperty("AssetTypeName")]
        public string AssetTypeName{ get; set; }

        /// <summary>
        /// <p>资产运行状态</p>
        /// </summary>
        [JsonProperty("AssetStatus")]
        public string AssetStatus{ get; set; }

        /// <summary>
        /// <p>是否公网暴露</p>
        /// </summary>
        [JsonProperty("PublicExpose")]
        public ulong? PublicExpose{ get; set; }

        /// <summary>
        /// <p>资产标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// <p>公网ip</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>内网ip</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>公网域名</p>
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// <p>内网域名</p>
        /// </summary>
        [JsonProperty("PrivateDomain")]
        public string PrivateDomain{ get; set; }

        /// <summary>
        /// <p>防护状态</p>
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public ulong? ProtectStatus{ get; set; }

        /// <summary>
        /// <p>风险数量</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// <p>告警数量</p>
        /// </summary>
        [JsonProperty("AlarmCount")]
        public ulong? AlarmCount{ get; set; }

        /// <summary>
        /// <p>实例创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>首次同步时间</p>
        /// </summary>
        [JsonProperty("FirstSyncTime")]
        public string FirstSyncTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>操作系统名称</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>严重风险总数</p>
        /// </summary>
        [JsonProperty("CriticalRiskCount")]
        public ulong? CriticalRiskCount{ get; set; }

        /// <summary>
        /// <p>高风险总数</p>
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public ulong? HighRiskCount{ get; set; }

        /// <summary>
        /// <p>中风险总数</p>
        /// </summary>
        [JsonProperty("MediumRiskCount")]
        public ulong? MediumRiskCount{ get; set; }

        /// <summary>
        /// <p>低风险总数</p>
        /// </summary>
        [JsonProperty("LowRiskCount")]
        public ulong? LowRiskCount{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>地域名称</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>资产唯一ID</p>
        /// </summary>
        [JsonProperty("AssetRID")]
        public string AssetRID{ get; set; }

        /// <summary>
        /// <p>云安全中心标签</p>
        /// </summary>
        [JsonProperty("CustomTags")]
        public CustomTag[] CustomTags{ get; set; }

        /// <summary>
        /// <p>资产类型图标</p>
        /// </summary>
        [JsonProperty("AssetTypeIconURL")]
        public string AssetTypeIconURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "ProviderName", this.ProviderName);
            this.SetParamSimple(map, prefix + "CloudAccountID", this.CloudAccountID);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "AssetID", this.AssetID);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetTypeName", this.AssetTypeName);
            this.SetParamSimple(map, prefix + "AssetStatus", this.AssetStatus);
            this.SetParamSimple(map, prefix + "PublicExpose", this.PublicExpose);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "PrivateDomain", this.PrivateDomain);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FirstSyncTime", this.FirstSyncTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "CriticalRiskCount", this.CriticalRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MediumRiskCount", this.MediumRiskCount);
            this.SetParamSimple(map, prefix + "LowRiskCount", this.LowRiskCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "AssetRID", this.AssetRID);
            this.SetParamArrayObj(map, prefix + "CustomTags.", this.CustomTags);
            this.SetParamSimple(map, prefix + "AssetTypeIconURL", this.AssetTypeIconURL);
        }
    }
}

