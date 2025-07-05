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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Events : AbstractModel
    {
        
        /// <summary>
        /// 开始时间，秒级时间戳
        /// </summary>
        [JsonProperty("EventTime")]
        public long? EventTime{ get; set; }

        /// <summary>
        /// 事件类型 1:注册 2:心跳 4:录制异常 5:播放异常 6:流中断
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("EventDesc")]
        public string EventDesc{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// 设备地址
        /// </summary>
        [JsonProperty("DeviceAddress")]
        public string DeviceAddress{ get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 通道Id
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 事件日志
        /// </summary>
        [JsonProperty("EventLog")]
        public string EventLog{ get; set; }

        /// <summary>
        /// 设备备注名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventDesc", this.EventDesc);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "DeviceAddress", this.DeviceAddress);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "EventLog", this.EventLog);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
        }
    }
}

