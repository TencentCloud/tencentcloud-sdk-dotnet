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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingWatermarkImage : AbstractModel
    {
        
        /// <summary>
        /// 水印源的ID，对应SourceInfoSet内的源。
        /// 注意1：对应的 MediaSourceInfo.Type需要为Image。
        /// 注意2：对于动图，只取第一帧图像作为水印源。
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 水印水平坐标，单位像素，默认：0。
        /// </summary>
        [JsonProperty("PosX")]
        public ulong? PosX{ get; set; }

        /// <summary>
        /// 水印垂直坐标，单位像素，默认：0。
        /// </summary>
        [JsonProperty("PosY")]
        public ulong? PosY{ get; set; }

        /// <summary>
        /// 水印宽度，单位像素，默认：0。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 水印高度，单位像素，默认：0。
        /// 注意：对于宽高符合以下规则：
        /// 1、Width>0 且 Height>0，按指定宽高拉伸；
        /// 2、Width=0 且 Height>0，以Height为基准等比缩放；
        /// 3、Width>0 且 Height=0，以Width为基准等比缩放；
        /// 4、Width=0 且 Height=0，采用源的宽高。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 指定坐标原点，可选值：
        /// <li>LeftTop：PosXY 表示水印左上点到图片左上点的相对位置</li>
        /// <li>RightTop：PosXY 表示水印右上点到图片右上点的相对位置</li>
        /// <li>LeftBottom：PosXY 表示水印左下点到图片左下点的相对位置</li>
        /// <li>RightBottom：PosXY 表示水印右下点到图片右下点的相对位置</li>
        /// <li>Center：PosXY 表示水印中心点到图片中心点的相对位置</li>
        /// 默认：LeftTop。
        /// </summary>
        [JsonProperty("PosOriginType")]
        public string PosOriginType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "PosOriginType", this.PosOriginType);
        }
    }
}

