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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetDetectRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络探测实例`ID`。形如：`netd-12345678`
        /// </summary>
        [JsonProperty("NetDetectId")]
        public string NetDetectId{ get; set; }

        /// <summary>
        /// 网络探测名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("NetDetectName")]
        public string NetDetectName{ get; set; }

        /// <summary>
        /// 探测目的IPv4地址数组，最多两个。
        /// </summary>
        [JsonProperty("DetectDestinationIp")]
        public string[] DetectDestinationIp{ get; set; }

        /// <summary>
        /// 下一跳类型，目前我们支持的类型有：
        /// VPN：VPN网关；
        /// DIRECTCONNECT：专线网关；
        /// PEERCONNECTION：对等连接；
        /// NAT：NAT网关；
        /// NORMAL_CVM：普通云服务器；
        /// </summary>
        [JsonProperty("NextHopType")]
        public string NextHopType{ get; set; }

        /// <summary>
        /// 下一跳目的网关，取值与“下一跳类型”相关：
        /// 下一跳类型为VPN，取值VPN网关ID，形如：vpngw-12345678；
        /// 下一跳类型为DIRECTCONNECT，取值专线网关ID，形如：dcg-12345678；
        /// 下一跳类型为PEERCONNECTION，取值对等连接ID，形如：pcx-12345678；
        /// 下一跳类型为NAT，取值Nat网关，形如：nat-12345678；
        /// 下一跳类型为NORMAL_CVM，取值云服务器IPv4地址，形如：10.0.0.12；
        /// </summary>
        [JsonProperty("NextHopDestination")]
        public string NextHopDestination{ get; set; }

        /// <summary>
        /// 网络探测描述。
        /// </summary>
        [JsonProperty("NetDetectDescription")]
        public string NetDetectDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetDetectId", this.NetDetectId);
            this.SetParamSimple(map, prefix + "NetDetectName", this.NetDetectName);
            this.SetParamArraySimple(map, prefix + "DetectDestinationIp.", this.DetectDestinationIp);
            this.SetParamSimple(map, prefix + "NextHopType", this.NextHopType);
            this.SetParamSimple(map, prefix + "NextHopDestination", this.NextHopDestination);
            this.SetParamSimple(map, prefix + "NetDetectDescription", this.NetDetectDescription);
        }
    }
}

