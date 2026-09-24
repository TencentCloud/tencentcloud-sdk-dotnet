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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceDomain : AbstractModel
    {
        
        /// <summary>
        /// <p>域名名称。</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>域名状态。</p><p>枚举值：</p><ul><li>Online： 已生效；</li><li>Process： 部署中；</li><li>Offline： 已停用；</li><li>Init： 未生效，待激活站点。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>推理任务请求鉴权开关。</p><p>枚举值：</p><ul><li>Off： 关闭鉴权；</li><li>On： 开启鉴权。</li></ul><p>默认值：On。</p>
        /// </summary>
        [JsonProperty("AuthSwitch")]
        public string AuthSwitch{ get; set; }

        /// <summary>
        /// <p>CNAME 地址。</p><p>校验域名 CNAME 配置状态，请参考<a href="https://cloud.tencent.com/document/api/1552/94491"> CheckCnameStatus </a>接口。</p>
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// <p>域名需进行归属权验证才能继续提供服务时，该对象会携带对应验证方式所需要的信息。</p><p>验证归属权，请参考<a href="https://cloud.tencent.com/document/api/1552/98879"> VerifyOwnership </a>接口。</p>
        /// </summary>
        [JsonProperty("OwnershipVerification")]
        public OwnershipVerification OwnershipVerification{ get; set; }

        /// <summary>
        /// <p>域名证书信息。</p><p>申请免费证书，请参考 <a href="https://cloud.tencent.com/document/api/1552/124807">ApplyFreeCertificate</a> 接口；<br>检查免费证书申请结果，请参考 <a href="https://cloud.tencent.com/document/api/1552/124806">CheckFreeCertificateVerification</a> 接口；<br>配置域名证书，请参考 <a href="https://cloud.tencent.com/document/api/1552/80764">ModifyHostsCertificate</a> 接口。</p>
        /// </summary>
        [JsonProperty("Certificate")]
        public HostsCertificate Certificate{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthSwitch", this.AuthSwitch);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamObj(map, prefix + "OwnershipVerification.", this.OwnershipVerification);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

