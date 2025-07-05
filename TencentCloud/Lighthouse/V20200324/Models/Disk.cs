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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Disk : AbstractModel
    {
        
        /// <summary>
        /// 磁盘ID
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 磁盘名称
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// 磁盘类型
        /// 枚举值：
        /// <li> SYSTEM_DISK: 系统盘 </li>
        /// <li> DATA_DISK: 数据盘 </li>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// 磁盘介质类型
        /// 枚举值:
        /// <li> CLOUD_BASIC: 普通云硬盘 </li>
        /// <li> CLOUD_PREMIUM: 高性能云硬盘 </li>
        /// <li> CLOUD_SSD: SSD云硬盘 </li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 磁盘付费类型
        /// <li> PREPAID: 预付费 </li>
        /// <li> POSTPAID_BY_HOUR: 按小时后付费 </li>
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// 磁盘大小, 单位GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 续费标识
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 磁盘状态，取值范围：
        /// <li>PENDING：创建中。 </li>
        /// <li>UNATTACHED：待挂载。</li>
        /// <li>ATTACHING：挂载中。</li>
        /// <li>ATTACHED：已挂载。</li>
        /// <li>DETACHING：卸载中。 </li>
        /// <li> SHUTDOWN：已隔离。</li>
        /// <li> CREATED_FAILED：创建失败。</li>
        /// <li>TERMINATING：销毁中。</li>
        /// <li> DELETING：删除中。</li>
        /// <li> FREEZING：冻结中。</li>
        /// </summary>
        [JsonProperty("DiskState")]
        public string DiskState{ get; set; }

        /// <summary>
        /// 磁盘挂载状态
        /// </summary>
        [JsonProperty("Attached")]
        public bool? Attached{ get; set; }

        /// <summary>
        /// 是否随实例释放
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// 上一次操作
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// 上一次操作状态
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// 上一次请求ID
        /// </summary>
        [JsonProperty("LatestOperationRequestId")]
        public string LatestOperationRequestId{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 到期时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 隔离时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 云硬盘的已有备份点数量。
        /// </summary>
        [JsonProperty("DiskBackupCount")]
        public long? DiskBackupCount{ get; set; }

        /// <summary>
        /// 云硬盘的备份点配额数量。
        /// </summary>
        [JsonProperty("DiskBackupQuota")]
        public long? DiskBackupQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "DiskState", this.DiskState);
            this.SetParamSimple(map, prefix + "Attached", this.Attached);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "LatestOperationRequestId", this.LatestOperationRequestId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "DiskBackupCount", this.DiskBackupCount);
            this.SetParamSimple(map, prefix + "DiskBackupQuota", this.DiskBackupQuota);
        }
    }
}

