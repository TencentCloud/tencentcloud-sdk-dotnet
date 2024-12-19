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

    public class OrganizationCommonInfo : AbstractModel
    {
        
        /// <summary>
        /// 组织机构名称。
        /// 请确认该名称与企业营业执照中注册的名称一致。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 组织机构企业统一社会信用代码。
        /// 请确认该企业统一社会信用代码与企业营业执照中注册的统一社会信用代码一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 组织机构法人的姓名。
        /// 请确认该企业统一社会信用代码与企业营业执照中注册的法人姓名一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 组织机构法人的证件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalIdCardType")]
        public string LegalIdCardType{ get; set; }

        /// <summary>
        /// 组织机构法人的证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LegalIdCardNumber")]
        public string LegalIdCardNumber{ get; set; }

        /// <summary>
        /// 组织机构超管姓名。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 组织机构超管手机号。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// 组织机构超管证件类型
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminIdCardType")]
        public string AdminIdCardType{ get; set; }

        /// <summary>
        /// 组织机构超管证件号码
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdminIdCardNumber")]
        public string AdminIdCardNumber{ get; set; }

        /// <summary>
        /// 原超管姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldAdminName")]
        public string OldAdminName{ get; set; }

        /// <summary>
        /// 原超管手机号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldAdminMobile")]
        public string OldAdminMobile{ get; set; }

        /// <summary>
        /// 原超管证件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldAdminIdCardType")]
        public string OldAdminIdCardType{ get; set; }

        /// <summary>
        /// 原超管证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldAdminIdCardNumber")]
        public string OldAdminIdCardNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "LegalIdCardType", this.LegalIdCardType);
            this.SetParamSimple(map, prefix + "LegalIdCardNumber", this.LegalIdCardNumber);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminMobile", this.AdminMobile);
            this.SetParamSimple(map, prefix + "AdminIdCardType", this.AdminIdCardType);
            this.SetParamSimple(map, prefix + "AdminIdCardNumber", this.AdminIdCardNumber);
            this.SetParamSimple(map, prefix + "OldAdminName", this.OldAdminName);
            this.SetParamSimple(map, prefix + "OldAdminMobile", this.OldAdminMobile);
            this.SetParamSimple(map, prefix + "OldAdminIdCardType", this.OldAdminIdCardType);
            this.SetParamSimple(map, prefix + "OldAdminIdCardNumber", this.OldAdminIdCardNumber);
        }
    }
}

