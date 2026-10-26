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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWIntentRoute : AbstractModel
    {
        
        /// <summary>
        /// <p>意图识别模型id</p>
        /// </summary>
        [JsonProperty("IntentModelServiceId")]
        public string IntentModelServiceId{ get; set; }

        /// <summary>
        /// <p>置信度</p>
        /// </summary>
        [JsonProperty("ConfidenceThreshold")]
        public float? ConfidenceThreshold{ get; set; }

        /// <summary>
        /// <p>默认服务id</p>
        /// </summary>
        [JsonProperty("DefaultModelServiceId")]
        public string DefaultModelServiceId{ get; set; }

        /// <summary>
        /// <p>规则</p>
        /// </summary>
        [JsonProperty("Rules")]
        public AIGWIntentRouteRule[] Rules{ get; set; }

        /// <summary>
        /// <p>默认路由目标 DefaultModelServiceId 对应的标准模型名称；为空表示未配置。仅对应 TIONE 模型服务时可配置。非空值最长 256 字节，支持中文、英文、数字、下划线和短横线，须以中文、英文或数字开头。同一网关内不同模型 API 不得使用相同的标准模型名称；同一模型 API 内同一模型服务在多处配置时须保持一致。</p>
        /// </summary>
        [JsonProperty("DefaultStandardModelName")]
        public string DefaultStandardModelName{ get; set; }

        /// <summary>
        /// <p>执行意图识别的 IntentModelServiceId 对应的标准模型名称；为空表示未配置。仅对应 TIONE 模型服务时可配置。非空值最长 256 字节，支持中文、英文、数字、下划线和短横线，须以中文、英文或数字开头。同一网关内不同模型 API 不得使用相同的标准模型名称；同一模型 API 内同一模型服务在多处配置时须保持一致。</p>
        /// </summary>
        [JsonProperty("IntentStandardModelName")]
        public string IntentStandardModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentModelServiceId", this.IntentModelServiceId);
            this.SetParamSimple(map, prefix + "ConfidenceThreshold", this.ConfidenceThreshold);
            this.SetParamSimple(map, prefix + "DefaultModelServiceId", this.DefaultModelServiceId);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "DefaultStandardModelName", this.DefaultStandardModelName);
            this.SetParamSimple(map, prefix + "IntentStandardModelName", this.IntentStandardModelName);
        }
    }
}

