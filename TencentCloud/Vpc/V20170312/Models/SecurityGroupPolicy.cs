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
        /// 安全组规则索引号，值会随着安全组规则的变更动态变化。使用PolicyIndex时，请先调用`DescribeSecurityGroupPolicies`获取到规则的PolicyIndex，并且结合返回值中的Version一起使用处理规则。
        /// </summary>
        [JsonProperty("PolicyIndex")]
        public long? PolicyIndex{ get; set; }

        /// <summary>
        /// 协议, 取值: TCP,UDP,ICMP,ICMPv6,ALL。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口(all, 离散port,  range)。
        /// 说明：如果Protocol设置为ALL，则Port也需要设置为all。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 协议端口ID或者协议端口组ID。ServiceTemplate和Protocol+Port互斥。
        /// </summary>
        [JsonProperty("ServiceTemplate")]
        public ServiceTemplateSpecification ServiceTemplate{ get; set; }

        /// <summary>
        /// 网段或IP(互斥)，特殊说明：0.0.0.0/n 都会映射为0.0.0.0/0。作为入参时，可使用字符串`MY_PUBLIC_IP`指代发起请求的公网IP地址。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 网段或IPv6(互斥)。作为入参时，可使用字符串`MY_PUBLIC_IP`指代发起请求的公网IPv6地址。
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// 安全组实例ID，例如：sg-ohuuioma。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// IP地址ID或者IP地址组ID。
        /// </summary>
        [JsonProperty("AddressTemplate")]
        public AddressTemplateSpecification AddressTemplate{ get; set; }

        /// <summary>
        /// ACCEPT 或 DROP。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 安全组规则描述。作为入参时，当未传递该参数或值为空，且参数CidrBlock或Ipv6CidrBlock值为MY_PUBLIC_IP时，该参数的值将会被自动填充为Replaced-From-MY_PUBLIC_IP。
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
        public override void ToMap(Dictionary<string, string> map, string prefix)
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

