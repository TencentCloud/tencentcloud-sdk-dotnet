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

    public class VideoInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频开始播放的时间（单位：毫秒）
        /// </summary>
        [JsonProperty("VideoPlayTime")]
        public long? VideoPlayTime{ get; set; }

        /// <summary>
        /// 视频大小（字节）
        /// </summary>
        [JsonProperty("VideoSize")]
        public long? VideoSize{ get; set; }

        /// <summary>
        /// 视频格式
        /// </summary>
        [JsonProperty("VideoFormat")]
        public string VideoFormat{ get; set; }

        /// <summary>
        /// 视频播放时长（单位：毫秒）
        /// </summary>
        [JsonProperty("VideoDuration")]
        public long? VideoDuration{ get; set; }

        /// <summary>
        /// 视频文件URL
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频文件Id
        /// </summary>
        [JsonProperty("VideoId")]
        public string VideoId{ get; set; }

        /// <summary>
        /// 视频流类型 
        /// - 0：摄像头视频 
        /// - 1：屏幕分享视频（仅课后录制支持）
        /// - 2：白板视频 
        /// - 3：混流视频
        /// - 4：纯音频（mp3)
        /// </summary>
        [JsonProperty("VideoType")]
        public long? VideoType{ get; set; }

        /// <summary>
        /// 摄像头/屏幕分享视频所属用户的 Id（白板视频为空、混流视频tic_mixstream_房间号_混流布局类型）
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoPlayTime", this.VideoPlayTime);
            this.SetParamSimple(map, prefix + "VideoSize", this.VideoSize);
            this.SetParamSimple(map, prefix + "VideoFormat", this.VideoFormat);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoId", this.VideoId);
            this.SetParamSimple(map, prefix + "VideoType", this.VideoType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

