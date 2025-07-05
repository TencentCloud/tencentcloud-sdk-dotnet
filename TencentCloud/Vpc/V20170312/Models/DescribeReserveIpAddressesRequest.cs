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

    public class DescribeReserveIpAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// 内网保留IP唯一ID 列表
        /// </summary>
        [JsonProperty("ReserveIpIds")]
        public string[] ReserveIpIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定ReserveIpIds和Filters。
        /// 
        /// reserve-ip-id  - String - （过滤条件）内网保留 IP唯一 ID，形如：rsvip-pvqgv9vi。
        /// vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。
        /// subnet-id - String - （过滤条件）所属子网实例ID，形如：subnet-f49l6u0z。
        /// address-ip - String - （过滤条件）内网保留 IP 地址，形如：192.168.0.10。
        /// ip-type - String - （过滤条件）业务类型 ipType，0。
        /// name - String - （过滤条件）名称。
        /// state - String - （过滤条件）状态，可选值：Bind， UnBind。
        /// resource-id - String - （过滤条件）绑定的实例资源，形如：eni-059qmnif。
        /// tag-key - String -（过滤条件）按照标签键进行过滤。
        /// tag:tag-key - String - （过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 请求对象个数。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ReserveIpIds.", this.ReserveIpIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

