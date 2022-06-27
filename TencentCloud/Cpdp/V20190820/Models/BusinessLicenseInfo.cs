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

    public class BusinessLicenseInfo : AbstractModel
    {
        
        /// <summary>
        /// 营业证件类型
        ///  IDCARD：身份证
        ///  CREDITCODE：统一社会信用代码
        /// </summary>
        [JsonProperty("BusinessLicenseType")]
        public string BusinessLicenseType{ get; set; }

        /// <summary>
        /// 营业证件号码 非个人商户上送统一社会信用代码，个人商户上送身份证号码
        /// </summary>
        [JsonProperty("BusinessLicenseNumber")]
        public string BusinessLicenseNumber{ get; set; }

        /// <summary>
        /// 营业证件有效期类型 
        /// LONGTERM：长期有效
        /// OTHER：非长期有效
        /// </summary>
        [JsonProperty("BusinessLicenseValidityType")]
        public string BusinessLicenseValidityType{ get; set; }

        /// <summary>
        /// 营业证件生效日期，yyyy-MM-dd
        /// </summary>
        [JsonProperty("BusinessLicenseEffectiveDate")]
        public string BusinessLicenseEffectiveDate{ get; set; }

        /// <summary>
        /// 营业证件失效日期，yyyy-MM-dd
        /// </summary>
        [JsonProperty("BusinessLicenseExpireDate")]
        public string BusinessLicenseExpireDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessLicenseType", this.BusinessLicenseType);
            this.SetParamSimple(map, prefix + "BusinessLicenseNumber", this.BusinessLicenseNumber);
            this.SetParamSimple(map, prefix + "BusinessLicenseValidityType", this.BusinessLicenseValidityType);
            this.SetParamSimple(map, prefix + "BusinessLicenseEffectiveDate", this.BusinessLicenseEffectiveDate);
            this.SetParamSimple(map, prefix + "BusinessLicenseExpireDate", this.BusinessLicenseExpireDate);
        }
    }
}

