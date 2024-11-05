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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GateWayAsset : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 私有ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 私有网络id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 出向峰值带宽
        /// </summary>
        [JsonProperty("OutboundPeakBandwidth")]
        public string OutboundPeakBandwidth{ get; set; }

        /// <summary>
        /// 入向峰值带宽
        /// </summary>
        [JsonProperty("InboundPeakBandwidth")]
        public string InboundPeakBandwidth{ get; set; }

        /// <summary>
        /// 出站累计流量
        /// </summary>
        [JsonProperty("OutboundCumulativeFlow")]
        public string OutboundCumulativeFlow{ get; set; }

        /// <summary>
        /// 入站累计流量
        /// </summary>
        [JsonProperty("InboundCumulativeFlow")]
        public string InboundCumulativeFlow{ get; set; }

        /// <summary>
        /// 网络攻击
        /// </summary>
        [JsonProperty("NetworkAttack")]
        public long? NetworkAttack{ get; set; }

        /// <summary>
        /// 暴露端口
        /// </summary>
        [JsonProperty("ExposedPort")]
        public long? ExposedPort{ get; set; }

        /// <summary>
        /// 暴露漏洞
        /// </summary>
        [JsonProperty("ExposedVUL")]
        public long? ExposedVUL{ get; set; }

        /// <summary>
        /// 配置风险
        /// </summary>
        [JsonProperty("ConfigureRisk")]
        public long? ConfigureRisk{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务数
        /// </summary>
        [JsonProperty("ScanTask")]
        public long? ScanTask{ get; set; }

        /// <summary>
        /// 最后扫描时间
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// ipv6地址
        /// </summary>
        [JsonProperty("AddressIPV6")]
        public string AddressIPV6{ get; set; }

        /// <summary>
        /// 是否核心
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// 风险服务暴露
        /// </summary>
        [JsonProperty("RiskExposure")]
        public long? RiskExposure{ get; set; }

        /// <summary>
        /// 是否新资产 1新
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// 网关状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// TSE的网关真实地域
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "OutboundPeakBandwidth", this.OutboundPeakBandwidth);
            this.SetParamSimple(map, prefix + "InboundPeakBandwidth", this.InboundPeakBandwidth);
            this.SetParamSimple(map, prefix + "OutboundCumulativeFlow", this.OutboundCumulativeFlow);
            this.SetParamSimple(map, prefix + "InboundCumulativeFlow", this.InboundCumulativeFlow);
            this.SetParamSimple(map, prefix + "NetworkAttack", this.NetworkAttack);
            this.SetParamSimple(map, prefix + "ExposedPort", this.ExposedPort);
            this.SetParamSimple(map, prefix + "ExposedVUL", this.ExposedVUL);
            this.SetParamSimple(map, prefix + "ConfigureRisk", this.ConfigureRisk);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "AddressIPV6", this.AddressIPV6);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "RiskExposure", this.RiskExposure);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
        }
    }
}

