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

    public class DescribeSimpleNamespacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID列表，按照【命名空间ID列表】进行过滤，可通过调用[DescribeNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录控制台进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新的命名空间。
        /// </summary>
        [JsonProperty("NamespaceIdList")]
        public string[] NamespaceIdList{ get; set; }

        /// <summary>
        /// 集群ID，按照【集群ID】进行过滤，可通过调用[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已创建的集群列表或登录控制台进行查看；也可以调用[CreateCluster](https://cloud.tencent.com/document/product/649/36049)创建新的集群。仅在集群下无部署组、命名空间、云主机时可以删除。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 数量限制，默认为20，最大值为100。关于Limit详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset详见[API简介](https://cloud.tencent.com/document/api/213/568#.E8.BE.93.E5.85.A5.E5.8F.82.E6.95.B0.E4.B8.8E.E8.BF.94.E5.9B.9E.E5.8F.82.E6.95.B0.E9.87.8A.E4.B9.89)
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 命名空间ID，按照【命名空间ID】进行过滤，可通过调用[DescribeNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录控制台进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 查询资源类型列表；DEF 表示默认资源类型；GW 表示网关资源类型
        /// </summary>
        [JsonProperty("NamespaceResourceTypeList")]
        public string[] NamespaceResourceTypeList{ get; set; }

        /// <summary>
        /// 通过id和name进行过滤
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 查询的命名空间类型列表。DEF：默认普通命名空间。GLOBAL：全局命名空间。
        /// </summary>
        [JsonProperty("NamespaceTypeList")]
        public string[] NamespaceTypeList{ get; set; }

        /// <summary>
        /// 通过命名空间名精确过滤
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 通过是否是默认命名空间过滤，不传表示拉取全部命名空间。0：默认命名空间。1：非默认命名空间。
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }

        /// <summary>
        /// 是否关闭鉴权查询
        /// </summary>
        [JsonProperty("DisableProgramAuthCheck")]
        public bool? DisableProgramAuthCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NamespaceIdList.", this.NamespaceIdList);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamArraySimple(map, prefix + "NamespaceResourceTypeList.", this.NamespaceResourceTypeList);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "NamespaceTypeList.", this.NamespaceTypeList);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "DisableProgramAuthCheck", this.DisableProgramAuthCheck);
        }
    }
}

