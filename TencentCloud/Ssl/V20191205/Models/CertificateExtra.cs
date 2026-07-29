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

    public class CertificateExtra : AbstractModel
    {
        
        /// <summary>
        /// <p>证书可配置域名数量。</p>
        /// </summary>
        [JsonProperty("DomainNumber")]
        public string DomainNumber{ get; set; }

        /// <summary>
        /// <p>续费原证书 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginCertificateId")]
        public string OriginCertificateId{ get; set; }

        /// <summary>
        /// <p>重颁发证书原始 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplacedBy")]
        public string ReplacedBy{ get; set; }

        /// <summary>
        /// <p>重颁发证书ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplacedFor")]
        public string ReplacedFor{ get; set; }

        /// <summary>
        /// <p>续费证书 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewOrder")]
        public string RenewOrder{ get; set; }

        /// <summary>
        /// <p>是否是国密证书</p>
        /// </summary>
        [JsonProperty("SMCert")]
        public long? SMCert{ get; set; }

        /// <summary>
        /// <p>公司类型，取值：1（个人）；2（公司）</p>
        /// </summary>
        [JsonProperty("CompanyType")]
        public long? CompanyType{ get; set; }

        /// <summary>
        /// <p>下一张订阅服务续期证书ID</p>
        /// </summary>
        [JsonProperty("ServiceRenewCertificateId")]
        public string ServiceRenewCertificateId{ get; set; }

        /// <summary>
        /// <p>上一张订阅服务来源证书ID</p>
        /// </summary>
        [JsonProperty("ServiceOriginCertificateId")]
        public string ServiceOriginCertificateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainNumber", this.DomainNumber);
            this.SetParamSimple(map, prefix + "OriginCertificateId", this.OriginCertificateId);
            this.SetParamSimple(map, prefix + "ReplacedBy", this.ReplacedBy);
            this.SetParamSimple(map, prefix + "ReplacedFor", this.ReplacedFor);
            this.SetParamSimple(map, prefix + "RenewOrder", this.RenewOrder);
            this.SetParamSimple(map, prefix + "SMCert", this.SMCert);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "ServiceRenewCertificateId", this.ServiceRenewCertificateId);
            this.SetParamSimple(map, prefix + "ServiceOriginCertificateId", this.ServiceOriginCertificateId);
        }
    }
}

