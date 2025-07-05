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

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Subnet : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网实例ID，例如：subnet-bthucmmy。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名称。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 子网的 IPv4 CIDR。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 可用IP数。
        /// </summary>
        [JsonProperty("AvailableIpAddressCount")]
        public long? AvailableIpAddressCount{ get; set; }

        /// <summary>
        /// 子网的 IPv6 CIDR。
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// 总IP数
        /// </summary>
        [JsonProperty("TotalIpAddressCount")]
        public long? TotalIpAddressCount{ get; set; }

        /// <summary>
        /// 是否为默认Subnet
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "AvailableIpAddressCount", this.AvailableIpAddressCount);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "TotalIpAddressCount", this.TotalIpAddressCount);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

