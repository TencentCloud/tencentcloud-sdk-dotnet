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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSimpleNamespacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID列表，不传入时查询全量
        /// </summary>
        [JsonProperty("NamespaceIdList")]
        public string[] NamespaceIdList{ get; set; }

        /// <summary>
        /// 集群ID，不传入时查询全量
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 起始偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 命名空间ID，不传入时查询全量
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 查询资源类型列表
        /// </summary>
        [JsonProperty("NamespaceResourceTypeList")]
        public string[] NamespaceResourceTypeList{ get; set; }

        /// <summary>
        /// 通过id和name进行过滤
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// 查询的命名空间类型列表
        /// </summary>
        [JsonProperty("NamespaceTypeList")]
        public string[] NamespaceTypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NamespaceIdList.", this.NamespaceIdList);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamArraySimple(map, prefix + "NamespaceResourceTypeList.", this.NamespaceResourceTypeList);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "NamespaceTypeList.", this.NamespaceTypeList);
        }
    }
}

