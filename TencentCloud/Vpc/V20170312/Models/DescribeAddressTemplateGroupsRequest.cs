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

    public class DescribeAddressTemplateGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>address-template-group-name - String - （过滤条件）IP地址模板集合名称。</li>
        /// <li>address-template-group-id - String - （过滤条件）IP地址模板实集合例ID，例如：ipmg-mdunqeb6。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// 是否查询IP地址模板成员标识。
        /// </summary>
        [JsonProperty("NeedMemberInfo")]
        public bool? NeedMemberInfo{ get; set; }

        /// <summary>
        /// 排序字段。支持：`AddressTemplateGroupId ` `CreatedTime` `UpdateTime`。注意：该字段没有默认值。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方法。升序：`ASC`，倒序：`DESC`。注意：该字段没有默认值。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// IP地址成员排序字段。支持：`AddressTemplateId` `UpdateTime`。注意：该字段没有默认值。
        /// </summary>
        [JsonProperty("MemberOrderField")]
        public string MemberOrderField{ get; set; }

        /// <summary>
        /// IP地址成员排序方法。升序：`ASC`，倒序：`DESC`。注意：该字段没有默认值。
        /// </summary>
        [JsonProperty("MemberOrderDirection")]
        public string MemberOrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NeedMemberInfo", this.NeedMemberInfo);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "MemberOrderField", this.MemberOrderField);
            this.SetParamSimple(map, prefix + "MemberOrderDirection", this.MemberOrderDirection);
        }
    }
}

