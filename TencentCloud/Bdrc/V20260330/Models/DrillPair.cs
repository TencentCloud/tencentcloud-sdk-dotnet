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

    public class DrillPair : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 演练对ID
        /// </summary>
        [JsonProperty("DrillPairId")]
        public string DrillPairId{ get; set; }

        /// <summary>
        /// 演练对名称
        /// </summary>
        [JsonProperty("DrillPairName")]
        public string DrillPairName{ get; set; }

        /// <summary>
        /// 演练对状态。枚举值：RUNNING / SUCCESS / FAILED 等。
        /// </summary>
        [JsonProperty("DrillPairState")]
        public string DrillPairState{ get; set; }

        /// <summary>
        /// 容灾站点对ID
        /// </summary>
        [JsonProperty("SitePairId")]
        public string SitePairId{ get; set; }

        /// <summary>
        /// 云硬盘复制对ID
        /// </summary>
        [JsonProperty("CopyPairId")]
        public string CopyPairId{ get; set; }

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
        /// 生产站点盘ID
        /// </summary>
        [JsonProperty("SourceResourceId")]
        public string SourceResourceId{ get; set; }

        /// <summary>
        /// 演练资源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// 演练对的类型。枚举值：DISK / INSTANCE / CFS。
        /// </summary>
        [JsonProperty("DrillPairType")]
        public string DrillPairType{ get; set; }

        /// <summary>
        /// 演练资源容量（GB）。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 演练的容灾点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoveryTime")]
        public string RecoveryTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 演练结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 是否正在回滚。0 - 未回滚，1 - 回滚中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rollbacking")]
        public long? Rollbacking{ get; set; }

        /// <summary>
        /// 回滚进度百分比（0-100）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackPercent")]
        public long? RollbackPercent{ get; set; }

        /// <summary>
        /// 创建定期备份策略的账户uin ID信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountUin")]
        public string AccountUin{ get; set; }

        /// <summary>
        /// 创建定期备份策略的子账户uin ID信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

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
        /// 复制对名称。
        /// </summary>
        [JsonProperty("CopyPairName")]
        public string CopyPairName{ get; set; }

        /// <summary>
        /// 演练组名称。
        /// </summary>
        [JsonProperty("DrillGroupName")]
        public string DrillGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "DrillPairId", this.DrillPairId);
            this.SetParamSimple(map, prefix + "DrillPairName", this.DrillPairName);
            this.SetParamSimple(map, prefix + "DrillPairState", this.DrillPairState);
            this.SetParamSimple(map, prefix + "SitePairId", this.SitePairId);
            this.SetParamSimple(map, prefix + "CopyPairId", this.CopyPairId);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "TargetZone", this.TargetZone);
            this.SetParamSimple(map, prefix + "SourceResourceId", this.SourceResourceId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamSimple(map, prefix + "DrillPairType", this.DrillPairType);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "RecoveryTime", this.RecoveryTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Rollbacking", this.Rollbacking);
            this.SetParamSimple(map, prefix + "RollbackPercent", this.RollbackPercent);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamSimple(map, prefix + "DrillGroupId", this.DrillGroupId);
            this.SetParamSimple(map, prefix + "CopyPairName", this.CopyPairName);
            this.SetParamSimple(map, prefix + "DrillGroupName", this.DrillGroupName);
        }
    }
}

