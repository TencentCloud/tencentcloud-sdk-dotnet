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

    public class EnableVpcEndPointConnectRequest : AbstractModel
    {
        
        /// <summary>
        /// 终端节点服务ID。
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// 终端节点ID。
        /// </summary>
        [JsonProperty("EndPointId")]
        public string[] EndPointId{ get; set; }

        /// <summary>
        /// 是否接受终端节点连接请求。
        /// <li> true：自动接受。</li> <li> false：不自动接受。</li>
        /// </summary>
        [JsonProperty("AcceptFlag")]
        public bool? AcceptFlag{ get; set; }

        /// <summary>
        /// 协议类型，支持 Ipv4，Ipv6，默认 Ipv4。
        /// </summary>
        [JsonProperty("IpAddressType")]
        public string IpAddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamArraySimple(map, prefix + "EndPointId.", this.EndPointId);
            this.SetParamSimple(map, prefix + "AcceptFlag", this.AcceptFlag);
            this.SetParamSimple(map, prefix + "IpAddressType", this.IpAddressType);
        }
    }
}

