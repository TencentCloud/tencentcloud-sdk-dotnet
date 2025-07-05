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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartCpuExpandRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 扩容类型，支持自动扩容和自定义扩容。
        /// 说明：1. auto 表示自动扩容。2. manual 表示自定义扩容，扩容时间为立即生效。3. timeInterval 表示自定义扩容，扩容时间为按时间段。4. period 表示自定义扩容，扩容时间为按周期。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 自定义扩容时，扩容的 CPU 核心数。
        /// 说明：1. Type 为 manual、timeInterval、period 时必传。2. 扩容的 CPU 核心数上限为当前实例 CPU 核心数，比如8核16G最大可手动扩容的 CPU 核心数为8，即范围为1 - 8。
        /// </summary>
        [JsonProperty("ExpandCpu")]
        public long? ExpandCpu{ get; set; }

        /// <summary>
        /// 自动扩容策略。Type 为 auto 时必传。
        /// </summary>
        [JsonProperty("AutoStrategy")]
        public AutoStrategy AutoStrategy{ get; set; }

        /// <summary>
        /// 按时间段扩容策略。
        /// 说明：当 Type 为 timeInterval 时，TimeIntervalStrategy 必填。
        /// </summary>
        [JsonProperty("TimeIntervalStrategy")]
        public TimeIntervalStrategy TimeIntervalStrategy{ get; set; }

        /// <summary>
        /// 按周期扩容策略。
        /// 说明：当 Type 为 period 时，PeriodStrategy 必填。
        /// </summary>
        [JsonProperty("PeriodStrategy")]
        public PeriodStrategy PeriodStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpandCpu", this.ExpandCpu);
            this.SetParamObj(map, prefix + "AutoStrategy.", this.AutoStrategy);
            this.SetParamObj(map, prefix + "TimeIntervalStrategy.", this.TimeIntervalStrategy);
            this.SetParamObj(map, prefix + "PeriodStrategy.", this.PeriodStrategy);
        }
    }
}

