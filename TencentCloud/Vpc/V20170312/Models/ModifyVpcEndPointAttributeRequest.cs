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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVpcEndPointAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 终端节点ID。可通过[DescribeVpcEndPoint](https://cloud.tencent.com/document/product/215/54679) 获取。
        /// </summary>
        [JsonProperty("EndPointId")]
        public string EndPointId{ get; set; }

        /// <summary>
        /// 终端节点名称。长度限制为60个字符。
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// 安全组ID列表。可通过[DescribeSecurityGroups](https://cloud.tencent.com/document/product/215/15808)接口获取。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

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
            this.SetParamSimple(map, prefix + "EndPointId", this.EndPointId);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "IpAddressType", this.IpAddressType);
        }
    }
}

