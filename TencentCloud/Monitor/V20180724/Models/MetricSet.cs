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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricSet : AbstractModel
    {
        
        /// <summary>
        /// 命名空间，每个云产品会有一个命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 指标使用的单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 指标使用的单位
        /// </summary>
        [JsonProperty("UnitCname")]
        public string UnitCname{ get; set; }

        /// <summary>
        /// 指标支持的统计周期，单位是秒，如60、300
        /// </summary>
        [JsonProperty("Period")]
        public long?[] Period{ get; set; }

        /// <summary>
        /// 统计周期内指标方式
        /// </summary>
        [JsonProperty("Periods")]
        public PeriodsSt[] Periods{ get; set; }

        /// <summary>
        /// 统计指标含义解释
        /// </summary>
        [JsonProperty("Meaning")]
        public MetricObjectMeaning Meaning{ get; set; }

        /// <summary>
        /// 维度描述信息
        /// </summary>
        [JsonProperty("Dimensions")]
        public DimensionsDesc[] Dimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "UnitCname", this.UnitCname);
            this.SetParamArraySimple(map, prefix + "Period.", this.Period);
            this.SetParamArrayObj(map, prefix + "Periods.", this.Periods);
            this.SetParamObj(map, prefix + "Meaning.", this.Meaning);
            this.SetParamArrayObj(map, prefix + "Dimensions.", this.Dimensions);
        }
    }
}

