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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewItem : AbstractModel
    {
        
        /// <summary>
        /// <p>图表类型（与请求中的 ChartTypes 对应）</p>
        /// </summary>
        [JsonProperty("ChartType")]
        public string ChartType{ get; set; }

        /// <summary>
        /// <p>当前瞬时值（如 QPS=15.2、延迟=120.5ms、利用率=85.0%）。查询失败或无数据时为 null</p>
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChartType", this.ChartType);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

