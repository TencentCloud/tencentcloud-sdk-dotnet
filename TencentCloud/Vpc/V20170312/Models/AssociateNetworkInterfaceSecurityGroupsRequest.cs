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

    public class AssociateNetworkInterfaceSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡实例ID。形如：eni-pxir56ns。每次请求的实例的上限为100。本接口不支持主网卡绑定安全组。可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/product/215/15817)接口获取。
        /// </summary>
        [JsonProperty("NetworkInterfaceIds")]
        public string[] NetworkInterfaceIds{ get; set; }

        /// <summary>
        /// 安全组实例ID，例如：sg-33ocnj9n，可通过DescribeSecurityGroups获取。每次请求的实例的上限为100。可通过[DescribeSecurityGroups](https://cloud.tencent.com/document/product/215/15808)接口获取。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetworkInterfaceIds.", this.NetworkInterfaceIds);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

