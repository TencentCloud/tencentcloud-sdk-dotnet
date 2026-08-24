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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisasterRecoveryDrillGroup : AbstractModel
    {
        
        /// <summary>
        /// 资源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 账户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 子账户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 容灾站点对ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 保护组ID
        /// </summary>
        [JsonProperty("ProtectGroupId")]
        public string ProtectGroupId{ get; set; }

        /// <summary>
        /// 演练组ID
        /// </summary>
        [JsonProperty("DrillGroupId")]
        public string DrillGroupId{ get; set; }

        /// <summary>
        /// 演练组名称
        /// </summary>
        [JsonProperty("DrillGroupName")]
        public string DrillGroupName{ get; set; }

        /// <summary>
        /// 演练组类型。枚举值：DISK / INSTANCE / CFS。
        /// </summary>
        [JsonProperty("DrillGroupType")]
        public string DrillGroupType{ get; set; }

        /// <summary>
        /// 恢复时间点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoveryTime")]
        public string RecoveryTime{ get; set; }

        /// <summary>
        /// 演练VPC
        /// </summary>
        [JsonProperty("DrillVpc")]
        public string DrillVpc{ get; set; }

        /// <summary>
        /// 演练安全组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DrillSecurityGroup")]
        public string DrillSecurityGroup{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 生命周期状态。枚举值：NORMAL / DELETED。
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// 容灾类型。枚举值：CROSS_ZONE / CROSS_REGION 等。
        /// </summary>
        [JsonProperty("DisasterRecoveryType")]
        public string DisasterRecoveryType{ get; set; }

        /// <summary>
        /// 复制技术。枚举值：SYN（同步）/ ASYN（异步）。
        /// </summary>
        [JsonProperty("CopyType")]
        public string CopyType{ get; set; }

        /// <summary>
        /// 对端云名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerCloudName")]
        public string PeerCloudName{ get; set; }

        /// <summary>
        /// 本地云名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalCloudName")]
        public string LocalCloudName{ get; set; }

        /// <summary>
        /// 生产地域
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// 生产可用区
        /// </summary>
        [JsonProperty("SourceZone")]
        public string SourceZone{ get; set; }

        /// <summary>
        /// 生产端VPC
        /// </summary>
        [JsonProperty("SourceVpc")]
        public string SourceVpc{ get; set; }

        /// <summary>
        /// 演练地域
        /// </summary>
        [JsonProperty("DrillRegion")]
        public string DrillRegion{ get; set; }

        /// <summary>
        /// 演练可用区
        /// </summary>
        [JsonProperty("DrillZone")]
        public string DrillZone{ get; set; }

        /// <summary>
        /// 数据方向。枚举值：POSITIVE（正向）/ REVERSE（反向）。
        /// </summary>
        [JsonProperty("DataDirection")]
        public string DataDirection{ get; set; }

        /// <summary>
        /// 绑定的演练资源数量。
        /// </summary>
        [JsonProperty("BindDrilledResourceCount")]
        public long? BindDrilledResourceCount{ get; set; }

        /// <summary>
        /// 演练资源状态分布（key 为状态名如 FAILED / SUCCESS，value 为该状态数量）。
        /// </summary>
        [JsonProperty("DrilledResourceStatusSet")]
        public DrilledResourceStatus[] DrilledResourceStatusSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamSimple(map, prefix + "DrillGroupId", this.DrillGroupId);
            this.SetParamSimple(map, prefix + "DrillGroupName", this.DrillGroupName);
            this.SetParamSimple(map, prefix + "DrillGroupType", this.DrillGroupType);
            this.SetParamSimple(map, prefix + "RecoveryTime", this.RecoveryTime);
            this.SetParamSimple(map, prefix + "DrillVpc", this.DrillVpc);
            this.SetParamSimple(map, prefix + "DrillSecurityGroup", this.DrillSecurityGroup);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "DisasterRecoveryType", this.DisasterRecoveryType);
            this.SetParamSimple(map, prefix + "CopyType", this.CopyType);
            this.SetParamSimple(map, prefix + "PeerCloudName", this.PeerCloudName);
            this.SetParamSimple(map, prefix + "LocalCloudName", this.LocalCloudName);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "SourceVpc", this.SourceVpc);
            this.SetParamSimple(map, prefix + "DrillRegion", this.DrillRegion);
            this.SetParamSimple(map, prefix + "DrillZone", this.DrillZone);
            this.SetParamSimple(map, prefix + "DataDirection", this.DataDirection);
            this.SetParamSimple(map, prefix + "BindDrilledResourceCount", this.BindDrilledResourceCount);
            this.SetParamArrayObj(map, prefix + "DrilledResourceStatusSet.", this.DrilledResourceStatusSet);
        }
    }
}

