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

    public class CreateQuitWorkOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 设备类型，server, netDevice, otherDevice
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 下架选择 1.自行解决 2.由腾讯IDC负责
        /// </summary>
        [JsonProperty("StuffOption")]
        public string StuffOption{ get; set; }

        /// <summary>
        /// 关电确认 1.授权时关电 2.关电前需要确认
        /// </summary>
        [JsonProperty("IsPowerOffConfirm")]
        public string IsPowerOffConfirm{ get; set; }

        /// <summary>
        /// 设备sn列表
        /// </summary>
        [JsonProperty("DeviceSnList")]
        public string[] DeviceSnList{ get; set; }

        /// <summary>
        /// 交接方式 1.物流上门收货 2.客户上门自提
        /// </summary>
        [JsonProperty("HandoverMethod")]
        public string HandoverMethod{ get; set; }

        /// <summary>
        /// 自行解决必填
        /// </summary>
        [JsonProperty("SelfOperationInfo")]
        public SelfOperation SelfOperationInfo{ get; set; }

        /// <summary>
        /// 关电前需要确认时必填
        /// </summary>
        [JsonProperty("PowerOffConfirmInfo")]
        public PowerOffConfirm PowerOffConfirmInfo{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "StuffOption", this.StuffOption);
            this.SetParamSimple(map, prefix + "IsPowerOffConfirm", this.IsPowerOffConfirm);
            this.SetParamArraySimple(map, prefix + "DeviceSnList.", this.DeviceSnList);
            this.SetParamSimple(map, prefix + "HandoverMethod", this.HandoverMethod);
            this.SetParamObj(map, prefix + "SelfOperationInfo.", this.SelfOperationInfo);
            this.SetParamObj(map, prefix + "PowerOffConfirmInfo.", this.PowerOffConfirmInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "LogisticsReceipt.", this.LogisticsReceipt);
            this.SetParamObj(map, prefix + "CustomerReceipt.", this.CustomerReceipt);
        }
    }
}

