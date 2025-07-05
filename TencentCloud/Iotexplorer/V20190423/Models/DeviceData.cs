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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceData : AbstractModel
    {
        
        /// <summary>
        /// 设备证书，用于 TLS 建立链接时校验客户端身份。采用非对称加密时返回该参数。
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// 设备名称。
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备私钥，用于 TLS 建立链接时校验客户端身份，腾讯云后台不保存，请妥善保管。采用非对称加密时返回该参数。
        /// </summary>
        [JsonProperty("DevicePrivateKey")]
        public string DevicePrivateKey{ get; set; }

        /// <summary>
        /// 对称加密密钥，base64编码。采用对称加密时返回该参数。
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DevicePrivateKey", this.DevicePrivateKey);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
        }
    }
}

