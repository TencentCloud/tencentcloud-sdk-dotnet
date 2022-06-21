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

    public class ModifyLiveTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板 Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 视频编码：h264/h265/origin，默认origin。
        /// 
        /// origin: 保持原始编码格式
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// 音频编码：aac，默认aac。
        /// 注意：当前该参数未生效，待后续支持！
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// 音频码率，默认0。
        /// 范围：0-500。
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public long? AudioBitrate{ get; set; }

        /// <summary>
        /// 模板描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 视频码率。范围：0kbps - 8000kbps。
        /// 0为保持原始码率。
        /// 注: 转码模板有码率唯一要求，最终保存的码率可能与输入码率有所差别。
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// 宽。0-3000。
        /// 数值必须是2的倍数，0是原始宽度
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 是否保留视频，0：否，1：是。默认1。
        /// </summary>
        [JsonProperty("NeedVideo")]
        public long? NeedVideo{ get; set; }

        /// <summary>
        /// 是否保留音频，0：否，1：是。默认1。
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// 高。0-3000。
        /// 数值必须是2的倍数，0是原始宽度
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 帧率，默认0。
        /// 范围0-60
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 关键帧间隔，单位：秒。
        /// 范围2-6
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// 旋转角度，默认0。
        /// 可取值：0，90，180，270
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
        /// 当设置的码率>原始码率时，是否以原始码率为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// </summary>
        [JsonProperty("BitrateToOrig")]
        public long? BitrateToOrig{ get; set; }

        /// <summary>
        /// 当设置的高度>原始高度时，是否以原始高度为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// </summary>
        [JsonProperty("HeightToOrig")]
        public long? HeightToOrig{ get; set; }

        /// <summary>
        /// 当设置的帧率>原始帧率时，是否以原始帧率为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// </summary>
        [JsonProperty("FpsToOrig")]
        public long? FpsToOrig{ get; set; }

        /// <summary>
        /// 极速高清视频码率压缩比。
        /// 极速高清目标码率=VideoBitrate * (1-AdaptBitratePercent)
        /// 
        /// 取值范围：0.0到0.5
        /// </summary>
        [JsonProperty("AdaptBitratePercent")]
        public float? AdaptBitratePercent{ get; set; }

        /// <summary>
        /// 是否以短边作为高度，0：否，1：是。默认0。
        /// </summary>
        [JsonProperty("ShortEdgeAsHeight")]
        public long? ShortEdgeAsHeight{ get; set; }

        /// <summary>
        /// DRM 加密类型，可选值：fairplay、normalaes、widevine。
        /// 不传递或着为空字符串，清空之前的DRM配置。
        /// </summary>
        [JsonProperty("DRMType")]
        public string DRMType{ get; set; }

        /// <summary>
        /// DRM 加密项，可选值：AUDIO、SD、HD、UHD1、UHD2，后四个为一组，同组中的内容只能选一个。
        /// 不传递或着为空字符串，清空之前的DRM配置。
        /// </summary>
        [JsonProperty("DRMTracks")]
        public string DRMTracks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "BitrateToOrig", this.BitrateToOrig);
            this.SetParamSimple(map, prefix + "HeightToOrig", this.HeightToOrig);
            this.SetParamSimple(map, prefix + "FpsToOrig", this.FpsToOrig);
            this.SetParamSimple(map, prefix + "AdaptBitratePercent", this.AdaptBitratePercent);
            this.SetParamSimple(map, prefix + "ShortEdgeAsHeight", this.ShortEdgeAsHeight);
            this.SetParamSimple(map, prefix + "DRMType", this.DRMType);
            this.SetParamSimple(map, prefix + "DRMTracks", this.DRMTracks);
        }
    }
}

