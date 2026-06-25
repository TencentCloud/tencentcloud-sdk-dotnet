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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntentModelServiceId", this.IntentModelServiceId);
            this.SetParamSimple(map, prefix + "ConfidenceThreshold", this.ConfidenceThreshold);
            this.SetParamSimple(map, prefix + "DefaultModelServiceId", this.DefaultModelServiceId);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

