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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicPodSpec : AbstractModel
    {
        
        /// <summary>
        /// 需求最小cpu核数
        /// </summary>
        [JsonProperty("RequestCpu")]
        public float? RequestCpu{ get; set; }

        /// <summary>
        /// 需求最大cpu核数
        /// </summary>
        [JsonProperty("LimitCpu")]
        public float? LimitCpu{ get; set; }

        /// <summary>
        /// 需求最小memory，单位MB
        /// </summary>
        [JsonProperty("RequestMemory")]
        public float? RequestMemory{ get; set; }

        /// <summary>
        /// 需求最大memory，单位MB
        /// </summary>
        [JsonProperty("LimitMemory")]
        public float? LimitMemory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestCpu", this.RequestCpu);
            this.SetParamSimple(map, prefix + "LimitCpu", this.LimitCpu);
            this.SetParamSimple(map, prefix + "RequestMemory", this.RequestMemory);
            this.SetParamSimple(map, prefix + "LimitMemory", this.LimitMemory);
        }
    }
}

