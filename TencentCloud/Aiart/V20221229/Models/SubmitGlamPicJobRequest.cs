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

    public class SubmitGlamPicJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 美照模板图 URL。
        /// 图片限制：模板图中最多出现5张人脸，单边分辨率大于300，转成 Base64 字符串后小于 10MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("TemplateUrl")]
        public string TemplateUrl{ get; set; }

        /// <summary>
        /// 用户图 URL 列表，以及模板图中需要替换成用户的人脸框信息。
        /// 一张美照中可包含1 ~ 5个用户形象。每个用户需上传1 ~ 6张照片，如果图中存在多个人脸将取最大人脸。
        /// 模板图中的人脸数量需要大于等于用户个数。如果不传每个用户在模板图中的人脸框位置，默认按照模板图人脸框从大到小的顺序进行替换。如需自定义顺序，需要依次上传每个用户在模板图中的人脸框位置。
        /// 图片限制：每张图片转成 Base64 字符串后小于 10MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。建议使用单人、正脸、脸部区域占比较大、脸部清晰无遮挡、无大角度偏转、无夸张表情的用户图。
        /// </summary>
        [JsonProperty("FaceInfos")]
        public FaceInfo[] FaceInfos{ get; set; }

        /// <summary>
        /// 美照生成数量。
        /// 支持1 ~ 4张，默认生成4张。
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 美照生成风格。
        /// 仅对单人美照生效，单人可支持选择不同风格。需按照美照生成数量，在数组中逐一填入每张美照的风格名称。如果不传，默认取不重复的随机风格顺序。
        /// 多人美照只支持 balanced 一种风格，该参数不生效。
        /// 可选风格：<ul><li>real：面部相似度更高。</li><li>balanced：平衡面部真实感和美观度。</li><li>extured：脸部皮肤更具真实感。</li><li>beautiful：脸部美观度更高。</li></ul>
        /// </summary>
        [JsonProperty("Style")]
        public string[] Style{ get; set; }

        /// <summary>
        /// 相似度系数，越高越像用户图。
        /// 取值范围[0, 1]，默认为0.6。
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// 超分选项，默认不做超分，可选开启。
        /// x2：2倍超分
        /// x4：4倍超分
        /// </summary>
        [JsonProperty("Clarity")]
        public string Clarity{ get; set; }

        /// <summary>
        /// 为生成结果图添加标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图是 AI 生成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateUrl", this.TemplateUrl);
            this.SetParamArrayObj(map, prefix + "FaceInfos.", this.FaceInfos);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamArraySimple(map, prefix + "Style.", this.Style);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "Clarity", this.Clarity);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

