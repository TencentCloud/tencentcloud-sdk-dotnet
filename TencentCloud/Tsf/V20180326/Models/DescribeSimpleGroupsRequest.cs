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

    public class DescribeSimpleGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照【部署组ID】进行过滤，不填写时查询全量。可通过调用[DescribeContainerGroups](https://cloud.tencent.com/document/product/649/36068)查询已创建的部署组列表或登录[控制台](https://console.cloud.tencent.com/tsf/app-detail?rid=1&id=application-zvw6zp9a&tab=publish&subTab=group)进行查看；也可以调用[CreateGroup](https://cloud.tencent.com/document/product/649/36074)创建新的部署组。
        /// </summary>
        [JsonProperty("GroupIdList")]
        public string[] GroupIdList{ get; set; }

        /// <summary>
        /// 按照【应用ID】进行过滤，不填写时查询全量。可通过调用[DescribeApplications](https://cloud.tencent.com/document/product/649/36090)查询已创建的应用列表或登录[控制台](https://console.cloud.tencent.com/tsf/app?rid=1)进行查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/product/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 按照【集群ID】进行过滤，不填写时查询全量。可通过调用[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已创建的集群列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=docker)进行查看；也可以调用[CreateCluster](https://cloud.tencent.com/document/product/649/36049)创建新的集群。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 按照【命名空间ID】进行过滤，不填写时查询全量。可通过调用[DescribeSimpleNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=namespace)进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新的命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 每页条数，默认值20，无上限
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 起始偏移量，默认值0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 部署组ID，不填写时查询全量
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 模糊查询，部署组名称，不填写时查询全量
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 部署组类型，精确过滤字段，M：service mesh, P：原生应用， G：网关应用
        /// </summary>
        [JsonProperty("AppMicroServiceType")]
        public string AppMicroServiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "GroupIdList.", this.GroupIdList);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamSimple(map, prefix + "AppMicroServiceType", this.AppMicroServiceType);
        }
    }
}

