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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewDiskChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// 续费周期。
        /// 单位：月。
        /// 取值范围: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36]
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 自动续费标识。
        /// 取值范围：
        /// <li>NOTIFY_AND_AUTO_RENEW：通知过期且自动续费</li>
        /// <li>NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费，用户需要手动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW：不自动续费，且不通知</li>
        /// 默认取值：NOTIFY_AND_MANUAL_RENEW。若该参数指定为NOTIFY_AND_AUTO_RENEW，在账户余额充足的情况下，云硬盘到期后将按月自动续费。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 周期单位。取值范围：“m”(月)。默认值: "m"。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 当前实例到期时间。如“2018-01-01 00:00:00”。
        /// 指定该参数即可对齐云硬盘所挂载的实例到期时间。
        /// 该参数与Period必须指定其一，且不支持同时指定。
        /// 该参数值必须大于入参中云硬盘的过期时间。
        /// </summary>
        [JsonProperty("CurInstanceDeadline")]
        public string CurInstanceDeadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "CurInstanceDeadline", this.CurInstanceDeadline);
        }
    }
}

