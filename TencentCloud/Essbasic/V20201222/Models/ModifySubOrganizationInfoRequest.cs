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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubOrganizationInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息，该接口 SubOrganizationId 字段与 OpenId 字段二者至少需要传入一个，全部传入时则使用 SubOrganizationId 信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 机构在第三方的唯一标识，32位定长字符串，与 Caller 中 SubOrgnizationId 二者至少需要传入一个，全部传入时则使用 SubOrganizationId 信息
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 机构名称全称，修改后机构状态将变为未实名，需要调用实名接口重新实名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 机构类型可选值：
        /// 1. ENTERPRISE - 企业；
        /// 2. INDIVIDUALBIZ - 个体工商户；
        /// 3. PUBLICINSTITUTION - 政府/事业单位
        /// 4. OTHERS - 其他组织
        /// </summary>
        [JsonProperty("OrganizationType")]
        public string OrganizationType{ get; set; }

        /// <summary>
        /// 机构证件照片文件，base64编码。支持jpg，jpeg，png格式；如果传值，则重新上传文件后，机构状态将变为未实名，需要调用实名接口重新实名。
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
        /// 机构法人/经营者证件类型，可选值：ID_CARD - 居民身份证。OrganizationType 为 ENTERPRISE、INDIVIDUALBIZ 时，此项必填，其他情况选填。
        /// </summary>
        [JsonProperty("LegalIdCardType")]
        public string LegalIdCardType{ get; set; }

        /// <summary>
        /// 机构法人/经营者证件号码。OrganizationType 为 ENTERPRISE、INDIVIDUALBIZ 时，此项必填，其他情况选填
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
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 企业联系地址
        /// </summary>
        [JsonProperty("ContactAddress")]
        public Address ContactAddress{ get; set; }

        /// <summary>
        /// 机构电子邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "OrganizationType", this.OrganizationType);
            this.SetParamSimple(map, prefix + "BizLicenseFile", this.BizLicenseFile);
            this.SetParamSimple(map, prefix + "BizLicenseFileName", this.BizLicenseFileName);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "LegalIdCardType", this.LegalIdCardType);
            this.SetParamSimple(map, prefix + "LegalIdCardNumber", this.LegalIdCardNumber);
            this.SetParamSimple(map, prefix + "LegalMobile", this.LegalMobile);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamObj(map, prefix + "ContactAddress.", this.ContactAddress);
            this.SetParamSimple(map, prefix + "Email", this.Email);
        }
    }
}

