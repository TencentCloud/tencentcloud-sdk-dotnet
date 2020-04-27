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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 开票平台ID
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("TaxpayerName")]
        public string TaxpayerName{ get; set; }

        /// <summary>
        /// 销方纳税人识别号
        /// </summary>
        [JsonProperty("TaxpayerNum")]
        public string TaxpayerNum{ get; set; }

        /// <summary>
        /// 注册企业法定代表人名称
        /// </summary>
        [JsonProperty("LegalPersonName")]
        public string LegalPersonName{ get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("ContactsName")]
        public string ContactsName{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 不包含省市名称的地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 地区编码
        /// </summary>
        [JsonProperty("RegionCode")]
        public long? RegionCode{ get; set; }

        /// <summary>
        /// 市（地区）名称
        /// </summary>
        [JsonProperty("CityName")]
        public string CityName{ get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonProperty("Drawer")]
        public string Drawer{ get; set; }

        /// <summary>
        /// 税务登记证图片（Base64）字符串，需小于 3M
        /// </summary>
        [JsonProperty("TaxRegistrationCertificate")]
        public string TaxRegistrationCertificate{ get; set; }

        /// <summary>
        /// 联系人邮箱地址
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 企业电话
        /// </summary>
        [JsonProperty("BusinessMobile")]
        public string BusinessMobile{ get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonProperty("BankAccount")]
        public string BankAccount{ get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonProperty("Reviewer")]
        public string Reviewer{ get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonProperty("Payee")]
        public string Payee{ get; set; }

        /// <summary>
        /// 注册邀请码
        /// </summary>
        [JsonProperty("RegisterCode")]
        public string RegisterCode{ get; set; }

        /// <summary>
        /// 不填默认为1，有效状态
        /// 0：表示无效；
        /// 1:表示有效；
        /// 2:表示禁止开蓝票；
        /// 3:表示禁止冲红。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 接收推送的消息地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamSimple(map, prefix + "TaxpayerName", this.TaxpayerName);
            this.SetParamSimple(map, prefix + "TaxpayerNum", this.TaxpayerNum);
            this.SetParamSimple(map, prefix + "LegalPersonName", this.LegalPersonName);
            this.SetParamSimple(map, prefix + "ContactsName", this.ContactsName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "CityName", this.CityName);
            this.SetParamSimple(map, prefix + "Drawer", this.Drawer);
            this.SetParamSimple(map, prefix + "TaxRegistrationCertificate", this.TaxRegistrationCertificate);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "BusinessMobile", this.BusinessMobile);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "BankAccount", this.BankAccount);
            this.SetParamSimple(map, prefix + "Reviewer", this.Reviewer);
            this.SetParamSimple(map, prefix + "Payee", this.Payee);
            this.SetParamSimple(map, prefix + "RegisterCode", this.RegisterCode);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

