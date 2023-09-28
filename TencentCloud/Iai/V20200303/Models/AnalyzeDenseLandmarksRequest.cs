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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyzeDenseLandmarksRequest : AbstractModel
    {
        
        /// <summary>
        /// 检测模式。0 为检测所有出现的人脸， 1 为检测面积最大的人脸。 
        /// 默认为 0。 
        /// 最多返回 5 张人脸的五官定位（人脸关键点）具体信息。
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 图片 base64 数据，base64 编码后大小不可超过5M。  
        /// jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。所有格式的图片短边像素不小于64。
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 图片的 Url 。对应图片 base64 编码后大小不可超过5M。  
        /// jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。所有格式的图片短边像素不小于64。
        /// Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。  
        /// 非腾讯云存储的Url速度和稳定性可能受一定影响。  
        /// 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 人脸识别服务所用的算法模型版本。本接口仅支持 “3.0“ 输入。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 是否开启图片旋转识别支持。0为不开启，1为开启。默认为0。本参数的作用为，当图片中的人脸被旋转且图片没有exif信息时，如果不开启图片旋转识别支持则无法正确检测、识别图片中的人脸。若您确认图片包含exif信息或者您确认输入图中人脸不会出现被旋转情况，请不要开启本参数。开启后，整体耗时将可能增加数百毫秒。
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public long? NeedRotateDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
        }
    }
}

