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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCPUExpandStrategyInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 策略类型。输出值：auto、manual、timeInterval、period。
        /// 说明：1. auto 表示自动扩容。2. manual 表示自定义扩容，扩容时间为立即生效。3. timeInterval 表示自定义扩容，扩容时间为按时间段。4. period 表示自定义扩容，扩容时间为按周期。5. 如果返回为 NULL 说明尚未开通弹性扩容策略。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 自定义扩容，且扩容时间为立即生效时的 CPU。Type 为 manual 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpandCpu")]
        public long? ExpandCpu{ get; set; }

        /// <summary>
        /// 自动扩容策略。Type 为 auto 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoStrategy")]
        public AutoStrategy AutoStrategy{ get; set; }

        /// <summary>
        /// 按周期扩容策略。当 Type 为 period 时有效。
        /// </summary>
        [JsonProperty("PeriodStrategy")]
        public PeriodStrategy PeriodStrategy{ get; set; }

        /// <summary>
        /// 按时间段扩容策略。当 Type 为 timeInterval 时有效。
        /// </summary>
        [JsonProperty("TimeIntervalStrategy")]
        public TimeIntervalStrategy TimeIntervalStrategy{ get; set; }

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
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpandCpu", this.ExpandCpu);
            this.SetParamObj(map, prefix + "AutoStrategy.", this.AutoStrategy);
            this.SetParamObj(map, prefix + "PeriodStrategy.", this.PeriodStrategy);
            this.SetParamObj(map, prefix + "TimeIntervalStrategy.", this.TimeIntervalStrategy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

