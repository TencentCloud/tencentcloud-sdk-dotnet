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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrainingMetric : AbstractModel
    {
        
        /// <summary>
        /// 指标名
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 数据值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Values")]
        public TrainingDataPoint[] Values{ get; set; }

        /// <summary>
        /// 上报的Epoch. 可能为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Epochs")]
        public TrainingDataPoint[] Epochs{ get; set; }

        /// <summary>
        /// 上报的Step. 可能为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Steps")]
        public TrainingDataPoint[] Steps{ get; set; }

        /// <summary>
        /// 上报的TotalSteps. 可能为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalSteps")]
        public TrainingDataPoint[] TotalSteps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArrayObj(map, prefix + "Values.", this.Values);
            this.SetParamArrayObj(map, prefix + "Epochs.", this.Epochs);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
            this.SetParamArrayObj(map, prefix + "TotalSteps.", this.TotalSteps);
        }
    }
}

