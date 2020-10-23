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

    public class CreateNamespaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 命名空间描述
        /// </summary>
        [JsonProperty("NamespaceDesc")]
        public string NamespaceDesc{ get; set; }

        /// <summary>
        /// 命名空间资源类型(默认值为DEF)
        /// </summary>
        [JsonProperty("NamespaceResourceType")]
        public string NamespaceResourceType{ get; set; }

        /// <summary>
        /// 是否是全局命名空间(默认是DEF，表示普通命名空间；GLOBAL表示全局命名空间)
        /// </summary>
        [JsonProperty("NamespaceType")]
        public string NamespaceType{ get; set; }

        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 是否开启高可用
        /// </summary>
        [JsonProperty("IsHaEnable")]
        public string IsHaEnable{ get; set; }


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
        }
    }
}

