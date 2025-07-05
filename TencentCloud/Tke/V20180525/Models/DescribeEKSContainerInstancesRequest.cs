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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEKSContainerInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 限定此次返回资源的数量。如果不设定，默认返回20，最大不能超过100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量,默认0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件，可条件：
        /// (1)实例名称
        /// KeyName: eks-ci-name
        /// 类型：String
        /// 
        /// (2)实例状态
        /// KeyName: status
        /// 类型：String
        /// 可选值："Pending", "Running", "Succeeded", "Failed"
        /// 
        /// (3)内网ip
        /// KeyName: private-ip
        /// 类型：String
        /// 
        /// (4)EIP地址
        /// KeyName: eip-address
        /// 类型：String
        /// 
        /// (5)VpcId
        /// KeyName: vpc-id
        /// 类型：String
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 容器实例 ID 数组
        /// </summary>
        [JsonProperty("EksCiIds")]
        public string[] EksCiIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "EksCiIds.", this.EksCiIds);
        }
    }
}

