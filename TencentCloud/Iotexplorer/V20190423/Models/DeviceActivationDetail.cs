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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceActivationDetail : AbstractModel
    {
        
        /// <summary>
        /// 可注册设备数
        /// </summary>
        [JsonProperty("TotalDeviceNum")]
        public long? TotalDeviceNum{ get; set; }

        /// <summary>
        /// 已注册设备数
        /// </summary>
        [JsonProperty("UsedDeviceNum")]
        public long? UsedDeviceNum{ get; set; }

        /// <summary>
        /// 设备授权数
        /// </summary>
        [JsonProperty("TotalNormalLicense")]
        public long? TotalNormalLicense{ get; set; }

        /// <summary>
        /// 已使用设备授权数
        /// </summary>
        [JsonProperty("UsedNormalLicense")]
        public long? UsedNormalLicense{ get; set; }

        /// <summary>
        /// 蓝牙授权数
        /// </summary>
        [JsonProperty("TotalBluetoothLicense")]
        public long? TotalBluetoothLicense{ get; set; }

        /// <summary>
        /// 已使用蓝牙授权数
        /// </summary>
        [JsonProperty("UsedBluetoothLicense")]
        public long? UsedBluetoothLicense{ get; set; }

        /// <summary>
        /// 可免费注册设备数
        /// </summary>
        [JsonProperty("TotalFreeLicense")]
        public long? TotalFreeLicense{ get; set; }

        /// <summary>
        /// 已使用注册设备数
        /// </summary>
        [JsonProperty("UsedFreeLicense")]
        public long? UsedFreeLicense{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalDeviceNum", this.TotalDeviceNum);
            this.SetParamSimple(map, prefix + "UsedDeviceNum", this.UsedDeviceNum);
            this.SetParamSimple(map, prefix + "TotalNormalLicense", this.TotalNormalLicense);
            this.SetParamSimple(map, prefix + "UsedNormalLicense", this.UsedNormalLicense);
            this.SetParamSimple(map, prefix + "TotalBluetoothLicense", this.TotalBluetoothLicense);
            this.SetParamSimple(map, prefix + "UsedBluetoothLicense", this.UsedBluetoothLicense);
            this.SetParamSimple(map, prefix + "TotalFreeLicense", this.TotalFreeLicense);
            this.SetParamSimple(map, prefix + "UsedFreeLicense", this.UsedFreeLicense);
        }
    }
}

