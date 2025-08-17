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

    public class CreateGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组所属的【应用ID】，可通过调用[DescribeApplications](https://cloud.tencent.com/document/product/649/36090)查询已创建的应用列表或登录[控制台](https://console.cloud.tencent.com/tsf/app?rid=1)进行查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/product/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 部署组所属【命名空间ID】，可通过调用[DescribeSimpleNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=namespace)进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新的命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 部署组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 部署组所属的【集群ID】，可通过调用[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已创建的集群列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=docker)进行查看；也可以调用[CreateCluster](https://cloud.tencent.com/document/product/649/36049)创建新的集群。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 部署组描述
        /// </summary>
        [JsonProperty("GroupDesc")]
        public string GroupDesc{ get; set; }

        /// <summary>
        /// 部署组资源类型；DEF 表示默认资源类型
        /// </summary>
        [JsonProperty("GroupResourceType")]
        public string GroupResourceType{ get; set; }

        /// <summary>
        /// 部署组备注
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// k8s命名空间名称
        /// </summary>
        [JsonProperty("K8sNamespaceName")]
        public string K8sNamespaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupDesc", this.GroupDesc);
            this.SetParamSimple(map, prefix + "GroupResourceType", this.GroupResourceType);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "K8sNamespaceName", this.K8sNamespaceName);
        }
    }
}

