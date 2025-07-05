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

    public class OpenBankSceneInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户端实际 ip。汇付渠道必填。
        /// </summary>
        [JsonProperty("PayerClientIp")]
        public string PayerClientIp{ get; set; }

        /// <summary>
        /// 浏览器 User-Agent。
        /// </summary>
        [JsonProperty("PayerUa")]
        public string PayerUa{ get; set; }

        /// <summary>
        /// 用户下单时间。若不上送，服务端默认当前时间。
        /// </summary>
        [JsonProperty("OrderTime")]
        public string OrderTime{ get; set; }

        /// <summary>
        /// 终端设备号（门店号或收银设备 ID），示例值：POS1:1。
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 终端设备类型。MOBILE_BROWSER:手机浏览器，MOBILE_APP:手机应用程序，TABLET:平板；WATCH:手表，PC:电脑PC，OTHER:其他。
        /// 汇付渠道必填。
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerClientIp", this.PayerClientIp);
            this.SetParamSimple(map, prefix + "PayerUa", this.PayerUa);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
        }
    }
}

