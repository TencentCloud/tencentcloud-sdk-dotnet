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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Personnel : AbstractModel
    {
        
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonProperty("IDCardNumber")]
        public string IDCardNumber{ get; set; }

        /// <summary>
        /// 证件类型。对应关系如下：IDENTITY_CARD: 身份证,
        /// HONG_KONG_AND_MACAO_PASS: 港澳通行证',
        /// PASSPORT: 护照,
        /// DRIVING_LICENSE: 驾照,
        /// OTHER: 其他
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("Company")]
        public string Company{ get; set; }

        /// <summary>
        /// 语言。对应关系：ENGLISH: 英文, CHINESE: 中文
        /// </summary>
        [JsonProperty("LanguageType")]
        public string LanguageType{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonProperty("TelNumber")]
        public string TelNumber{ get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        [JsonProperty("Position")]
        public string Position{ get; set; }

        /// <summary>
        /// 微信
        /// </summary>
        [JsonProperty("Wechat")]
        public string Wechat{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IDCardNumber", this.IDCardNumber);
            this.SetParamSimple(map, prefix + "IDCardType", this.IDCardType);
            this.SetParamSimple(map, prefix + "Company", this.Company);
            this.SetParamSimple(map, prefix + "LanguageType", this.LanguageType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TelNumber", this.TelNumber);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "Wechat", this.Wechat);
            this.SetParamSimple(map, prefix + "Email", this.Email);
        }
    }
}

