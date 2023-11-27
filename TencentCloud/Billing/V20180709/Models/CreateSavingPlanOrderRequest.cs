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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSavingPlanOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 预付费类型
        /// </summary>
        [JsonProperty("PrePayType")]
        public string PrePayType{ get; set; }

        /// <summary>
        /// 时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 时长单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 商品唯一标识
        /// </summary>
        [JsonProperty("CommodityCode")]
        public string CommodityCode{ get; set; }

        /// <summary>
        /// 承诺时长内的小额金额（单位：元）
        /// </summary>
        [JsonProperty("PromiseUseAmount")]
        public ulong? PromiseUseAmount{ get; set; }

        /// <summary>
        /// 节省计划的指定生效时间，若不传则为当前下单时间。传参数格式:"2023-10-01 00:00:00"，仅支持指定日期的0点时刻
        /// </summary>
        [JsonProperty("SpecifyEffectTime")]
        public string SpecifyEffectTime{ get; set; }

        /// <summary>
        /// 可重入ID
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }


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
        }
    }
}

