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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomSampleMatrix : AbstractModel
    {
        
        /// <summary>
        /// 指标名字
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 聚合函数
        /// </summary>
        [JsonProperty("Aggregation")]
        public string Aggregation{ get; set; }

        /// <summary>
        /// 指标单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 指标序列数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Streams")]
        public SampleStream[] Streams{ get; set; }

        /// <summary>
        /// 两个时间点的时间间隔，单位纳秒
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Aggregation", this.Aggregation);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "Streams.", this.Streams);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

