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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChildTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 自适应码率转码模板，子模板Id。
        /// 入参时候，填写此字段，表示更新子模板，否则是新增子模板。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 子模板名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 视频编码：h264/h265/origin，默认origin。
        /// 
        /// origin: 保持原始编码格式。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// 视频码率。范围：0kbps - 8000kbps。
        /// 0为保持原始码率。
        /// 注: 转码模板有码率唯一要求，最终保存的码率可能与输入码率有所差别。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// 宽，默认0。
        /// 范围[0-3000]。
        /// 数值必须是2的倍数，0是原始宽度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高，默认0。
        /// 范围[0-3000]
        /// 数值必须是2的倍数，0是原始高度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 帧率，默认0。
        /// 范围0-60fps。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 关键帧间隔，单位：秒。
        /// 默认原始的间隔。
        /// 范围2-6。
        /// 同一个父模板下面的所有子模板，gop必须相等且存在。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// 是否保留视频，0：否，1：是。默认1。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NeedVideo")]
        public long? NeedVideo{ get; set; }

        /// <summary>
        /// 是否保留音频，0：否，1：是。默认1。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// 当设置的码率>原始码率时，是否以原始码率为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BitrateToOrig")]
        public long? BitrateToOrig{ get; set; }

        /// <summary>
        /// 当设置的高度>原始高度时，是否以原始高度为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeightToOrig")]
        public long? HeightToOrig{ get; set; }

        /// <summary>
        /// 当设置的帧率>原始帧率时，是否以原始帧率为准。
        /// 0：否， 1：是
        /// 默认 0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FpsToOrig")]
        public long? FpsToOrig{ get; set; }

        /// <summary>
        /// 是否以短边作为高度，0：否，1：是。默认0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShortEdgeAsHeight")]
        public long? ShortEdgeAsHeight{ get; set; }

        /// <summary>
        /// HLS 分片类型。
        /// 可选值：ts、fmp4。
        /// 注：编码方式为 H.265 时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HlsContainerFormat")]
        public string HlsContainerFormat{ get; set; }

        /// <summary>
        /// 编码标签。
        /// 可选值：hvc1、hev1。
        /// 注：HLS 分片类型选择 fmp4 时生效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HlsMp4VideoCodecTag")]
        public string HlsMp4VideoCodecTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "BitrateToOrig", this.BitrateToOrig);
            this.SetParamSimple(map, prefix + "HeightToOrig", this.HeightToOrig);
            this.SetParamSimple(map, prefix + "FpsToOrig", this.FpsToOrig);
            this.SetParamSimple(map, prefix + "ShortEdgeAsHeight", this.ShortEdgeAsHeight);
            this.SetParamSimple(map, prefix + "HlsContainerFormat", this.HlsContainerFormat);
            this.SetParamSimple(map, prefix + "HlsMp4VideoCodecTag", this.HlsMp4VideoCodecTag);
        }
    }
}

