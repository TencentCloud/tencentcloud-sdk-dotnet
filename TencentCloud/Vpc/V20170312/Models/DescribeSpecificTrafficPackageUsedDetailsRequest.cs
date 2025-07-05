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

    public class DescribeSpecificTrafficPackageUsedDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// 共享流量包唯一ID。可以使用[DescribeTrafficPackages](https://cloud.tencent.com/document/product/215/80090?locationSource=from%3Ddoc-search%26scope%3Dcurrent%26keyword%3D%E6%B5%81%E9%87%8F%E5%8C%85)接口获取TrafficPackageId。
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。详细的过滤条件如下：<ul style="margin:0"><li> resource-type - String - 是否必填：否 - （过滤条件）按照资源类型过滤，资源类型包括 EIP、BWP、LB。 </li>
        /// <li> resource-id - String - 是否必填：否 - （过滤条件）按照抵扣流量资源的唯一 ID 过滤。以下补充资源ID获取方式：<ul><li>EIP：可以使用[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取资源ID。</li>
        /// <li>BWP：可以使用[DescribeBandwidthPackages](https://cloud.tencent.com/document/product/215/19209)接口获取资源ID。</li>
        /// <li>LB：可以使用[DescribeLoadBalancers](https://cloud.tencent.com/document/product/214/30685)接口获取资源ID。</li></ul></li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序条件。该参数仅支持根据抵扣量排序，传值为 deduction
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序类型，仅支持0和1，0-降序，1-升序。不传默认为0
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 开始时间。待查询的共享流量包用量开始时间。不传默认为当前时间往前推30天。
        /// 时间格式：YYYY-MM-DD hh:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。待查询的共享流量包用量结束时间。不传默认为当前时间。
        /// 时间格式：YYYY-MM-DD hh:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API 中的相关小节
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20。关于Limit的更进一步介绍请参考 API 中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

