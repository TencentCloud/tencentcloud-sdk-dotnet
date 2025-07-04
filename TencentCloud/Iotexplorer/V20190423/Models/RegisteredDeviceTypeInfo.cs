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

    public class RegisteredDeviceTypeInfo : AbstractModel
    {
        
        /// <summary>
        /// 已注册设备数
        /// </summary>
        [JsonProperty("NormalDeviceNum")]
        public long? NormalDeviceNum{ get; set; }

        /// <summary>
        /// 已注册网关数
        /// </summary>
        [JsonProperty("GatewayDeviceNum")]
        public long? GatewayDeviceNum{ get; set; }

        /// <summary>
        /// 已注册子设备数
        /// </summary>
        [JsonProperty("SubDeviceNum")]
        public long? SubDeviceNum{ get; set; }

        /// <summary>
        /// 已注册视频设备数
        /// </summary>
        [JsonProperty("VideoDeviceNum")]
        public long? VideoDeviceNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NormalDeviceNum", this.NormalDeviceNum);
            this.SetParamSimple(map, prefix + "GatewayDeviceNum", this.GatewayDeviceNum);
            this.SetParamSimple(map, prefix + "SubDeviceNum", this.SubDeviceNum);
            this.SetParamSimple(map, prefix + "VideoDeviceNum", this.VideoDeviceNum);
        }
    }
}

