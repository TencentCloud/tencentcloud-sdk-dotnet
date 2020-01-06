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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushDataInfo : AbstractModel
    {
        
        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 推流路径。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流客户端ip。
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 接流服务器ip。
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }

        /// <summary>
        /// 推流视频帧率，单位是Hz。
        /// </summary>
        [JsonProperty("VideoFps")]
        public ulong? VideoFps{ get; set; }

        /// <summary>
        /// 推流视频码率，单位是bps。
        /// </summary>
        [JsonProperty("VideoSpeed")]
        public ulong? VideoSpeed{ get; set; }

        /// <summary>
        /// 推流音频帧率，单位是Hz。
        /// </summary>
        [JsonProperty("AudioFps")]
        public ulong? AudioFps{ get; set; }

        /// <summary>
        /// 推流音频码率，单位是bps。
        /// </summary>
        [JsonProperty("AudioSpeed")]
        public ulong? AudioSpeed{ get; set; }

        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// 推流开始时间。
        /// </summary>
        [JsonProperty("BeginPushTime")]
        public string BeginPushTime{ get; set; }

        /// <summary>
        /// 音频编码格式，
        /// 例："AAC"。
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// 视频编码格式，
        /// 例："H264"。
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// 分辨率。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 采样率。
        /// </summary>
        [JsonProperty("AsampleRate")]
        public ulong? AsampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
            this.SetParamSimple(map, prefix + "VideoFps", this.VideoFps);
            this.SetParamSimple(map, prefix + "VideoSpeed", this.VideoSpeed);
            this.SetParamSimple(map, prefix + "AudioFps", this.AudioFps);
            this.SetParamSimple(map, prefix + "AudioSpeed", this.AudioSpeed);
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "BeginPushTime", this.BeginPushTime);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "AsampleRate", this.AsampleRate);
        }
    }
}

