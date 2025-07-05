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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerlessMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// space空间id
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// index索引id
        /// </summary>
        [JsonProperty("IndexId")]
        public string IndexId{ get; set; }

        /// <summary>
        /// 指标类型，暂时只支持Storage(存储大小),AllMetric(所有存储指标：索引流量、存储大小、文档数量、读请求和写请求)
        /// </summary>
        [JsonProperty("MetricType")]
        public string[] MetricType{ get; set; }

        /// <summary>
        /// 时间长度类型DurationType(1: 3小时, 2: 昨天1天,3: 今日0点到现在)
        /// </summary>
        [JsonProperty("DurationType")]
        public long? DurationType{ get; set; }

        /// <summary>
        /// 索引数据
        /// </summary>
        [JsonProperty("BatchIndexList")]
        public string[] BatchIndexList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "IndexId", this.IndexId);
            this.SetParamArraySimple(map, prefix + "MetricType.", this.MetricType);
            this.SetParamSimple(map, prefix + "DurationType", this.DurationType);
            this.SetParamArraySimple(map, prefix + "BatchIndexList.", this.BatchIndexList);
        }
    }
}

