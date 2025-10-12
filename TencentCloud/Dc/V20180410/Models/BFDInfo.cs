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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BFDInfo : AbstractModel
    {
        
        /// <summary>
        /// 使能BFD多跳，0:未开启，2-255:BFD跳数
        /// </summary>
        [JsonProperty("EnableBfdMultiHop")]
        public long? EnableBfdMultiHop{ get; set; }

        /// <summary>
        /// 健康检查次数
        /// </summary>
        [JsonProperty("ProbeFailedTimes")]
        public long? ProbeFailedTimes{ get; set; }

        /// <summary>
        /// 健康检查间隔
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableBfdMultiHop", this.EnableBfdMultiHop);
            this.SetParamSimple(map, prefix + "ProbeFailedTimes", this.ProbeFailedTimes);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

