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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CropImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要裁剪区域的宽度，与Height共同组成所需裁剪的图片宽高比例；
        /// 输入数字请大于0、小于图片宽度的像素值；
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 需要裁剪区域的高度，与Width共同组成所需裁剪的图片宽高比例；
        /// 输入数字请请大于0、小于图片高度的像素值；
        /// 宽高比例（Width : Height）会简化为最简分数，即如果Width输入10、Height输入20，会简化为1：2。
        /// Width : Height建议取值在[1, 2.5]之间，超过这个范围可能会影响效果；
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 图片URL地址。 
        /// 图片限制： 
        /// • 图片格式：PNG、JPG、JPEG。 
        /// • 图片大小：所下载图片经Base64编码后不超过4M。图片下载时间不超过3秒。 
        /// 建议：
        /// • 图片像素：大于50*50像素，否则影响识别效果； 
        /// • 长宽比：长边：短边<5； 
        /// 接口响应时间会受到图片下载时间的影响，建议使用更可靠的存储服务，推荐将图片存储在腾讯云COS。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片经过base64编码的内容。最大不超过4M。与ImageUrl同时存在时优先使用ImageUrl字段。
        /// **注意：图片需要base64编码，并且要去掉编码头部。**
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
        }
    }
}

