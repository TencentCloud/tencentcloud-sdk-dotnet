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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BiddingAppointResult : AbstractModel
    {
        
        /// <summary>
        /// 预约ID
        /// </summary>
        [JsonProperty("BusinessID")]
        public string BusinessID{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 预定价格 单位元
        /// </summary>
        [JsonProperty("AppointPrice")]
        public ulong? AppointPrice{ get; set; }

        /// <summary>
        /// 预约保证金 单位元
        /// </summary>
        [JsonProperty("AppointBondPrice")]
        public ulong? AppointBondPrice{ get; set; }

        /// <summary>
        /// 预约结束时间
        /// </summary>
        [JsonProperty("AppointEndTime")]
        public string AppointEndTime{ get; set; }

        /// <summary>
        /// 预约人数
        /// </summary>
        [JsonProperty("AppointNum")]
        public ulong? AppointNum{ get; set; }

        /// <summary>
        /// 1 已预约，2 竞价中，3 等待出价 4 竞价失败 5 等待支付 6 等待转移，7 转移中 8 交易成功 9 预约持有者赎回 10 竞价持有者赎回 11 其他阶段持有者赎回 12 违约
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessID", this.BusinessID);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AppointPrice", this.AppointPrice);
            this.SetParamSimple(map, prefix + "AppointBondPrice", this.AppointBondPrice);
            this.SetParamSimple(map, prefix + "AppointEndTime", this.AppointEndTime);
            this.SetParamSimple(map, prefix + "AppointNum", this.AppointNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

