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

    public class DialDimensionItem : AbstractModel
    {
        
        /// <summary>
        /// <p>维度值。空值在控制台展示为未知。</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>执行次数。target_ip 按探测条数，其它维度按批次。</p>
        /// </summary>
        [JsonProperty("ExecutionCount")]
        public long? ExecutionCount{ get; set; }

        /// <summary>
        /// <p>成功次数</p>
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// <p>失败次数</p>
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ExecutionCount", this.ExecutionCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "AvgDuration", this.AvgDuration);
            this.SetParamSimple(map, prefix + "AvgLoss", this.AvgLoss);
        }
    }
}

