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
        public ServiceTemplateSpecification ServiceTemplate{ get; set; }

        /// <summary>
        /// 网段或IP(互斥)。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 网段或IPv6(互斥)。
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// 安全组实例ID，例如：sg-ohuuioma。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// IP地址ID或者ID地址组ID。
        /// </summary>
        [JsonProperty("AddressTemplate")]
        public AddressTemplateSpecification AddressTemplate{ get; set; }

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
        /// 安全组最近修改时间。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyIndex", this.PolicyIndex);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamObj(map, prefix + "ServiceTemplate.", this.ServiceTemplate);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamObj(map, prefix + "AddressTemplate.", this.AddressTemplate);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

