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

namespace TencentCloud.Svp.V20240125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SavingPlanOverviewDetail : AbstractModel
    {
        
        /// <summary>
        /// 节省计划类型
        /// </summary>
        [JsonProperty("SpType")]
        public string SpType{ get; set; }

        /// <summary>
        /// 支付金额（单位：元）
        /// </summary>
        [JsonProperty("PayAmount")]
        public string PayAmount{ get; set; }

        /// <summary>
        /// 开始时间 yyyy-mm-dd HH:mm:ss格式
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间 yyyy-mm-dd HH:mm:ss格式
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 累计节省金额（单位：元）
        /// </summary>
        [JsonProperty("SavingAmount")]
        public string SavingAmount{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [JsonProperty("PayType")]
        public ulong? PayType{ get; set; }

        /// <summary>
        /// 购买时间 yyyy-mm-dd HH:mm:ss格式
        /// </summary>
        [JsonProperty("BuyTime")]
        public string BuyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpType", this.SpType);
            this.SetParamSimple(map, prefix + "PayAmount", this.PayAmount);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SavingAmount", this.SavingAmount);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "BuyTime", this.BuyTime);
        }
    }
}

