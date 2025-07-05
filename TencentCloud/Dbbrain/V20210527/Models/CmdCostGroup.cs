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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CmdCostGroup : AbstractModel
    {
        
        /// <summary>
        /// 该延迟区间内命令数占总命令数百分比
        /// </summary>
        [JsonProperty("Percent")]
        public float? Percent{ get; set; }

        /// <summary>
        /// 延迟区间上界，单位ms
        /// </summary>
        [JsonProperty("CostUpperLimit")]
        public string CostUpperLimit{ get; set; }

        /// <summary>
        /// 延迟区间下界，单位ms
        /// </summary>
        [JsonProperty("CostLowerLimit")]
        public string CostLowerLimit{ get; set; }

        /// <summary>
        /// 该延迟区间内命令次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CostUpperLimit", this.CostUpperLimit);
            this.SetParamSimple(map, prefix + "CostLowerLimit", this.CostLowerLimit);
            this.SetParamSimple(map, prefix + "Count", this.Count);
        }
    }
}

