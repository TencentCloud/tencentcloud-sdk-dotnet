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

    public class DescribeVpcsRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。形如：vpc-f49l6u0z。每次请求的实例的上限为100。参数不支持同时指定VpcIds和Filters。
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定VpcIds和Filters。
        /// vpc-name - String - VPC实例名称，只支持单值的模糊查询。
        /// vpc-id - String - VPC实例ID形如：vpc-f49l6u0z。
        /// cidr-block - String - vpc的cidr，只支持单值的模糊查询。
        /// region - String - vpc的region。
        /// tag-key - String -是否必填：否- 按照标签键进行过滤。
        /// tag:tag-key - String - 是否必填：否 - 按照标签键值对进行过滤。
        /// ipv6-cidr-block - String - 是否必填：否 - 按照IPv6 CIDR block进行过滤。
        /// isp-type - String - 是否必填：否 - 按照运营商（如CMCC, CUCC, CTCC）进行过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 地域
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
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
        }
    }
}

