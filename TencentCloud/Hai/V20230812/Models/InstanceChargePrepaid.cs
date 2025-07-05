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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceChargePrepaid : AbstractModel
    {
        
        /// <summary>
        /// 时长，默认值：1
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 续费标志可选参数：
        /// NOTIFY_AND_MANUAL_RENEW：表示默认状态(用户未设置，即初始状态：若用户有预付费不停服特权，也会对该值进行自动续费)
        /// NOTIFY_AND_AUTO_RENEW：表示自动续费
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW：表示明确不自动续费(用户设置)
        /// 默认值：NOTIFY_AND_MANUAL_RENEW
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 时长单位，枚举： MONTH, DAY, HOUR；释义：月，日，小时
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
        }
    }
}

