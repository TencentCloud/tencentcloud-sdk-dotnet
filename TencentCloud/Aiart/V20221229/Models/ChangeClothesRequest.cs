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

    public class ChangeClothesRequest : AbstractModel
    {
        
        /// <summary>
        /// 模特图片 Url。
        /// 图片限制：单边分辨率小于3000，且大于512，转成 Base64 字符串后小于 8MB。
        /// 输入要求：
        /// 1、建议上传正面模特图片，至少完整露出应穿着输入指定服装的身体部位（全身、上半身或下半身），无大角度身体偏转或异常姿势。
        /// 2、建议上传3:4比例的图片，生成效果更佳。
        /// 3、建议模特图片中的原始服装和更换后的服装类别一致，或原始服装在身体上的覆盖范围小于等于更换后的服装（例如需要给模特换上短裤，则原始模特图片中也建议穿短裤，不建议穿长裤），否则会影响人像生成效果。
        /// </summary>
        [JsonProperty("ModelUrl")]
        public string ModelUrl{ get; set; }

        /// <summary>
        /// 服装图片 Url。
        /// 图片限制：单边分辨率小于3000，大于512，转成 Base64 字符串后小于 8MB。
        /// 输入要求：
        /// 建议上传服装完整的正面平铺图片，仅包含1个服装主体，服装类型支持上衣、下装、连衣裙，三选一。算法将根据输入的图片，结合服装图片给模特换装。
        /// </summary>
        [JsonProperty("ClothesUrl")]
        public string ClothesUrl{ get; set; }

        /// <summary>
        /// 服装类型，需要和服装图片保持一致。
        /// 取值：
        /// Upper-body：上衣
        /// Lower-body：下装
        /// Dress：连衣裙
        /// </summary>
        [JsonProperty("ClothesType")]
        public string ClothesType{ get; set; }

        /// <summary>
        /// 为生成结果图添加标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 返回图像方式（base64 或 url) ，二选一，默认为 base64。url 有效期为1小时。
        /// 生成图分辨率较大时建议选择 url，使用 base64 可能因图片过大导致返回失败。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelUrl", this.ModelUrl);
            this.SetParamSimple(map, prefix + "ClothesUrl", this.ClothesUrl);
            this.SetParamSimple(map, prefix + "ClothesType", this.ClothesType);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

