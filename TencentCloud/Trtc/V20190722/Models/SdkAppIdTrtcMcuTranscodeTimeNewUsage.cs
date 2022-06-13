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

    public class SdkAppIdTrtcMcuTranscodeTimeNewUsage : AbstractModel
    {
        
        /// <summary>
        /// 本组数据对应的时间点，格式如：2020-09-07或2020-09-07 00:05:05。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 语音时长，单位：秒。
        /// </summary>
        [JsonProperty("AudioTime")]
        public ulong? AudioTime{ get; set; }

        /// <summary>
        /// 视频时长-标清SD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH264SD")]
        public ulong? VideoTimeH264SD{ get; set; }

        /// <summary>
        /// 视频时长-高清HD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH264HD")]
        public ulong? VideoTimeH264HD{ get; set; }

        /// <summary>
        /// 视频时长-全高清FHD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH264FHD")]
        public ulong? VideoTimeH264FHD{ get; set; }

        /// <summary>
        /// 视频时长-带宽，单位：mbps。
        /// </summary>
        [JsonProperty("Flux")]
        public float? Flux{ get; set; }

        /// <summary>
        /// 视频时长-标清2K，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH2642K")]
        public ulong? VideoTimeH2642K{ get; set; }

        /// <summary>
        /// 视频时长-标清4K，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH2644K")]
        public ulong? VideoTimeH2644K{ get; set; }

        /// <summary>
        /// 视频时长-标清265SD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH265SD")]
        public ulong? VideoTimeH265SD{ get; set; }

        /// <summary>
        /// 视频时长-高清265HD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH265HD")]
        public ulong? VideoTimeH265HD{ get; set; }

        /// <summary>
        /// 视频时长-全高清265FHD，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH265FHD")]
        public ulong? VideoTimeH265FHD{ get; set; }

        /// <summary>
        /// 视频时长-标清2652K，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH2652K")]
        public ulong? VideoTimeH2652K{ get; set; }

        /// <summary>
        /// 视频时长-标清265 4K，单位：秒。
        /// </summary>
        [JsonProperty("VideoTimeH2654K")]
        public ulong? VideoTimeH2654K{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "AudioTime", this.AudioTime);
            this.SetParamSimple(map, prefix + "VideoTimeH264SD", this.VideoTimeH264SD);
            this.SetParamSimple(map, prefix + "VideoTimeH264HD", this.VideoTimeH264HD);
            this.SetParamSimple(map, prefix + "VideoTimeH264FHD", this.VideoTimeH264FHD);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "VideoTimeH2642K", this.VideoTimeH2642K);
            this.SetParamSimple(map, prefix + "VideoTimeH2644K", this.VideoTimeH2644K);
            this.SetParamSimple(map, prefix + "VideoTimeH265SD", this.VideoTimeH265SD);
            this.SetParamSimple(map, prefix + "VideoTimeH265HD", this.VideoTimeH265HD);
            this.SetParamSimple(map, prefix + "VideoTimeH265FHD", this.VideoTimeH265FHD);
            this.SetParamSimple(map, prefix + "VideoTimeH2652K", this.VideoTimeH2652K);
            this.SetParamSimple(map, prefix + "VideoTimeH2654K", this.VideoTimeH2654K);
        }
    }
}

