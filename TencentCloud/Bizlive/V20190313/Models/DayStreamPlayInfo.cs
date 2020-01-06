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

namespace TencentCloud.Bizlive.V20190313.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DayStreamPlayInfo : AbstractModel
    {
        
        /// <summary>
        /// 带宽（单位Mbps）。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// 流量 （单位MB）。
        /// </summary>
        [JsonProperty("Flux")]
        public float? Flux{ get; set; }

        /// <summary>
        /// 在线人数。
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// 请求数。
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }

        /// <summary>
        /// 数据时间点，格式：yyyy-mm-dd HH:MM:SS。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "Time", this.Time);
        }
    }
}

