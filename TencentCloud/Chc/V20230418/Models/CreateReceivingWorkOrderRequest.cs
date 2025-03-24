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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReceivingWorkOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 机房id
        /// </summary>
        [JsonProperty("IdcId")]
        public ulong? IdcId{ get; set; }

        /// <summary>
        /// 设备类型，server, netDevice, wire, otherDevice
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 进入时间
        /// </summary>
        [JsonProperty("EntryTime")]
        public string EntryTime{ get; set; }

        /// <summary>
        /// 1.收货-仅核对外包装完整和数量，不开箱 2.验收-开箱核对型号SN一致
        /// </summary>
        [JsonProperty("ReceivingOperation")]
        public string ReceivingOperation{ get; set; }

        /// <summary>
        /// 是否快递寄件
        /// </summary>
        [JsonProperty("IsExpressDelivery")]
        public bool? IsExpressDelivery{ get; set; }

        /// <summary>
        /// 快递寄件信息,快递寄件必填
        /// </summary>
        [JsonProperty("ExpressInfo")]
        public ExpressDelivery ExpressInfo{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 服务器收货列表
        /// </summary>
        [JsonProperty("ServerDeviceList")]
        public ServerReceivingInfo[] ServerDeviceList{ get; set; }

        /// <summary>
        /// 网络设备收货列表
        /// </summary>
        [JsonProperty("NetDeviceList")]
        public NetReceivingInfo[] NetDeviceList{ get; set; }

        /// <summary>
        /// 线材收货列表
        /// </summary>
        [JsonProperty("WireDeviceList")]
        public WireReceivingInfo[] WireDeviceList{ get; set; }

        /// <summary>
        /// 其他设备收货列表
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
            this.SetParamSimple(map, prefix + "EntryTime", this.EntryTime);
            this.SetParamSimple(map, prefix + "ReceivingOperation", this.ReceivingOperation);
            this.SetParamSimple(map, prefix + "IsExpressDelivery", this.IsExpressDelivery);
            this.SetParamObj(map, prefix + "ExpressInfo.", this.ExpressInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "ServerDeviceList.", this.ServerDeviceList);
            this.SetParamArrayObj(map, prefix + "NetDeviceList.", this.NetDeviceList);
            this.SetParamArrayObj(map, prefix + "WireDeviceList.", this.WireDeviceList);
            this.SetParamArrayObj(map, prefix + "OtherDeviceList.", this.OtherDeviceList);
        }
    }
}

