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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubOrganizationDetail : AbstractModel
    {
        
        /// <summary>
        /// 组织ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 机构名称全称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 机构电子邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 机构证件号码类型
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 机构证件号码
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [JsonProperty("OrganizationType")]
        public string OrganizationType{ get; set; }

        /// <summary>
        /// 机构证件文件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardFileType")]
        public string IdCardFileType{ get; set; }

        /// <summary>
        /// 机构证件照片文件，base64编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizLicenseFile")]
        public string BizLicenseFile{ get; set; }

        /// <summary>
        /// 机构证件照片文件名
        /// </summary>
        [JsonProperty("BizLicenseFileName")]
        public string BizLicenseFileName{ get; set; }

        /// <summary>
        /// 机构法人/经营者姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 机构法人/经营者证件类型
        /// </summary>
        [JsonProperty("LegalIdCardType")]
        public string LegalIdCardType{ get; set; }

        /// <summary>
        /// 机构法人/经营者证件号码
        /// </summary>
        [JsonProperty("LegalIdCardNumber")]
        public string LegalIdCardNumber{ get; set; }

        /// <summary>
        /// 机构法人/经营者/联系人手机号码
        /// </summary>
        [JsonProperty("LegalMobile")]
        public string LegalMobile{ get; set; }

        /// <summary>
        /// 组织联系人姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 机构实名状态
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public string VerifyStatus{ get; set; }

        /// <summary>
        /// 机构通过实名时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifiedOn")]
        public long? VerifiedOn{ get; set; }

        /// <summary>
        /// 机构创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 机构更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedOn")]
        public long? UpdatedOn{ get; set; }

        /// <summary>
        /// 实名认证的客户端IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyClientIp")]
        public string VerifyClientIp{ get; set; }

        /// <summary>
        /// 实名认证的服务器IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyServerIp")]
        public string VerifyServerIp{ get; set; }

        /// <summary>
        /// 企业联系地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContactAddress")]
        public Address ContactAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "OrganizationType", this.OrganizationType);
            this.SetParamSimple(map, prefix + "IdCardFileType", this.IdCardFileType);
            this.SetParamSimple(map, prefix + "BizLicenseFile", this.BizLicenseFile);
            this.SetParamSimple(map, prefix + "BizLicenseFileName", this.BizLicenseFileName);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "LegalIdCardType", this.LegalIdCardType);
            this.SetParamSimple(map, prefix + "LegalIdCardNumber", this.LegalIdCardNumber);
            this.SetParamSimple(map, prefix + "LegalMobile", this.LegalMobile);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "VerifiedOn", this.VerifiedOn);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "UpdatedOn", this.UpdatedOn);
            this.SetParamSimple(map, prefix + "VerifyClientIp", this.VerifyClientIp);
            this.SetParamSimple(map, prefix + "VerifyServerIp", this.VerifyServerIp);
            this.SetParamObj(map, prefix + "ContactAddress.", this.ContactAddress);
        }
    }
}

