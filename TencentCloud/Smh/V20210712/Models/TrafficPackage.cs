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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// 流量资源包所抵扣的实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 专属域名。如果实例无专属域名，则该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 流量资源包来源类型，0 为付费购买，1 为赠送。
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 总流量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 总流量，单位为 GB
        /// </summary>
        [JsonProperty("SizeGB")]
        public ulong? SizeGB{ get; set; }

        /// <summary>
        /// 剩余流量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("Remain")]
        public string Remain{ get; set; }

        /// <summary>
        /// 已使用流量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("Used")]
        public string Used{ get; set; }

        /// <summary>
        /// 已使用百分比，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("UsedPercentage")]
        public string UsedPercentage{ get; set; }

        /// <summary>
        /// 生效时间，即流量资源包的订购时间
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// 过期时间，即所抵扣的实例的过期时间。如果流量资源包所抵扣的实例为按量计费或永久有效实例，该属性为 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SizeGB", this.SizeGB);
            this.SetParamSimple(map, prefix + "Remain", this.Remain);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "UsedPercentage", this.UsedPercentage);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

