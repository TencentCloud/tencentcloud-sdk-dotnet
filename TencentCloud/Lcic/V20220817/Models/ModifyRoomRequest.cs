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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// 房间ID。
        /// </summary>
        [JsonProperty("RoomId")]
        public ulong? RoomId{ get; set; }

        /// <summary>
        /// 低代码互动课堂的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 预定的房间开始时间，unix时间戳。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 预定的房间结束时间，unix时间戳。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 老师ID。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("TeacherId")]
        public string TeacherId{ get; set; }

        /// <summary>
        /// 房间名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分辨率。可以有如下取值：
        /// 1 标清
        /// 2 高清
        /// 3 全高清
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("Resolution")]
        public ulong? Resolution{ get; set; }

        /// <summary>
        /// 最大连麦人数（不包括老师）。取值范围[0, 17)
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("MaxMicNumber")]
        public ulong? MaxMicNumber{ get; set; }

        /// <summary>
        /// 进入房间时是否自动连麦。可以有以下取值：
        /// 0 不自动连麦（默认值）
        /// 1 自动连麦
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("AutoMic")]
        public ulong? AutoMic{ get; set; }

        /// <summary>
        /// 高音质模式。可以有以下取值：
        /// 0 不开启高音质（默认值）
        /// 1 开启高音质
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("AudioQuality")]
        public ulong? AudioQuality{ get; set; }

        /// <summary>
        /// 房间子类型，可以有以下取值：
        /// videodoc 文档+视频
        /// video 纯视频
        /// coteaching 双师
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 禁止录制。可以有以下取值：
        /// 0 不禁止录制（默认值）
        /// 1 禁止录制
        /// 直播开始后不允许修改。
        /// </summary>
        [JsonProperty("DisableRecord")]
        public ulong? DisableRecord{ get; set; }

        /// <summary>
        /// 助教Id列表。直播开始后不允许修改。
        /// </summary>
        [JsonProperty("Assistants")]
        public string[] Assistants{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TeacherId", this.TeacherId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MaxMicNumber", this.MaxMicNumber);
            this.SetParamSimple(map, prefix + "AutoMic", this.AutoMic);
            this.SetParamSimple(map, prefix + "AudioQuality", this.AudioQuality);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "DisableRecord", this.DisableRecord);
            this.SetParamArraySimple(map, prefix + "Assistants.", this.Assistants);
        }
    }
}

