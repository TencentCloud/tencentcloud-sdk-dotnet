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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveDomainPlayInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据时间，格式为yyyy-mm-dd HH:MM:SS。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 实时总带宽。
        /// </summary>
        [JsonProperty("TotalBandwidth")]
        public float? TotalBandwidth{ get; set; }

        /// <summary>
        /// 实时总流量。
        /// </summary>
        [JsonProperty("TotalFlux")]
        public float? TotalFlux{ get; set; }

        /// <summary>
        /// 总请求数。
        /// </summary>
        [JsonProperty("TotalRequest")]
        public ulong? TotalRequest{ get; set; }

        /// <summary>
        /// 实时总连接数。
        /// </summary>
        [JsonProperty("TotalOnline")]
        public ulong? TotalOnline{ get; set; }

        /// <summary>
        /// 分域名的数据情况。
        /// </summary>
        [JsonProperty("DomainInfoList")]
        public DomainInfoList[] DomainInfoList{ get; set; }

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
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TotalBandwidth", this.TotalBandwidth);
            this.SetParamSimple(map, prefix + "TotalFlux", this.TotalFlux);
            this.SetParamSimple(map, prefix + "TotalRequest", this.TotalRequest);
            this.SetParamSimple(map, prefix + "TotalOnline", this.TotalOnline);
            this.SetParamArrayObj(map, prefix + "DomainInfoList.", this.DomainInfoList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

