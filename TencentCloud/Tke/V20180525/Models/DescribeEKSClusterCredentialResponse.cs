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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEKSClusterCredentialResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群的接入地址信息
        /// </summary>
        [JsonProperty("Addresses")]
        public IPAddress[] Addresses{ get; set; }

        /// <summary>
        /// 集群的认证信息（token只有请求是主账号才返回，子账户请使用返回的kubeconfig）
        /// </summary>
        [JsonProperty("Credential")]
        public ClusterCredential Credential{ get; set; }

        /// <summary>
        /// 集群的公网访问信息
        /// </summary>
        [JsonProperty("PublicLB")]
        public ClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// 集群的内网访问信息
        /// </summary>
        [JsonProperty("InternalLB")]
        public ClusterInternalLB InternalLB{ get; set; }

        /// <summary>
        /// 标记是否新的内外网功能
        /// </summary>
        [JsonProperty("ProxyLB")]
        public bool? ProxyLB{ get; set; }

        /// <summary>
        /// 连接用户集群k8s 的Config
        /// </summary>
        [JsonProperty("Kubeconfig")]
        public string Kubeconfig{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Addresses.", this.Addresses);
            this.SetParamObj(map, prefix + "Credential.", this.Credential);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamObj(map, prefix + "InternalLB.", this.InternalLB);
            this.SetParamSimple(map, prefix + "ProxyLB", this.ProxyLB);
            this.SetParamSimple(map, prefix + "Kubeconfig", this.Kubeconfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

