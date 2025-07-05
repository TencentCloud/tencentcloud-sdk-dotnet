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

namespace TencentCloud.Iai.V20200303.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 人员ID，取值为创建人员接口中的PersonId。
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 图片 base64 数据。
        /// - base64 编码后大小不可超过5M。
        /// - jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。所有格式的图片短边像素不小于64。
        /// - 人员人脸总数量不可超过5张。
        /// - 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// - 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 图片的 Url 。
        /// - 对应图片 base64 编码后大小不可超过5M。
        /// - jpg格式长边像素不可超过4000，其他格式图片长边像素不可超2000。所有格式的图片短边像素不小于64。
        /// - Url、Image必须提供一个，如果都提供，只使用 Url。  
        /// - 图片存储于腾讯云的Url可保障更高下载速度和稳定性，建议图片存储于腾讯云。 
        /// - 非腾讯云存储的Url速度和稳定性可能受一定影响。
        /// - 支持PNG、JPG、JPEG、BMP，不支持 GIF 图片。
        /// - 人员人脸总数量不可超过5张。
        /// - 若图片中包含多张人脸，只选取其中人脸面积最大的人脸。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 只有和该人员已有的人脸相似度超过FaceMatchThreshold值的人脸，才能增加人脸成功。 
        /// - 默认值60分。
        /// - 取值范围：[0,100] 。
        /// </summary>
        [JsonProperty("FaceMatchThreshold")]
        public float? FaceMatchThreshold{ get; set; }

        /// <summary>
        /// 图片质量控制。 
        /// - 取值范围：
        /// 0: 不进行控制； 
        /// 1:较低的质量要求，图像存在非常模糊，眼睛鼻子嘴巴遮挡至少其中一种或多种的情况； 
        /// 2: 一般的质量要求，图像存在偏亮，偏暗，模糊或一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，至少其中三种的情况； 
        /// 3: 较高的质量要求，图像存在偏亮，偏暗，一般模糊，眉毛遮挡，脸颊遮挡，下巴遮挡，其中一到两种的情况； 
        /// 4: 很高的质量要求，各个维度均为最好或最多在某一维度上存在轻微问题； 
        /// - 默认 0。 
        /// - 若图片质量不满足要求，则返回结果中会提示图片质量检测不符要求。
        /// </summary>
        [JsonProperty("QualityControl")]
        public ulong? QualityControl{ get; set; }

        /// <summary>
        /// 是否开启图片旋转识别支持。
        /// - 取值范围：0为不开启，1为开启。
        /// - 默认为0。
        /// - 本参数的作用为，当图片中的人脸被旋转且图片没有exif信息时，如果不开启图片旋转识别支持则无法正确检测、识别图片中的人脸。
        /// - 若您确认图片包含exif信息或者您确认输入图中人脸不会出现被旋转情况，请不要开启本参数。开启后，整体耗时将可能增加数百毫秒。
        /// </summary>
        [JsonProperty("NeedRotateDetection")]
        public ulong? NeedRotateDetection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "FaceMatchThreshold", this.FaceMatchThreshold);
            this.SetParamSimple(map, prefix + "QualityControl", this.QualityControl);
            this.SetParamSimple(map, prefix + "NeedRotateDetection", this.NeedRotateDetection);
        }
    }
}

