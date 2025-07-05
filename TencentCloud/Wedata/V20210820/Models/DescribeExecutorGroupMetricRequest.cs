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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExecutorGroupMetricRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行资源组id
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 使用趋势开始时间(毫秒)
        /// </summary>
        [JsonProperty("TrendStartTime")]
        public long? TrendStartTime{ get; set; }

        /// <summary>
        /// 使用趋势结束时间(毫秒)
        /// </summary>
        [JsonProperty("TrendEndTime")]
        public long? TrendEndTime{ get; set; }

        /// <summary>
        /// 执行资源组类型
        /// </summary>
        [JsonProperty("ExecutorGroupType")]
        public string ExecutorGroupType{ get; set; }

        /// <summary>
        /// 执行资源类型
        /// </summary>
        [JsonProperty("ExecutorResourceType")]
        public string ExecutorResourceType{ get; set; }

        /// <summary>
        /// 执行机ID
        /// </summary>
        [JsonProperty("LoaderId")]
        public string LoaderId{ get; set; }

        /// <summary>
        /// 指标维度
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// 指标采集粒度
        /// </summary>
        [JsonProperty("Granularity")]
        public long? Granularity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "TrendStartTime", this.TrendStartTime);
            this.SetParamSimple(map, prefix + "TrendEndTime", this.TrendEndTime);
            this.SetParamSimple(map, prefix + "ExecutorGroupType", this.ExecutorGroupType);
            this.SetParamSimple(map, prefix + "ExecutorResourceType", this.ExecutorResourceType);
            this.SetParamSimple(map, prefix + "LoaderId", this.LoaderId);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
        }
    }
}

