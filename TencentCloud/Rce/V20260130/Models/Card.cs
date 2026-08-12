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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Card : AbstractModel
    {
        
        /// <summary>
        /// <p>发卡行识别码卡号前6位</p><p>参数格式：符合ISO 13616-1标准</p>
        /// </summary>
        [JsonProperty("CardBin")]
        public string CardBin{ get; set; }

        /// <summary>
        /// <p>发卡行识别码卡号后4位</p><p>参数格式：符合ISO 13616-1标准</p>
        /// </summary>
        [JsonProperty("LastFourDigits")]
        public string LastFourDigits{ get; set; }

        /// <summary>
        /// <p>发行国家</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// <p>发行银行</p>
        /// </summary>
        [JsonProperty("Bank")]
        public string Bank{ get; set; }

        /// <summary>
        /// <p>支付卡类型</p><p>枚举值：</p><ul><li>credit： 信用卡</li><li>debit： 借记卡</li><li>charge： 签账卡</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>支付卡品牌</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>支付卡等级</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>持有者姓名</p>
        /// </summary>
        [JsonProperty("HolderName")]
        public string HolderName{ get; set; }

        /// <summary>
        /// <p>过期日期</p><p>参数格式：YYYY-MM-DD</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CardBin", this.CardBin);
            this.SetParamSimple(map, prefix + "LastFourDigits", this.LastFourDigits);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Bank", this.Bank);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "HolderName", this.HolderName);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

