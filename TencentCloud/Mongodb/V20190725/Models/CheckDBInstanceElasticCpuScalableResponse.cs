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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckDBInstanceElasticCpuScalableResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>是否可以进行弹性CPU扩容</p>
        /// </summary>
        [JsonProperty("Scalable")]
        public bool? Scalable{ get; set; }

        /// <summary>
        /// <p>当前是否处于扩容状态</p>
        /// </summary>
        [JsonProperty("IsScaled")]
        public bool? IsScaled{ get; set; }

        /// <summary>
        /// <p>实例是否被锁定（有流程在执行）</p>
        /// </summary>
        [JsonProperty("IsLocked")]
        public bool? IsLocked{ get; set; }

        /// <summary>
        /// <p>不可扩容的原因</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// <p>最大可扩容的CPU核数，MIN(最小分片CPU核数, 24)</p>
        /// </summary>
        [JsonProperty("MaxExtraCpu")]
        public long? MaxExtraCpu{ get; set; }

        /// <summary>
        /// <p>当前扩容的CPU核数（如果处于扩容状态）</p>
        /// </summary>
        [JsonProperty("ExtraCpu")]
        public long? ExtraCpu{ get; set; }

        /// <summary>
        /// <p>扩容触发类型: 1-手动, 2-周期, 3-一次性时间段, 4-监控</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public long? TriggerType{ get; set; }

        /// <summary>
        /// <p>扩容时间</p>
        /// </summary>
        [JsonProperty("ScaleUpTime")]
        public string ScaleUpTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scalable", this.Scalable);
            this.SetParamSimple(map, prefix + "IsScaled", this.IsScaled);
            this.SetParamSimple(map, prefix + "IsLocked", this.IsLocked);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "MaxExtraCpu", this.MaxExtraCpu);
            this.SetParamSimple(map, prefix + "ExtraCpu", this.ExtraCpu);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ScaleUpTime", this.ScaleUpTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

