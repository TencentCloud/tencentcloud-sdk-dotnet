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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>调用类型，来源于计费 scene_billing（与 filter.call_type 对应）</p>
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// <p>是否默认知识库</p>
        /// </summary>
        [JsonProperty("IsDefaultKB")]
        public bool? IsDefaultKB{ get; set; }

        /// <summary>
        /// <p>模型名称</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>MODEL 域单次调用的消耗计量列表（权威字段）：按单位+label 分项列出每类计量。unit=TOKEN 时 label 区分 Token 子类别（input/output/avg_*/cache_*），label 为空表示 total_tokens；unit=PAGE_COUNT 表示模型消耗页数</p>
        /// </summary>
        [JsonProperty("ResourceConsumptionList")]
        public ResourceConsumption[] ResourceConsumptionList{ get; set; }

        /// <summary>
        /// <p>本次调用消耗 PU 量</p>
        /// </summary>
        [JsonProperty("ConsumptionPU")]
        public float? ConsumptionPU{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "IsDefaultKB", this.IsDefaultKB);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArrayObj(map, prefix + "ResourceConsumptionList.", this.ResourceConsumptionList);
            this.SetParamSimple(map, prefix + "ConsumptionPU", this.ConsumptionPU);
        }
    }
}

