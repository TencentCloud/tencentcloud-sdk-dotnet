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

    public class AssociateConfigWithGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置项ID
        /// 可通过调用[DescribeBusinessLogConfigs](https://cloud.tencent.com/document/product/649/75777)查询已创建的日志配置项列表或登录[控制台](https://console.cloud.tencent.com/tsf/observable/log?rid=1)进行查看
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 部署组信息
        /// </summary>
        [JsonProperty("Groups")]
        public GroupInfo[] Groups{ get; set; }

        /// <summary>
        /// 是否选择全部投递，1 表示全部，0或不填表示非全部
        /// </summary>
        [JsonProperty("SelectAll")]
        public long? SelectAll{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// 可通过[DescribeSimpleNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已经创建的命名空间，也可以通过登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=namespace)查看
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 集群ID
        /// 可通过[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已经创建的集群列表，也可以通过登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1)查看
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 模糊搜索关键词
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "SelectAll", this.SelectAll);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
        }
    }
}

