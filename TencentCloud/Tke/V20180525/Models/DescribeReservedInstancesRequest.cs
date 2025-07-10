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

    public class DescribeReservedInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量，默认0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// status
        /// 按照**【状态**】进行过滤。状态：Creating：创建中、Active：生效中、Expired：已过期、Refunded：已退还。
        /// 类型：String
        /// 必选：否
        /// 
        /// resource-type
        /// 按照**【资源类型**】进行过滤。资源类型：common、amd、v100、t4、a10\*gnv4、a10\*gnv4v等，common表示通用类型。
        /// 类型：String
        /// 必选：否
        /// 
        /// cpu
        /// 按照**【核数**】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// memory
        /// 按照**【内存**】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// gpu
        /// 按照**【GPU卡数**】进行过滤，取值有0.25、0.5、1、2、4等。
        /// 类型：String
        /// 必选：否
        /// 
        /// cluster-id
        /// 按照**【集群ID**】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// node-name
        /// 按照**【节点名称**】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// scope
        /// 按照**【可用区**】进行过滤。比如：ap-guangzhou-2，为空字符串表示地域抵扣范围。如果只过滤可用区抵扣范围，需要同时将cluster-id、node-name设置为空字符串。
        /// 类型：String
        /// 必选：否
        /// 
        /// reserved-instance-id
        /// 按照**【预留实例ID**】进行过滤。预留实例ID形如：eksri-xxxxxxxx。
        /// 类型：String
        /// 必选：否
        /// 
        /// reserved-instance-name
        /// 按照**【预留实例名称**】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// reserved-instance-deduct
        /// 按照**【上个周期抵扣的预留券**】进行过滤。Values可不设置。
        /// 必选：否
        /// 
        /// reserved-instance-not-deduct
        /// 按照**【上个周期未抵扣的预留券**】进行过滤。Values可不设置。
        /// 必选：否
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段。支持CreatedAt、ActiveAt、ExpireAt。默认值CreatedAt。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方法。顺序：ASC，倒序：DESC。默认值DESC。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

