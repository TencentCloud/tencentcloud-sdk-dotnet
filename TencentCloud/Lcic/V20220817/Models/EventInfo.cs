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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventInfo : AbstractModel
    {
        
        /// <summary>
        /// 事件发生的秒级unix时间戳。
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// 事件类型,有以下值:
        /// RoomStart:房间开始 RoomEnd:房间结束 MemberJoin:成员加入 MemberQuit:成员退出 RecordFinish:录制结束
        /// CameraOn: 摄像头打开
        /// CameraOff: 摄像头关闭
        /// MicOn: 麦克风打开
        /// MicOff: 麦克风关闭
        /// ScreenOn: 屏幕共享打开
        /// ScreenOff: 屏幕共享关闭
        /// VisibleOn: 页面可见
        /// VisibleOff: 页面不可见
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件详细内容，包含房间号,成员类型事件包含用户Id。
        /// </summary>
        [JsonProperty("EventData")]
        public EventDataInfo EventData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamObj(map, prefix + "EventData.", this.EventData);
        }
    }
}

