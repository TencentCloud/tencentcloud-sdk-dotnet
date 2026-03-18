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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmailSmtpConfig : AbstractModel
    {
        
        /// <summary>
        /// 邮件发送者的邮箱地址，即收件人看到的发件人地址。需为有效的邮箱格式，且须与 SMTP 服务器的授权账号一致，否则可能被邮件服务商拒绝发送。例如：abc@example.com
        /// </summary>
        [JsonProperty("SenderAddress")]
        public string SenderAddress{ get; set; }

        /// <summary>
        /// SMTP 邮件服务器的域名或 IP 地址，用于建立邮件发送连接。不同邮件服务商的 SMTP 地址不同，例如 QQ 邮箱为 smtp.qq.com，Gmail 为 smtp.gmail.com，请以实际服务商提供的地址为准。
        /// </summary>
        [JsonProperty("ServerHost")]
        public string ServerHost{ get; set; }

        /// <summary>
        /// SMTP 邮件服务器的端口号，需与所选安全模式（SecurityMode）匹配。常用端口：465（SSL 加密）、587（STARTTLS 加密）、25（无加密，不推荐）。建议优先使用 465 或 587 以保障传输安全。
        /// </summary>
        [JsonProperty("ServerPort")]
        public ulong? ServerPort{ get; set; }

        /// <summary>
        /// SMTP 服务器的登录账号，通常为发件人的完整邮箱地址。部分邮件服务商支持使用独立的 SMTP 授权账号，请以实际服务商的要求为准。
        /// </summary>
        [JsonProperty("AccountUsername")]
        public string AccountUsername{ get; set; }

        /// <summary>
        /// SMTP 服务器的登录密码。注意：部分邮件服务商（如 QQ 邮箱、163 邮箱）不支持直接使用账号登录密码，需在邮箱设置中开启 SMTP 服务并生成专用的授权码，请以实际服务商的要求为准。
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// SMTP 连接的加密模式，用于保障邮件传输安全。可选值：AUTO（自动选择，优先使用安全连接）、SSL（全程 SSL/TLS 加密，通常配合端口 465 使用）、STARTSSL（通过 STARTTLS 命令升级为加密连接，通常配合端口 587 使用）、NO_SSL（不使用加密，仅建议在内网或测试环境中使用）。推荐使用 AUTO 或 SSL 以确保传输安全。
        /// </summary>
        [JsonProperty("SecurityMode")]
        public string SecurityMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SenderAddress", this.SenderAddress);
            this.SetParamSimple(map, prefix + "ServerHost", this.ServerHost);
            this.SetParamSimple(map, prefix + "ServerPort", this.ServerPort);
            this.SetParamSimple(map, prefix + "AccountUsername", this.AccountUsername);
            this.SetParamSimple(map, prefix + "AccountPassword", this.AccountPassword);
            this.SetParamSimple(map, prefix + "SecurityMode", this.SecurityMode);
        }
    }
}

