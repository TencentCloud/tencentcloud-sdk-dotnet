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

    public class ApplyPayerInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 付款人ID
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 付款人类型 (个人: INDIVIDUAL, 企业: CORPORATE)
        /// </summary>
        [JsonProperty("PayerType")]
        public string PayerType{ get; set; }

        /// <summary>
        /// 付款人姓名
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName{ get; set; }

        /// <summary>
        /// 付款人证件类型 (身份证: ID_CARD, 统一社会信用代码: UNIFIED_CREDIT_CODE)
        /// </summary>
        [JsonProperty("PayerIdType")]
        public string PayerIdType{ get; set; }

        /// <summary>
        /// 付款人证件号
        /// </summary>
        [JsonProperty("PayerIdNo")]
        public string PayerIdNo{ get; set; }

        /// <summary>
        /// 付款人常驻国家或地区编码 (见常见问题-国家/地区编码)
        /// </summary>
        [JsonProperty("PayerCountryCode")]
        public string PayerCountryCode{ get; set; }

        /// <summary>
        /// 付款人联系人名称
        /// </summary>
        [JsonProperty("PayerContactName")]
        public string PayerContactName{ get; set; }

        /// <summary>
        /// 付款人联系电话 (PayerType=CORPORATE 必填)
        /// </summary>
        [JsonProperty("PayerContactNumber")]
        public string PayerContactNumber{ get; set; }

        /// <summary>
        /// 付款人联系邮箱
        /// </summary>
        [JsonProperty("PayerEmailAddress")]
        public string PayerEmailAddress{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "PayerType", this.PayerType);
            this.SetParamSimple(map, prefix + "PayerName", this.PayerName);
            this.SetParamSimple(map, prefix + "PayerIdType", this.PayerIdType);
            this.SetParamSimple(map, prefix + "PayerIdNo", this.PayerIdNo);
            this.SetParamSimple(map, prefix + "PayerCountryCode", this.PayerCountryCode);
            this.SetParamSimple(map, prefix + "PayerContactName", this.PayerContactName);
            this.SetParamSimple(map, prefix + "PayerContactNumber", this.PayerContactNumber);
            this.SetParamSimple(map, prefix + "PayerEmailAddress", this.PayerEmailAddress);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

