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
        /// 电子签平台给企业分配的ID（在不同应用下同一个企业会分配通用的ID）
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业的唯一标识
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 第三方平台子客企业名称
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业的统一社会信用代码
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCode")]
        public string UnifiedSocialCreditCode{ get; set; }

        /// <summary>
        /// 企业法定代表人的姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 企业法定代表人作为第三方平台子客企业员工的唯一标识
        /// </summary>
        [JsonProperty("LegalOpenId")]
        public string LegalOpenId{ get; set; }

        /// <summary>
        /// 企业超级管理员的姓名
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 企业超级管理员作为第三方平台子客企业员工的唯一标识
        /// </summary>
        [JsonProperty("AdminOpenId")]
        public string AdminOpenId{ get; set; }

        /// <summary>
        /// 企业超级管理员的手机号码
        /// **注**：`手机号码脱敏（隐藏部分用*替代）`
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
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public string AuthorizationType{ get; set; }

        /// <summary>
        /// 子企业激活状态。值如下：
        /// <ul>
        ///   <li>**0**： 未激活</li>
        ///   <li>**1**： 已激活</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public long? ActiveStatus{ get; set; }

        /// <summary>
        /// 账号过期时间，时间戳
        /// </summary>
        [JsonProperty("LicenseExpireTime")]
        public long? LicenseExpireTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "ActiveStatus", this.ActiveStatus);
            this.SetParamSimple(map, prefix + "LicenseExpireTime", this.LicenseExpireTime);
        }
    }
}

