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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetIpTraceStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启IP溯源
        /// </summary>
        [JsonProperty("OpenIpTrace")]
        public bool? OpenIpTrace{ get; set; }

        /// <summary>
        /// IP溯源开启持续时间，单位：秒
        /// </summary>
        [JsonProperty("DurationTime")]
        public long? DurationTime{ get; set; }

        /// <summary>
        /// IP溯源配置
        /// </summary>
        [JsonProperty("IpTraceConfig")]
        public IpTraceConfig IpTraceConfig{ get; set; }

        /// <summary>
        /// 上次执行时间
        /// </summary>
        [JsonProperty("LastStartTime")]
        public string LastStartTime{ get; set; }

        /// <summary>
        /// 上次关闭时间
        /// </summary>
        [JsonProperty("LastEndTime")]
        public string LastEndTime{ get; set; }

        /// <summary>
        /// 是否过滤Kibana节点IP
        /// </summary>
        [JsonProperty("FilterKibanaIp")]
        public bool? FilterKibanaIp{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenIpTrace", this.OpenIpTrace);
            this.SetParamSimple(map, prefix + "DurationTime", this.DurationTime);
            this.SetParamObj(map, prefix + "IpTraceConfig.", this.IpTraceConfig);
            this.SetParamSimple(map, prefix + "LastStartTime", this.LastStartTime);
            this.SetParamSimple(map, prefix + "LastEndTime", this.LastEndTime);
            this.SetParamSimple(map, prefix + "FilterKibanaIp", this.FilterKibanaIp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

