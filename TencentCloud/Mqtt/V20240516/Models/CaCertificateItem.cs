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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CaCertificateItem : AbstractModel
    {
        
        /// <summary>
        /// 证书的公用名(Common Name)
        /// </summary>
        [JsonProperty("CaCn")]
        public string CaCn{ get; set; }

        /// <summary>
        /// 证书内容
        /// </summary>
        [JsonProperty("CaCertificate")]
        public string CaCertificate{ get; set; }

        /// <summary>
        /// 证书序列号
        /// </summary>
        [JsonProperty("CaSn")]
        public string CaSn{ get; set; }

        /// <summary>
        /// 证书格式，当前仅支持 PEM 格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 验证证书内容
        /// </summary>
        [JsonProperty("VerificationCertificate")]
        public string VerificationCertificate{ get; set; }

        /// <summary>
        /// CA证书的状态
        ///     ACTIVE：激活
        ///     INACTIVE：未激活
        ///     REVOKED：吊销
        ///     PENDING_ACTIVATION：注册待激活
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 上次激活时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("LastActivationTime")]
        public long? LastActivationTime{ get; set; }

        /// <summary>
        /// 创建时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 上次去激活时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("LastInactivationTime")]
        public long? LastInactivationTime{ get; set; }

        /// <summary>
        /// Ca证书颁发者CN
        /// </summary>
        [JsonProperty("CaIssuerCn")]
        public string CaIssuerCn{ get; set; }

        /// <summary>
        /// 生效时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("NotBeforeTime")]
        public long? NotBeforeTime{ get; set; }

        /// <summary>
        /// 失效时间，毫秒级时间戳 。
        /// </summary>
        [JsonProperty("NotAfterTime")]
        public long? NotAfterTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaCn", this.CaCn);
            this.SetParamSimple(map, prefix + "CaCertificate", this.CaCertificate);
            this.SetParamSimple(map, prefix + "CaSn", this.CaSn);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "VerificationCertificate", this.VerificationCertificate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastActivationTime", this.LastActivationTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastInactivationTime", this.LastInactivationTime);
            this.SetParamSimple(map, prefix + "CaIssuerCn", this.CaIssuerCn);
            this.SetParamSimple(map, prefix + "NotBeforeTime", this.NotBeforeTime);
            this.SetParamSimple(map, prefix + "NotAfterTime", this.NotAfterTime);
        }
    }
}

