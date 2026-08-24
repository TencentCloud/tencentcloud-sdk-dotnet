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

    public class ProtectGroup : AbstractModel
    {
        
        /// <summary>
        /// 用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 保护组ID
        /// </summary>
        [JsonProperty("ProtectGroupId")]
        public string ProtectGroupId{ get; set; }

        /// <summary>
        /// 保护组名称
        /// </summary>
        [JsonProperty("ProtectGroupName")]
        public string ProtectGroupName{ get; set; }

        /// <summary>
        /// 保护组类型（产品类型，如 DISK/CFS/INSTANCE）
        /// </summary>
        [JsonProperty("ProtectGroupType")]
        public string ProtectGroupType{ get; set; }

        /// <summary>
        /// 所属容灾策略ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 所属容灾策略名称
        /// </summary>
        [JsonProperty("SitePairName")]
        public string SitePairName{ get; set; }

        /// <summary>
        /// RPO时间（单位秒）
        /// </summary>
        [JsonProperty("RecoveryPointObjective")]
        public long? RecoveryPointObjective{ get; set; }

        /// <summary>
        /// 生产地域（当 DataDirection=REVERSE 时会与 TargetRegion 自动轮转，保持用户视角一致）
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// 生产可用区（REVERSE 时与 TargetZone 自动轮转）
        /// </summary>
        [JsonProperty("SourceZone")]
        public string SourceZone{ get; set; }

        /// <summary>
        /// 生产端VPC（REVERSE 时与 TargetVpc 自动轮转）
        /// </summary>
        [JsonProperty("SourceVpc")]
        public string SourceVpc{ get; set; }

        /// <summary>
        /// 容灾地域（REVERSE 时与 SourceRegion 自动轮转）
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// 容灾可用区
        /// </summary>
        [JsonProperty("TargetZone")]
        public string TargetZone{ get; set; }

        /// <summary>
        /// 容灾端VPC
        /// </summary>
        [JsonProperty("TargetVpc")]
        public string TargetVpc{ get; set; }

        /// <summary>
        /// 复制技术（SYN 同步 / ASY 异步）
        /// </summary>
        [JsonProperty("CopyType")]
        public string CopyType{ get; set; }

        /// <summary>
        /// 容灾类型（CROSS_ZONE 跨可用区 / CROSS_REGION 跨地域 / CROSS_CLOUD 跨云）
        /// </summary>
        [JsonProperty("DisasterRecoveryType")]
        public string DisasterRecoveryType{ get; set; }

        /// <summary>
        /// 数据复制方向（POSITIVE 正向 / REVERSE 反向）
        /// </summary>
        [JsonProperty("DataDirection")]
        public string DataDirection{ get; set; }

        /// <summary>
        /// 跨云场景对端云名称（仅 DisasterRecoveryType=CROSS_CLOUD 时返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerCloudName")]
        public string PeerCloudName{ get; set; }

        /// <summary>
        /// 创建来源（LOCAL 本端创建 / PEER 对端创建）
        /// </summary>
        [JsonProperty("CreateFrom")]
        public string CreateFrom{ get; set; }

        /// <summary>
        /// 生命周期状态
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// 创建保护组的账户主账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 创建保护组的子账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

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
        /// 绑定的已保护资源数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindProtectedResourceCount")]
        public long? BindProtectedResourceCount{ get; set; }

        /// <summary>
        /// RPO 异常（超过 15 分钟未同步）的复制对数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorRecoveryPointObjectiveCount")]
        public long? ErrorRecoveryPointObjectiveCount{ get; set; }

        /// <summary>
        /// 已保护资源状态统计，key 为复制对状态，value 为该状态下的资源数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectedResourceStatusSet")]
        public ProtectedResourceStatus[] ProtectedResourceStatusSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamSimple(map, prefix + "ProtectGroupName", this.ProtectGroupName);
            this.SetParamSimple(map, prefix + "ProtectGroupType", this.ProtectGroupType);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "SitePairName", this.SitePairName);
            this.SetParamSimple(map, prefix + "RecoveryPointObjective", this.RecoveryPointObjective);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "SourceVpc", this.SourceVpc);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "TargetZone", this.TargetZone);
            this.SetParamSimple(map, prefix + "TargetVpc", this.TargetVpc);
            this.SetParamSimple(map, prefix + "CopyType", this.CopyType);
            this.SetParamSimple(map, prefix + "DisasterRecoveryType", this.DisasterRecoveryType);
            this.SetParamSimple(map, prefix + "DataDirection", this.DataDirection);
            this.SetParamSimple(map, prefix + "PeerCloudName", this.PeerCloudName);
            this.SetParamSimple(map, prefix + "CreateFrom", this.CreateFrom);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "BindProtectedResourceCount", this.BindProtectedResourceCount);
            this.SetParamSimple(map, prefix + "ErrorRecoveryPointObjectiveCount", this.ErrorRecoveryPointObjectiveCount);
            this.SetParamArrayObj(map, prefix + "ProtectedResourceStatusSet.", this.ProtectedResourceStatusSet);
        }
    }
}

