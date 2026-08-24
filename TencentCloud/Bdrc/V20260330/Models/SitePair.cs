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

    public class SitePair : AbstractModel
    {
        
        /// <summary>
        /// 用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 容灾策略ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 容灾策略名称
        /// </summary>
        [JsonProperty("SitePairName")]
        public string SitePairName{ get; set; }

        /// <summary>
        /// 容灾策略类型（产品类型，如 DISK/CFS/INSTANCE 等）
        /// </summary>
        [JsonProperty("SitePairType")]
        public string SitePairType{ get; set; }

        /// <summary>
        /// 容灾策略状态
        /// </summary>
        [JsonProperty("SitePairState")]
        public string SitePairState{ get; set; }

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
        /// 容灾地域
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// 容灾可用区
        /// </summary>
        [JsonProperty("TargetZone")]
        public string TargetZone{ get; set; }

        /// <summary>
        /// 生产端VPC
        /// </summary>
        [JsonProperty("SourceVpc")]
        public string SourceVpc{ get; set; }

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
        /// 创建来源（LOCAL 本端创建 / PEER 对端创建）
        /// </summary>
        [JsonProperty("CreateFrom")]
        public string CreateFrom{ get; set; }

        /// <summary>
        /// 创建容灾策略的账户主账号 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 创建容灾策略的子账户 Uin
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
        /// 已绑定的保护组数量
        /// </summary>
        [JsonProperty("BindProtectGroupCount")]
        public long? BindProtectGroupCount{ get; set; }

        /// <summary>
        /// RPO 异常的复制对ID列表（最近一次保护点距今超过15分钟的复制对）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorRecoveryPointObjectiveCopyPairSet")]
        public string[] ErrorRecoveryPointObjectiveCopyPairSet{ get; set; }

        /// <summary>
        /// 已保护的资源列表（按资源类型分组）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectedResourceSet")]
        public ProtectedResource[] ProtectedResourceSet{ get; set; }

        /// <summary>
        /// 已保护资源的状态统计，key 为复制对状态，value 为该状态下的资源数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectedResourceStatusSet")]
        public ProtectedResourceStatus[] ProtectedResourceStatusSet{ get; set; }

        /// <summary>
        /// 跨云场景下的额外信息（仅 IsCrossCloud=true 时返回，非跨云为 null）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrossCloudDetails")]
        public CrossCloudDetails CrossCloudDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "SitePairName", this.SitePairName);
            this.SetParamSimple(map, prefix + "SitePairType", this.SitePairType);
            this.SetParamSimple(map, prefix + "SitePairState", this.SitePairState);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "TargetZone", this.TargetZone);
            this.SetParamSimple(map, prefix + "SourceVpc", this.SourceVpc);
            this.SetParamSimple(map, prefix + "TargetVpc", this.TargetVpc);
            this.SetParamSimple(map, prefix + "CopyType", this.CopyType);
            this.SetParamSimple(map, prefix + "DisasterRecoveryType", this.DisasterRecoveryType);
            this.SetParamSimple(map, prefix + "CreateFrom", this.CreateFrom);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BindProtectGroupCount", this.BindProtectGroupCount);
            this.SetParamArraySimple(map, prefix + "ErrorRecoveryPointObjectiveCopyPairSet.", this.ErrorRecoveryPointObjectiveCopyPairSet);
            this.SetParamArrayObj(map, prefix + "ProtectedResourceSet.", this.ProtectedResourceSet);
            this.SetParamArrayObj(map, prefix + "ProtectedResourceStatusSet.", this.ProtectedResourceStatusSet);
            this.SetParamObj(map, prefix + "CrossCloudDetails.", this.CrossCloudDetails);
        }
    }
}

