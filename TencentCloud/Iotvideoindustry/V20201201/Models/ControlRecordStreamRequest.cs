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

    public class ControlRecordStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备Id，设备的唯一标识
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 流Id，流的唯一标识
        /// </summary>
        [JsonProperty("StreamId")]
        public string StreamId{ get; set; }

        /// <summary>
        /// |控制参数，CmdJson结构转义的json字符串。| Action  | string  |是|控制动作，play(用于暂停后恢复播放)、pause（暂停）、teardown(停止)、jump(拖动播放)
        /// | Offset  | uint  |否|拖动播放时的时间偏移量（相对于起始时间）,单位：秒
        /// 目前支持的command：
        /// "Command": "{"Action":"PAUSE"}" 暂停
        /// "Command": "{"Action":"PLAY"}" 暂停恢复
        /// "Command": "{"Action":"PLAY","Offset":"15"}" 位置偏移，可以替代jump操作
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 通道唯一标识
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "StreamId", this.StreamId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
        }
    }
}

