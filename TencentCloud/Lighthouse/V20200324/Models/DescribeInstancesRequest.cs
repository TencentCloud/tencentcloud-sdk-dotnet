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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID 列表。每次请求批量实例的上限为 100。可通过[DescribeInstances](https://cloud.tencent.com/document/api/1207/47573)接口返回值中的InstanceId获取。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 过滤器列表。
        /// <li>instance-name</li>按照【实例名称】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>private-ip-address</li>按照【实例主网卡的内网 IP】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>public-ip-address</li>按照【实例主网卡的公网 IP】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>zone</li>按照【可用区】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>instance-state</li>按照【实例状态】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>tag-key</li>按照【标签键】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>tag-value</li>按照【标签值】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li> tag:tag-key</li>按照【标签键值对】进行过滤。 tag-key使用具体的标签键进行替换。
        /// 类型：String
        /// 必选：否
        /// <li>bundle-id</li>按照【套餐 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// 每次请求的 Filters 的上限为 10，Filter.Values 的上限为 100。参数不支持同时指定 InstanceIds 和 Filters。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 指定排序字段 。取值范围： "EXPIRED_TIME"：依据实例的到期时间排序。 
        ///  不传入此字段时, 优先返回实例状态为“待回收”的实例, 其余实例以“创建时间”倒序返回。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 输出实例列表的排列顺序。取值范围：
        /// "ASC"：升序排列。
        /// "DESC"：降序排列。
        /// 默认按升序排序。当传入该字段时，必须指定OrderField。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

