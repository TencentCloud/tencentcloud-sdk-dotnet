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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportBaselineEffectHostListRequest : AbstractModel
    {
        
        /// <summary>
        /// 基线id
        /// </summary>
        [JsonProperty("BaselineId")]
        public ulong? BaselineId{ get; set; }

        /// <summary>
        /// 筛选条件
        /// <li>AliasName- String- 主机别名</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// 主机uuid数组
        /// </summary>
        [JsonProperty("UuidList")]
        public string[] UuidList{ get; set; }

        /// <summary>
        /// 基线名称
        /// </summary>
        [JsonProperty("BaselineName")]
        public string BaselineName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BaselineId", this.BaselineId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamArraySimple(map, prefix + "UuidList.", this.UuidList);
            this.SetParamSimple(map, prefix + "BaselineName", this.BaselineName);
        }
    }
}

