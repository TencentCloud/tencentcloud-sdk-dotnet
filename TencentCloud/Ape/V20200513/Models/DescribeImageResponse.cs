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

namespace TencentCloud.Ape.V20200513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 图片ID
        /// </summary>
        [JsonProperty("ImageId")]
        public ulong? ImageId{ get; set; }

        /// <summary>
        /// 图片标题
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 图片描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 图片预览链接
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// 图片缩略图
        /// </summary>
        [JsonProperty("ThumbUrl")]
        public string ThumbUrl{ get; set; }

        /// <summary>
        /// 图片供应商
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// 图片售卖组合信息
        /// </summary>
        [JsonProperty("Marshals")]
        public ImageMarshal[] Marshals{ get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 高
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 图片格式 jpg/eps/psd/...
        /// </summary>
        [JsonProperty("ImageFormat")]
        public string ImageFormat{ get; set; }

        /// <summary>
        /// 图片类型 摄影图片、插画、漫画、图表、矢量、psd、全景、gif、模板
        /// </summary>
        [JsonProperty("ImageSenseType")]
        public string ImageSenseType{ get; set; }

        /// <summary>
        /// 关键词，多关键词用空格分隔
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// 分层图库id
        /// </summary>
        [JsonProperty("LayeredGalleryId")]
        public long? LayeredGalleryId{ get; set; }

        /// <summary>
        /// 构图方式：horizontal:横图、vertical:竖图、square:方图
        /// </summary>
        [JsonProperty("Orientation")]
        public string Orientation{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamSimple(map, prefix + "ThumbUrl", this.ThumbUrl);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamArrayObj(map, prefix + "Marshals.", this.Marshals);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ImageFormat", this.ImageFormat);
            this.SetParamSimple(map, prefix + "ImageSenseType", this.ImageSenseType);
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
            this.SetParamSimple(map, prefix + "LayeredGalleryId", this.LayeredGalleryId);
            this.SetParamSimple(map, prefix + "Orientation", this.Orientation);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

