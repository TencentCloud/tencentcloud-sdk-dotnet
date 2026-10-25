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

    public class TDEMSSEDistributionBin : AbstractModel
    {
        
        /// <summary>
        /// <p>档位左端，左闭。</p>
        /// </summary>
        [JsonProperty("Start")]
        public float? Start{ get; set; }

        /// <summary>
        /// <p>档位右端。溢出档省略。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("End")]
        public float? End{ get; set; }

        /// <summary>
        /// <p>是否为溢出档。溢出档为 true，且不返回 End。</p>
        /// </summary>
        [JsonProperty("Overflow")]
        public bool? Overflow{ get; set; }

        /// <summary>
        /// <p>落入该档的对话次数。</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>该档占有效样本的百分比，已乘 100。</p>
        /// </summary>
        [JsonProperty("Rate")]
        public float? Rate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
            this.SetParamSimple(map, prefix + "Overflow", this.Overflow);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
        }
    }
}

