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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterInfo : AbstractModel
    {
        
        /// <summary>
        /// <font color="red">字段不再使用</font>，法人姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 社会统一信用代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uscc")]
        [System.Obsolete]
        public string Uscc{ get; set; }

        /// <summary>
        /// <font color="red">字段不再使用</font>，社会统一信用代码
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCode")]
        public string UnifiedSocialCreditCode{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式 支持多选:
        /// 
        /// <ul>
        /// <li><strong>2</strong>: 法人授权方式</li>
        /// <li><strong>5</strong>: 授权书+对公打款方式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        [System.Obsolete]
        public ulong?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式 支持多选:
        /// 
        /// <ul>
        /// <li><strong>2</strong>: 法人授权方式</li>
        /// <li><strong>5</strong>: 授权书+对公打款方式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public long? AuthorizationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "Uscc", this.Uscc);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCode", this.UnifiedSocialCreditCode);
            this.SetParamArraySimple(map, prefix + "AuthorizationTypes.", this.AuthorizationTypes);
            this.SetParamSimple(map, prefix + "AuthorizationType", this.AuthorizationType);
        }
    }
}

