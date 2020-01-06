/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorMetricSeriesData : AbstractModel
    {
        
        /// <summary>
        /// 监控指标。
        /// </summary>
        [JsonProperty("Series")]
        public MonitorMetric[] Series{ get; set; }

        /// <summary>
        /// 监控指标对应的时间戳。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long?[] Timestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Series.", this.Series);
            this.SetParamArraySimple(map, prefix + "Timestamp.", this.Timestamp);
        }
    }
}

