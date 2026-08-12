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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class App : AbstractModel
    {
        
        /// <summary>
        /// <p>应用程序运行的移动设备的操作系统类型</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>应用程序运行的移动设备的操作系统版本</p>
        /// </summary>
        [JsonProperty("OSVersion")]
        public string OSVersion{ get; set; }

        /// <summary>
        /// <p>应用程序运行的移动设备的生产厂商</p>
        /// </summary>
        [JsonProperty("DeviceManufacturer")]
        public string DeviceManufacturer{ get; set; }

        /// <summary>
        /// <p>应用程序运行的移动设备的型号</p>
        /// </summary>
        [JsonProperty("DeviceModel")]
        public string DeviceModel{ get; set; }

        /// <summary>
        /// <p>应用程序运行的移动设备的唯一ID，对于iOS为IFV标识，对于Android为Android ID</p>
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// <p>应用程序名称</p>
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// <p>应用程序版本</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>应用程序提供的语言</p>
        /// </summary>
        [JsonProperty("ClientLanguage")]
        public string ClientLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamSimple(map, prefix + "OSVersion", this.OSVersion);
            this.SetParamSimple(map, prefix + "DeviceManufacturer", this.DeviceManufacturer);
            this.SetParamSimple(map, prefix + "DeviceModel", this.DeviceModel);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "ClientLanguage", this.ClientLanguage);
        }
    }
}

