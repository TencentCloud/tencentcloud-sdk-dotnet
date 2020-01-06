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

    public class CreateNetworkInterfaceRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。可通过DescribeVpcs接口返回值中的VpcId获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 弹性网卡名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// 弹性网卡所在的子网实例ID，例如：subnet-0ap8nwca。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 弹性网卡描述，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// 新申请的内网IP地址个数，内网IP地址个数总和不能超过配数。
        /// </summary>
        [JsonProperty("SecondaryPrivateIpAddressCount")]
        public ulong? SecondaryPrivateIpAddressCount{ get; set; }

        /// <summary>
        /// 指定绑定的安全组，例如：['sg-1dd51d']。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 指定的内网IP信息，单次最多指定10个。
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public PrivateIpAddressSpecification[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceDescription", this.NetworkInterfaceDescription);
            this.SetParamSimple(map, prefix + "SecondaryPrivateIpAddressCount", this.SecondaryPrivateIpAddressCount);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

