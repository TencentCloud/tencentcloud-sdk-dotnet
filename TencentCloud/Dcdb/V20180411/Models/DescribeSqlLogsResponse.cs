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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSqlLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前消息队列中的sql日志条目数。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 消息队列中的sql日志起始偏移。
        /// </summary>
        [JsonProperty("StartOffset")]
        public ulong? StartOffset{ get; set; }

        /// <summary>
        /// 消息队列中的sql日志结束偏移。
        /// </summary>
        [JsonProperty("EndOffset")]
        public ulong? EndOffset{ get; set; }

        /// <summary>
        /// 返回的第一条sql日志的偏移。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回的sql日志数量。
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Sql日志列表。
        /// </summary>
        [JsonProperty("SqlItems")]
        public SqlLogItem[] SqlItems{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "StartOffset", this.StartOffset);
            this.SetParamSimple(map, prefix + "EndOffset", this.EndOffset);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArrayObj(map, prefix + "SqlItems.", this.SqlItems);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

