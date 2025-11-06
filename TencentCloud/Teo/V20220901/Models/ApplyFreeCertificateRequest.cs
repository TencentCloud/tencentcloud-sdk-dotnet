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

    public class ApplyFreeCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 申请免费证书的目标域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 申请免费证书时验证方式，详细验证方式说明参考[免费证书申请方式说明文档](https://cloud.tencent.com/document/product/1552/90437) ，相关取值有：
        /// <li>http_challenge：HTTP 访问文件验证方式，通过 HTTP 访问域名指定 URL 获取文件信息以完成免费证书申请验证；</li>
        /// <li>dns_challenge：DNS 委派验证方式，通过添加指定的主机记录解析指向 EdgeOne 以完成免费证书申请验证。</li>
        /// 注意：在触发本接口后，你需要根据返回的验证信息，完成验证内容配置。配置完成后，还需要通过<a href = 'https://tcloud4api.woa.com/document/product/1657/927938?!preview&!document=1'>检查免费证书申请结果</a>接口进行验证，验证通过后，即可申请成功。在免费证书申请成功后，你可以调用<a href = 'https://cloud.tencent.com/document/product/1552/80764'>配置域名证书</a>接口为当前域名部署免费证书。
        /// </summary>
        [JsonProperty("VerificationMethod")]
        public string VerificationMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerificationMethod", this.VerificationMethod);
        }
    }
}

