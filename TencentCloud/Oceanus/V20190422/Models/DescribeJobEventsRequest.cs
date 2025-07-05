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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// 作业的 ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 筛选条件：起始 Unix 时间戳（秒）
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public ulong? StartTimestamp{ get; set; }

        /// <summary>
        /// 筛选条件：结束 Unix 时间戳（秒）
        /// </summary>
        [JsonProperty("EndTimestamp")]
        public ulong? EndTimestamp{ get; set; }

        /// <summary>
        /// 事件类型。如果不传则返回所有类型的数据
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// 运行实例 ID 数组
        /// </summary>
        [JsonProperty("RunningOrderIds")]
        public ulong?[] RunningOrderIds{ get; set; }

        /// <summary>
        /// 工作空间 SerialId
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "EndTimestamp", this.EndTimestamp);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamArraySimple(map, prefix + "RunningOrderIds.", this.RunningOrderIds);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
        }
    }
}

