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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSceneVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型版本号。</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>场景化类型。</p><p>枚举值：</p><ul><li>template_effect： 模板特效。</li></ul>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>输入的Prompt。避免出现违规词汇，审核会进行拦截。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>指定输出的视频时长。</p><p>部分场景不支持指定时长。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>输入的首帧参考图片Url。需外网可访问。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>输入的尾帧参考图片Url。</p>
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// <p>多图参考生视频时，通过该参数指定多张参考图。</p>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public SceneVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>视频编辑时，指定参考视频信息。</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public SceneVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>常规扩展参数。</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public SceneVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>模型扩展参数，用于透传到模型侧。</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// <p>输出结果存储到私有cos，需授权响应角色权限。</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public SceneStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>操作者名称。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "LastImageUrl", this.LastImageUrl);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

