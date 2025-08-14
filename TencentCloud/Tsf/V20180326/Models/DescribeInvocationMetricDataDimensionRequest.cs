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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInvocationMetricDataDimensionRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 开始index
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 聚合维度。可选值 NamespaceId：命名空间ID，GroupId：部署组ID，InstanceId：实例ID，ApplicationId：应用ID，OperationMethod：执行方法，OperationName：执行名称，ServiceName：服务名，UpstreamNamespaceId：上游命名空间ID
        /// </summary>
        [JsonProperty("DimensionName")]
        public string DimensionName{ get; set; }

        /// <summary>
        /// 搜索关键字
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 构建维度
        /// </summary>
        [JsonProperty("MetricDimensionValues")]
        public MetricDimensionValue[] MetricDimensionValues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "DimensionName", this.DimensionName);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArrayObj(map, prefix + "MetricDimensionValues.", this.MetricDimensionValues);
        }
    }
}

