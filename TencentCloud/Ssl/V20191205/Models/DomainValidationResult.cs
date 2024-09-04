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

    public class DomainValidationResult : AbstractModel
    {
        
        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 验证类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 本地检查结果。
        /// </summary>
        [JsonProperty("LocalCheck")]
        public long? LocalCheck{ get; set; }

        /// <summary>
        /// CA检查结果。
        /// </summary>
        [JsonProperty("CaCheck")]
        public long? CaCheck{ get; set; }

        /// <summary>
        /// 检查失败原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalCheckFailReason")]
        public string LocalCheckFailReason{ get; set; }

        /// <summary>
        /// 检查到的值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckValue")]
        public string[] CheckValue{ get; set; }

        /// <summary>
        /// 是否频繁请求。
        /// </summary>
        [JsonProperty("Frequently")]
        public bool? Frequently{ get; set; }

        /// <summary>
        /// 是否已经签发。
        /// </summary>
        [JsonProperty("Issued")]
        public bool? Issued{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "LocalCheck", this.LocalCheck);
            this.SetParamSimple(map, prefix + "CaCheck", this.CaCheck);
            this.SetParamSimple(map, prefix + "LocalCheckFailReason", this.LocalCheckFailReason);
            this.SetParamArraySimple(map, prefix + "CheckValue.", this.CheckValue);
            this.SetParamSimple(map, prefix + "Frequently", this.Frequently);
            this.SetParamSimple(map, prefix + "Issued", this.Issued);
        }
    }
}

