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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备ID（从获取设备列表接口ListDevices中获取）
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备名称（仅支持中文、英文、数字、空格、中英文括号、_、-, 长度不超过128位）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 设备流传输协议，仅国标设备有效，填0则不做更改（1:UDP,2:TCP）
        /// </summary>
        [JsonProperty("TransportProtocol")]
        public long? TransportProtocol{ get; set; }

        /// <summary>
        /// 设备密码（仅国标，网关设备支持，长度不超过 64 位）
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 设备描述（长度不超过128位）
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 设备接入Ip（仅网关接入支持）
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 设备Port（仅网关接入支持）
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 设备用户名（仅网关接入支持）
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 网关设备接入协议（仅网关接入支持）
        /// </summary>
        [JsonProperty("ProtocolType")]
        public long? ProtocolType{ get; set; }

        /// <summary>
        /// 音频关开（0：关闭；1：开启）默认开启，关闭时丢弃音频
        /// </summary>
        [JsonProperty("AudioSwitch")]
        public long? AudioSwitch{ get; set; }

        /// <summary>
        /// 订阅开关（0：关闭；1：开启）默认开启，开启状态下会订阅设备通道变化，仅国标NVR设备有效
        /// </summary>
        [JsonProperty("SubscribeSwitch")]
        public long? SubscribeSwitch{ get; set; }

        /// <summary>
        /// 是否开启静音帧（0：关闭；1 开启）
        /// </summary>
        [JsonProperty("SilentFrameSwitch")]
        public long? SilentFrameSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TransportProtocol", this.TransportProtocol);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "AudioSwitch", this.AudioSwitch);
            this.SetParamSimple(map, prefix + "SubscribeSwitch", this.SubscribeSwitch);
            this.SetParamSimple(map, prefix + "SilentFrameSwitch", this.SilentFrameSwitch);
        }
    }
}

