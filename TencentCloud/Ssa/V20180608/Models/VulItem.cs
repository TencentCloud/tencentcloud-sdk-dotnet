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

    public class VulItem : AbstractModel
    {
        
        /// <summary>
        /// 标识
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 发现时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 影响资产数
        /// </summary>
        [JsonProperty("ImpactAssetNum")]
        public long? ImpactAssetNum{ get; set; }

        /// <summary>
        /// 影响资产id
        /// </summary>
        [JsonProperty("ImpactAsset")]
        public string ImpactAsset{ get; set; }

        /// <summary>
        /// 影响资产名称
        /// </summary>
        [JsonProperty("ImpactAssetName")]
        public string ImpactAssetName{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("VulDetail")]
        public string VulDetail{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("VulRefLink")]
        public string VulRefLink{ get; set; }

        /// <summary>
        /// Md5值
        /// </summary>
        [JsonProperty("OldIdMd5")]
        public string OldIdMd5{ get; set; }

        /// <summary>
        /// 漏洞唯一标识
        /// </summary>
        [JsonProperty("UniqId")]
        public string UniqId{ get; set; }

        /// <summary>
        /// 忽略时间
        /// </summary>
        [JsonProperty("OperateTime")]
        public string OperateTime{ get; set; }

        /// <summary>
        /// 受影响资产是否下线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAssetDeleted")]
        public string IsAssetDeleted{ get; set; }

        /// <summary>
        /// 漏洞首次发现时间
        /// </summary>
        [JsonProperty("DiscoverTime")]
        public string DiscoverTime{ get; set; }

        /// <summary>
        /// 主机源信息标识符
        /// </summary>
        [JsonProperty("OriginId")]
        public ulong? OriginId{ get; set; }

        /// <summary>
        /// 资产区域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 资产所属网络
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vpcid")]
        public string Vpcid{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 资产子类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetSubType")]
        public string AssetSubType{ get; set; }

        /// <summary>
        /// 资产IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIpAll")]
        public string[] AssetIpAll{ get; set; }

        /// <summary>
        /// cvm类型的公网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// cvm类型的内网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 漏洞来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulSource")]
        public string VulSource{ get; set; }

        /// <summary>
        /// 影响URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedUrl")]
        public string AffectedUrl{ get; set; }

        /// <summary>
        /// 资产归属
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAssetCategory")]
        public long? SsaAssetCategory{ get; set; }

        /// <summary>
        /// 影响url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulUrl")]
        public string VulUrl{ get; set; }

        /// <summary>
        /// 是否扫描
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsOpen")]
        public bool? IsOpen{ get; set; }

        /// <summary>
        /// 御知主机id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YzHostId")]
        public ulong? YzHostId{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulRepairPlan")]
        public string VulRepairPlan{ get; set; }

        /// <summary>
        /// 漏洞文件路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulPath")]
        public string VulPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "ImpactAssetNum", this.ImpactAssetNum);
            this.SetParamSimple(map, prefix + "ImpactAsset", this.ImpactAsset);
            this.SetParamSimple(map, prefix + "ImpactAssetName", this.ImpactAssetName);
            this.SetParamSimple(map, prefix + "VulDetail", this.VulDetail);
            this.SetParamSimple(map, prefix + "VulRefLink", this.VulRefLink);
            this.SetParamSimple(map, prefix + "OldIdMd5", this.OldIdMd5);
            this.SetParamSimple(map, prefix + "UniqId", this.UniqId);
            this.SetParamSimple(map, prefix + "OperateTime", this.OperateTime);
            this.SetParamSimple(map, prefix + "IsAssetDeleted", this.IsAssetDeleted);
            this.SetParamSimple(map, prefix + "DiscoverTime", this.DiscoverTime);
            this.SetParamSimple(map, prefix + "OriginId", this.OriginId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Vpcid", this.Vpcid);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetSubType", this.AssetSubType);
            this.SetParamArraySimple(map, prefix + "AssetIpAll.", this.AssetIpAll);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "VulSource", this.VulSource);
            this.SetParamSimple(map, prefix + "AffectedUrl", this.AffectedUrl);
            this.SetParamSimple(map, prefix + "SsaAssetCategory", this.SsaAssetCategory);
            this.SetParamSimple(map, prefix + "VulUrl", this.VulUrl);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "YzHostId", this.YzHostId);
            this.SetParamSimple(map, prefix + "VulRepairPlan", this.VulRepairPlan);
            this.SetParamSimple(map, prefix + "VulPath", this.VulPath);
        }
    }
}

