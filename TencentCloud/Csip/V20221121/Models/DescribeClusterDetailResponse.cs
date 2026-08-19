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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>集群基础信息</p>
        /// </summary>
        [JsonProperty("ClusterBaseInfo")]
        public ClusterListItem ClusterBaseInfo{ get; set; }

        /// <summary>
        /// <p>运行时组件</p>
        /// </summary>
        [JsonProperty("RuntimeComponent")]
        public string RuntimeComponent{ get; set; }

        /// <summary>
        /// <p>master ip</p>
        /// </summary>
        [JsonProperty("MasterIP")]
        public string MasterIP{ get; set; }

        /// <summary>
        /// <p>节点数</p>
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// <p>命名空间数</p>
        /// </summary>
        [JsonProperty("NamespaceCount")]
        public ulong? NamespaceCount{ get; set; }

        /// <summary>
        /// <p>pod数</p>
        /// </summary>
        [JsonProperty("PodCount")]
        public ulong? PodCount{ get; set; }

        /// <summary>
        /// <p>容器数</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>service数</p>
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// <p>ingress数</p>
        /// </summary>
        [JsonProperty("IngressCount")]
        public ulong? IngressCount{ get; set; }

        /// <summary>
        /// <p>镜像数</p>
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// <p>系统组件数量</p>
        /// </summary>
        [JsonProperty("SystemComponentCount")]
        public ulong? SystemComponentCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClusterBaseInfo.", this.ClusterBaseInfo);
            this.SetParamSimple(map, prefix + "RuntimeComponent", this.RuntimeComponent);
            this.SetParamSimple(map, prefix + "MasterIP", this.MasterIP);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "NamespaceCount", this.NamespaceCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "IngressCount", this.IngressCount);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "SystemComponentCount", this.SystemComponentCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

