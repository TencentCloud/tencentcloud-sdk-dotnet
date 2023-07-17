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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobSubmissionLogRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业ID，例如：cql-6v1jkxrn
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 起始时间，unix时间戳，毫秒级，例如：1611754219108
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，unix时间戳，毫秒级，例如：1611754219108
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 作业运行的实例ID, 例如：1,2,3。默认为0，表示未选中任何实例，搜索该时间段内最近的一个实例的日志
        /// </summary>
        [JsonProperty("RunningOrderId")]
        public long? RunningOrderId{ get; set; }

        /// <summary>
        /// 日志搜索的关键词，默认为空
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 日志搜索的游标，可透传上次返回的值，默认为空
        /// </summary>
        [JsonProperty("Cursor")]
        public string Cursor{ get; set; }

        /// <summary>
        /// 时间戳排序规则，asc - 升序，desc - 降序。默认为升序
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 搜索的日志条数上限值，最大为100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RunningOrderId", this.RunningOrderId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

