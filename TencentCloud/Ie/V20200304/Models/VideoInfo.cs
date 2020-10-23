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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频帧率，取值范围：[0, 60]，单位：Hz。
        /// 注意：当取值为 0，表示帧率和原始视频保持一致。
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 宽度，取值范围：0 和 [128, 4096]
        /// 注意：
        /// 当 Width、Height 均为 0，则分辨率同源；
        /// 当 Width 为 0，Height 非 0，则 Width 按比例缩放；
        /// 当 Width 非 0，Height 为 0，则 Height 按比例缩放；
        /// 当 Width、Height 均非 0，则分辨率按用户指定。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高度，取值范围：0 和 [128, 4096]
        /// 注意：
        /// 当 Width、Height 均为 0，则分辨率同源；
        /// 当 Width 为 0，Height 非 0，则 Width 按比例缩放；
        /// 当 Width 非 0，Height 为 0，则 Height 按比例缩放；
        /// 当 Width、Height 均非 0，则分辨率按用户指定。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 长边分辨率，取值范围：0 和 [128, 4096]
        /// 注意：
        /// 当 LongSide、ShortSide 均为 0，则分辨率按照Width，Height；
        /// 当 LongSide 为 0，ShortSide 非 0，则 LongSide 按比例缩放；
        /// 当 LongSide非 0，ShortSide为 0，则 ShortSide 按比例缩放；
        /// 当 LongSide、ShortSide 均非 0，则分辨率按用户指定。
        /// 长短边优先级高于Weight,Height,设置长短边则忽略宽高。
        /// </summary>
        [JsonProperty("LongSide")]
        public long? LongSide{ get; set; }

        /// <summary>
        /// 短边分辨率，取值范围：0 和 [128, 4096]
        /// 注意：
        /// 当 LongSide、ShortSide 均为 0，则分辨率按照Width，Height；
        /// 当 LongSide 为 0，ShortSide 非 0，则 LongSide 按比例缩放；
        /// 当 LongSide非 0，ShortSide为 0，则 ShortSide 按比例缩放；
        /// 当 LongSide、ShortSide 均非 0，则分辨率按用户指定。
        /// 长短边优先级高于Weight,Height,设置长短边则忽略宽高。
        /// </summary>
        [JsonProperty("ShortSide")]
        public long? ShortSide{ get; set; }

        /// <summary>
        /// 视频流的码率，取值范围：0 和 [128, 35000]，单位：kbps。当取值为 0，表示视频码率和原始视频保持一致。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 固定I帧之间，视频帧数量，取值范围： [25, 2500]，如果不填，使用编码默认最优序列。
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// 编码器支持选项，可选值：
        /// h264,
        /// h265,
        /// av1
        /// 。
        /// 不填默认h264。
        /// </summary>
        [JsonProperty("VideoCodec")]
        public string VideoCodec{ get; set; }

        /// <summary>
        /// 图片水印。
        /// </summary>
        [JsonProperty("PicMarkInfo")]
        public PicMarkInfoItem[] PicMarkInfo{ get; set; }

        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。
        /// </summary>
        [JsonProperty("DarInfo")]
        public DarInfo DarInfo{ get; set; }

        /// <summary>
        /// 支持hdr,可选项：
        /// hdr10,
        /// hlg。
        /// 此时，VideoCodec会强制设置为h265, 编码位深为10
        /// </summary>
        [JsonProperty("Hdr")]
        public string Hdr{ get; set; }

        /// <summary>
        /// 画质增强参数信息。
        /// </summary>
        [JsonProperty("VideoEnhance")]
        public VideoEnhance VideoEnhance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "LongSide", this.LongSide);
            this.SetParamSimple(map, prefix + "ShortSide", this.ShortSide);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "VideoCodec", this.VideoCodec);
            this.SetParamArrayObj(map, prefix + "PicMarkInfo.", this.PicMarkInfo);
            this.SetParamObj(map, prefix + "DarInfo.", this.DarInfo);
            this.SetParamSimple(map, prefix + "Hdr", this.Hdr);
            this.SetParamObj(map, prefix + "VideoEnhance.", this.VideoEnhance);
        }
    }
}

