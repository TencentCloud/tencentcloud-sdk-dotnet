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

    public class DeviceOrderBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 机房名称
        /// </summary>
        [JsonProperty("IdcName")]
        public string IdcName{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 1.收货-仅核对外包装完整和数量，不开箱 2.验收-开箱核对型号SN一致
        /// </summary>
        [JsonProperty("ReceivingOperation")]
        public string ReceivingOperation{ get; set; }

        /// <summary>
        /// 设备收货-进入时间
        /// </summary>
        [JsonProperty("EntryTime")]
        public string EntryTime{ get; set; }

        /// <summary>
        /// 设备收货-是否快递寄件
        /// </summary>
        [JsonProperty("IsExpressDelivery")]
        public bool? IsExpressDelivery{ get; set; }

        /// <summary>
        /// 设备收货-快递寄件信息
        /// </summary>
        [JsonProperty("ExpressInfo")]
        public ExpressDelivery ExpressInfo{ get; set; }

        /// <summary>
        /// 上/下架人员 1.自行解决 2.由腾讯IDC负责
        /// </summary>
        [JsonProperty("StuffOption")]
        public string StuffOption{ get; set; }

        /// <summary>
        /// 上/下架自行解决信息
        /// </summary>
        [JsonProperty("SelfOperationInfo")]
        public SelfOperation SelfOperationInfo{ get; set; }

        /// <summary>
        /// 上架后开电
        /// </summary>
        [JsonProperty("WithPowerOn")]
        public bool? WithPowerOn{ get; set; }

        /// <summary>
        /// 关电确认 1.授权时关电 2.关电前需要确认
        /// </summary>
        [JsonProperty("IsPowerOffConfirm")]
        public string IsPowerOffConfirm{ get; set; }

        /// <summary>
        /// 关电前需要确认信息
        /// </summary>
        [JsonProperty("PowerOffConfirmInfo")]
        public PowerOffConfirm PowerOffConfirmInfo{ get; set; }

        /// <summary>
        /// 退出交接方式 1.物流上门收货 2.客户上门自提
        /// </summary>
        [JsonProperty("HandoverMethod")]
        public string HandoverMethod{ get; set; }

        /// <summary>
        /// 客户上门自提信息
        /// </summary>
        [JsonProperty("CustomerReceipt")]
        public CustomerReceipt CustomerReceipt{ get; set; }

        /// <summary>
        /// 物流上门收货信息
        /// </summary>
        [JsonProperty("LogisticsReceipt")]
        public LogisticsReceipt LogisticsReceipt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdcId", this.IdcId);
            this.SetParamSimple(map, prefix + "IdcName", this.IdcName);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ReceivingOperation", this.ReceivingOperation);
            this.SetParamSimple(map, prefix + "EntryTime", this.EntryTime);
            this.SetParamSimple(map, prefix + "IsExpressDelivery", this.IsExpressDelivery);
            this.SetParamObj(map, prefix + "ExpressInfo.", this.ExpressInfo);
            this.SetParamSimple(map, prefix + "StuffOption", this.StuffOption);
            this.SetParamObj(map, prefix + "SelfOperationInfo.", this.SelfOperationInfo);
            this.SetParamSimple(map, prefix + "WithPowerOn", this.WithPowerOn);
            this.SetParamSimple(map, prefix + "IsPowerOffConfirm", this.IsPowerOffConfirm);
            this.SetParamObj(map, prefix + "PowerOffConfirmInfo.", this.PowerOffConfirmInfo);
            this.SetParamSimple(map, prefix + "HandoverMethod", this.HandoverMethod);
            this.SetParamObj(map, prefix + "CustomerReceipt.", this.CustomerReceipt);
            this.SetParamObj(map, prefix + "LogisticsReceipt.", this.LogisticsReceipt);
        }
    }
}

