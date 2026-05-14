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

namespace TencentCloud.Svp.V20240125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSavingPlanOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>地域编码</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>区域编码</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// <p>预付费类型</p><p>枚举值：</p><ul><li>1： 全预费</li><li>2： 部分预付</li><li>3： 不预付</li></ul>
        /// </summary>
        [JsonProperty("PrePayType")]
        public string PrePayType{ get; set; }

        /// <summary>
        /// <p>时长</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>时长单位</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>商品唯一标识</p>
        /// </summary>
        [JsonProperty("CommodityCode")]
        public string CommodityCode{ get; set; }

        /// <summary>
        /// <p>承诺时长内的小额金额（单位：元）</p>
        /// </summary>
        [JsonProperty("PromiseUseAmount")]
        public long? PromiseUseAmount{ get; set; }

        /// <summary>
        /// <p>节省计划的指定生效时间，若不传则为当前下单时间。传参数格式:&quot;2023-10-01 00:00:00&quot;，仅支持指定日期的0点时刻</p>
        /// </summary>
        [JsonProperty("SpecifyEffectTime")]
        public string SpecifyEffectTime{ get; set; }

        /// <summary>
        /// <p>可重入ID</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>节省计划结算类型</p><p>枚举值：</p><ul><li>1： 小时结算包</li><li>2： 日结算包</li><li>3： 月结算包</li></ul><p>默认值：1</p><p>不填写是默认是小时结算包</p>
        /// </summary>
        [JsonProperty("CommitmentPeriod")]
        public long? CommitmentPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PrePayType", this.PrePayType);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "CommodityCode", this.CommodityCode);
            this.SetParamSimple(map, prefix + "PromiseUseAmount", this.PromiseUseAmount);
            this.SetParamSimple(map, prefix + "SpecifyEffectTime", this.SpecifyEffectTime);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "CommitmentPeriod", this.CommitmentPeriod);
        }
    }
}

