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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSpeciallyQuitWorkOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 设备类型：otherDevice。此接口只支持其他设备
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 交接方式 1.物流上门收货 2.客户上门自提
        /// </summary>
        [JsonProperty("HandoverMethod")]
        public string HandoverMethod{ get; set; }

        /// <summary>
        /// 物流上门收货必传
        /// </summary>
        [JsonProperty("LogisticsReceipt")]
        public LogisticsReceipt LogisticsReceipt{ get; set; }

        /// <summary>
        /// 客户上门自提必传
        /// </summary>
        [JsonProperty("CustomerReceipt")]
        public CustomerReceipt CustomerReceipt{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 当设备类型为otherDevice，此参数必传
        /// </summary>
        [JsonProperty("OtherDeviceList")]
        public OtherDevReceivingInfo[] OtherDeviceList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "HandoverMethod", this.HandoverMethod);
            this.SetParamObj(map, prefix + "LogisticsReceipt.", this.LogisticsReceipt);
            this.SetParamObj(map, prefix + "CustomerReceipt.", this.CustomerReceipt);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "OtherDeviceList.", this.OtherDeviceList);
        }
    }
}

