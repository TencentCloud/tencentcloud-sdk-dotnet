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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerStatus : AbstractModel
    {
        
        /// <summary>
        /// 失败次数
        /// </summary>
        [JsonProperty("FailedCount")]
        public string FailedCount{ get; set; }

        /// <summary>
        /// 上次触发时间
        /// </summary>
        [JsonProperty("LastFireTime")]
        public string LastFireTime{ get; set; }

        /// <summary>
        /// 最近一次会话ID
        /// </summary>
        [JsonProperty("LastSessionId")]
        public string LastSessionId{ get; set; }

        /// <summary>
        /// 下次触发时间
        /// </summary>
        [JsonProperty("NextFireTime")]
        public string NextFireTime{ get; set; }

        /// <summary>
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 |  |
        /// | 1 | 启用 |
        /// | 2 | 暂停 |
        /// | 3 | 一次性任务已完成 |
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 成功次数
        /// </summary>
        [JsonProperty("SuccessCount")]
        public string SuccessCount{ get; set; }

        /// <summary>
        /// 未读数量
        /// </summary>
        [JsonProperty("UnreadRunLogCount")]
        public string UnreadRunLogCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamSimple(map, prefix + "LastFireTime", this.LastFireTime);
            this.SetParamSimple(map, prefix + "LastSessionId", this.LastSessionId);
            this.SetParamSimple(map, prefix + "NextFireTime", this.NextFireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "UnreadRunLogCount", this.UnreadRunLogCount);
        }
    }
}

