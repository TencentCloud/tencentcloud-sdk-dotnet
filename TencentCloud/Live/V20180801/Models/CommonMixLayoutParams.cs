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

    public class CommonMixLayoutParams : AbstractModel
    {
        
        /// <summary>
        /// 输入图层。取值范围[1，16]。
        /// 1)背景流（即大主播画面或画布）的 image_layer 填1。
        /// 2)纯音频混流，该参数也需填。
        /// </summary>
        [JsonProperty("ImageLayer")]
        public long? ImageLayer{ get; set; }

        /// <summary>
        /// 输入类型。取值范围[0，5]。
        /// 不填默认为0。
        /// 0表示输入流为音视频。
        /// 2表示输入流为图片。
        /// 3表示输入流为画布。 
        /// 4表示输入流为音频。
        /// 5表示输入流为纯视频。
        /// </summary>
        [JsonProperty("InputType")]
        public long? InputType{ get; set; }

        /// <summary>
        /// 输入画面在输出时的宽度。取值范围：
        /// 像素：[0，2000]
        /// 百分比：[0.01，0.99]
        /// 不填默认为输入流的宽度。
        /// 使用百分比时，期望输出为（百分比 * 背景宽）。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public float? ImageWidth{ get; set; }

        /// <summary>
        /// 输入画面在输出时的高度。取值范围：
        /// 像素：[0，2000]
        /// 百分比：[0.01，0.99]
        /// 不填默认为输入流的高度。
        /// 使用百分比时，期望输出为（百分比 * 背景高）。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public float? ImageHeight{ get; set; }

        /// <summary>
        /// 输入在输出画面的X偏移。取值范围：
        /// 像素：[0，2000]
        /// 百分比：[0.01，0.99]
        /// 不填默认为0。
        /// 相对于大主播背景画面左上角的横向偏移。 
        /// 使用百分比时，期望输出为（百分比 * 背景宽）。
        /// </summary>
        [JsonProperty("LocationX")]
        public float? LocationX{ get; set; }

        /// <summary>
        /// 输入在输出画面的Y偏移。取值范围：
        /// 像素：[0，2000]
        /// 百分比：[0.01，0.99]
        /// 不填默认为0。
        /// 相对于大主播背景画面左上角的纵向偏移。 
        /// 使用百分比时，期望输出为（百分比 * 背景宽）
        /// </summary>
        [JsonProperty("LocationY")]
        public float? LocationY{ get; set; }

        /// <summary>
        /// 当InputType为3(画布)时，该值表示画布的颜色。
        /// 常用的颜色有：
        /// 红色：0xcc0033。
        /// 黄色：0xcc9900。
        /// 绿色：0xcccc33。
        /// 蓝色：0x99CCFF。
        /// 黑色：0x000000。
        /// 白色：0xFFFFFF。
        /// 灰色：0x999999。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 当InputType为2(图片)时，该值是水印ID。
        /// </summary>
        [JsonProperty("WatermarkId")]
        public long? WatermarkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageLayer", this.ImageLayer);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
        }
    }
}

