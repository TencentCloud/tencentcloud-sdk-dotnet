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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVideoEncodingPresetRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 配置名，可用来简单描述该配置的作用。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 封装格式，可选值：
        /// <li>mp4 ；</li>
        /// <li>mov 。</li>
        /// 默认值：mp4。
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 是否去除视频数据，可选值：
        /// <li>0：保留；</li>
        /// <li>1：去除。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// 是否去除音频数据，可选值：
        /// <li>0：保留；</li>
        /// <li>1：去除。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// 编码配置的视频设置。默认值参考VideoEncodingPresetVideoSetting 定义。
        /// </summary>
        [JsonProperty("VideoSetting")]
        public VideoEncodingPresetVideoSetting VideoSetting{ get; set; }

        /// <summary>
        /// 编码配置的音频设置。默认值参考VideoEncodingPresetAudioSetting 定义。
        /// </summary>
        [JsonProperty("AudioSetting")]
        public VideoEncodingPresetAudioSetting AudioSetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoSetting.", this.VideoSetting);
            this.SetParamObj(map, prefix + "AudioSetting.", this.AudioSetting);
        }
    }
}

