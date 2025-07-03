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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 探测任务配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskQuota")]
        public ulong? TaskQuota{ get; set; }

        /// <summary>
        /// 地址池配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PoolQuota")]
        public ulong? PoolQuota{ get; set; }

        /// <summary>
        /// 地址配额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressQuota")]
        public ulong? AddressQuota{ get; set; }

        /// <summary>
        /// 探点资源数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorQuota")]
        public ulong? MonitorQuota{ get; set; }

        /// <summary>
        /// 消息资源数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageQuota")]
        public ulong? MessageQuota{ get; set; }

        /// <summary>
        /// 已使用探测任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedTaskQuota")]
        public ulong? UsedTaskQuota{ get; set; }

        /// <summary>
        /// 已使用体验实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedFreeInstanceNum")]
        public ulong? UsedFreeInstanceNum{ get; set; }

        /// <summary>
        /// 已使用付费实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedBillInstanceNum")]
        public ulong? UsedBillInstanceNum{ get; set; }

        /// <summary>
        /// 体验套餐总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreePackageNum")]
        public ulong? FreePackageNum{ get; set; }

        /// <summary>
        /// 已使用付费套餐数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedBillPackageNum")]
        public ulong? UsedBillPackageNum{ get; set; }

        /// <summary>
        /// 付费套餐总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillPackageNum")]
        public ulong? BillPackageNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskQuota", this.TaskQuota);
            this.SetParamSimple(map, prefix + "PoolQuota", this.PoolQuota);
            this.SetParamSimple(map, prefix + "AddressQuota", this.AddressQuota);
            this.SetParamSimple(map, prefix + "MonitorQuota", this.MonitorQuota);
            this.SetParamSimple(map, prefix + "MessageQuota", this.MessageQuota);
            this.SetParamSimple(map, prefix + "UsedTaskQuota", this.UsedTaskQuota);
            this.SetParamSimple(map, prefix + "UsedFreeInstanceNum", this.UsedFreeInstanceNum);
            this.SetParamSimple(map, prefix + "UsedBillInstanceNum", this.UsedBillInstanceNum);
            this.SetParamSimple(map, prefix + "FreePackageNum", this.FreePackageNum);
            this.SetParamSimple(map, prefix + "UsedBillPackageNum", this.UsedBillPackageNum);
            this.SetParamSimple(map, prefix + "BillPackageNum", this.BillPackageNum);
        }
    }
}

