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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetRenewalRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品编码。
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 地域编码。
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 实例ID，仅支持指定一个。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 续费标识。枚举值如下：
        /// NOTIFY_AND_MANUAL_RENEW：手动续费
        /// NOTIFY_AND_AUTO_RENEW：自动续费
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW：到期不续
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 自动续费周期长度，不填写时默认按产品侧设置的默认值
        /// 如果是月，支持：1-11
        /// 如果是年，支持：1-5
        /// 实际按产品侧支持的范围为主
        /// </summary>
        [JsonProperty("RenewPeriod")]
        public string RenewPeriod{ get; set; }

        /// <summary>
        /// 自动续费周期单位，不填写时默认按产品侧设置的默认值
        /// y 年，m 月
        /// 实际按产品侧支持的范围为主
        /// </summary>
        [JsonProperty("RenewPeriodUnit")]
        public string RenewPeriodUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "RenewPeriod", this.RenewPeriod);
            this.SetParamSimple(map, prefix + "RenewPeriodUnit", this.RenewPeriodUnit);
        }
    }
}

