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

    public class BindUserDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 AppKey，用于解析 IotAppID 并完成签名校验</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名（禁止使用虚拟设备名 ~virtualDev）</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>用户 OpenID，用于定位 / 兜底创建 App 用户</p>
        /// </summary>
        [JsonProperty("OpenID")]
        public string OpenID{ get; set; }

        /// <summary>
        /// <p>家庭名，默认 default</p>
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// <p>房间 ID，默认 &quot;0&quot;</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>用户昵称（仅首次创建用户时使用）</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "OpenID", this.OpenID);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
        }
    }
}

