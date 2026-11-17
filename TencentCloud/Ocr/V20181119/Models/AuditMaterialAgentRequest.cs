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

    public class AuditMaterialAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资料审核Agent类型，不同类型包含不同的输入、输出参数，提供不同的审核能力。</p><p>枚举值：</p><ul><li>StorePicAudit： 商户照片审核</li></ul>
        /// </summary>
        [JsonProperty("AgentType")]
        public string AgentType{ get; set; }

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
        /// <p>商户照片分类是否输出具体场景标签。注：开启后耗时会增加。 支持该入参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("NeedSceneType")]
        public bool? NeedSceneType{ get; set; }

        /// <summary>
        /// <p>商户名称信息，辅助判断具体场景标签。注：仅SceneType配置为true时支持。  支持该出参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("StoreInfoHint")]
        public string StoreInfoHint{ get; set; }

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
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "NeedSceneType", this.NeedSceneType);
            this.SetParamSimple(map, prefix + "StoreInfoHint", this.StoreInfoHint);
            this.SetParamArraySimple(map, prefix + "IgnoreWatermarkCategories.", this.IgnoreWatermarkCategories);
        }
    }
}

