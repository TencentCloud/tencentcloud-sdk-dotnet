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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDataRetrievalTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>开始时间。须早于 EndTime ，仅支持查询最近3个月内的任务数据</p><p>参数格式：2024-11-19 10:15:37</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间。须晚于 StartTime ，仅支持查询最近3个月内的任务数据。</p><p>参数格式：2024-10-  19 10:15:37</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>数据检索ID示例值：dataretrieval-123456</p>
        /// </summary>
        [JsonProperty("DataRetrievalId")]
        public string DataRetrievalId{ get; set; }

        /// <summary>
        /// <p>分页的偏移量，默认值为0。 示例值：0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>分页单页限制数目，默认值为20，最大值100。 示例值：20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>DataRetrievalTaskID按照【数据检索任务id】进行过滤。类型：String</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataRetrievalId", this.DataRetrievalId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

