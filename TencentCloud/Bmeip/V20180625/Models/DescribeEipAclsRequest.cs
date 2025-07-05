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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEipAclsRequest : AbstractModel
    {
        
        /// <summary>
        /// ACL 名称，支持模糊查找
        /// </summary>
        [JsonProperty("AclName")]
        public string AclName{ get; set; }

        /// <summary>
        /// ACL 实例 ID 列表，数组下标从 0 开始
        /// </summary>
        [JsonProperty("AclIds")]
        public string[] AclIds{ get; set; }

        /// <summary>
        /// 分页参数。偏移量，默认为 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页参数。每一页的 EIPACL 列表数目
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// EIP实例ID列表
        /// </summary>
        [JsonProperty("EipIds")]
        public string[] EipIds{ get; set; }

        /// <summary>
        /// EIP IP地址列表
        /// </summary>
        [JsonProperty("EipIps")]
        public string[] EipIps{ get; set; }

        /// <summary>
        /// EIP名称列表
        /// </summary>
        [JsonProperty("EipNames")]
        public string[] EipNames{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方式，取值：0:增序(默认)，1:降序
        /// </summary>
        [JsonProperty("Order")]
        public ulong? Order{ get; set; }

        /// <summary>
        /// ACL名称列表，支持模糊查找
        /// </summary>
        [JsonProperty("AclNames")]
        public string[] AclNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AclName", this.AclName);
            this.SetParamArraySimple(map, prefix + "AclIds.", this.AclIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "EipIds.", this.EipIds);
            this.SetParamArraySimple(map, prefix + "EipIps.", this.EipIps);
            this.SetParamArraySimple(map, prefix + "EipNames.", this.EipNames);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "AclNames.", this.AclNames);
        }
    }
}

