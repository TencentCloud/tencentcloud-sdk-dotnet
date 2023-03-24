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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuLayout : AbstractModel
    {
        
        /// <summary>
        /// 用户媒体流参数。不填时腾讯云后台按照上行主播的进房顺序自动填充。
        /// </summary>
        [JsonProperty("UserMediaStream")]
        public UserMediaStream UserMediaStream{ get; set; }

        /// <summary>
        /// 子画面在输出时的宽度，单位为像素值，不填默认为0。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public ulong? ImageWidth{ get; set; }

        /// <summary>
        /// 子画面在输出时的高度，单位为像素值，不填默认为0。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public ulong? ImageHeight{ get; set; }

        /// <summary>
        /// 子画面在输出时的X偏移，单位为像素值，LocationX与ImageWidth之和不能超过混流输出的总宽度，不填默认为0。
        /// </summary>
        [JsonProperty("LocationX")]
        public ulong? LocationX{ get; set; }

        /// <summary>
        /// 子画面在输出时的Y偏移，单位为像素值，LocationY与ImageHeight之和不能超过混流输出的总高度，不填默认为0。
        /// </summary>
        [JsonProperty("LocationY")]
        public ulong? LocationY{ get; set; }

        /// <summary>
        /// 子画面在输出时的层级，不填默认为0。
        /// </summary>
        [JsonProperty("ZOrder")]
        public ulong? ZOrder{ get; set; }

        /// <summary>
        /// 子画面在输出时的显示模式：0为裁剪，1为缩放，2为缩放并显示黑底。不填默认为0。
        /// </summary>
        [JsonProperty("RenderMode")]
        public ulong? RenderMode{ get; set; }

        /// <summary>
        /// 【此参数配置无效，暂不支持】子画面的背景颜色，常用的颜色有：
        /// 红色：0xcc0033。
        /// 黄色：0xcc9900。
        /// 绿色：0xcccc33。
        /// 蓝色：0x99CCFF。
        /// 黑色：0x000000。
        /// 白色：0xFFFFFF。
        /// 灰色：0x999999。
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// 子画面的背景图url，填写该参数，当用户关闭摄像头或未进入TRTC房间时，会在布局位置填充为指定图片。若指定图片与布局位置尺寸比例不一致，则会对图片进行拉伸处理，优先级高于BackGroundColor。
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// 客户自定义裁剪，针对原始输入流裁剪
        /// </summary>
        [JsonProperty("CustomCrop")]
        public McuCustomCrop CustomCrop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserMediaStream.", this.UserMediaStream);
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamSimple(map, prefix + "LocationX", this.LocationX);
            this.SetParamSimple(map, prefix + "LocationY", this.LocationY);
            this.SetParamSimple(map, prefix + "ZOrder", this.ZOrder);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamObj(map, prefix + "CustomCrop.", this.CustomCrop);
        }
    }
}

