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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcEndpointInfo : AbstractModel
    {
        
        /// <summary>
        /// vpc的id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// vpc接入点信息
        /// </summary>
        [JsonProperty("VpcEndpoint")]
        public string VpcEndpoint{ get; set; }

        /// <summary>
        /// vpc接入点状态 OFF/ON/CREATING/DELETING
        /// </summary>
        [JsonProperty("VpcDataStreamEndpointStatus")]
        public string VpcDataStreamEndpointStatus{ get; set; }

        /// <summary>
        /// TLS加密的数据流接入点
        /// </summary>
        [JsonProperty("VpcTlsEndpoint")]
        public string VpcTlsEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcEndpoint", this.VpcEndpoint);
            this.SetParamSimple(map, prefix + "VpcDataStreamEndpointStatus", this.VpcDataStreamEndpointStatus);
            this.SetParamSimple(map, prefix + "VpcTlsEndpoint", this.VpcTlsEndpoint);
        }
    }
}

