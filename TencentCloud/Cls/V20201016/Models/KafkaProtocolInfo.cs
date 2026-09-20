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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaProtocolInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>协议类型，支持的协议类型包括 plaintext、sasl_plaintext 或 sasl_ssl。建议使用 sasl_ssl，此协议会进行连接加密同时需要用户认证。</p><ul><li>当IsEncryptionAddr为true时，Protocol必填。</li><li>支持的协议类型如下：<ul><li>plaintext：纯文本无加密协议</li><li>sasl_ssl：SASL 认证 + SSL 加密</li><li>ssl：纯 SSL/TLS 加密协议</li><li>sasl_plaintext：SASL 认证 + 非加密通道</li></ul></li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>加密类型，支持 PLAIN、SCRAM-SHA-256 或 SCRAM-SHA-512。</p><ul><li>当Protocol为  <code>sasl_plaintext</code> 或 <code>sasl_ssl</code> 时 Mechanism 必填。</li><li>支持加密类型如下<ul><li>PLAIN：明文认证</li><li>SCRAM-SHA-256：基于挑战-响应机制，使用PBKDF2-HMAC-SHA256算法</li><li>SCRAM-SHA-512：增强版SCRAM，使用PBKDF2-HMAC-SHA512算法</li></ul></li></ul>
        /// </summary>
        [JsonProperty("Mechanism")]
        public string Mechanism{ get; set; }

        /// <summary>
        /// <p>用户名。<br>当Protocol为sasl_plaintext或sasl_ssl时必填</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>用户密码。<br>当Protocol为sasl_plaintext或sasl_ssl时必填</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>是否开启客户端证书验证</p>
        /// </summary>
        [JsonProperty("EnableClientCertificate")]
        public ulong? EnableClientCertificate{ get; set; }

        /// <summary>
        /// <p>是否开启服务端证书验证</p>
        /// </summary>
        [JsonProperty("EnableServerCertificate")]
        public ulong? EnableServerCertificate{ get; set; }

        /// <summary>
        /// <p>云托管CA证书id</p>
        /// </summary>
        [JsonProperty("CACertificateId")]
        public string CACertificateId{ get; set; }

        /// <summary>
        /// <p>云托管服务端证书id</p>
        /// </summary>
        [JsonProperty("SVRCertificateId")]
        public string SVRCertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Mechanism", this.Mechanism);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "EnableClientCertificate", this.EnableClientCertificate);
            this.SetParamSimple(map, prefix + "EnableServerCertificate", this.EnableServerCertificate);
            this.SetParamSimple(map, prefix + "CACertificateId", this.CACertificateId);
            this.SetParamSimple(map, prefix + "SVRCertificateId", this.SVRCertificateId);
        }
    }
}

