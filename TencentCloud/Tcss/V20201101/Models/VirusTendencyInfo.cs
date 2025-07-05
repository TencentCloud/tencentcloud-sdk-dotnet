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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VirusTendencyInfo : AbstractModel
    {
        
        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 待处理事件总数
        /// </summary>
        [JsonProperty("PendingEventCount")]
        public ulong? PendingEventCount{ get; set; }

        /// <summary>
        /// 风险容器总数
        /// </summary>
        [JsonProperty("RiskContainerCount")]
        public ulong? RiskContainerCount{ get; set; }

        /// <summary>
        /// 事件总数
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// 隔离事件总数
        /// </summary>
        [JsonProperty("IsolateEventCount")]
        public ulong? IsolateEventCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PendingEventCount", this.PendingEventCount);
            this.SetParamSimple(map, prefix + "RiskContainerCount", this.RiskContainerCount);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "IsolateEventCount", this.IsolateEventCount);
        }
    }
}

