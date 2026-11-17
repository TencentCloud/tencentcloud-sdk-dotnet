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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoMlConf : AbstractModel
    {
        
        /// <summary>
        /// 评估指标：acc/auc/f1/mse/mae/rmse
        /// </summary>
        [JsonProperty("EvaluationMetric")]
        public string EvaluationMetric{ get; set; }

        /// <summary>
        /// 搜索空间列表
        /// </summary>
        [JsonProperty("SearchSpace")]
        public string[] SearchSpace{ get; set; }

        /// <summary>
        /// 最大运行时间（分钟），默认60
        /// </summary>
        [JsonProperty("MaxRuntimeMinutes")]
        public long? MaxRuntimeMinutes{ get; set; }

        /// <summary>
        /// 最大运行次数，默认100
        /// </summary>
        [JsonProperty("MaxRunCount")]
        public long? MaxRunCount{ get; set; }

        /// <summary>
        /// 最大运行并发，默认1，最大100
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvaluationMetric", this.EvaluationMetric);
            this.SetParamArraySimple(map, prefix + "SearchSpace.", this.SearchSpace);
            this.SetParamSimple(map, prefix + "MaxRuntimeMinutes", this.MaxRuntimeMinutes);
            this.SetParamSimple(map, prefix + "MaxRunCount", this.MaxRunCount);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
        }
    }
}

