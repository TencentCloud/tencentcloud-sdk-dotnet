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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupUnitApiDailyUseStatistics : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 该API在该命名空间下的总调用次数
        /// </summary>
        [JsonProperty("SumReqAmount")]
        public string SumReqAmount{ get; set; }

        /// <summary>
        /// 该API在该命名空间下的平均错误率
        /// </summary>
        [JsonProperty("AvgFailureRate")]
        public string AvgFailureRate{ get; set; }

        /// <summary>
        /// 该API在该命名空间下的平均响应时间
        /// </summary>
        [JsonProperty("AvgTimeCost")]
        public string AvgTimeCost{ get; set; }

        /// <summary>
        /// 监控数据曲线点位图Map集合
        /// </summary>
        [JsonProperty("MetricDataPointMap")]
        public MetricDataPointMap MetricDataPointMap{ get; set; }

        /// <summary>
        /// 状态码分布详情
        /// </summary>
        [JsonProperty("TopStatusCode")]
        public ApiUseStatisticsEntity[] TopStatusCode{ get; set; }

        /// <summary>
        /// 耗时分布详情
        /// </summary>
        [JsonProperty("TopTimeCost")]
        public ApiUseStatisticsEntity[] TopTimeCost{ get; set; }

        /// <summary>
        /// 分位值对象
        /// </summary>
        [JsonProperty("Quantile")]
        public QuantileEntity Quantile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "SumReqAmount", this.SumReqAmount);
            this.SetParamSimple(map, prefix + "AvgFailureRate", this.AvgFailureRate);
            this.SetParamSimple(map, prefix + "AvgTimeCost", this.AvgTimeCost);
            this.SetParamObj(map, prefix + "MetricDataPointMap.", this.MetricDataPointMap);
            this.SetParamArrayObj(map, prefix + "TopStatusCode.", this.TopStatusCode);
            this.SetParamArrayObj(map, prefix + "TopTimeCost.", this.TopTimeCost);
            this.SetParamObj(map, prefix + "Quantile.", this.Quantile);
        }
    }
}

