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

    public class CertificateInfo : AbstractModel
    {
        
        /// <summary>
        /// 证书 ID。来源于 SSL 侧，您可以前往 [SSL 证书列表](https://console.cloud.tencent.com/ssl) 查看 CertId。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 证书备注名。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 证书类型，取值有：
        /// <li>default：默认证书；</li>
        /// <li>upload：用户上传；</li>
        /// <li>managed：腾讯云托管。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 证书过期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 证书部署时间。
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// 签名算法。
        /// </summary>
        [JsonProperty("SignAlgo")]
        public string SignAlgo{ get; set; }

        /// <summary>
        /// 证书状态，取值有：
        /// <li>deployed：已部署；</li>
        /// <li>processing：部署中；</li>
        /// <li>applying：申请中；</li>
        /// <li>failed：申请失败；</li>
        /// <li>issued：绑定失败。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "SignAlgo", this.SignAlgo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

