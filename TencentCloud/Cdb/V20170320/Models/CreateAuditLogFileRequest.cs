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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAuditLogFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 开始时间(建议开始到结束时间区间最大7天)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间(建议开始到结束时间区间最大7天）。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序方式。支持值包括："ASC" - 升序，"DESC" - 降序，默认降序排序。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段。支持值包括(默认按照时间戳排序)： "timestamp" - 时间戳； "affectRows" - 影响行数； "execTime" - 执行时间。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 已废弃。
        /// </summary>
        [JsonProperty("Filter")]
        [System.Obsolete]
        public AuditLogFilter Filter{ get; set; }

        /// <summary>
        /// 过滤条件。可按设置的过滤条件过滤日志。
        /// </summary>
        [JsonProperty("LogFilter")]
        public InstanceAuditLogFilters[] LogFilter{ get; set; }

        /// <summary>
        /// 下载筛选列
        /// </summary>
        [JsonProperty("ColumnFilter")]
        public string[] ColumnFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArrayObj(map, prefix + "LogFilter.", this.LogFilter);
            this.SetParamArraySimple(map, prefix + "ColumnFilter.", this.ColumnFilter);
        }
    }
}

