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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Disk : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘ID。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 云硬盘类型。取值范围：<br><li>SYSTEM_DISK：系统盘<br><li>DATA_DISK：数据盘。
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// 付费模式。取值范围：<br><li>PREPAID：预付费，即包年包月<br><li>POSTPAID_BY_HOUR：后付费，即按量计费。
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// 是否为弹性云盘，false表示非弹性云盘，true表示弹性云盘。
        /// </summary>
        [JsonProperty("Portable")]
        public bool? Portable{ get; set; }

        /// <summary>
        /// 云硬盘所在的位置。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 云盘是否具备创建快照的能力。取值范围：<br><li>false表示不具备<br><li>true表示具备。
        /// </summary>
        [JsonProperty("SnapshotAbility")]
        public bool? SnapshotAbility{ get; set; }

        /// <summary>
        /// 云硬盘名称。
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// 云硬盘大小，单位GB。
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 云盘状态。取值范围：<br><li>UNATTACHED：未挂载<br><li>ATTACHING：挂载中<br><li>ATTACHED：已挂载<br><li>DETACHING：解挂中<br><li>EXPANDING：扩容中<br><li>ROLLBACKING：回滚中<br><li>TORECYCLE：待回收<br><li>DUMPING：拷贝硬盘中。
        /// </summary>
        [JsonProperty("DiskState")]
        public string DiskState{ get; set; }

        /// <summary>
        /// 云盘介质类型。取值范围：<br><li>CLOUD_BASIC：表示普通云硬盘<br><li>CLOUD_PREMIUM：表示高性能云硬盘<br><li>CLOUD_SSD：SSD表示SSD云硬盘。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 云盘是否挂载到云主机上。取值范围：<br><li>false:表示未挂载<br><li>true:表示已挂载。
        /// </summary>
        [JsonProperty("Attached")]
        public bool? Attached{ get; set; }

        /// <summary>
        /// 云硬盘挂载的云主机ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 云硬盘的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 云硬盘的到期时间。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 云盘是否处于快照回滚状态。取值范围：<br><li>false:表示不处于快照回滚状态<br><li>true:表示处于快照回滚状态。
        /// </summary>
        [JsonProperty("Rollbacking")]
        public bool? Rollbacking{ get; set; }

        /// <summary>
        /// 云盘快照回滚的进度。
        /// </summary>
        [JsonProperty("RollbackPercent")]
        public ulong? RollbackPercent{ get; set; }

        /// <summary>
        /// 云盘是否为加密盘。取值范围：<br><li>false:表示非加密盘<br><li>true:表示加密盘。
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// 云盘已挂载到子机，且子机与云盘都是包年包月。<br><li>true：子机设置了自动续费标识，但云盘未设置<br><li>false：云盘自动续费标识正常。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlagError")]
        public bool? AutoRenewFlagError{ get; set; }

        /// <summary>
        /// 自动续费标识。取值范围：<br><li>NOTIFY_AND_AUTO_RENEW：通知过期且自动续费<br><li>NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费<br><li>DISABLE_NOTIFY_AND_MANUAL_RENEW：不通知过期不自动续费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 在云盘已挂载到实例，且实例与云盘都是包年包月的条件下，此字段才有意义。<br><li>true:云盘到期时间早于实例。<br><li>false：云盘到期时间晚于实例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineError")]
        public bool? DeadlineError{ get; set; }

        /// <summary>
        /// 判断预付费的云盘是否支持主动退还。<br><li>true:支持主动退还<br><li>false:不支持主动退还。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsReturnable")]
        public bool? IsReturnable{ get; set; }

        /// <summary>
        /// 预付费云盘在不支持主动退还的情况下，该参数表明不支持主动退还的具体原因。取值范围：<br><li>1：云硬盘已经退还<br><li>2：云硬盘已过期<br><li>3：云盘不支持退还<br><li>8：超过可退还数量的限制。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnFailCode")]
        public long? ReturnFailCode{ get; set; }

        /// <summary>
        /// 云盘关联的定期快照ID。只有在调用DescribeDisks接口时，入参ReturnBindAutoSnapshotPolicy取值为TRUE才会返回该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyIds")]
        public string[] AutoSnapshotPolicyIds{ get; set; }

        /// <summary>
        /// 与云盘绑定的标签，云盘未绑定标签则取值为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 云盘是否与挂载的实例一起销毁。<br><li>true:销毁实例时会同时销毁云盘，只支持按小时后付费云盘。<br><li>false：销毁实例时不销毁云盘。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// 当前时间距离盘到期的天数（仅对预付费盘有意义）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DifferDaysOfDeadline")]
        public long? DifferDaysOfDeadline{ get; set; }

        /// <summary>
        /// 云盘是否处于类型变更中。取值范围：<br><li>false:表示云盘不处于类型变更中<br><li>true:表示云盘已发起类型变更，正处于迁移中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Migrating")]
        public bool? Migrating{ get; set; }

        /// <summary>
        /// 云盘类型变更的迁移进度，取值0到100。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MigratePercent")]
        public ulong? MigratePercent{ get; set; }

        /// <summary>
        /// 云盘是否为共享型云盘。
        /// </summary>
        [JsonProperty("Shareable")]
        public bool? Shareable{ get; set; }

        /// <summary>
        /// 对于非共享型云盘，该参数为空数组。对于共享型云盘，则表示该云盘当前被挂载到的CVM实例InstanceId
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// 云盘拥有的快照总数。
        /// </summary>
        [JsonProperty("SnapshotCount")]
        public long? SnapshotCount{ get; set; }

        /// <summary>
        /// 云盘拥有的快照总容量，单位为MB。
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "Portable", this.Portable);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "SnapshotAbility", this.SnapshotAbility);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskState", this.DiskState);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "Attached", this.Attached);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Rollbacking", this.Rollbacking);
            this.SetParamSimple(map, prefix + "RollbackPercent", this.RollbackPercent);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "AutoRenewFlagError", this.AutoRenewFlagError);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "DeadlineError", this.DeadlineError);
            this.SetParamSimple(map, prefix + "IsReturnable", this.IsReturnable);
            this.SetParamSimple(map, prefix + "ReturnFailCode", this.ReturnFailCode);
            this.SetParamArraySimple(map, prefix + "AutoSnapshotPolicyIds.", this.AutoSnapshotPolicyIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "DifferDaysOfDeadline", this.DifferDaysOfDeadline);
            this.SetParamSimple(map, prefix + "Migrating", this.Migrating);
            this.SetParamSimple(map, prefix + "MigratePercent", this.MigratePercent);
            this.SetParamSimple(map, prefix + "Shareable", this.Shareable);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "SnapshotCount", this.SnapshotCount);
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
        }
    }
}

