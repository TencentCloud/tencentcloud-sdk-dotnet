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

    public class PushQualityData : AbstractModel
    {
        
        /// <summary>
        /// 数据时间，使用UTC格式时间，
        /// 例如：2019-01-08T10:00:00Z。
        /// 注意：北京时间值为 UTC 时间值 + 8 小时，格式按照 ISO 8601 标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 推流域名。
        /// </summary>
        [JsonProperty("PushDomain")]
        public string PushDomain{ get; set; }

        /// <summary>
        /// 推流路径。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 推流客户端 IP。
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 开始推流时间，格式: %Y-%m-%d %H:%M:%S.%ms，精确到毫秒级。
        /// </summary>
        [JsonProperty("BeginPushTime")]
        public string BeginPushTime{ get; set; }

        /// <summary>
        /// 分辨率信息。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// 视频编码格式。
        /// </summary>
        [JsonProperty("VCodec")]
        public string VCodec{ get; set; }

        /// <summary>
        /// 音频编码格式。
        /// </summary>
        [JsonProperty("ACodec")]
        public string ACodec{ get; set; }

        /// <summary>
        /// 推流序列号，用来唯一的标志一次推流。
        /// </summary>
        [JsonProperty("Sequence")]
        public string Sequence{ get; set; }

        /// <summary>
        /// 视频帧率。
        /// </summary>
        [JsonProperty("VideoFps")]
        public ulong? VideoFps{ get; set; }

        /// <summary>
        /// 视频码率，单位: bps。
        /// </summary>
        [JsonProperty("VideoRate")]
        public ulong? VideoRate{ get; set; }

        /// <summary>
        /// 音频帧率。
        /// </summary>
        [JsonProperty("AudioFps")]
        public ulong? AudioFps{ get; set; }

        /// <summary>
        /// 音频码率，单位: bps。
        /// </summary>
        [JsonProperty("AudioRate")]
        public ulong? AudioRate{ get; set; }

        /// <summary>
        /// 本地流逝时间，单位: ms，音视频流逝时间与本地流逝时间的差距越大表示推流质量越差，上行卡顿越严重。
        /// </summary>
        [JsonProperty("LocalTs")]
        public ulong? LocalTs{ get; set; }

        /// <summary>
        /// 视频流逝时间，单位: ms。
        /// </summary>
        [JsonProperty("VideoTs")]
        public ulong? VideoTs{ get; set; }

        /// <summary>
        /// 音频流逝时间，单位: ms。
        /// </summary>
        [JsonProperty("AudioTs")]
        public ulong? AudioTs{ get; set; }

        /// <summary>
        /// metadata 中的视频码率，单位: kbps。
        /// </summary>
        [JsonProperty("MetaVideoRate")]
        public ulong? MetaVideoRate{ get; set; }

        /// <summary>
        /// metadata 中的音频码率，单位: kbps。
        /// </summary>
        [JsonProperty("MetaAudioRate")]
        public ulong? MetaAudioRate{ get; set; }

        /// <summary>
        /// metadata 中的帧率。
        /// </summary>
        [JsonProperty("MateFps")]
        public ulong? MateFps{ get; set; }

        /// <summary>
        /// 推流参数
        /// </summary>
        [JsonProperty("StreamParam")]
        public string StreamParam{ get; set; }

        /// <summary>
        /// 带宽，单位Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// 流量，单位MB。
        /// </summary>
        [JsonProperty("Flux")]
        public float? Flux{ get; set; }

        /// <summary>
        /// 推流服务端 IP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerIp")]
        public string ServerIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "PushDomain", this.PushDomain);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "BeginPushTime", this.BeginPushTime);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "VCodec", this.VCodec);
            this.SetParamSimple(map, prefix + "ACodec", this.ACodec);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "VideoFps", this.VideoFps);
            this.SetParamSimple(map, prefix + "VideoRate", this.VideoRate);
            this.SetParamSimple(map, prefix + "AudioFps", this.AudioFps);
            this.SetParamSimple(map, prefix + "AudioRate", this.AudioRate);
            this.SetParamSimple(map, prefix + "LocalTs", this.LocalTs);
            this.SetParamSimple(map, prefix + "VideoTs", this.VideoTs);
            this.SetParamSimple(map, prefix + "AudioTs", this.AudioTs);
            this.SetParamSimple(map, prefix + "MetaVideoRate", this.MetaVideoRate);
            this.SetParamSimple(map, prefix + "MetaAudioRate", this.MetaAudioRate);
            this.SetParamSimple(map, prefix + "MateFps", this.MateFps);
            this.SetParamSimple(map, prefix + "StreamParam", this.StreamParam);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "ServerIp", this.ServerIp);
        }
    }
}

