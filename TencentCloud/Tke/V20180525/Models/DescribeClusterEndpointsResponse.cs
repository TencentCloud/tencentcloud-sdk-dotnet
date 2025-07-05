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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterEndpointsResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群APIServer的CA证书
        /// </summary>
        [JsonProperty("CertificationAuthority")]
        public string CertificationAuthority{ get; set; }

        /// <summary>
        /// 集群APIServer的外网访问地址
        /// </summary>
        [JsonProperty("ClusterExternalEndpoint")]
        public string ClusterExternalEndpoint{ get; set; }

        /// <summary>
        /// 集群APIServer的内网访问地址
        /// </summary>
        [JsonProperty("ClusterIntranetEndpoint")]
        public string ClusterIntranetEndpoint{ get; set; }

        /// <summary>
        /// 集群APIServer的域名
        /// </summary>
        [JsonProperty("ClusterDomain")]
        public string ClusterDomain{ get; set; }

        /// <summary>
        /// 集群APIServer的外网访问ACL列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterExternalACL")]
        public string[] ClusterExternalACL{ get; set; }

        /// <summary>
        /// 外网域名
        /// </summary>
        [JsonProperty("ClusterExternalDomain")]
        public string ClusterExternalDomain{ get; set; }

        /// <summary>
        /// 内网域名
        /// </summary>
        [JsonProperty("ClusterIntranetDomain")]
        public string ClusterIntranetDomain{ get; set; }

        /// <summary>
        /// 外网安全组
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// 内网访问所属子网
        /// </summary>
        [JsonProperty("ClusterIntranetSubnetId")]
        public string ClusterIntranetSubnetId{ get; set; }

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
            this.SetParamSimple(map, prefix + "CertificationAuthority", this.CertificationAuthority);
            this.SetParamSimple(map, prefix + "ClusterExternalEndpoint", this.ClusterExternalEndpoint);
            this.SetParamSimple(map, prefix + "ClusterIntranetEndpoint", this.ClusterIntranetEndpoint);
            this.SetParamSimple(map, prefix + "ClusterDomain", this.ClusterDomain);
            this.SetParamArraySimple(map, prefix + "ClusterExternalACL.", this.ClusterExternalACL);
            this.SetParamSimple(map, prefix + "ClusterExternalDomain", this.ClusterExternalDomain);
            this.SetParamSimple(map, prefix + "ClusterIntranetDomain", this.ClusterIntranetDomain);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ClusterIntranetSubnetId", this.ClusterIntranetSubnetId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

