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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>会话所属空间 ID。</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>用户 ID。可通过调用方业务系统接口获取。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>会话 ID。可通过 CreateSession 或 DescribeSessions 接口获取。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Agent ID。可选。</p>
        /// </summary>
        [JsonProperty("AgentId")]
        [System.Obsolete]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>返回最近事件数量，默认为 0，最大值为 200。</p>
        /// </summary>
        [JsonProperty("NumRecentEvents")]
        public long? NumRecentEvents{ get; set; }

        /// <summary>
        /// <p>事件起始时间，RFC3339 格式，最大长度 64 字符。</p>
        /// </summary>
        [JsonProperty("AfterTimestamp")]
        public string AfterTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "NumRecentEvents", this.NumRecentEvents);
            this.SetParamSimple(map, prefix + "AfterTimestamp", this.AfterTimestamp);
        }
    }
}

