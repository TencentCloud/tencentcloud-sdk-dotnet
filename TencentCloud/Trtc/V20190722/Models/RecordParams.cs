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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordParams : AbstractModel
    {
        
        /// <summary>
        /// 录制模式：
        /// 1：单流录制，分别录制房间的订阅UserId的音频和视频，将录制文件上传至云存储；
        /// 2：混流录制，将房间内订阅UserId的音视频混录成一个音视频文件，将录制文件上传至云存储；
        /// </summary>
        [JsonProperty("RecordMode")]
        public ulong? RecordMode{ get; set; }

        /// <summary>
        /// 房间内持续没有主播的状态超过MaxIdleTime的时长，自动停止录制，单位：秒。默认值为 30 秒，该值需大于等于 5秒，且小于等于 86400秒(24小时)。
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// 录制的媒体流类型：
        /// 0：录制音频+视频流（默认）;
        /// 1：仅录制音频流；
        /// 2：仅录制视频流，
        /// </summary>
        [JsonProperty("StreamType")]
        public ulong? StreamType{ get; set; }

        /// <summary>
        /// 指定订阅流白名单或者黑名单。
        /// </summary>
        [JsonProperty("SubscribeStreamUserIds")]
        public SubscribeStreamUserIds SubscribeStreamUserIds{ get; set; }

        /// <summary>
        /// 输出文件的格式，上传到云点播时此参数无效，存储到云点播时请关注TencentVod内的MediaType参数。0：(默认)输出文件为hls格式。1：输出文件格式为hls+mp4（hls录制完成后转mp4文件）。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public ulong? OutputFormat{ get; set; }

        /// <summary>
        /// 单流录制模式下，用户的音视频是否合并，0：单流音视频不合并（默认）。1：单流音视频合并成一个ts。混流录制此参数无需设置，默认音视频合并。
        /// </summary>
        [JsonProperty("AvMerge")]
        public ulong? AvMerge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordMode", this.RecordMode);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamObj(map, prefix + "SubscribeStreamUserIds.", this.SubscribeStreamUserIds);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "AvMerge", this.AvMerge);
        }
    }
}

