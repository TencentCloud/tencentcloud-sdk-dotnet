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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchLogRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>起始时间unix 毫秒时间戳</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间unix 毫秒时间戳</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>事件集ID</p>
        /// </summary>
        [JsonProperty("EventBusId")]
        public string EventBusId{ get; set; }

        /// <summary>
        /// <p>页码</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>每页数据大小</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>事件查询筛选条件；示例如下：[{&quot;key&quot;:&quot;host&quot;,&quot;operator&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;106.53.106.243&quot;},{&quot;type&quot;:&quot;AND&quot;,&quot;filters&quot;:[{&quot;key&quot;:&quot;region&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;value&quot;:&quot;<em>guangzhou</em>&quot;},{&quot;key&quot;:&quot;type&quot;,&quot;operator&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;cvm:ErrorEvent:GuestReboot&quot;}]},{&quot;type&quot;:&quot;OR&quot;,&quot;filters&quot;:[{&quot;key&quot;:&quot;field1&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;value&quot;:&quot;<em>access</em>&quot;},{&quot;key&quot;:&quot;field2&quot;,&quot;operator&quot;:&quot;eq&quot;,&quot;value&quot;:&quot;custom&quot;}]}]</p>
        /// </summary>
        [JsonProperty("Filter")]
        public LogFilter[] Filter{ get; set; }

        /// <summary>
        /// <p>事件查询结果排序，[&quot;timestamp&quot;,&quot;subject&quot;]</p>
        /// </summary>
        [JsonProperty("OrderFields")]
        public string[] OrderFields{ get; set; }

        /// <summary>
        /// <p>排序方式，asc 从旧到新，desc 从新到旧</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EventBusId", this.EventBusId);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
        }
    }
}

