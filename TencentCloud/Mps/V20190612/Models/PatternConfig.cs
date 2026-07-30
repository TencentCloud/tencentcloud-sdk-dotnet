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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PatternConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>透明度阈值</p><p>取值范围：[0, 255]</p><p>默认值：30</p>
        /// </summary>
        [JsonProperty("TransparencyThreshold")]
        public long? TransparencyThreshold{ get; set; }

        /// <summary>
        /// <p>不透明阈值，必须大于TransparencyThreshold</p><p>取值范围：[0, 255]</p><p>默认值：127</p>
        /// </summary>
        [JsonProperty("OpaqueThreshold")]
        public long? OpaqueThreshold{ get; set; }

        /// <summary>
        /// <p>边缘采样步数，默认5</p><p>取值范围：[1, 10]</p>
        /// </summary>
        [JsonProperty("EdgeSamplingStep")]
        public long? EdgeSamplingStep{ get; set; }

        /// <summary>
        /// <p>边缘扩展步数，默认5</p>
        /// </summary>
        [JsonProperty("EdgeExpansionStep")]
        public long? EdgeExpansionStep{ get; set; }

        /// <summary>
        /// <p>边缘融合强度，默认0.5</p><p>取值范围：[0, 1.0]</p>
        /// </summary>
        [JsonProperty("EdgeBlendingIntensity")]
        public float? EdgeBlendingIntensity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransparencyThreshold", this.TransparencyThreshold);
            this.SetParamSimple(map, prefix + "OpaqueThreshold", this.OpaqueThreshold);
            this.SetParamSimple(map, prefix + "EdgeSamplingStep", this.EdgeSamplingStep);
            this.SetParamSimple(map, prefix + "EdgeExpansionStep", this.EdgeExpansionStep);
            this.SetParamSimple(map, prefix + "EdgeBlendingIntensity", this.EdgeBlendingIntensity);
        }
    }
}

