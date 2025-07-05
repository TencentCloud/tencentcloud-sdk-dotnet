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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpertServiceOrderInfo : AbstractModel
    {
        
        /// <summary>
        /// 订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public ulong? OrderId{ get; set; }

        /// <summary>
        /// 订单类型 1应急 2 旗舰重保 3 安全管家
        /// </summary>
        [JsonProperty("InquireType")]
        public ulong? InquireType{ get; set; }

        /// <summary>
        /// 服务数量
        /// </summary>
        [JsonProperty("InquireNum")]
        public ulong? InquireNum{ get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 服务时长几个月
        /// </summary>
        [JsonProperty("ServiceTime")]
        public ulong? ServiceTime{ get; set; }

        /// <summary>
        /// 订单状态 0 未启动 1 服务中 2已过期 3完成，4退费销毁
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "InquireType", this.InquireType);
            this.SetParamSimple(map, prefix + "InquireNum", this.InquireNum);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceTime", this.ServiceTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

