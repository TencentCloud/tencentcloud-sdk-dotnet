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

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频编码：
        /// h264/h265。
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// 视频码率。100-8000kbps
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// 音频编码：aac/mp3
        /// aac/mp3。
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// 音频码率。0-500
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public long? AudioBitrate{ get; set; }

        /// <summary>
        /// 宽。0-3000
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高。0-3000
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 帧率。0-200
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 关键帧间隔，单位：秒。1-50
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// 旋转角度。0 90 180 270
        /// </summary>
        [JsonProperty("Rotate")]
        public long? Rotate{ get; set; }

        /// <summary>
        /// 编码质量：
        /// baseline/main/high。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 是否不超过原始码率。0：否，1：是。
        /// </summary>
        [JsonProperty("BitrateToOrig")]
        public long? BitrateToOrig{ get; set; }

        /// <summary>
        /// 是否不超过原始高度。0：否，1：是。
        /// </summary>
        [JsonProperty("HeightToOrig")]
        public long? HeightToOrig{ get; set; }

        /// <summary>
        /// 是否不超过原始帧率。0：否，1：是。
        /// </summary>
        [JsonProperty("FpsToOrig")]
        public long? FpsToOrig{ get; set; }

        /// <summary>
        /// 是否保留视频。0：否，1：是。
        /// </summary>
        [JsonProperty("NeedVideo")]
        public long? NeedVideo{ get; set; }

        /// <summary>
        /// 是否保留音频。0：否，1：是。
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// 模板Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否是急速高清模板，0：否，1：是。默认0。
        /// </summary>
        [JsonProperty("AiTransCode")]
        public long? AiTransCode{ get; set; }

        /// <summary>
        /// 急速高清相比VideoBitrate少多少码率，0.1到0.5
        /// </summary>
        [JsonProperty("AdaptBitratePercent")]
        public float? AdaptBitratePercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "BitrateToOrig", this.BitrateToOrig);
            this.SetParamSimple(map, prefix + "HeightToOrig", this.HeightToOrig);
            this.SetParamSimple(map, prefix + "FpsToOrig", this.FpsToOrig);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AiTransCode", this.AiTransCode);
            this.SetParamSimple(map, prefix + "AdaptBitratePercent", this.AdaptBitratePercent);
        }
    }
}

