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

    public class OpenBankBillingInfo : AbstractModel
    {
        
        /// <summary>
        /// 账单人名字
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// 账单人姓氏
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// 账单地址1
        /// </summary>
        [JsonProperty("AddressOne")]
        public string AddressOne{ get; set; }

        /// <summary>
        /// 账单地址1
        /// </summary>
        [JsonProperty("AddressTwo")]
        public string AddressTwo{ get; set; }

        /// <summary>
        /// 账单地址所在城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 账单地址所在州/省，当国家是美国或加拿大时，使用ISO-3166-2:US或ISO -3166-2:CA 中该国家地区编 码标准中的两位字母编码。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 账单地址所在国家，使用ISO-3166-1标准中的两位字母编码。
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 账单地址邮编
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode{ get; set; }

        /// <summary>
        /// 账单人手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "AddressOne", this.AddressOne);
            this.SetParamSimple(map, prefix + "AddressTwo", this.AddressTwo);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "ZipCode", this.ZipCode);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
        }
    }
}

