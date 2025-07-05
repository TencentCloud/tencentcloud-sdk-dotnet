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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEmrApplicationStaticsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 起始时间，时间戳（秒）
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 结束时间，时间戳（秒）
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 过滤的队列名
        /// </summary>
        [JsonProperty("Queues")]
        public string[] Queues{ get; set; }

        /// <summary>
        /// 过滤的用户名
        /// </summary>
        [JsonProperty("Users")]
        public string[] Users{ get; set; }

        /// <summary>
        /// 过滤的作业类型
        /// </summary>
        [JsonProperty("ApplicationTypes")]
        public string[] ApplicationTypes{ get; set; }

        /// <summary>
        /// 分组字段，可选：queue, user, applicationType
        /// </summary>
        [JsonProperty("GroupBy")]
        public string[] GroupBy{ get; set; }

        /// <summary>
        /// 排序字段，可选：sumMemorySeconds, sumVCoreSeconds, sumHDFSBytesWritten, sumHDFSBytesRead
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 是否顺序排序，0-逆序，1-正序
        /// </summary>
        [JsonProperty("IsAsc")]
        public long? IsAsc{ get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 页容量，范围为[10,100]
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Queues.", this.Queues);
            this.SetParamArraySimple(map, prefix + "Users.", this.Users);
            this.SetParamArraySimple(map, prefix + "ApplicationTypes.", this.ApplicationTypes);
            this.SetParamArraySimple(map, prefix + "GroupBy.", this.GroupBy);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "IsAsc", this.IsAsc);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

