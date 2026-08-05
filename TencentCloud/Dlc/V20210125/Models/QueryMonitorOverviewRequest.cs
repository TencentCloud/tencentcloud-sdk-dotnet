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

    public class QueryMonitorOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图表类型列表（批量查询多个指标的当前值）</p>
        /// </summary>
        [JsonProperty("ChartTypes")]
        public string[] ChartTypes{ get; set; }

        /// <summary>
        /// <p>推理服务 ID（业务唯一标识）</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ChartTypes.", this.ChartTypes);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

