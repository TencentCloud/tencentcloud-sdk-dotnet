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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparkJobSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>Driver 资源规格（CU 数）.</p>
        /// </summary>
        [JsonProperty("DriverCU")]
        public long? DriverCU{ get; set; }

        /// <summary>
        /// <p>Executor 资源规格（CU 数）.</p>
        /// </summary>
        [JsonProperty("ExecutorCU")]
        public long? ExecutorCU{ get; set; }

        /// <summary>
        /// <p>Executor 实例数量（弹性伸缩关闭时的固定数量）.</p>
        /// </summary>
        [JsonProperty("ExecutorNum")]
        public long? ExecutorNum{ get; set; }

        /// <summary>
        /// <p>是否开启弹性扩缩容.</p>
        /// </summary>
        [JsonProperty("DynamicAllocation")]
        public bool? DynamicAllocation{ get; set; }

        /// <summary>
        /// <p>弹性扩缩容最小 Executor 数.</p>
        /// </summary>
        [JsonProperty("MinExecutors")]
        public long? MinExecutors{ get; set; }

        /// <summary>
        /// <p>弹性扩缩容最大 Executor 数.</p>
        /// </summary>
        [JsonProperty("MaxExecutors")]
        public long? MaxExecutors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DriverCU", this.DriverCU);
            this.SetParamSimple(map, prefix + "ExecutorCU", this.ExecutorCU);
            this.SetParamSimple(map, prefix + "ExecutorNum", this.ExecutorNum);
            this.SetParamSimple(map, prefix + "DynamicAllocation", this.DynamicAllocation);
            this.SetParamSimple(map, prefix + "MinExecutors", this.MinExecutors);
            this.SetParamSimple(map, prefix + "MaxExecutors", this.MaxExecutors);
        }
    }
}

