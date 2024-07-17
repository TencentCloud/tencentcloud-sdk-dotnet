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

namespace TencentCloud.Cloudapp.V20220530.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class License : AbstractModel
    {
        
        /// <summary>
        /// License ID
        /// </summary>
        [JsonProperty("LicenseId")]
        public string LicenseId{ get; set; }

        /// <summary>
        /// 软件授权模式。
        /// 
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>枚举值</th>
        /// <th>说明</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Permanent</td>
        /// <td>永久授权。该授权不受有效期限制。</td>
        /// </tr>
        /// <tr>
        /// <td>Subscription</td>
        /// <td>订阅授权。授权如果过了有效期，则会进入过期状态。</td>
        /// </tr>
        /// </tbody></table>
        /// </summary>
        [JsonProperty("LicenseMode")]
        public string LicenseMode{ get; set; }

        /// <summary>
        /// 软件的授权状态。
        /// 
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>枚举值</th>
        /// <th>说明</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Issued</td>
        /// <td>已颁发，等待激活。一般来说，如果软件已经在运行，不会出现该状态。</td>
        /// </tr>
        /// <tr>
        /// <td>Active</td>
        /// <td>授权在有效期内，这是软件运行期间最常见的状态。</td>
        /// </tr>
        /// <tr>
        /// <td>Expired</td>
        /// <td>授权已过期。订阅类的软件授权有有效期，如果服务器时间已晚于有效期，则会进入过期状态。</td>
        /// </tr>
        /// <tr>
        /// <td>Deactivated</td>
        /// <td>授权已失效。用户如果退货软件，则授权会自动失效。</td>
        /// </tr>
        /// </tbody></table>
        /// </summary>
        [JsonProperty("LicenseStatus")]
        public string LicenseStatus{ get; set; }

        /// <summary>
        /// 软件供应方 ID。
        /// </summary>
        [JsonProperty("ProviderId")]
        public ulong? ProviderId{ get; set; }

        /// <summary>
        /// 软件包 ID。
        /// </summary>
        [JsonProperty("SoftwarePackageId")]
        public string SoftwarePackageId{ get; set; }

        /// <summary>
        /// 软件包版本。
        /// </summary>
        [JsonProperty("SoftwarePackageVersion")]
        public string SoftwarePackageVersion{ get; set; }

        /// <summary>
        /// 被授权的用户 UIN。
        /// </summary>
        [JsonProperty("AuthorizedUserUin")]
        public string AuthorizedUserUin{ get; set; }

        /// <summary>
        /// 被授权的应用实例 ID。
        /// </summary>
        [JsonProperty("AuthorizedCloudappId")]
        public string AuthorizedCloudappId{ get; set; }

        /// <summary>
        /// 被授权的角色 ID。
        /// </summary>
        [JsonProperty("AuthorizedCloudappRoleId")]
        public string AuthorizedCloudappRoleId{ get; set; }

        /// <summary>
        /// 被授权的软件规格，具体字段请参考结构SaleParam
        /// </summary>
        [JsonProperty("AuthorizedSpecification")]
        public SaleParam[] AuthorizedSpecification{ get; set; }

        /// <summary>
        /// 被授权的软件的计费模式。
        /// 
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>枚举值</th>
        /// <th>说明</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>1</td>
        /// <td>线上计费，软件的授权从腾讯云线上购买，支持续费、退款等操作。</td>
        /// </tr>
        /// <tr>
        /// <td>2</td>
        /// <td>线下计费，软件的授权线下签订合同购买，定向客户交付，无法从线上续费和退款。</td>
        /// </tr>
        /// <tr>
        /// <td>4</td>
        /// <td>免费</td>
        /// </tr>
        /// </tbody></table>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// 授权时长（单位由LifeSpanUnit确定，枚举值有Y年/M月/D日三种）
        /// </summary>
        [JsonProperty("LifeSpan")]
        public long? LifeSpan{ get; set; }

        /// <summary>
        /// 授权颁发时间。
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// 授权激活时间，如从未激活则返回 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivationDate")]
        public string ActivationDate{ get; set; }

        /// <summary>
        /// 授权过期时间，如未过期或者是永久授权，则返回 null。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// 授权时长单位，枚举值有Y年/M月/D日三种
        /// </summary>
        [JsonProperty("LifeSpanUnit")]
        public string LifeSpanUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseId", this.LicenseId);
            this.SetParamSimple(map, prefix + "LicenseMode", this.LicenseMode);
            this.SetParamSimple(map, prefix + "LicenseStatus", this.LicenseStatus);
            this.SetParamSimple(map, prefix + "ProviderId", this.ProviderId);
            this.SetParamSimple(map, prefix + "SoftwarePackageId", this.SoftwarePackageId);
            this.SetParamSimple(map, prefix + "SoftwarePackageVersion", this.SoftwarePackageVersion);
            this.SetParamSimple(map, prefix + "AuthorizedUserUin", this.AuthorizedUserUin);
            this.SetParamSimple(map, prefix + "AuthorizedCloudappId", this.AuthorizedCloudappId);
            this.SetParamSimple(map, prefix + "AuthorizedCloudappRoleId", this.AuthorizedCloudappRoleId);
            this.SetParamArrayObj(map, prefix + "AuthorizedSpecification.", this.AuthorizedSpecification);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "LifeSpan", this.LifeSpan);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "ActivationDate", this.ActivationDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "LifeSpanUnit", this.LifeSpanUnit);
        }
    }
}

