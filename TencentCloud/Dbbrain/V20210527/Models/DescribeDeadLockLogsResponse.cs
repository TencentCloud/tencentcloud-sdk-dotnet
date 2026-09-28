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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeadLockLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>是否还有更多分页。true 表示 Offset+Limit &lt; TotalCount，客户端可用 Offset+Limit 与本次 ResultVersion 继续翻页。</p>
        /// </summary>
        [JsonProperty("HasMore")]
        public bool? HasMore{ get; set; }

        /// <summary>
        /// <p>当前查询窗口内可用的死锁事件总数（去重、关联、时间窗口过滤后）。</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>结果集版本号（SHA-256 十六进制）。同一批数据在同一查询条件下保持不变；数据发生变化时版本变化。翻页必须透传。</p>
        /// </summary>
        [JsonProperty("ResultVersion")]
        public string ResultVersion{ get; set; }

        /// <summary>
        /// <p>死锁事件列表。按事件时间倒序排列（最近的死锁在前）。</p>
        /// </summary>
        [JsonProperty("Items")]
        public DeadLockLogItem[] Items{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HasMore", this.HasMore);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "ResultVersion", this.ResultVersion);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

