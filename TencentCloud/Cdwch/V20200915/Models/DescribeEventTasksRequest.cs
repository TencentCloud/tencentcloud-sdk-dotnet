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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEventTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 过滤的事件任务id
        /// </summary>
        [JsonProperty("EventTaskId")]
        public long? EventTaskId{ get; set; }

        /// <summary>
        /// 页码，默认为1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量（支持10、20、30、50、100、200），默认为100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 事件名称过滤
        /// </summary>
        [JsonProperty("EventCode")]
        public string EventCode{ get; set; }

        /// <summary>
        /// (1-待处理;2-已预约;3-处理中;4-已结束;5-处理中;-1-已忽略;-2-已删除)
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 创建时间范围开始 (格式: YYYY-MM-DD HH:MM:SS)，最大支持查询180天信息
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 创建时间范围结束 (格式: YYYY-MM-DD HH:MM:SS)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 排序字段（事件类型：event_code；触发时间：create_time；完成时间：end_time）
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// 排序顺序 (asc/desc)
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EventTaskId", this.EventTaskId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "EventCode", this.EventCode);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

