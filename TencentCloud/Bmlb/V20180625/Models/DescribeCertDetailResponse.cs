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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 证书ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 证书名称。
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// 证书类型（SVR=服务器证书，CA=客户端证书）。
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// 证书内容。
        /// </summary>
        [JsonProperty("CertContent")]
        public string CertContent{ get; set; }

        /// <summary>
        /// 证书主域名。
        /// </summary>
        [JsonProperty("CertDomain")]
        public string CertDomain{ get; set; }

        /// <summary>
        /// 证书子域名列表。
        /// </summary>
        [JsonProperty("CertSubjectDomain")]
        public string[] CertSubjectDomain{ get; set; }

        /// <summary>
        /// 证书上传时间。
        /// </summary>
        [JsonProperty("CertUploadTime")]
        public string CertUploadTime{ get; set; }

        /// <summary>
        /// 证书生效时间。
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// 证书失效时间。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// 该证书关联的黑石负载均衡对象列表。
        /// </summary>
        [JsonProperty("CertLoadBalancerSet")]
        public CertDetailLoadBalancer[] CertLoadBalancerSet{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "CertContent", this.CertContent);
            this.SetParamSimple(map, prefix + "CertDomain", this.CertDomain);
            this.SetParamArraySimple(map, prefix + "CertSubjectDomain.", this.CertSubjectDomain);
            this.SetParamSimple(map, prefix + "CertUploadTime", this.CertUploadTime);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamArrayObj(map, prefix + "CertLoadBalancerSet.", this.CertLoadBalancerSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

