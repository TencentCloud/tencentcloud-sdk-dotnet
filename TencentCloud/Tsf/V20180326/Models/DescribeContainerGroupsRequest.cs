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

    public class DescribeContainerGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分组所属【应用ID】，可通过调用<a href="https://cloud.tencent.com/document/product/649/36090">DescribeApplications</a>查询已创建的应用列表或登录<a href="https://console.cloud.tencent.com/tsf/app?rid=1">控制台</a>进行查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/36094">CreateApplication</a>创建新的应用。</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>搜索字段，模糊搜索groupName字段</p>
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// <p>排序字段，默认为 createTime字段，支持id， name， createTime</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>排序方式，默认为1：倒序排序，0：正序，1：倒序</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// <p>偏移量，取值从0开始</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>分页个数，默认为20， 取值应为1~50</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分组所属【集群ID】，可通过调用<a href="https://cloud.tencent.com/document/product/649/85857">DescribeClusters</a>查询已创建的集群列表或登录<a href="https://console.cloud.tencent.com/tsf/resource?rid=1&amp;tab=docker">控制台</a>进行查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/36049">CreateCluster</a>创建新的集群。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>分组所属【命名空间 ID】，可通过调用<a href="https://cloud.tencent.com/document/product/649/36096">DescribeSimpleNamespaces</a>查询已创建的命名空间列表或登录<a href="https://console.cloud.tencent.com/tsf/resource?rid=1&amp;tab=namespace">控制台</a>进行查看；也可以调用<a href="https://cloud.tencent.com/document/product/649/36098">CreateNamespace</a>创建新的命名空间。</p>
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// <p>部署组ID列表</p>
        /// </summary>
        [JsonProperty("GroupIdList")]
        public string[] GroupIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
        }
    }
}

