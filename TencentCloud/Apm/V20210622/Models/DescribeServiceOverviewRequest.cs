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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServiceOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务系统 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指标列表
        /// </summary>
        [JsonProperty("Metrics")]
        public QueryMetricItem[] Metrics{ get; set; }

        /// <summary>
        /// 聚合维度
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 开始时间（单位：秒）
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间（单位：秒）
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 排序方式
        /// Value 填写：
        /// - asc：对查询指标进行升序排序
        /// - desc：对查询指标进行降序排序
        /// </summary>
        [JsonProperty("OrderBy")]
        public OrderBy OrderBy{ get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

