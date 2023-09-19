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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeImageItem : AbstractModel
    {
        
        /// <summary>
        /// 元素对应媒体信息。
        /// </summary>
        [JsonProperty("SourceMedia")]
        public ComposeSourceMedia SourceMedia{ get; set; }

        /// <summary>
        /// 元素在轨道时间轴上的时间信息，不填则紧跟上一个元素。
        /// </summary>
        [JsonProperty("TrackTime")]
        public ComposeTrackTime TrackTime{ get; set; }

        /// <summary>
        /// 元素中心点距离画布原点的水平位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示元素 XPos 为画布宽度指定百分比的位置，如 10% 表示 XPos 为画布宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示元素 XPos 单位为像素，如 100px 表示 XPos 为100像素。</li>
        /// 默认：50%。
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// 元素中心点距离画布原点的垂直位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示元素 YPos 为画布高度指定百分比的位置，如 10% 表示 YPos 为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示元素 YPos 单位为像素，如 100px 表示 YPos 为100像素。</li>
        /// 默认：50%。
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 视频片段的宽度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示元素 Width 为画布宽度的百分比大小，如 10% 表示 Width 为画布宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示元素 Width 单位为像素，如 100px 表示 Width 为100像素。</li>
        /// 为空（或0） 的场景：
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取源素材本身的 Width、Height。</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按源素材比例缩放。</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按源素材比例缩放。</li>
        /// </summary>
        [JsonProperty("Width")]
        public string Width{ get; set; }

        /// <summary>
        /// 元素的高度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示元素 Height 为画布高度的百分比大小，如 10% 表示 Height 为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示元素 Height 单位为像素，如 100px 表示 Height 为100像素。</li>
        /// 为空（或0） 的场景：
        /// <li>当 Width、Height 均为空，则 Width 和 Height 取源素材本身的 Width、Height。</li>
        /// <li>当 Width 为空，Height 非空，则 Width 按源素材比例缩放。</li>
        /// <li>当 Width 非空，Height 为空，则 Height 按源素材比例缩放。</li>
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 对图像画面进行的操作，如图像旋转等。
        /// </summary>
        [JsonProperty("ImageOperations")]
        public ComposeImageOperation[] ImageOperations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SourceMedia.", this.SourceMedia);
            this.SetParamObj(map, prefix + "TrackTime.", this.TrackTime);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "ImageOperations.", this.ImageOperations);
        }
    }
}

