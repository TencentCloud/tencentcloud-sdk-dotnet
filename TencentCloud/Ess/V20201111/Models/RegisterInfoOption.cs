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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterInfoOption : AbstractModel
    {
        
        /// <summary>
        /// 是否允许编辑企业注册时的法人姓名。
        /// <br/>true：允许编辑<br/>false：不允许编辑（默认值）<br/>
        /// 
        /// 注意：
        /// RegisterInfo 中的LegalName值不为空的时候，才可设置为不可编辑。
        /// </summary>
        [JsonProperty("LegalNameSame")]
        public bool? LegalNameSame{ get; set; }

        /// <summary>
        /// 是否允许编辑企业注册时统一社会信用代码。
        /// <br/>true:不允许编辑。
        /// <br/>false:允许编辑（默认值）。
        /// <br/>
        /// 
        /// 
        /// 注意：
        /// RegisterInfo 中的UnifiedSocialCreditCode值不为空的时候，才可设置为不可编辑。
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCodeCNameSame")]
        public bool? UnifiedSocialCreditCodeCNameSame{ get; set; }

        /// <summary>
        /// 是否允许编辑企业注册时的证照类型
        /// <br/>true:不允许编辑。
        /// <br/>false:允许编辑（默认值）。
        /// <br/>
        /// 
        /// 注意：
        /// RegisterInfo 中的OrganizationIdCardType值不为空的时候，才可设置为不可编辑。
        /// </summary>
        [JsonProperty("OrganizationIdCardTypeSame")]
        public bool? OrganizationIdCardTypeSame{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LegalNameSame", this.LegalNameSame);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCodeCNameSame", this.UnifiedSocialCreditCodeCNameSame);
            this.SetParamSimple(map, prefix + "OrganizationIdCardTypeSame", this.OrganizationIdCardTypeSame);
        }
    }
}

