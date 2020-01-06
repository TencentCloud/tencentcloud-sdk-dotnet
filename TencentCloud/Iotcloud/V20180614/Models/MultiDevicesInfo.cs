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

    public class MultiDevicesInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 对称加密密钥，base64 编码，采用对称加密时返回该参数
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// 设备证书，采用非对称加密时返回该参数
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// 设备私钥，采用非对称加密时返回该参数，腾讯云为用户缓存起来，其生命周期与任务生命周期一致
        /// </summary>
        [JsonProperty("DevicePrivateKey")]
        public string DevicePrivateKey{ get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("Result")]
        public ulong? Result{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "DevicePrivateKey", this.DevicePrivateKey);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
        }
    }
}

