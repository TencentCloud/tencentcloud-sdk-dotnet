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

    public class Namespace : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 命名空间编码
        /// </summary>
        [JsonProperty("NamespaceCode")]
        public string NamespaceCode{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 命名空间描述
        /// </summary>
        [JsonProperty("NamespaceDesc")]
        public string NamespaceDesc{ get; set; }

        /// <summary>
        /// 默认命名空间
        /// </summary>
        [JsonProperty("IsDefault")]
        public string IsDefault{ get; set; }

        /// <summary>
        /// 命名空间状态
        /// </summary>
        [JsonProperty("NamespaceStatus")]
        public string NamespaceStatus{ get; set; }

        /// <summary>
        /// 删除标识
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 集群数组，仅携带集群ID，集群名称，集群类型等基础信息。
        /// </summary>
        [JsonProperty("ClusterList")]
        public Cluster[] ClusterList{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群资源类型
        /// </summary>
        [JsonProperty("NamespaceResourceType")]
        public string NamespaceResourceType{ get; set; }

        /// <summary>
        /// 命名空间类型
        /// </summary>
        [JsonProperty("NamespaceType")]
        public string NamespaceType{ get; set; }

        /// <summary>
        /// 是否开启高可用
        /// </summary>
        [JsonProperty("IsHaEnable")]
        public string IsHaEnable{ get; set; }

        /// <summary>
        /// KubeInjectEnable值
        /// </summary>
        [JsonProperty("KubeInjectEnable")]
        public bool? KubeInjectEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "NamespaceCode", this.NamespaceCode);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "NamespaceDesc", this.NamespaceDesc);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "NamespaceStatus", this.NamespaceStatus);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "ClusterList.", this.ClusterList);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NamespaceResourceType", this.NamespaceResourceType);
            this.SetParamSimple(map, prefix + "NamespaceType", this.NamespaceType);
            this.SetParamSimple(map, prefix + "IsHaEnable", this.IsHaEnable);
            this.SetParamSimple(map, prefix + "KubeInjectEnable", this.KubeInjectEnable);
        }
    }
}

