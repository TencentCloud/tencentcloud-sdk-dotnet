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

namespace TencentCloud.Yinsuda.V20220527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKTVRobotRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 用户标识。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// RTC厂商类型，取值有：
        /// <li>TRTC</li>
        /// </summary>
        [JsonProperty("RTCSystem")]
        public string RTCSystem{ get; set; }

        /// <summary>
        /// 进房参数。
        /// </summary>
        [JsonProperty("JoinRoomInput")]
        public JoinRoomInput JoinRoomInput{ get; set; }

        /// <summary>
        /// 创建机器人时初始化参数。
        /// </summary>
        [JsonProperty("SyncRobotCommands")]
        public SyncRobotCommand[] SyncRobotCommands{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "RTCSystem", this.RTCSystem);
            this.SetParamObj(map, prefix + "JoinRoomInput.", this.JoinRoomInput);
            this.SetParamArrayObj(map, prefix + "SyncRobotCommands.", this.SyncRobotCommands);
        }
    }
}

