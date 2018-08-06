/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
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

    public class SecurityGroupPolicy : AbstractModel
    {
        
        /// <summary>
        /// 安全组规则索引号。
        /// </summary>
        [JsonProperty("PolicyIndex")]
        public long? PolicyIndex{ get; set; }

        /// <summary>
        /// 协议, 取值: TCP,UDP, ICMP。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口(all, 离散port,  range)。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 协议端口ID或者协议端口组ID。ServiceTemplate和Protocol+Port互斥。
        /// </summary>
        [JsonProperty("ServiceTemplate")]
        public string[] ServiceTemplate{ get; set; }

        /// <summary>
        /// 网段或IP(互斥)。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 已绑定安全组的网段或IP。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// IP地址ID或者ID地址组ID。
        /// </summary>
        [JsonProperty("AddressTemplate")]
        public string AddressTemplate{ get; set; }

        /// <summary>
        /// ACCEPT 或 DROP。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 安全组规则描述。
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyIndex", this.PolicyIndex);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArraySimple(map, prefix + "ServiceTemplate.", this.ServiceTemplate);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "AddressTemplate", this.AddressTemplate);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
        }
    }
}

