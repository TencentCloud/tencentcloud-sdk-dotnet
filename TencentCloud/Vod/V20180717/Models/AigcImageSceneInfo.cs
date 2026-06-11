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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcImageSceneInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>AI生图场景类型，可选值：</p><ul><li><code>ai_try_on</code>：AI 换装。</li><li><code>product_image</code>：AI 生商品图。</li><li><code>outpainting</code>: AI 扩图。</li></ul><p>下列 <code>Type</code> 已废弃，后续不再更新：</p><ul><li><code>change_clothes</code></li><li><code>change_clothes_under</code></li><li><code>change_clothes_top_wear</code></li><li><code>change_clothes_bottom_wear</code></li><li><code>change_clothes_full_wear</code></li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>当 Type 为 ai_try_on 时必填，表示 AI 换装配置参数。</p>
        /// </summary>
        [JsonProperty("AiTryOnConfig")]
        public AiTryOnConfig AiTryOnConfig{ get; set; }

        /// <summary>
        /// <p><strong>已废弃，请使用AiTryOnConfig。</strong>当 Type 下列类型时，则该项为必填，表示AI 换衣生图配置参数：</p><ul><li>change_clothes</li><li>change_clothes_under</li></ul>
        /// </summary>
        [JsonProperty("ChangeClothesConfig")]
        public ChangeClothesConfig ChangeClothesConfig{ get; set; }

        /// <summary>
        /// <p>当 Type 为 product_image 时必填，表示AI 生商品图配置参数。</p>
        /// </summary>
        [JsonProperty("ProductImageConfig")]
        public ProductImageConfig ProductImageConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AiTryOnConfig.", this.AiTryOnConfig);
            this.SetParamObj(map, prefix + "ChangeClothesConfig.", this.ChangeClothesConfig);
            this.SetParamObj(map, prefix + "ProductImageConfig.", this.ProductImageConfig);
        }
    }
}

