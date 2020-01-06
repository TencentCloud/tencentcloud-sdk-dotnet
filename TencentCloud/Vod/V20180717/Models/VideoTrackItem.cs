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

    public class VideoTrackItem : AbstractModel
    {
        
        /// <summary>
        /// 视频片段的媒体素材来源，可以是点播的文件 ID，或者是其它文件的 URL。
        /// </summary>
        [JsonProperty("SourceMedia")]
        public string SourceMedia{ get; set; }

        /// <summary>
        /// 视频片段取自素材文件的起始时间，单位为秒。默认为0。
        /// </summary>
        [JsonProperty("SourceMediaStartTime")]
        public float? SourceMediaStartTime{ get; set; }

        /// <summary>
        /// 视频片段时长，单位为秒。默认取视频素材本身长度，表示截取全部素材。如果源文件是图片，Duration需要大于0。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 视频原点位置，取值有：
        /// <li>Center：坐标原点为中心位置，如画布中心。</li>
        /// 默认值 ：Center。
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// 视频片段原点距离画布原点的水平位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 XPos 为画布宽度指定百分比的位置，如 10% 表示 XPos 为画布口宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示视频片段 XPos 单位为像素，如 100px 表示 XPos 为100像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// 视频片段原点距离画布原点的垂直位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 YPos 为画布高度指定百分比的位置，如 10% 表示 YPos 为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示视频片段 YPos 单位为像素，如 100px 表示 YPos 为100像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 视频片段的宽度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 Width 为画布宽度的百分比大小，如 10% 表示 Width 为画布宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示视频片段 Width 单位为像素，如 100px 表示 Width 为100像素。</li>
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取视频素材本身的 Width、Height。</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按比例缩放</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按比例缩放。</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// 视频片段的高度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示视频片段 Height 为画布高度的百分比大小，如 10% 表示 Height 为画布高度的 10%；
        /// </li><li>当字符串以 px 结尾，表示视频片段 Height 单位为像素，如 100px 表示 Height 为100像素。</li>
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取视频素材本身的 Width、Height。</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按比例缩放</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按比例缩放。</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 对图像进行的操作，如图像旋转等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageOperations")]
        public ImageTransform[] ImageOperations{ get; set; }

        /// <summary>
        /// 对音频进行操作，如静音等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioOperations")]
        public AudioTransform[] AudioOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceMedia", this.SourceMedia);
            this.SetParamSimple(map, prefix + "SourceMediaStartTime", this.SourceMediaStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "ImageOperations.", this.ImageOperations);
            this.SetParamArrayObj(map, prefix + "AudioOperations.", this.AudioOperations);
        }
    }
}

