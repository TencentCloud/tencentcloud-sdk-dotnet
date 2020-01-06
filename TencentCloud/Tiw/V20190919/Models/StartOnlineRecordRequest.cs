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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartOnlineRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户的SdkAppId
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 需要录制的房间号
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// 用于实时录制服务进房的用户Id，格式为`tic_record_user_${RoomId}_${Random}`，其中 `${RoomId}` 与录制房间号对应，`${Random}`为一个随机字符串。
        /// 实时录制服务会使用这个用户Id进房进行录制房间内的音视频与白板，为了防止进房冲突，请保证此 用户Id不重复
        /// </summary>
        [JsonProperty("RecordUserId")]
        public string RecordUserId{ get; set; }

        /// <summary>
        /// 与RecordUserId对应的签名
        /// </summary>
        [JsonProperty("RecordUserSig")]
        public string RecordUserSig{ get; set; }

        /// <summary>
        /// 白板的 IM 群组 Id，默认同房间号
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 实时录制视频拼接参数
        /// </summary>
        [JsonProperty("Concat")]
        public Concat Concat{ get; set; }

        /// <summary>
        /// 实时录制白板参数，例如白板宽高等
        /// </summary>
        [JsonProperty("Whiteboard")]
        public Whiteboard Whiteboard{ get; set; }

        /// <summary>
        /// 实时录制混流参数
        /// 特别说明：
        /// 1. 混流功能需要根据额外开通， 请联系腾讯云互动白板客服人员
        /// 2. 使用混流功能，必须提供 Extras 参数，且 Extras 参数中必须包含 "MIX_STREAM"
        /// </summary>
        [JsonProperty("MixStream")]
        public MixStream MixStream{ get; set; }

        /// <summary>
        /// 使用到的高级功能列表
        /// 可以选值列表：
        /// MIX_STREAM - 混流功能
        /// </summary>
        [JsonProperty("Extras")]
        public string[] Extras{ get; set; }

        /// <summary>
        /// 是否需要在结果回调中返回各路流的纯音频录制文件，文件格式为mp3
        /// </summary>
        [JsonProperty("AudioFileNeeded")]
        public bool? AudioFileNeeded{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RecordUserId", this.RecordUserId);
            this.SetParamSimple(map, prefix + "RecordUserSig", this.RecordUserSig);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamObj(map, prefix + "Concat.", this.Concat);
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamObj(map, prefix + "MixStream.", this.MixStream);
            this.SetParamArraySimple(map, prefix + "Extras.", this.Extras);
            this.SetParamSimple(map, prefix + "AudioFileNeeded", this.AudioFileNeeded);
        }
    }
}

