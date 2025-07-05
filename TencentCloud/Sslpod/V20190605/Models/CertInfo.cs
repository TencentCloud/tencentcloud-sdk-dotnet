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

namespace TencentCloud.Sslpod.V20190605.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertInfo : AbstractModel
    {
        
        /// <summary>
        /// 证书sha1
        /// </summary>
        [JsonProperty("Hash")]
        public string Hash{ get; set; }

        /// <summary>
        /// 证书通用名称
        /// </summary>
        [JsonProperty("CN")]
        public string CN{ get; set; }

        /// <summary>
        /// 备用名称
        /// </summary>
        [JsonProperty("SANs")]
        public string SANs{ get; set; }

        /// <summary>
        /// 公钥算法
        /// </summary>
        [JsonProperty("KeyAlgo")]
        public string KeyAlgo{ get; set; }

        /// <summary>
        /// 颁发者
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 有效期开始
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 有效期结束
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 剩余天数
        /// </summary>
        [JsonProperty("Days")]
        public long? Days{ get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 信任状态
        /// </summary>
        [JsonProperty("TrustStatus")]
        public string TrustStatus{ get; set; }

        /// <summary>
        /// 证书类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hash", this.Hash);
            this.SetParamSimple(map, prefix + "CN", this.CN);
            this.SetParamSimple(map, prefix + "SANs", this.SANs);
            this.SetParamSimple(map, prefix + "KeyAlgo", this.KeyAlgo);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Days", this.Days);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "TrustStatus", this.TrustStatus);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
        }
    }
}

