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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateDetail : AbstractModel
    {
        
        /// <summary>
        /// 证书ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 证书类型。
        /// </summary>
        [JsonProperty("CertificateType")]
        public long? CertificateType{ get; set; }

        /// <summary>
        /// 证书名字。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 证书内容。
        /// </summary>
        [JsonProperty("CertificateContent")]
        public string CertificateContent{ get; set; }

        /// <summary>
        /// 密钥内容。仅当证书类型为SSL证书时，返回该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificateKey")]
        public string CertificateKey{ get; set; }

        /// <summary>
        /// 创建时间，采用Unix时间戳的方式，表示从1970年1月1日（UTC/GMT的午夜）开始所经过的秒数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 证书生效起始时间，采用Unix时间戳的方式，表示从1970年1月1日（UTC/GMT的午夜）开始所经过的秒数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginTime")]
        public ulong? BeginTime{ get; set; }

        /// <summary>
        /// 证书过期时间，采用Unix时间戳的方式，表示从1970年1月1日（UTC/GMT的午夜）开始所经过的秒数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 证书签发者通用名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IssuerCN")]
        public string IssuerCN{ get; set; }

        /// <summary>
        /// 证书主题通用名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubjectCN")]
        public string SubjectCN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "CertificateContent", this.CertificateContent);
            this.SetParamSimple(map, prefix + "CertificateKey", this.CertificateKey);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IssuerCN", this.IssuerCN);
            this.SetParamSimple(map, prefix + "SubjectCN", this.SubjectCN);
        }
    }
}

