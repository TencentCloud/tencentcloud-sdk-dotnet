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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRule : AbstractModel
    {
        
        /// <summary>
        /// 策略，ACCEPT或者DROP
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 来源Ip或Ip段，例如192.168.0.0/16
        /// </summary>
        [JsonProperty("CidrIp")]
        public string CidrIp{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("PortRange")]
        public string PortRange{ get; set; }

        /// <summary>
        /// 网络协议，支持udp、tcp等
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// 协议端口ID或者协议端口组ID。
        /// </summary>
        [JsonProperty("ServiceModule")]
        public string ServiceModule{ get; set; }

        /// <summary>
        /// IP地址ID或者ID地址组ID。
        /// </summary>
        [JsonProperty("AddressModule")]
        public string AddressModule{ get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "CidrIp", this.CidrIp);
            this.SetParamSimple(map, prefix + "PortRange", this.PortRange);
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "ServiceModule", this.ServiceModule);
            this.SetParamSimple(map, prefix + "AddressModule", this.AddressModule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

