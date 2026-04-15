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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNatGatewayAdvancedAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT网关的ID，形如：`nat-df45454`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// UDP映射空闲时间，单位：秒。含义为UDP流空闲多少秒以后从NAT映射中释放。取值范围为：3-7200，默认为180。
        /// </summary>
        [JsonProperty("UDPMappingTimeout")]
        public ulong? UDPMappingTimeout{ get; set; }

        /// <summary>
        /// TCP已建立的连接空闲超时时间，单位：秒。含义为TCP已建立的连接空闲多少秒以后从NAT映射中释放。取值范围为：40-10800，默认为10800。
        /// </summary>
        [JsonProperty("TCPEstablishedConnectionTimeout")]
        public ulong? TCPEstablishedConnectionTimeout{ get; set; }

        /// <summary>
        /// TCP TIME_WAIT超时时间，单位：秒。含义为完全关闭的TCP连接在到期后保留在NAT映射中的秒数。取值范围为：10-600，默认为120。
        /// </summary>
        [JsonProperty("TCPTimeWaitTimeout")]
        public ulong? TCPTimeWaitTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamSimple(map, prefix + "UDPMappingTimeout", this.UDPMappingTimeout);
            this.SetParamSimple(map, prefix + "TCPEstablishedConnectionTimeout", this.TCPEstablishedConnectionTimeout);
            this.SetParamSimple(map, prefix + "TCPTimeWaitTimeout", this.TCPTimeWaitTimeout);
        }
    }
}

