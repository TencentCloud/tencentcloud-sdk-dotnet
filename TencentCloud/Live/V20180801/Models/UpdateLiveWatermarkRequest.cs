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

    public class UpdateLiveWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// 水印ID。
        /// </summary>
        [JsonProperty("WatermarkId")]
        public long? WatermarkId{ get; set; }

        /// <summary>
        /// 水印图片url。
        /// </summary>
        [JsonProperty("PictureUrl")]
        public string PictureUrl{ get; set; }

        /// <summary>
        /// 显示位置，X轴偏移。
        /// </summary>
        [JsonProperty("XPosition")]
        public long? XPosition{ get; set; }

        /// <summary>
        /// 显示位置，Y轴偏移。
        /// </summary>
        [JsonProperty("YPosition")]
        public long? YPosition{ get; set; }

        /// <summary>
        /// 水印名称。
        /// </summary>
        [JsonProperty("WatermarkName")]
        public string WatermarkName{ get; set; }

        /// <summary>
        /// 水印宽度，占直播原始画面宽度百分比，建议高宽只设置一项，另外一项会自适应缩放，避免变形。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 水印高度，占直播原始画面宽度百分比，建议高宽只设置一项，另外一项会自适应缩放，避免变形。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
            this.SetParamSimple(map, prefix + "PictureUrl", this.PictureUrl);
            this.SetParamSimple(map, prefix + "XPosition", this.XPosition);
            this.SetParamSimple(map, prefix + "YPosition", this.YPosition);
            this.SetParamSimple(map, prefix + "WatermarkName", this.WatermarkName);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
        }
    }
}

