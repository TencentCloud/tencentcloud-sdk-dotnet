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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyFunctionArg : AbstractModel
    {
        
        /// <summary>
        /// CPT ID
        /// </summary>
        [JsonProperty("CptId")]
        public ulong? CptId{ get; set; }

        /// <summary>
        /// issuer did
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public long? ExpirationDate{ get; set; }

        /// <summary>
        /// 声明
        /// </summary>
        [JsonProperty("ClaimJson")]
        public string ClaimJson{ get; set; }

        /// <summary>
        /// 颁发时间
        /// </summary>
        [JsonProperty("IssuanceDate")]
        public long? IssuanceDate{ get; set; }

        /// <summary>
        /// context值
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// id值
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 签名值
        /// </summary>
        [JsonProperty("Proof")]
        public Proof Proof{ get; set; }

        /// <summary>
        /// type值
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CptId", this.CptId);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "ClaimJson", this.ClaimJson);
            this.SetParamSimple(map, prefix + "IssuanceDate", this.IssuanceDate);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Proof.", this.Proof);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
        }
    }
}

