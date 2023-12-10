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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelOrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 电子签企业Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 电子签企业OpenId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 企业名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业信用代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCode")]
        public string UnifiedSocialCreditCode{ get; set; }

        /// <summary>
        /// 法人姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 法人OpenId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalOpenId")]
        public string LegalOpenId{ get; set; }

        /// <summary>
        /// 超管姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 超管OpenId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminOpenId")]
        public string AdminOpenId{ get; set; }

        /// <summary>
        /// 超管手机号，脱敏后返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// 企业认证状态字段。值如下：
        /// <ul>
        ///   <li>**"UNVERIFIED"**： 未认证的企业</li>
        ///   <li>**"VERIFYINGLEGALPENDINGAUTHORIZATION"**： 认证中待法人授权的企业</li>
        ///   <li>**"VERIFYINGAUTHORIZATIONFILEPENDING"**： 认证中授权书审核中的企业</li>
        ///   <li>**"VERIFYINGAUTHORIZATIONFILEREJECT"**： 认证中授权书已驳回的企业</li>
        ///   <li>**"VERIFYING"**： 认证中的企业</li>
        ///   <li>**"VERIFIED"**： 已认证的企业</li>
        /// </ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationStatus")]
        public string AuthorizationStatus{ get; set; }

        /// <summary>
        /// 企业认证方式字段。值如下：
        /// <ul>
        ///   <li>**"AuthorizationInit"**： 暂未选择授权方式</li>
        ///   <li>**"AuthorizationFile"**： 授权书</li>
        ///   <li>**"AuthorizationLegalPerson"**： 法人授权超管</li>
        ///   <li>**"AuthorizationLegalIdentity"**： 法人直接认证</li>
        /// </ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public string AuthorizationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "UnifiedSocialCreditCode", this.UnifiedSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "LegalOpenId", this.LegalOpenId);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminOpenId", this.AdminOpenId);
            this.SetParamSimple(map, prefix + "AdminMobile", this.AdminMobile);
            this.SetParamSimple(map, prefix + "AuthorizationStatus", this.AuthorizationStatus);
            this.SetParamSimple(map, prefix + "AuthorizationType", this.AuthorizationType);
        }
    }
}

