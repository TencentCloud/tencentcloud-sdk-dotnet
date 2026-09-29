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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyScenePhotoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>场景类型参数，如果场景无法细分请选用该大类的第一个子类，目前支持以下类型：<br><strong>经营场所照</strong><br>0101 门头照<br>0102 店内照<br>0103 流动经营照    </p><p><strong>车牌业务照</strong><br>0201 车牌</p>
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// <p>鉴伪模式，目前支持以下模式，对应支持不同的入参、出参。<br>Image：图像鉴伪模式，根据图像分析输出告警提示，支持推理，支持区域篡改提示、AIGC合成提示、屏幕翻拍提示、截图提示、文字水印提示、水印内容、模板图片提示、VLM 推理结果。每次调用按1次调用计费。<br>Video：视频鉴伪模式，根据视频分析输出告警提示，不支持推理，支持屏幕翻拍提示。每次调用按1次调用计费。<br>Hybrid：混合鉴伪模式，综合图像、视频分析输出告警提示，支持推理，支持区域篡改提示、AIGC合成提示、屏幕翻拍提示、截图提示、文字水印提示、水印内容、模板图片提示、VLM 推理结果。每次调用按2次调用计费。</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>视频的 Url 地址。格式支持：xxxxxx。要求视频不超过 100M。建议视频时长不小于1s。</p>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>图片的 Url 地址。要求图片经Base64编码后不超过 10M。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>图片的 Base64 值。要求图片经Base64编码后不超过 10M。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>推理 Prompt 模板，默认使用 VLM 对图片进行理解推理，同时支持使用 ${变量名} 进行推理。传入该参数即开启推理流程。</p><p>入参限制：长度限制：1–2000 字符</p>
        /// </summary>
        [JsonProperty("ReasoningPrompt")]
        public string ReasoningPrompt{ get; set; }

        /// <summary>
        /// <p>推理输出配置。当 ReasoningPrompt 传入时建议同步传入，未传入时使用默认配置（OutputMode=enum, EnumValues=[&quot;true&quot;,&quot;false&quot;], EnableImageInput=true）。</p>
        /// </summary>
        [JsonProperty("ReasoningConfig")]
        public ReasoningConfig ReasoningConfig{ get; set; }

        /// <summary>
        /// <p>水印提示排除类型，选择出参“水印提示”排除掉的水印类型，不传的话即代表任意水印都会提示。<br>PhoneCam：手机相机水印<br>WatermarkCam：水印相机水印</p>
        /// </summary>
        [JsonProperty("IgnoreWatermarkCategories")]
        public string[] IgnoreWatermarkCategories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ReasoningPrompt", this.ReasoningPrompt);
            this.SetParamObj(map, prefix + "ReasoningConfig.", this.ReasoningConfig);
            this.SetParamArraySimple(map, prefix + "IgnoreWatermarkCategories.", this.IgnoreWatermarkCategories);
        }
    }
}

