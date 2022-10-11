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

    public class QueryCompanyTitleRequest : AbstractModel
    {
        
        /// <summary>
        /// 公司抬头关键字
        /// </summary>
        [JsonProperty("CompanyTitleKeyword")]
        public string CompanyTitleKeyword{ get; set; }

        /// <summary>
        /// 开票平台ID。0：高灯，1：票易通
        /// </summary>
        [JsonProperty("InvoicePlatformId")]
        public long? InvoicePlatformId{ get; set; }

        /// <summary>
        /// 销方纳税人识别号
        /// </summary>
        [JsonProperty("SellerTaxpayerNum")]
        public string SellerTaxpayerNum{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyTitleKeyword", this.CompanyTitleKeyword);
            this.SetParamSimple(map, prefix + "InvoicePlatformId", this.InvoicePlatformId);
            this.SetParamSimple(map, prefix + "SellerTaxpayerNum", this.SellerTaxpayerNum);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

