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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SuperNodeResource : AbstractModel
    {
        
        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点上的资源总数
        /// </summary>
        [JsonProperty("Num")]
        public ulong? Num{ get; set; }

        /// <summary>
        /// 节点上的总核数
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 节点上的总内存数
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 节点上的总 GPU 卡数
        /// </summary>
        [JsonProperty("Gpu")]
        public float? Gpu{ get; set; }

        /// <summary>
        /// 节点资源的配额类型，exact表示精确配额，fuzzy 表示模糊配额。
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 配额的计费类型，PREPAID表示包月，POSTPAID_BY_HOUR表示按量。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// QuotaType为 exact 时，此字段有效，表示精确配额的资源类型。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 置放群组 ID
        /// </summary>
        [JsonProperty("DisasterRecoverGroupId")]
        public string DisasterRecoverGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "DisasterRecoverGroupId", this.DisasterRecoverGroupId);
        }
    }
}

