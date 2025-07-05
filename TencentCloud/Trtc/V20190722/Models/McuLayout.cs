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
        /// 子画面在输出时的显示模式：0为裁剪，1为缩放并显示背景，2为缩放并显示黑底。不填默认为0。
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
        /// 子画面的背景图url，填写该参数，当用户关闭摄像头或未进入TRTC房间时，会在布局位置填充为指定图片。若指定图片与布局位置尺寸比例不一致，则会对图片进行拉伸处理，优先级高于BackGroundColor。支持png、jpg、jpeg、bmp、gif、webm格式。图片大小限制不超过5MB。
        /// 注：您需要确保图片链接的可访问性，后台单次下载超时时间为10秒，最多重试3次，若最终图片下载失败，子画面的背景图将不会生效。
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// 客户自定义裁剪，针对原始输入流裁剪
        /// </summary>
        [JsonProperty("CustomCrop")]
        public McuCustomCrop CustomCrop{ get; set; }

        /// <summary>
        /// 子背景图在输出时的显示模式：0为裁剪，1为缩放并显示背景，2为缩放并显示黑底，3为变比例伸缩，4为自定义渲染。不填默认为3。
        /// </summary>
        [JsonProperty("BackgroundRenderMode")]
        public ulong? BackgroundRenderMode{ get; set; }

        /// <summary>
        /// 子画面的透明模版url，指向一张包含透明通道的模板图片。填写该参数，后台混流时会提取该模板图片的透明通道，将其缩放作为目标画面的透明通道，再和其他画面进行混合。您可以通过透明模版实现目标画面的半透明效果和任意形状裁剪（如圆角、星形、心形等）。 支持png格式。图片大小限制不超过5MB。
        /// 注：1，模板图片宽高比应接近目标画面宽高比，以避免缩放适配目标画面时出现模板效果变形；2，透明模版只有RenderMode为0（裁剪）时才生效；3，您需要确保图片链接的可访问性，后台单次下载超时时间为10秒，最多重试3次，若最终图片下载失败，透明模版将不会生效。
        /// </summary>
        [JsonProperty("TransparentUrl")]
        public string TransparentUrl{ get; set; }

        /// <summary>
        /// 子背景图的自定义渲染参数，当BackgroundRenderMode为4时必须配置。
        /// </summary>
        [JsonProperty("BackgroundCustomRender")]
        public McuBackgroundCustomRender BackgroundCustomRender{ get; set; }

        /// <summary>
        /// 子背景色生效模式，默认值为0表示均不生效。
        /// bit0:占位图缩放是否生效。
        /// bit1:上行流缩放是否生效。
        /// 您可以将相应bit位置1启动生效，例如：
        /// 0(00)表示子背景色不生效。
        /// 1(01)表示子背景色只在占位图缩放时生效。
        /// 2(10)表示子背景色只在上行流缩放时生效。
        /// 3(11)表示子背景色在占位图缩放和上行流缩放时均生效。
        /// </summary>
        [JsonProperty("BackGroundColorMode")]
        public ulong? BackGroundColorMode{ get; set; }


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
            this.SetParamSimple(map, prefix + "BackgroundRenderMode", this.BackgroundRenderMode);
            this.SetParamSimple(map, prefix + "TransparentUrl", this.TransparentUrl);
            this.SetParamObj(map, prefix + "BackgroundCustomRender.", this.BackgroundCustomRender);
            this.SetParamSimple(map, prefix + "BackGroundColorMode", this.BackGroundColorMode);
        }
    }
}

