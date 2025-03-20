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

namespace TencentCloud.Fmu.V20191213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BeautifyPicRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M，单边分辨率不超过4000。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 暂不支持带有alpha透明通道的图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。，单边分辨率不超过4000。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。  
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// 暂不支持带有alpha透明通道的图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 美白程度，取值范围[0,100]。0不美白，100代表最高程度。默认值30。
        /// </summary>
        [JsonProperty("Whitening")]
        public ulong? Whitening{ get; set; }

        /// <summary>
        /// 磨皮程度，取值范围[0,100]。0不磨皮，100代表最高程度。默认值10。
        /// </summary>
        [JsonProperty("Smoothing")]
        public ulong? Smoothing{ get; set; }

        /// <summary>
        /// 瘦脸程度，取值范围[0,100]。0不瘦脸，100代表最高程度。默认值70。
        /// </summary>
        [JsonProperty("FaceLifting")]
        public ulong? FaceLifting{ get; set; }

        /// <summary>
        /// 大眼程度，取值范围[0,100]。0不大眼，100代表最高程度。默认值70。
        /// </summary>
        [JsonProperty("EyeEnlarging")]
        public ulong? EyeEnlarging{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url ) ，二选一。url有效期为1天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Whitening", this.Whitening);
            this.SetParamSimple(map, prefix + "Smoothing", this.Smoothing);
            this.SetParamSimple(map, prefix + "FaceLifting", this.FaceLifting);
            this.SetParamSimple(map, prefix + "EyeEnlarging", this.EyeEnlarging);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

