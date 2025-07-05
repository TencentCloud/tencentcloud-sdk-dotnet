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

    public class MorphFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。 
        /// jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。 
        /// 人员人脸总数量至少2张，不可超过5张。 
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。 
        /// Url、Image必须提供一个，如果都提供，只使用 Url。图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。 
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。 
        /// 人员人脸总数量不可超过5张。 
        /// 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 人脸渐变参数。可调整每张图片的展示时长、人像渐变的最长时间
        /// </summary>
        [JsonProperty("GradientInfos")]
        public GradientInfo[] GradientInfos{ get; set; }

        /// <summary>
        /// 视频帧率，取值[1,25]。默认10
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// 视频类型，取值0。目前仅支持MP4格式，默认为MP4格式
        /// </summary>
        [JsonProperty("OutputType")]
        public long? OutputType{ get; set; }

        /// <summary>
        /// 视频宽度，取值[128,1280]。默认值720
        /// </summary>
        [JsonProperty("OutputWidth")]
        public long? OutputWidth{ get; set; }

        /// <summary>
        /// 视频高度，取值[128,1280]。默认值1280
        /// </summary>
        [JsonProperty("OutputHeight")]
        public long? OutputHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamArrayObj(map, prefix + "GradientInfos.", this.GradientInfos);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "OutputWidth", this.OutputWidth);
            this.SetParamSimple(map, prefix + "OutputHeight", this.OutputHeight);
        }
    }
}

