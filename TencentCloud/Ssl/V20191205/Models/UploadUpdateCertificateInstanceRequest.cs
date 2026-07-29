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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadUpdateCertificateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>一键更新的旧证书ID。 通过查询该证书ID绑定的云资源，然后使用新证书对这些云资源进行更新</p>
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// <p>需要部署的资源类型，参数值可选（小写）：clb</p>
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// <p>公钥证书</p>
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// <p>私钥证书</p>
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// <p>云资源需要部署的地域列表，支持地域的云资源类型必传，取值：clb</p>
        /// </summary>
        [JsonProperty("ResourceTypesRegions")]
        public ResourceTypeRegions[] ResourceTypesRegions{ get; set; }

        /// <summary>
        /// <p>证书ID</p>
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamArrayObj(map, prefix + "ResourceTypesRegions.", this.ResourceTypesRegions);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
        }
    }
}

