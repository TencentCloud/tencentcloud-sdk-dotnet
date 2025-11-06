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

    public class UpdateIpTraceStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// IP溯源配置开关
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
        /// 是否过滤kibana节点IP
        /// </summary>
        [JsonProperty("FilterKibanaIp")]
        public bool? FilterKibanaIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpenIpTrace", this.OpenIpTrace);
            this.SetParamSimple(map, prefix + "DurationTime", this.DurationTime);
            this.SetParamObj(map, prefix + "IpTraceConfig.", this.IpTraceConfig);
            this.SetParamSimple(map, prefix + "FilterKibanaIp", this.FilterKibanaIp);
        }
    }
}

