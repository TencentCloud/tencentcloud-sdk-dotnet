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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTDEMDialOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务数</p>
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// <p>执行批次数</p>
        /// </summary>
        [JsonProperty("ExecutionCount")]
        public long? ExecutionCount{ get; set; }

        /// <summary>
        /// <p>成功批次数</p>
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// <p>失败批次数</p>
        /// </summary>
        [JsonProperty("FailCount")]
        public long? FailCount{ get; set; }

        /// <summary>
        /// <p>平均时延，单位毫秒</p>
        /// </summary>
        [JsonProperty("AvgDuration")]
        public float? AvgDuration{ get; set; }

        /// <summary>
        /// <p>平均丢包率，0 到 100</p>
        /// </summary>
        [JsonProperty("AvgLoss")]
        public float? AvgLoss{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "ExecutionCount", this.ExecutionCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "AvgDuration", this.AvgDuration);
            this.SetParamSimple(map, prefix + "AvgLoss", this.AvgLoss);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

