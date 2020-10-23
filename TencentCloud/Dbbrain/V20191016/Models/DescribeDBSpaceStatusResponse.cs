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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBSpaceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 磁盘增长量(MB)。
        /// </summary>
        [JsonProperty("Growth")]
        public long? Growth{ get; set; }

        /// <summary>
        /// 磁盘剩余(MB)。
        /// </summary>
        [JsonProperty("Remain")]
        public long? Remain{ get; set; }

        /// <summary>
        /// 磁盘总量(MB)。
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// 预计可用天数。
        /// </summary>
        [JsonProperty("AvailableDays")]
        public long? AvailableDays{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Growth", this.Growth);
            this.SetParamSimple(map, prefix + "Remain", this.Remain);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "AvailableDays", this.AvailableDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

