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

    public class FeeRangInfo : AbstractModel
    {
        
        /// <summary>
        /// 卡类型，银联产品使用 
        /// DEBIT：借记卡 
        /// CREDIT：贷记卡
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// 区间起始金额，单位（分）
        /// </summary>
        [JsonProperty("RangeStartValue")]
        public ulong? RangeStartValue{ get; set; }

        /// <summary>
        /// 区间结束金额，单位（分）
        /// </summary>
        [JsonProperty("RangeEndValue")]
        public ulong? RangeEndValue{ get; set; }

        /// <summary>
        /// 分段计费模式 
        /// SINGLE：按金额计费 
        /// RATIO：按费率计费
        /// </summary>
        [JsonProperty("RangeFeeMode")]
        public string RangeFeeMode{ get; set; }

        /// <summary>
        /// 费用值，单位（0.01%或分）
        /// </summary>
        [JsonProperty("FeeValue")]
        public ulong? FeeValue{ get; set; }

        /// <summary>
        /// 最低收费金额，单位（分）
        /// </summary>
        [JsonProperty("MinFee")]
        public ulong? MinFee{ get; set; }

        /// <summary>
        /// 最高收费金额，单位（分）
        /// </summary>
        [JsonProperty("MaxFee")]
        public ulong? MaxFee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "RangeStartValue", this.RangeStartValue);
            this.SetParamSimple(map, prefix + "RangeEndValue", this.RangeEndValue);
            this.SetParamSimple(map, prefix + "RangeFeeMode", this.RangeFeeMode);
            this.SetParamSimple(map, prefix + "FeeValue", this.FeeValue);
            this.SetParamSimple(map, prefix + "MinFee", this.MinFee);
            this.SetParamSimple(map, prefix + "MaxFee", this.MaxFee);
        }
    }
}

