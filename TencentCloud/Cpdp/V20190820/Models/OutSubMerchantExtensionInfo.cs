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

    public class OutSubMerchantExtensionInfo : AbstractModel
    {
        
        /// <summary>
        /// 地区代码，国标码
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        [JsonProperty("RegisterAddress")]
        public string RegisterAddress{ get; set; }

        /// <summary>
        /// 通讯地址
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("MailingAddress")]
        public string MailingAddress{ get; set; }

        /// <summary>
        /// 营业地址/经营地址
        /// </summary>
        [JsonProperty("BusinessAddress")]
        public string BusinessAddress{ get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonProperty("ServicePhone")]
        public string ServicePhone{ get; set; }

        /// <summary>
        /// 网站url
        /// </summary>
        [JsonProperty("WebSiteUrl")]
        public string WebSiteUrl{ get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "RegisterAddress", this.RegisterAddress);
            this.SetParamSimple(map, prefix + "MailingAddress", this.MailingAddress);
            this.SetParamSimple(map, prefix + "BusinessAddress", this.BusinessAddress);
            this.SetParamSimple(map, prefix + "ServicePhone", this.ServicePhone);
            this.SetParamSimple(map, prefix + "WebSiteUrl", this.WebSiteUrl);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
        }
    }
}

