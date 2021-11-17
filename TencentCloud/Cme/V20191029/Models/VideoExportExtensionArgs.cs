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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoExportExtensionArgs : AbstractModel
    {
        
        /// <summary>
        /// 封装格式，可选值：
        /// <li>mp4 </li>
        /// <li>mov </li>
        /// 不填则默认使用导出模板中的值。
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 视频短边尺寸，取值范围： [128, 4096]，单位：px。
        /// 视频最后的分辨率，根据短边尺寸和宽高比进行计算。
        /// 例如：项目的宽高比是 16：9 ：
        /// <li>短边尺寸为 1080，则导出视频的分辨率为 1920 * 1080。</li>
        /// <li>短边尺寸为 720，则导出视频的分辨率为 1280 * 720</li>
        /// 不填则默认使用导出模板中对的值。
        /// </summary>
        [JsonProperty("ShortEdge")]
        public ulong? ShortEdge{ get; set; }

        /// <summary>
        /// 指定码率，单位 bps。当该参数为 0 时则不强制限定码率。
        /// 不填则默认使用导出模板中的值。
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// 是否去除视频数据，可选值：
        /// <li>0：保留；</li>
        /// <li>1：去除。</li>
        /// 不填则默认使用导出模板中对的值。
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// 是否去除音频数据，可选值：
        /// <li>0：保留；</li>
        /// <li>1：去除。</li>
        /// 不填则默认使用导出模板中对的值。
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// 片段起始时间，单位：毫秒。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 片段结束时间，单位：毫秒。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "ShortEdge", this.ShortEdge);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

