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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 视频流的编码格式，可选值：
        /// <li>libx264：H.264 编码；</li>
        /// <li>libx265：H.265 编码；</li>
        /// <li>av1：AOMedia Video 1 编码；</li>
        /// <li>H.266：H.266 编码。</li>
        /// <font color=red>注意：</font>
        /// <li> av1，H.266 编码容器目前只支持 mp4 ；</li>
        /// <li> H.266 目前只支持恒定 CRF 码率控制方式。 </li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 视频帧率，取值范围：[0, 100]，单位：Hz。
        /// 当取值为 0，表示帧率和原始视频保持一致。
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// 视频流的码率，取值范围：0 和 [128, 100000]，单位：kbps。
        /// 当取值为 0，表示由云点播自动设置码率。
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// 分辨率自适应，可选值：
        /// <li>open：开启，此时，Width 代表视频的长边，Height 表示视频的短边；</li>
        /// <li>close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。</li>
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// 视频流宽度（或长边）的最大值，取值范围：0 和 [128, 8192]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率同源；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 视频流高度（或短边）的最大值，取值范围：0 和 [128, 8192]，单位：px。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式：
        /// <li> stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“；</li>
        /// <li>black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。</li>
        /// <li>white：留白，保持视频宽高比不变，边缘剩余部分使用白色填充。</li>
        /// <li>gauss：高斯模糊，保持视频宽高比不变，边缘剩余部分使用高斯模糊填充。</li>
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// 视频恒定码率控制因子，取值范围为[1, 51]，填 0 表示禁用该参数。
        /// 
        /// <font color=red>注意：</font>
        /// <li>如果指定该参数，将使用 CRF 的码率控制方式做转码（视频码率将不再生效）；</li>
        /// <li>当指定视频流编码格式为 H.266 时，该字段必填，推荐值为 28；</li>
        /// <li>如果没有特殊需求，不建议指定该参数。</li>
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// 关键帧 I 帧之间的间隔，取值范围：0 和 [1, 100000]，单位：帧数。
        /// 当填 0 或不填时，系统将自动设置 gop 长度。
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// 当原始视频为 HDR（High Dynamic Range）时，转码输出是否依然保持 HDR。取值范围：
        /// <li>ON: 如果原始文件是 HDR，则转码输出保持 HDR；否则转码输出为 SDR （Standard Dynamic Range）。</li>
        /// <li>OFF: 无论原始文件是 HDR 还是 SDR，转码输出均为 SDR。</li>
        /// </summary>
        [JsonProperty("PreserveHDRSwitch")]
        public string PreserveHDRSwitch{ get; set; }

        /// <summary>
        /// 编码标签，仅当视频流的编码格式为 H.265 编码时有效，可选值：
        /// <li>hvc1 表示 hvc1 标签；</li>
        /// <li>hev1 表示 hev1 标签。 </li>
        /// 默认值：hvc1。
        /// </summary>
        [JsonProperty("CodecTag")]
        public string CodecTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "PreserveHDRSwitch", this.PreserveHDRSwitch);
            this.SetParamSimple(map, prefix + "CodecTag", this.CodecTag);
        }
    }
}

