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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubnetsRequest : AbstractModel
    {
        
        /// <summary>
        /// 子网实例ID查询。形如：subnet-pxir56ns。每次请求的实例的上限为100。参数不支持同时指定SubnetIds和Filters。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定SubnetIds和Filters。
        /// subnet-id - String - Subnet实例名称。
        /// subnet-name - String - 子网名称。只支持单值的模糊查询。
        /// cidr-block - String - 子网网段，形如: 192.168.1.0 。只支持单值的模糊查询。
        /// vpc-id - String - VPC实例ID，形如：vpc-f49l6u0z。
        /// vpc-cidr-block  - String - vpc网段，形如: 192.168.1.0 。只支持单值的模糊查询。
        /// region - String - ECM地域
        /// zone - String - 可用区。
        /// tag-key - String -是否必填：否- 按照标签键进行过滤。
        /// ipv6-cidr-block- String - 是否必填：否 - 按照IPv6 CIDR进行过滤。
        /// isp-type - String - 是否必填：否 - 按照运营商类型( 如CMCC，CUCC， CTCC)进行过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// ECM 地域
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 排序方式：time时间倒序, default按照网络规划排序
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
        }
    }
}

