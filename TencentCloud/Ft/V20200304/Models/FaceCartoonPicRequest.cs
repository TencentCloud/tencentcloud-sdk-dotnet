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

namespace TencentCloud.Ft.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceCartoonPicRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url ，对应图片 base64 编码后大小不可超过5M。
        /// 图片的 Url、Image必须提供一个，如果都提供，只使用 Url。
        /// 图片存储于腾讯云的 Url 可保障更高下载速度和稳定性，建议图片存储于腾讯云。
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url ) ，二选一。url有效期为1天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 关闭全图动漫化，传入true（不分大小写）即关闭全图动漫化。
        /// </summary>
        [JsonProperty("DisableGlobalEffect")]
        public string DisableGlobalEffect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamSimple(map, prefix + "DisableGlobalEffect", this.DisableGlobalEffect);
        }
    }
}

