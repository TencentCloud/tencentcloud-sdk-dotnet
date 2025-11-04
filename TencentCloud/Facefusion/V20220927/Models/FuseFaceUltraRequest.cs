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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FuseFaceUltraRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回融合结果图片方式（url 或 base64) ，二选一。url有效期为1天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 用户人脸图片、素材模板图的人脸位置信息。主要用于素材模版中人脸以及用作融合的用户人脸相关信息，两种人脸都需要提供人脸图片，可选择提供人脸框位置，具体见MergeInfo说明 
        /// 目前最多支持融合模板图片中的6张人脸。
        /// </summary>
        [JsonProperty("MergeInfos")]
        public MergeInfo[] MergeInfos{ get; set; }

        /// <summary>
        /// 素材模版图片的url地址。
        /// ●base64 和 url 必须提供一个，如果都提供以 url 为准。
        /// ●图片分辨率限制：图片中面部尺寸大于34 * 34；图片尺寸大于64 * 64，小于8000 * 8000（单边限制）。
        /// ●图片大小限制：base64 编码后大小不可超过10M， url不超过20M。
        /// ●图片格式：支持jpg或png
        /// </summary>
        [JsonProperty("ModelUrl")]
        public string ModelUrl{ get; set; }

        /// <summary>
        /// 素材模版图片base64数据。
        /// ●base64 和 url 必须提供一个，如果都提供以 url 为准。
        /// ●素材图片限制：图片中面部尺寸大于34 * 34；图片尺寸大于64 * 64，小于8000*8000（单边限制）。
        /// ●图片大小限制：base64 编码后大小不可超过10M， url不超过20M。
        /// ●支持图片格式：支持jpg或png
        /// </summary>
        [JsonProperty("ModelImage")]
        public string ModelImage{ get; set; }

        /// <summary>
        /// 图片人脸融合（专业版）效果参数。可用于设置拉脸、人脸增强、磨皮、牙齿增强、妆容迁移等融合效果参数，生成理想的融合效果。不传默认使用接口推荐值。具体见FusionUltraParam说明
        /// </summary>
        [JsonProperty("FusionUltraParam")]
        public FusionUltraParam FusionUltraParam{ get; set; }

        /// <summary>
        /// 为融合结果图添加合成标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图使用了人脸融合技术，是AI合成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在融合结果图右下角添加“本图片为AI合成图片”字样，您可根据自身需要替换为其他的Logo图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// 融合模型类型参数：默认为1。
        /// 图片人脸融合（专业版）针对不同场景，提供多种模型供选择。如您的产品是泛娱乐场景，推荐使用1；如您主要用于影像场景，推荐使用4、5。其他模型类型也可以结合您的产品使用场景进行选择，也许会有意想不到的效果
        /// 1：默认泛娱乐场景，画面偏锐。
        /// 2：影视级场景，画面偏自然。
        /// 3：影视级场景，高分辨率，画面偏自然。
        /// 4：影视级场景，高分辦率，高人脸相似度，画面偏自然，可用于证件照等场景。
        /// 5：影视级场景，高分辨率，对闭眼和遮挡更友好。
        /// 6：影视级场景，高分辨率，极高人脸相似度，可用于电商照片、证件照、文旅照片等场景。
        /// </summary>
        [JsonProperty("SwapModelType")]
        public long? SwapModelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamArrayObj(map, prefix + "MergeInfos.", this.MergeInfos);
            this.SetParamSimple(map, prefix + "ModelUrl", this.ModelUrl);
            this.SetParamSimple(map, prefix + "ModelImage", this.ModelImage);
            this.SetParamObj(map, prefix + "FusionUltraParam.", this.FusionUltraParam);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "SwapModelType", this.SwapModelType);
        }
    }
}

