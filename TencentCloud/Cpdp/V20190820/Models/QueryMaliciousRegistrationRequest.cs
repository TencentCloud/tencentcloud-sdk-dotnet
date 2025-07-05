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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryMaliciousRegistrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户ID，调用方使用的商户号信息，与商户主体一一对应
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 企业工商注册标准名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonProperty("RegAddress")]
        public string RegAddress{ get; set; }

        /// <summary>
        /// 商户进件Unix时间，单位秒（非企业注册工商时间)
        /// </summary>
        [JsonProperty("RegTime")]
        public ulong? RegTime{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("USCI")]
        public string USCI{ get; set; }

        /// <summary>
        /// 工商注册码，匹配优先级为Usci>RegNumber>CompanyName
        /// </summary>
        [JsonProperty("RegNumber")]
        public string RegNumber{ get; set; }

        /// <summary>
        /// 手机号码32位MD5加密结果，全大写，格式为0086-13812345678
        /// </summary>
        [JsonProperty("EncryptedPhoneNumber")]
        public string EncryptedPhoneNumber{ get; set; }

        /// <summary>
        /// 邮箱32位MD5加密结果，全大写
        /// </summary>
        [JsonProperty("EncryptedEmailAddress")]
        public string EncryptedEmailAddress{ get; set; }

        /// <summary>
        /// 身份证MD5加密结果，最后一位x大写
        /// </summary>
        [JsonProperty("EncryptedPersonId")]
        public string EncryptedPersonId{ get; set; }

        /// <summary>
        /// 填写信息设备的IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 进件渠道号，客户自行编码即可
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "RegAddress", this.RegAddress);
            this.SetParamSimple(map, prefix + "RegTime", this.RegTime);
            this.SetParamSimple(map, prefix + "USCI", this.USCI);
            this.SetParamSimple(map, prefix + "RegNumber", this.RegNumber);
            this.SetParamSimple(map, prefix + "EncryptedPhoneNumber", this.EncryptedPhoneNumber);
            this.SetParamSimple(map, prefix + "EncryptedEmailAddress", this.EncryptedEmailAddress);
            this.SetParamSimple(map, prefix + "EncryptedPersonId", this.EncryptedPersonId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
        }
    }
}

