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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadTrainPortraitImagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 写真模型 ID。由英文大小写字母、数字及下划线组成。
        /// 用于唯一标识一个写真模型，一个写真模型只能用于一个人物的写真图片生成。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 写真模型训练用的基础图像 URL，用于固定写真模型可生成的人物。
        /// 图片数量：1张。
        /// 图片内容：单人，脸部清晰。
        /// 图片限制：单边分辨率小于2000，转成 Base64 字符串后小于 5MB。
        /// </summary>
        [JsonProperty("BaseUrl")]
        public string BaseUrl{ get; set; }

        /// <summary>
        /// 写真模型训练用的图像 URL 列表。
        /// 图片数量：19 - 24 张。
        /// 图片内容：单人，脸部清晰，和基础图像中的人物为同一人。
        /// 图片限制：单边分辨率小于2000，转成 Base64 字符串后小于 5MB。
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 训练图像质量过滤开关配置。
        /// 支持开启或关闭对训练图像分辨率下限、脸部区域大小、脸部遮挡的过滤，默认开启以上过滤。
        /// 如果训练图像内包含多人脸或无人脸、和 Base 人像不为同一人也将被过滤，不可关闭该过滤条件。
        /// 建议：关闭以上过滤可能导致写真生成效果受损，建议使用单人、正脸、脸部区域占比较大、脸部清晰无遮挡、无大角度偏转、无夸张表情的图像进行训练。
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// 是否开启快速训练模式。
        /// 默认不开启。开启后只需要在 BaseUrl 中传入1张图片，Urls.N 中无需传入图片。  
        /// 0：不开启  
        /// 1：开启
        /// </summary>
        [JsonProperty("TrainMode")]
        public long? TrainMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "BaseUrl", this.BaseUrl);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "TrainMode", this.TrainMode);
        }
    }
}

