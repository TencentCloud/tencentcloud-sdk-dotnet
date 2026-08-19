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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RemoteDiskDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>单副本SSD硬盘的创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘到期时间。按小时后付费单副本SSD硬盘可能为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘计费类型。</p><p>枚举值：</p><ul><li>PREPAID： 预付费</li><li>POSTPAID_BY_HOUR： 按小时后付费</li></ul>
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘大小，单位为 GiB。</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘挂载的云服务器实例ID。未挂载时为空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘所在的位置。</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘ID。</p>
        /// </summary>
        [JsonProperty("RemoteDiskId")]
        public string RemoteDiskId{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘名称。</p>
        /// </summary>
        [JsonProperty("RemoteDiskName")]
        public string RemoteDiskName{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘状态。</p><p>枚举值：</p><ul><li>UNATTACHED： 未挂载</li><li>ATTACHED： 已挂载</li><li>TORECYCLE： 待回收</li></ul>
        /// </summary>
        [JsonProperty("RemoteDiskState")]
        public string RemoteDiskState{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘类型。</p><p>枚举值：</p><ul><li>REMOTE_SSD： 单副本SSD硬盘</li><li>ELASTIC_REMOTE_SSD： 弹性单副本SSD硬盘</li></ul>
        /// </summary>
        [JsonProperty("RemoteDiskType")]
        public string RemoteDiskType{ get; set; }

        /// <summary>
        /// <p>自动续费标识。</p><p>枚举值：</p><ul><li>NOTIFY_AND_AUTO_RENEW： 通知过期且自动续费</li><li>NOTIFY_AND_MANUAL_RENEW： 通知过期不自动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW： 不通知过期不自动续费</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "RemoteDiskId", this.RemoteDiskId);
            this.SetParamSimple(map, prefix + "RemoteDiskName", this.RemoteDiskName);
            this.SetParamSimple(map, prefix + "RemoteDiskState", this.RemoteDiskState);
            this.SetParamSimple(map, prefix + "RemoteDiskType", this.RemoteDiskType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

