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

    public class GenerateAvatarRequest : AbstractModel
    {
        
        /// <summary>
        /// 头像风格，仅在人像模式下生效。
        /// 请在  [百变头像风格列表](https://cloud.tencent.com/document/product/1668/107741) 中选择期望的风格，传入风格编号，不传默认使用 flower 风格。
        /// 若使用萌宠贴纸模式，无需选择风格，该参数不生效。
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }

        /// <summary>
        /// 输入图 Base64 数据。
        /// Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：单边分辨率小于5000，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("InputImage")]
        public string InputImage{ get; set; }

        /// <summary>
        /// 输入图 Url。
        /// Base64 和 Url 必须提供一个，如果都提供以 Url 为准。
        /// 图片限制：单边分辨率小于5000，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("InputUrl")]
        public string InputUrl{ get; set; }

        /// <summary>
        /// 图像类型，默认为人像。
        /// human：人像头像，仅支持人像图片输入，建议避免上传无人、多人、人像过小的图片。
        /// pet：萌宠贴纸，仅支持动物图片输入，建议避免上传无动物、多动物、动物过小的图片。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输入人像图的质量检测开关，默认开启，仅在人像模式下生效。
        /// 1：开启
        /// 0：关闭
        /// 建议开启检测，可提升生成效果，关闭检测可能因输入图像质量较差导致生成效果受损。
        /// 开启后，将增强对输入图像的质量要求，如果输入图像单边分辨率<500、图像中人脸占比较小、存在多人、没有检测到人脸、人脸不完整、人脸遮挡等，将被拦截。
        /// 关闭后，将降低对输入图像的质量要求，如果图像中没有检测到人脸或人脸占比过小等，将被拦截。
        /// </summary>
        [JsonProperty("Filter")]
        public long? Filter{ get; set; }

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
        /// 返回图像方式（base64 或 url) ，二选一，默认为 base64。url 有效期为1小时。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Style", this.Style);
            this.SetParamSimple(map, prefix + "InputImage", this.InputImage);
            this.SetParamSimple(map, prefix + "InputUrl", this.InputUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

