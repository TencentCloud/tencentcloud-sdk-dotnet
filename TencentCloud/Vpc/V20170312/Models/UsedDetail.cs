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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsedDetail : AbstractModel
    {
        
        /// <summary>
        /// 流量包唯一ID
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// 流量包名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrafficPackageName")]
        public string TrafficPackageName{ get; set; }

        /// <summary>
        /// 流量包总量
        /// </summary>
        [JsonProperty("TotalAmount")]
        public TrafficFlow TotalAmount{ get; set; }

        /// <summary>
        /// 本次抵扣
        /// </summary>
        [JsonProperty("Deduction")]
        public TrafficFlow Deduction{ get; set; }

        /// <summary>
        /// 本次抵扣后剩余量
        /// </summary>
        [JsonProperty("RemainingAmount")]
        public TrafficFlow RemainingAmount{ get; set; }

        /// <summary>
        /// 抵扣时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 资源类型。可能的值: CVM, LB, NAT, HAVIP, EIP
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 流量包到期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamSimple(map, prefix + "TrafficPackageName", this.TrafficPackageName);
            this.SetParamObj(map, prefix + "TotalAmount.", this.TotalAmount);
            this.SetParamObj(map, prefix + "Deduction.", this.Deduction);
            this.SetParamObj(map, prefix + "RemainingAmount.", this.RemainingAmount);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
        }
    }
}

