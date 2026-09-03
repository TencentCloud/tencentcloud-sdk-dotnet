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

    public class CheckpointMetrics : AbstractModel
    {
        
        /// <summary>
        /// <p>当前 checkpoint 对应的 epoch</p>
        /// </summary>
        [JsonProperty("Epoch")]
        public float? Epoch{ get; set; }

        /// <summary>
        /// <p>全局训练步数</p>
        /// </summary>
        [JsonProperty("Step")]
        public long? Step{ get; set; }

        /// <summary>
        /// <p>训练 loss（归一化后）</p>
        /// </summary>
        [JsonProperty("Loss")]
        public float? Loss{ get; set; }

        /// <summary>
        /// <p>评估 loss（归一化后）</p>
        /// </summary>
        [JsonProperty("EvalLoss")]
        public float? EvalLoss{ get; set; }

        /// <summary>
        /// <p>学习率</p>
        /// </summary>
        [JsonProperty("LearningRate")]
        public float? LearningRate{ get; set; }

        /// <summary>
        /// <p>snapshot 中的原始 metrics 键值对列表（前端可展开查看）</p>
        /// </summary>
        [JsonProperty("RawMetrics")]
        public MetricItem[] RawMetrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Epoch", this.Epoch);
            this.SetParamSimple(map, prefix + "Step", this.Step);
            this.SetParamSimple(map, prefix + "Loss", this.Loss);
            this.SetParamSimple(map, prefix + "EvalLoss", this.EvalLoss);
            this.SetParamSimple(map, prefix + "LearningRate", this.LearningRate);
            this.SetParamArrayObj(map, prefix + "RawMetrics.", this.RawMetrics);
        }
    }
}

