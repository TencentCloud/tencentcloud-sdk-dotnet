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

    public class CreateNamespaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 集群ID，按照【集群ID】进行过滤，可通过调用[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已创建的集群列表或登录控制台进行查看；也可以调用[CreateCluster](https://cloud.tencent.com/document/product/649/36049)创建新的集群。仅在集群下无部署组、命名空间、云主机时可以删除。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 命名空间描述
        /// </summary>
        [JsonProperty("NamespaceDesc")]
        public string NamespaceDesc{ get; set; }

        /// <summary>
        /// 命名空间资源类型；DEF：表示默认资源类型；GW：表示网关资源类型
        /// </summary>
        [JsonProperty("NamespaceResourceType")]
        public string NamespaceResourceType{ get; set; }

        /// <summary>
        /// 命名空间类型；DEF 表示默认普通命名空间；GLOBAL 表示全局命名空间
        /// </summary>
        [JsonProperty("NamespaceType")]
        public string NamespaceType{ get; set; }

        /// <summary>
        /// 命名空间ID，按照【命名空间ID】进行过滤，可通过调用[DescribeNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录控制台进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 是否开启高可用，1 表示开启，0 表示不开启
        /// </summary>
        [JsonProperty("IsHaEnable")]
        public string IsHaEnable{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID，可通过调用[DescribePrograms](https://cloud.tencent.com/document/api/649/73477)查询已创建的数据集列表或登录控制台进行查看；也可以调用[CreateProgram](https://cloud.tencent.com/document/api/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID列表，可通过调用[DescribePrograms](https://cloud.tencent.com/document/api/649/73477)查询已创建的数据集列表或登录控制台进行查看；也可以调用[CreateProgram](https://cloud.tencent.com/document/api/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }

        /// <summary>
        /// 是否创建k8s命名空间标识
        /// </summary>
        [JsonProperty("CreateK8sNamespaceFlag")]
        public bool? CreateK8sNamespaceFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NamespaceDesc", this.NamespaceDesc);
            this.SetParamSimple(map, prefix + "NamespaceResourceType", this.NamespaceResourceType);
            this.SetParamSimple(map, prefix + "NamespaceType", this.NamespaceType);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "IsHaEnable", this.IsHaEnable);
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
            this.SetParamSimple(map, prefix + "CreateK8sNamespaceFlag", this.CreateK8sNamespaceFlag);
        }
    }
}

