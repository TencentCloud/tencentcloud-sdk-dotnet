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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CredentialState : AbstractModel
    {
        
        /// <summary>
        /// 凭证唯一id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 凭证状态（0：吊销；1：有效）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 凭证颁发者Did
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// VC摘要，对应凭证Proof的vcDigest字段
        /// </summary>
        [JsonProperty("VCDigest")]
        public string VCDigest{ get; set; }

        /// <summary>
        /// 交易摘要，对应凭证Proof的txDigest字段 
        /// </summary>
        [JsonProperty("TXDigest")]
        public string TXDigest{ get; set; }

        /// <summary>
        /// 颁布凭证的UTC时间戳
        /// </summary>
        [JsonProperty("IssueTime")]
        public ulong? IssueTime{ get; set; }

        /// <summary>
        /// 凭证过期的UTC时间戳
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 凭证模板id
        /// </summary>
        [JsonProperty("CPTId")]
        public ulong? CPTId{ get; set; }

        /// <summary>
        /// 凭证签名
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }

        /// <summary>
        /// 元数据摘要
        /// </summary>
        [JsonProperty("MetaDigest")]
        public string MetaDigest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "VCDigest", this.VCDigest);
            this.SetParamSimple(map, prefix + "TXDigest", this.TXDigest);
            this.SetParamSimple(map, prefix + "IssueTime", this.IssueTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CPTId", this.CPTId);
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
            this.SetParamSimple(map, prefix + "MetaDigest", this.MetaDigest);
        }
    }
}

