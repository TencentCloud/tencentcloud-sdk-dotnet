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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRule : AbstractModel
    {
        
        /// <summary>
        /// <p>规则动作，</p><p>枚举值：</p><ul><li>ACCEPT： 允许</li><li>DROP： 拒绝</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>来源/目标 IP 或 CIDR，如 0.0.0.0/0</p>
        /// </summary>
        [JsonProperty("CidrIp")]
        public string CidrIp{ get; set; }

        /// <summary>
        /// <p>端口范围，如 80、8080-8090、ALL</p>
        /// </summary>
        [JsonProperty("PortRange")]
        public string PortRange{ get; set; }

        /// <summary>
        /// <p>协议类型，如 tcp、udp、icmp、ALL</p>
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// <p>协议端口模板 ID</p>
        /// </summary>
        [JsonProperty("ServiceModule")]
        public string ServiceModule{ get; set; }

        /// <summary>
        /// <p>IP 地址模板 ID</p>
        /// </summary>
        [JsonProperty("AddressModule")]
        public string AddressModule{ get; set; }

        /// <summary>
        /// <p>安全组 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>规则备注描述</p>
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

