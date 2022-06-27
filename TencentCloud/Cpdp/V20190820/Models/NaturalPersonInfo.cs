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

    public class NaturalPersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 自然人类型 
        /// 2：商户负责人 
        /// 3：授权经办人
        /// 4：业务联系人 
        /// 5：实际控制人 
        /// 6：控股股东 
        /// 7：受益人 
        /// 8：结算人
        /// 注意：HELIPAY渠道必传业务联系人
        /// </summary>
        [JsonProperty("PersonType")]
        public string PersonType{ get; set; }

        /// <summary>
        /// 证件类型 
        /// IDCARD：身份证 
        /// PASSPORT：护照 SOLDIERSCERTIFICATE：士兵证 OFFICERSCERTIFICATE：军官证 GATXCERTIFICATE：香港居民来往内地通行证 TWNDCERTIFICATE：台湾同胞来往内地通行证 MACAOCERTIFICATE：澳门来往内地通行证
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("IdNumber")]
        public string IdNumber{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 证件有效期类型 
        /// LONGTERM：长期有效 
        /// OTHER：非长期有效
        /// </summary>
        [JsonProperty("IdValidityType")]
        public string IdValidityType{ get; set; }

        /// <summary>
        /// 证件生效日期，yyyy-MM-dd
        /// </summary>
        [JsonProperty("IdEffectiveDate")]
        public string IdEffectiveDate{ get; set; }

        /// <summary>
        /// 证件失效日期，yyyy-MM-dd
        /// </summary>
        [JsonProperty("IdExpireDate")]
        public string IdExpireDate{ get; set; }

        /// <summary>
        /// 联系电话，HELIPAY渠道业务联系人必传
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone{ get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [JsonProperty("ContactAddress")]
        public string ContactAddress{ get; set; }

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
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "IdNumber", this.IdNumber);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "IdValidityType", this.IdValidityType);
            this.SetParamSimple(map, prefix + "IdEffectiveDate", this.IdEffectiveDate);
            this.SetParamSimple(map, prefix + "IdExpireDate", this.IdExpireDate);
            this.SetParamSimple(map, prefix + "ContactPhone", this.ContactPhone);
            this.SetParamSimple(map, prefix + "ContactAddress", this.ContactAddress);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
        }
    }
}

