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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDeviceResponse : AbstractModel
    {
        
        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 对称加密密钥，base64编码。采用对称加密时返回该参数
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// 设备证书，用于 TLS 建立链接时校验客户端身份。采用非对称加密时返回该参数
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// 设备私钥，用于 TLS 建立链接时校验客户端身份，腾讯云后台不保存，请妥善保管。采用非对称加密时返回该参数
        /// </summary>
        [JsonProperty("DevicePrivateKey")]
        public string DevicePrivateKey{ get; set; }

        /// <summary>
        /// LoRa设备的DevEui，当设备是LoRa设备时，会返回该字段
        /// </summary>
        [JsonProperty("LoraDevEui")]
        public string LoraDevEui{ get; set; }

        /// <summary>
        /// LoRa设备的MoteType，当设备是LoRa设备时，会返回该字段
        /// </summary>
        [JsonProperty("LoraMoteType")]
        public ulong? LoraMoteType{ get; set; }

        /// <summary>
        /// LoRa设备的AppKey，当设备是LoRa设备时，会返回该字段
        /// </summary>
        [JsonProperty("LoraAppKey")]
        public string LoraAppKey{ get; set; }

        /// <summary>
        /// LoRa设备的NwkKey，当设备是LoRa设备时，会返回该字段
        /// </summary>
        [JsonProperty("LoraNwkKey")]
        public string LoraNwkKey{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "DevicePrivateKey", this.DevicePrivateKey);
            this.SetParamSimple(map, prefix + "LoraDevEui", this.LoraDevEui);
            this.SetParamSimple(map, prefix + "LoraMoteType", this.LoraMoteType);
            this.SetParamSimple(map, prefix + "LoraAppKey", this.LoraAppKey);
            this.SetParamSimple(map, prefix + "LoraNwkKey", this.LoraNwkKey);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

