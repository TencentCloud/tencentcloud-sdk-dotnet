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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstancePackage : AbstractModel
    {
        
        /// <summary>
        /// 实例套餐资源id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 套餐类型
        /// FREE: 免费版
        /// STANDARD：标准版
        /// ULTIMATE：旗舰版
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 套餐过期时间
        /// </summary>
        [JsonProperty("CurrentDeadline")]
        public string CurrentDeadline{ get; set; }

        /// <summary>
        /// 套餐创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否过期0否1是
        /// </summary>
        [JsonProperty("IsExpire")]
        public ulong? IsExpire{ get; set; }

        /// <summary>
        /// 实例状态
        /// ENABLED: 正常
        /// DISABLED: 禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否自动续费0不1是
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 计费项
        /// </summary>
        [JsonProperty("CostItemList")]
        public CostItem[] CostItemList{ get; set; }

        /// <summary>
        /// 最小检查间隔时间s
        /// </summary>
        [JsonProperty("MinCheckInterval")]
        public ulong? MinCheckInterval{ get; set; }

        /// <summary>
        /// 最小TTL s
        /// </summary>
        [JsonProperty("MinGlobalTtl")]
        public ulong? MinGlobalTtl{ get; set; }

        /// <summary>
        /// 流量策略类型：ALL返回全部，WEIGHT权重
        /// </summary>
        [JsonProperty("TrafficStrategy")]
        public string[] TrafficStrategy{ get; set; }

        /// <summary>
        /// 策略类型：LOCATION按地理位置调度，DELAY按延迟调度
        /// </summary>
        [JsonProperty("ScheduleStrategy")]
        public string[] ScheduleStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "CurrentDeadline", this.CurrentDeadline);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsExpire", this.IsExpire);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "CostItemList.", this.CostItemList);
            this.SetParamSimple(map, prefix + "MinCheckInterval", this.MinCheckInterval);
            this.SetParamSimple(map, prefix + "MinGlobalTtl", this.MinGlobalTtl);
            this.SetParamArraySimple(map, prefix + "TrafficStrategy.", this.TrafficStrategy);
            this.SetParamArraySimple(map, prefix + "ScheduleStrategy.", this.ScheduleStrategy);
        }
    }
}

