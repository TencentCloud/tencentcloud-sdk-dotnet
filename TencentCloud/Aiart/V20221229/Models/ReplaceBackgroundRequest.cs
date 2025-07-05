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

namespace TencentCloud.Aiart.V20221229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceBackgroundRequest : AbstractModel
    {
        
        /// <summary>
        /// 商品原图 Url。
        /// 图片限制：单边分辨率小于4000，长宽比在2:5 ~ 5:2之间，转成 Base64 字符串后小于 6MB，格式支持 jpg、jpeg、png、bmp、tiff、webp。
        /// </summary>
        [JsonProperty("ProductUrl")]
        public string ProductUrl{ get; set; }

        /// <summary>
        /// 对新背景的文本描述。
        /// 最多支持256个 utf-8 字符，支持中、英文。
        /// 如果 Prompt = "BackgroundTemplate" 代表启用背景模板，需要在参数 BackgroundTemplate 中指定一个背景名称。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 反向提示词。
        /// 最多支持256个 utf-8 字符，支持中、英文。
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 商品图中的商品主体名称。
        /// 最多支持50个 utf-8 字符，支持中、英文。
        /// 建议说明商品主体，否则影响生成效果。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 背景模板。
        /// 仅当 Prompt = "BackgroundTemplate" 时生效，可支持的模板详见 [商品背景模板列表](https://cloud.tencent.com/document/product/1668/115391) ，请传入字段“背景名称”中的值。
        /// </summary>
        [JsonProperty("BackgroundTemplate")]
        public string BackgroundTemplate{ get; set; }

        /// <summary>
        /// 商品 Mask 图 Url，要求背景透明，保留商品主体。
        /// 如果不传，将自动使用内置的商品分割算法得到 Mask。
        /// 支持自定义上传 Mask，如果该参数不为空，则以实际上传的数据为准。
        /// 图片限制：Mask 图必须和商品原图分辨率一致，转成 Base64 字符串后小于 6MB，格式仅支持 png。
        /// </summary>
        [JsonProperty("MaskUrl")]
        public string MaskUrl{ get; set; }

        /// <summary>
        /// 替换背景后生成的商品图分辨率。
        /// 支持生成单边分辨率大于500且小于4000、长宽比在2:5 ~ 5:2之间的图片，不传默认生成1280:1280。
        /// 建议图片比例为1:1、9:16、16:9，生成效果更佳，使用其他比例的生成效果可能不如建议比例。
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

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
        /// 生成图分辨率较大时建议选择 url，使用 base64 可能因图片过大导致返回失败。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductUrl", this.ProductUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "BackgroundTemplate", this.BackgroundTemplate);
            this.SetParamSimple(map, prefix + "MaskUrl", this.MaskUrl);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
        }
    }
}

