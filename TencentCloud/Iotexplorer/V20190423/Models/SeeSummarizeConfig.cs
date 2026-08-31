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

    public class SeeSummarizeConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启每日总结
        /// </summary>
        [JsonProperty("EnableDailySummary")]
        public bool? EnableDailySummary{ get; set; }

        /// <summary>
        /// 是否开启每周总结
        /// </summary>
        [JsonProperty("EnableWeeklySummary")]
        public bool? EnableWeeklySummary{ get; set; }

        /// <summary>
        /// <p>生成总结的详细程度</p><p>枚举值：</p><ul><li>low： 精简</li><li>medium： 概要（默认值）</li></ul>
        /// </summary>
        [JsonProperty("SummaryVerbosity")]
        public string SummaryVerbosity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableDailySummary", this.EnableDailySummary);
            this.SetParamSimple(map, prefix + "EnableWeeklySummary", this.EnableWeeklySummary);
            this.SetParamSimple(map, prefix + "SummaryVerbosity", this.SummaryVerbosity);
        }
    }
}

