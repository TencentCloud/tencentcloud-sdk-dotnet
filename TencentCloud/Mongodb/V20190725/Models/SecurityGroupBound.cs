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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupBound : AbstractModel
    {
        
        /// <summary>
        /// 执行规则。ACCEPT或DROP
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// ip段。
        /// </summary>
        [JsonProperty("CidrIp")]
        public string CidrIp{ get; set; }

        /// <summary>
        /// 端口范围
        /// </summary>
        [JsonProperty("PortRange")]
        public string PortRange{ get; set; }

        /// <summary>
        /// 传输层协议。tcp，udp或ALL
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// 安全组id代表的地址集合
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 地址组id代表的地址集合
        /// </summary>
        [JsonProperty("AddressModule")]
        public string AddressModule{ get; set; }

        /// <summary>
        /// 服务组id代表的协议和端口集合
        /// </summary>
        [JsonProperty("ServiceModule")]
        public string ServiceModule{ get; set; }

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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AddressModule", this.AddressModule);
            this.SetParamSimple(map, prefix + "ServiceModule", this.ServiceModule);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
        }
    }
}

