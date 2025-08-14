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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索字段
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 应用ID。调用[DescribeApplications](https://cloud.tencent.com/document/api/649/36090)查询已创建的应用或通过[CreateApplication](https://cloud.tencent.com/document/api/649/36094)接口创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，0：升序，1：降序
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 偏移量，默认值：0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页个数，默认值：20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 命名空间ID。调用[DescribeSimpleNamespaces](https://cloud.tencent.com/document/api/649/36096)查询已创建的命名空间或通过[CreateNamespace](https://cloud.tencent.com/document/api/649/36098)接口创建新的集群。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 集群 ID。调用[DescribeSimpleClusters](https://cloud.tencent.com/document/api/649/36047)查询已创建的集群或通过[CreateCluster](https://cloud.tencent.com/document/api/649/36049)接口创建新的集群。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 部署组资源类型列表
        /// </summary>
        [JsonProperty("GroupResourceTypeList")]
        public string[] GroupResourceTypeList{ get; set; }

        /// <summary>
        /// 部署组状态过滤字段
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("GroupIdList")]
        public string[] GroupIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "GroupResourceTypeList.", this.GroupResourceTypeList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
        }
    }
}

