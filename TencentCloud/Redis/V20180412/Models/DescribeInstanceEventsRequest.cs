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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置查询事件执行计划的起始日期，查询日期最大跨度30天。
        /// </summary>
        [JsonProperty("ExecutionStartDate")]
        public string ExecutionStartDate{ get; set; }

        /// <summary>
        /// 配置查询事件执行计划的结束日期，查询日期最大跨度30天。
        /// </summary>
        [JsonProperty("ExecutionEndDate")]
        public string ExecutionEndDate{ get; set; }

        /// <summary>
        /// 指定实例 ID。例如：crs-xjhsdj****。请登录[Redis控制台](https://console.cloud.tencent.com/redis)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 输出每页显示事件的数量。
        /// - 默认值：10。
        /// - 取值范围：[1,100]。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 配置查询事件的输出页码，即支持根据PageNo（页码）与 PageSize （每页输出数量）查询某一页的事件。
        /// - 默认值：1。
        /// - 取值范围：大于0 的正整数。
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 事件当前状态。
        /// - Waiting：未到达执行日期或不在维护时间窗内的事件。
        /// - Running：在维护时间窗内，正在执行维护的事件。
        /// - Finished：已全部完成维护的事件。
        /// - Canceled：已取消执行的事件。
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// 事件类型，当前仅支持配置实例迁移、资源腾挪、机房裁撤相关的运维操作。该参数仅支持配置为 **InstanceMigration**。
        /// </summary>
        [JsonProperty("EventTypes")]
        public string[] EventTypes{ get; set; }

        /// <summary>
        /// 配置查询事件等级。事件等级根据其影响严重程度和紧急程度进行分级，由重至轻依次为关键、重要、中等、一般。
        /// - Critical：关键
        /// - High：重要
        /// - Middle：中等
        /// - Low：一般
        /// </summary>
        [JsonProperty("Grades")]
        public string[] Grades{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionStartDate", this.ExecutionStartDate);
            this.SetParamSimple(map, prefix + "ExecutionEndDate", this.ExecutionEndDate);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "EventTypes.", this.EventTypes);
            this.SetParamArraySimple(map, prefix + "Grades.", this.Grades);
        }
    }
}

