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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryMetricItem : AbstractModel
    {
        
        /// <summary>
        /// 指标名
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 同比，现支持 CompareByYesterday (与昨天相比)和CompareByLastWeek (与上周相比) 
        /// </summary>
        [JsonProperty("Compares")]
        public string[] Compares{ get; set; }

        /// <summary>
        /// 同比，已弃用，不建议使用
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "Compares.", this.Compares);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
        }
    }
}

