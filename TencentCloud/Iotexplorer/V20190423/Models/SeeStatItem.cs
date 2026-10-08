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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeStatItem : AbstractModel
    {
        
        /// <summary>
        /// <p>时间</p>
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// <p>任务数量</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>基础能力后付费用量</p>
        /// </summary>
        [JsonProperty("CostBasic")]
        public long? CostBasic{ get; set; }

        /// <summary>
        /// <p>高级能力后付费用量</p>
        /// </summary>
        [JsonProperty("CostAdvanced")]
        public long? CostAdvanced{ get; set; }

        /// <summary>
        /// <p>预付费额度用量</p>
        /// </summary>
        [JsonProperty("CostCredits")]
        public float? CostCredits{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "CostBasic", this.CostBasic);
            this.SetParamSimple(map, prefix + "CostAdvanced", this.CostAdvanced);
            this.SetParamSimple(map, prefix + "CostCredits", this.CostCredits);
        }
    }
}

