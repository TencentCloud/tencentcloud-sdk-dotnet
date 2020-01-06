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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTimeWindowResponse : AbstractModel
    {
        
        /// <summary>
        /// 星期一的可维护时间列表。
        /// </summary>
        [JsonProperty("Monday")]
        public string[] Monday{ get; set; }

        /// <summary>
        /// 星期二的可维护时间列表。
        /// </summary>
        [JsonProperty("Tuesday")]
        public string[] Tuesday{ get; set; }

        /// <summary>
        /// 星期三的可维护时间列表。
        /// </summary>
        [JsonProperty("Wednesday")]
        public string[] Wednesday{ get; set; }

        /// <summary>
        /// 星期四的可维护时间列表。
        /// </summary>
        [JsonProperty("Thursday")]
        public string[] Thursday{ get; set; }

        /// <summary>
        /// 星期五的可维护时间列表。
        /// </summary>
        [JsonProperty("Friday")]
        public string[] Friday{ get; set; }

        /// <summary>
        /// 星期六的可维护时间列表。
        /// </summary>
        [JsonProperty("Saturday")]
        public string[] Saturday{ get; set; }

        /// <summary>
        /// 星期日的可维护时间列表。
        /// </summary>
        [JsonProperty("Sunday")]
        public string[] Sunday{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "Monday.", this.Monday);
            this.SetParamArraySimple(map, prefix + "Tuesday.", this.Tuesday);
            this.SetParamArraySimple(map, prefix + "Wednesday.", this.Wednesday);
            this.SetParamArraySimple(map, prefix + "Thursday.", this.Thursday);
            this.SetParamArraySimple(map, prefix + "Friday.", this.Friday);
            this.SetParamArraySimple(map, prefix + "Saturday.", this.Saturday);
            this.SetParamArraySimple(map, prefix + "Sunday.", this.Sunday);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

