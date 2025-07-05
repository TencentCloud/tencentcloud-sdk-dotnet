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

    public class DescribeGatewayMonitor : AbstractModel
    {
        
        /// <summary>
        /// 设备接入总数
        /// </summary>
        [JsonProperty("DeviceTotal")]
        public long? DeviceTotal{ get; set; }

        /// <summary>
        /// 设备在线数
        /// </summary>
        [JsonProperty("DeviceOnline")]
        public long? DeviceOnline{ get; set; }

        /// <summary>
        /// 设备离线数
        /// </summary>
        [JsonProperty("DeviceOffline")]
        public long? DeviceOffline{ get; set; }

        /// <summary>
        /// 视频通道总数
        /// </summary>
        [JsonProperty("ChannelTotal")]
        public long? ChannelTotal{ get; set; }

        /// <summary>
        /// 视频通道在线数
        /// </summary>
        [JsonProperty("ChannelOnline")]
        public long? ChannelOnline{ get; set; }

        /// <summary>
        /// 视频通道离线数
        /// </summary>
        [JsonProperty("ChannelOffline")]
        public long? ChannelOffline{ get; set; }

        /// <summary>
        /// 网关上行流量,单位kbps
        /// </summary>
        [JsonProperty("UpFlow")]
        public long? UpFlow{ get; set; }

        /// <summary>
        /// 流在传输中的通道数
        /// </summary>
        [JsonProperty("ChannelPull")]
        public long? ChannelPull{ get; set; }

        /// <summary>
        /// 流未传输中的通道数
        /// </summary>
        [JsonProperty("ChannelUnPull")]
        public long? ChannelUnPull{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceTotal", this.DeviceTotal);
            this.SetParamSimple(map, prefix + "DeviceOnline", this.DeviceOnline);
            this.SetParamSimple(map, prefix + "DeviceOffline", this.DeviceOffline);
            this.SetParamSimple(map, prefix + "ChannelTotal", this.ChannelTotal);
            this.SetParamSimple(map, prefix + "ChannelOnline", this.ChannelOnline);
            this.SetParamSimple(map, prefix + "ChannelOffline", this.ChannelOffline);
            this.SetParamSimple(map, prefix + "UpFlow", this.UpFlow);
            this.SetParamSimple(map, prefix + "ChannelPull", this.ChannelPull);
            this.SetParamSimple(map, prefix + "ChannelUnPull", this.ChannelUnPull);
        }
    }
}

