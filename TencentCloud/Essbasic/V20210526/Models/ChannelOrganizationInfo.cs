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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelOrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>电子签平台给企业分配的ID（在不同应用下同一个企业会分配通用的ID）</p>
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// <p>第三方平台子客企业的唯一标识</p>
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// <p>第三方平台子客企业名称</p>
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// <p>企业的统一社会信用代码</p>
        /// </summary>
        [JsonProperty("UnifiedSocialCreditCode")]
        public string UnifiedSocialCreditCode{ get; set; }

        /// <summary>
        /// <p>企业法定代表人的姓名</p>
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// <p>企业法定代表人作为第三方平台子客企业员工的唯一标识</p>
        /// </summary>
        [JsonProperty("LegalOpenId")]
        public string LegalOpenId{ get; set; }

        /// <summary>
        /// <p>企业超级管理员的姓名</p>
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// <p>企业超级管理员作为第三方平台子客企业员工的唯一标识</p>
        /// </summary>
        [JsonProperty("AdminOpenId")]
        public string AdminOpenId{ get; set; }

        /// <summary>
        /// <p>企业超级管理员的手机号码<br><strong>注</strong>：<code>手机号码脱敏（隐藏部分用*替代）</code></p>
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// <p>企业认证状态枚举值及说明如下：</p><table>  <thead>    <tr>      <th>枚举值</th>      <th>说明</th>    </tr>  </thead>  <tbody>    <tr>      <td><code>UNVERIFIED</code></td>      <td>企业未认证</td>    </tr>    <tr>      <td><code>VERIFYING</code></td>      <td>企业认证中，还未选择授权方式</td>    </tr>    <tr>      <td><code>VERIFYINGLEGALPENDINGAUTHORIZATION</code></td>      <td>企业认证中，待法人授权或法人认证</td>    </tr>    <tr>      <td><code>VERIFYINGAUTHORIZATIONFILEPENDING</code></td>      <td>企业认证中，已上传授权书，授权书待审核</td>    </tr>    <tr>      <td><code>VERIFYINGAUTHORIZATIONFILEREJECT</code></td>      <td>企业认证中，授权书审核被驳回</td>    </tr>    <tr>      <td><code>VERIFIED</code></td>      <td>企业已认证成功</td>    </tr>  </tbody></table><p>企业认证流程的典型流转路径如下：</p><pre><code>UNVERIFIED → VERIFYING（提交企业信息，选择授权方式）                ├─ 法人授权 → VERIFYINGLEGALPENDINGAUTHORIZATION → VERIFIED                ├─ 法人认证 → VERIFYINGLEGALPENDINGAUTHORIZATION → VERIFIED                └─ 授权书 → VERIFYINGAUTHORIZATIONFILEPENDING                              ├─ 审核通过 → VERIFIED                              └─ 审核驳回 → VERIFYINGAUTHORIZATIONFILEREJECT</code></pre><p>枚举值：</p><ul><li>UNVERIFIED： 企业未认证</li><li>VERIFYING： 企业认证中，还未选择授权方式</li><li>VERIFYINGLEGALPENDINGAUTHORIZATION： 企业认证中，待法人授权或法人认证</li><li>VERIFYINGAUTHORIZATIONFILEPENDING： 企业认证中，已上传授权书，授权书待审核</li><li>VERIFYINGAUTHORIZATIONFILEREJECT： 企业认证中，授权书审核被驳回</li><li>VERIFIED： 企业已认证成功</li></ul>
        /// </summary>
        [JsonProperty("AuthorizationStatus")]
        public string AuthorizationStatus{ get; set; }

        /// <summary>
        /// <p>企业认证方式字段。值如下：</p><ul>  <li>**"AuthorizationInit"**： 暂未选择授权方式</li>  <li>**"AuthorizationFile"**： 授权书</li>  <li>**"AuthorizationLegalPerson"**： 法人授权超管</li>  <li>**"AuthorizationLegalIdentity"**： 法人直接认证</li></ul>
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public string AuthorizationType{ get; set; }

        /// <summary>
        /// <p>子企业激活状态。值如下：</p><ul>  <li>**0**： 未激活</li>  <li>**1**： 已激活</li></ul>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public long? ActiveStatus{ get; set; }

        /// <summary>
        /// <p>账号到期时间，时间戳</p>
        /// </summary>
        [JsonProperty("LicenseExpireTime")]
        public long? LicenseExpireTime{ get; set; }

        /// <summary>
        /// <p>是否已提交企业认证信息</p><p>默认值：false</p><p>此参数表示客户是否已提交企业信息。如图所示，在点击提交按钮之前，该字段为 <code>false</code>；点击提交按钮之后，该字段变为 <code>true</code>。</p><img src="https://qcloudimg.tencent-cloud.cn/raw/548d838430b60e797dbfba80cb4a3ef7.png" alt="企业信息提交状态示意图"><p><strong>注意：</strong>该字段并非在变为 <code>true</code> 后就不再变化。任何导致当前认证记录失效的操作都会将其重置为 <code>false</code>，包括但不限于：重新提交企业信息、审核被拒绝后重新上传企业信息等操作。</p>
        /// </summary>
        [JsonProperty("HasSubmittedAuthInfo")]
        public bool? HasSubmittedAuthInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "HasSubmittedAuthInfo", this.HasSubmittedAuthInfo);
        }
    }
}

