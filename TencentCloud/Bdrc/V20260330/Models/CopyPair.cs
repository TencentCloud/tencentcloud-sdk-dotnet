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

    public class CopyPair : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 复制对ID（CVM 类型为 cvmcopypair-xxxxxxxx，DISK/CFS 类型为 copypair-xxxxxxxx）
        /// </summary>
        [JsonProperty("CopyPairId")]
        public string CopyPairId{ get; set; }

        /// <summary>
        /// 复制对名称
        /// </summary>
        [JsonProperty("CopyPairName")]
        public string CopyPairName{ get; set; }

        /// <summary>
        /// 所属容灾站点对ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 所属容灾站点对名称
        /// </summary>
        [JsonProperty("SitePairName")]
        public string SitePairName{ get; set; }

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
        /// 复制对状态。可选值：INIT、RUNNING、FULL_COPYING、INC_COPYING、NORMAL、DOWN、DEGRADE 等
        /// </summary>
        [JsonProperty("CopyPairState")]
        public string CopyPairState{ get; set; }

        /// <summary>
        /// 复制对类型。可选值：DISK、INSTANCE、CFS
        /// </summary>
        [JsonProperty("CopyPairType")]
        public string CopyPairType{ get; set; }

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
        /// 容灾端VPC
        /// </summary>
        [JsonProperty("TargetVpc")]
        public string TargetVpc{ get; set; }

        /// <summary>
        /// 生产资源ID。CVM 类型为源 InstanceId（ins-xxx）；DISK 类型为源 DiskId（disk-xxx）；CFS 类型为源 FilesystemId（cfs-xxx）
        /// </summary>
        [JsonProperty("SourceResourceId")]
        public string SourceResourceId{ get; set; }

        /// <summary>
        /// 容灾资源ID。语义同 SourceResourceId（CVM/DISK/CFS）。延迟创建模式且 CVM 未真实创建时为占位符 drp-xxx，CVM 创建后为真实 ins-xxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// 生产站点盘挂载的实例ID（DISK 类型时为挂载的 CVM ins-xxx；INSTANCE 类型时与 SourceResourceId 一致）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 所属CVM复制对ID（仅 DISK 类型且其 CVM 复制对存在时返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCopyPairId")]
        public string InstanceCopyPairId{ get; set; }

        /// <summary>
        /// 复制进度。CVM 类型为所有挂载磁盘进度的平均值；DISK/CFS 类型为本盘进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// 最新保护时间点。当 CopyPairState=FULL_COPYING 时为 null（首次全量未完成）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestProtectionTime")]
        public string LatestProtectionTime{ get; set; }

        /// <summary>
        /// RPO（秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoveryPointObjective")]
        public long? RecoveryPointObjective{ get; set; }

        /// <summary>
        /// 数据方向。可选值：POSITIVE（正向）、REVERSE（反向，failover 后）。后端在 REVERSE 时已自动轮转 src/target 字段
        /// </summary>
        [JsonProperty("DataDirection")]
        public string DataDirection{ get; set; }

        /// <summary>
        /// 创建来源。可选值：LOCAL（本地侧创建）、PEER（对端创建）
        /// </summary>
        [JsonProperty("CreateFrom")]
        public string CreateFrom{ get; set; }

        /// <summary>
        /// 容灾类型。可选值：CROSS_ZONE（跨可用区）、CROSS_REGION（跨地域）、CROSS_CLOUD（跨云）
        /// </summary>
        [JsonProperty("DisasterRecoveryType")]
        public string DisasterRecoveryType{ get; set; }

        /// <summary>
        /// 对端云名称（仅跨云场景）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PeerCloudName")]
        public string PeerCloudName{ get; set; }

        /// <summary>
        /// 是否在回滚中（0/1）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rollbacking")]
        public long? Rollbacking{ get; set; }

        /// <summary>
        /// 回滚进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackPercent")]
        public long? RollbackPercent{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 创建账户 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 创建协作者 Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 演练组ID（用于演练组内过滤存量复制对，无演练时为 null）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DrillGroupId")]
        public string DrillGroupId{ get; set; }

        /// <summary>
        /// 保护时间点列表（仅当 QueryProtectionTime=true 时返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProtectionTimeSet")]
        public string[] ProtectionTimeSet{ get; set; }

        /// <summary>
        /// CVM下挂载磁盘的复制对列表（仅 CopyPairType=INSTANCE 时返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskCopyPairSet")]
        public DiskCopyPairForCvm[] DiskCopyPairSet{ get; set; }

        /// <summary>
        /// 是否为延迟创建模式（创建后固定不变）。仅 CVM 复制对返回
        /// </summary>
        [JsonProperty("DeferredCreate")]
        public bool? DeferredCreate{ get; set; }

        /// <summary>
        /// 目标 CVM 是否已真实创建（首次 failover 完成后置 true）。仅 CVM 复制对返回
        /// </summary>
        [JsonProperty("TargetCvmCreated")]
        public bool? TargetCvmCreated{ get; set; }

        /// <summary>
        /// CVM 创建参数（JSON 字符串）。仅当请求传 QueryCvmCreateParams=true 且复制对处于 deferred_create=1 AND target_cvm_created=0 时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CvmCreateParams")]
        public string CvmCreateParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CopyPairId", this.CopyPairId);
            this.SetParamSimple(map, prefix + "CopyPairName", this.CopyPairName);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "SitePairName", this.SitePairName);
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamSimple(map, prefix + "ProtectGroupName", this.ProtectGroupName);
            this.SetParamSimple(map, prefix + "CopyPairState", this.CopyPairState);
            this.SetParamSimple(map, prefix + "CopyPairType", this.CopyPairType);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "SourceVpc", this.SourceVpc);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "TargetZone", this.TargetZone);
            this.SetParamSimple(map, prefix + "TargetVpc", this.TargetVpc);
            this.SetParamSimple(map, prefix + "SourceResourceId", this.SourceResourceId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceCopyPairId", this.InstanceCopyPairId);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "LatestProtectionTime", this.LatestProtectionTime);
            this.SetParamSimple(map, prefix + "RecoveryPointObjective", this.RecoveryPointObjective);
            this.SetParamSimple(map, prefix + "DataDirection", this.DataDirection);
            this.SetParamSimple(map, prefix + "CreateFrom", this.CreateFrom);
            this.SetParamSimple(map, prefix + "DisasterRecoveryType", this.DisasterRecoveryType);
            this.SetParamSimple(map, prefix + "PeerCloudName", this.PeerCloudName);
            this.SetParamSimple(map, prefix + "Rollbacking", this.Rollbacking);
            this.SetParamSimple(map, prefix + "RollbackPercent", this.RollbackPercent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "DrillGroupId", this.DrillGroupId);
            this.SetParamArraySimple(map, prefix + "ProtectionTimeSet.", this.ProtectionTimeSet);
            this.SetParamArrayObj(map, prefix + "DiskCopyPairSet.", this.DiskCopyPairSet);
            this.SetParamSimple(map, prefix + "DeferredCreate", this.DeferredCreate);
            this.SetParamSimple(map, prefix + "TargetCvmCreated", this.TargetCvmCreated);
            this.SetParamSimple(map, prefix + "CvmCreateParams", this.CvmCreateParams);
        }
    }
}

