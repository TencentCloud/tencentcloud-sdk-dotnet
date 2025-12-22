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

    public class RegisterInfo : AbstractModel
    {
        
        /// <summary>
        /// 法人姓名
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
        /// 社会统一信用代码
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCode")]
        public string UnifiedSocialCreditCode{ get; set; }

        /// <summary>
        /// 组织机构企业注册地址。 请确认该企业注册地址与企业营业执照中注册的地址一致。
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式 支持多选:
        /// 
        /// <ul>
        /// <li><strong>2</strong>: 法人授权方式</li>
        /// <li><strong>5</strong>: 授权书+对公打款方式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        public ulong?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式:
        /// 
        /// <ul>
        /// <li><strong>2</strong>: 法人授权方式</li>
        /// <li><strong>5</strong>: 授权书+对公打款方式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationType")]
        [System.Obsolete]
        public long? AuthorizationType{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式 支持多选:
        /// 
        /// <ul>
        /// <li><strong>1</strong>: 上传营业执照</li>
        /// <li><strong>2</strong>: 腾讯云快速认证</li>
        /// <li><strong>3</strong>: 腾讯商户号授权<font color="red">（仅支持小程序端）</font></li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationMethods")]
        public ulong?[] AuthorizationMethods{ get; set; }

        /// <summary>
        /// 企业证照类型：
        /// 
        /// USCC :(默认)工商组织营业执照
        /// PRACTICELICENSEOFMEDICALINSTITUTION :医疗机构执业许可证
        /// CLINICFILLINGCERTIFICATE:诊所备案证
        /// </summary>
        [JsonProperty("OrganizationIdCardType")]
        public string OrganizationIdCardType{ get; set; }

        /// <summary>
        /// 企业创建时候的个性化参数。
        /// 其中，包括一下内容：
        /// LegalNameSame  是否可以编辑法人。
        /// UnifiedSocialCreditCodeSame  是否可以编辑证件号码。
        /// OrganizationIdCardTypeSame  是否可以更改证照类型。
        /// </summary>
        [JsonProperty("RegisterInfoOption")]
        public RegisterInfoOption RegisterInfoOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "Uscc", this.Uscc);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCode", this.UnifiedSocialCreditCode);
            this.SetParamSimple(map, prefix + "OrganizationAddress", this.OrganizationAddress);
            this.SetParamArraySimple(map, prefix + "AuthorizationTypes.", this.AuthorizationTypes);
            this.SetParamSimple(map, prefix + "AuthorizationType", this.AuthorizationType);
            this.SetParamArraySimple(map, prefix + "AuthorizationMethods.", this.AuthorizationMethods);
            this.SetParamSimple(map, prefix + "OrganizationIdCardType", this.OrganizationIdCardType);
            this.SetParamObj(map, prefix + "RegisterInfoOption.", this.RegisterInfoOption);
        }
    }
}

