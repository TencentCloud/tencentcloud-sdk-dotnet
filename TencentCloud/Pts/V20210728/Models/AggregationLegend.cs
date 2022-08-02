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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AggregationLegend : AbstractModel
    {
        
        /// <summary>
        /// 指标支持的聚合函数
        /// </summary>
        [JsonProperty("Aggregation")]
        public string Aggregation{ get; set; }

        /// <summary>
        /// 聚合函数作用于指标后对应的描述
        /// </summary>
        [JsonProperty("Legend")]
        public string Legend{ get; set; }

        /// <summary>
        /// 聚合之后的指标单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Aggregation", this.Aggregation);
            this.SetParamSimple(map, prefix + "Legend", this.Legend);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

