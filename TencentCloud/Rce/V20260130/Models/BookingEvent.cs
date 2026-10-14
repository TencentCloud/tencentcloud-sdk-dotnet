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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BookingEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>预约场景。例如：预订机票、预订酒店</p>
        /// </summary>
        [JsonProperty("BookingScene")]
        public string BookingScene{ get; set; }

        /// <summary>
        /// <p>预约时间。要求符合ISO-8601标准的带时区的毫秒级时间，格式&quot;YYYY-MM-DDTHH:mm:ss.sssZ&quot; ，例如&quot;2025-10-19T09:11:10.145+08:00&quot;。</p>
        /// </summary>
        [JsonProperty("BookingTime")]
        public string BookingTime{ get; set; }

        /// <summary>
        /// <p>预约单唯一ID。</p>
        /// </summary>
        [JsonProperty("BookingId")]
        public string BookingId{ get; set; }

        /// <summary>
        /// <p>与RCE-PRO约定的定制化信息。为K:V 格式的对象数组。<br>示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BookingScene", this.BookingScene);
            this.SetParamSimple(map, prefix + "BookingTime", this.BookingTime);
            this.SetParamSimple(map, prefix + "BookingId", this.BookingId);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

