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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书 ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 验证类型：DNS_AUTO = 自动DNS验证（仅支持在腾讯云解析且解析状态正常的域名使用该验证类型），DNS = 手动DNS验证，FILE = 文件验证。
        /// </summary>
        [JsonProperty("ValidType")]
        public string ValidType{ get; set; }

        /// <summary>
        /// 类型，默认 Original。可选项：Original = 原证书 CSR，Upload = 手动上传，Online = 在线生成。
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// CSR 内容。
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// KEY 密码。
        /// </summary>
        [JsonProperty("CsrkeyPassword")]
        public string CsrkeyPassword{ get; set; }

        /// <summary>
        /// 重颁发原因。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ValidType", this.ValidType);
            this.SetParamSimple(map, prefix + "CsrType", this.CsrType);
            this.SetParamSimple(map, prefix + "CsrContent", this.CsrContent);
            this.SetParamSimple(map, prefix + "CsrkeyPassword", this.CsrkeyPassword);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

