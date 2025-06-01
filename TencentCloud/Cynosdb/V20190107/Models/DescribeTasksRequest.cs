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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务开始时间起始值
        /// </summary>
        [JsonProperty("StartTimeBegin")]
        public string StartTimeBegin{ get; set; }

        /// <summary>
        /// 任务开始时间结束值
        /// </summary>
        [JsonProperty("StartTimeEnd")]
        public string StartTimeEnd{ get; set; }

        /// <summary>
        /// 过滤条件，支持的搜索字段："ClusterId"、"ClusterName"、"InstanceId"、"InstanceName"、"Status"、"TaskId"、"TaskType"
        /// </summary>
        [JsonProperty("Filters")]
        public QueryFilter[] Filters{ get; set; }

        /// <summary>
        /// 查询列表长度
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 查询列表偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeBegin", this.StartTimeBegin);
            this.SetParamSimple(map, prefix + "StartTimeEnd", this.StartTimeEnd);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

