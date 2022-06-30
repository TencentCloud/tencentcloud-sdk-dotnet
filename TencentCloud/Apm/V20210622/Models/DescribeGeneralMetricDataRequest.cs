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

    public class DescribeGeneralMetricDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 要过滤的维度信息
        /// service_metric视图支持：service.name（服务名）、span.kind（客户端/服务端视角）为维度进行过滤。
        /// span.kind:
        /// 	server:服务端视角
        /// 	client:客户端视角
        /// 默认为服务端视角进行查询。
        /// runtime_metric视图支持：service.name（服务名）维度进行过滤。
        /// sql_metric视图支持：service.name（服务名）维度进行过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public GeneralFilter[] Filters{ get; set; }

        /// <summary>
        /// 需要查询的指标，不可自定义输入。
        /// service_metric视图支持：service_request_count（总请求）、service_duration（平均响应时间）、service_error_req_rate（平均错误率）、service_slow_call_count（慢调用）、service_error_request_count（异常数量）。
        /// runtime_metric视图支持：service_gc_full_count（Full GC）。
        /// sql_metric视图支持：service_slow_sql_count（慢sql）。
        /// </summary>
        [JsonProperty("Metrics")]
        public string[] Metrics{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 视图名称，不可自定义输入。支持：service_metric、runtime_metric、sql_metric。
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// 聚合维度
        /// service_metric视图支持：service.name（服务名）、span.kind （客户端/服务端视角）维度进行聚合。
        /// runtime_metric视图支持：service.name（服务名）维度进行聚合。
        /// sql_metric视图支持：service.name（服务名）维度进行聚合。
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// 起始时间的时间戳，单位为秒，只支持查询2天内最多1小时的指标数据。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间的时间戳，单位为秒，只支持查询2天内最多1小时的指标数据。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 聚合粒度，单位为秒，最小为60s，即一分钟的聚合粒度；如果为空或0则计算开始时间到截止时间的指标数据，上报其他值会报错。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Period", this.Period);
        }
    }
}

