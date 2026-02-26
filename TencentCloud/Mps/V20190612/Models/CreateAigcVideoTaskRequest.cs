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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAigcVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称。<br>当前支持的模型列表:<br>Hunyuan,<br>Hailuo，<br>Kling，<br>Vidu，<br>OS，<br>GV。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>指定模型特定版本号。默认使用系统当前所支持的模型稳定版本。</p><ol><li>Hailuo， 可选[02、2.3]。</li><li>Kling，可选[2.0、2.1、2.5、O1、2.6、3.0、3.0-Omni]。</li><li>Vidu,可选[q2、q2-pro、q2-turbo、q3-pro、q3-turbo]。</li><li>GV, 可选[3.1]。</li><li>OS，可选[2.0]。</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>指定场景生视频。<br>注意：仅部分模型支持指定场景。</p><ol><li>Kling支持动作控制，motion_control。</li><li>Mingmou支持横转竖，land2port。</li><li>Vidu支持特效模板，template_effect。</li></ol>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>生成视频的描述。(注：最大支持2000字符)。当未传入图片时，此参数必填。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>用于描述您想要阻止模型生成的内容。<br>注意：部分模型支持。<br>例如：<br>顶部照明、明亮的色彩<br>人物、动物<br>多辆汽车、风。</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>默认取值为False，模型会严格地遵循指令。如果需要更精细的prompt获得最佳效果，可将此参数设置为True，将自动优化传入的prompt，以提升生成质量。</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>用于指导视频生成的图片 URL。该URL需外网可访问。<br>注意：</p><ol><li>推荐图片大小不超过10M，不同模型大小限制不相同。</li><li>支持的图片格式：jpeg、png。</li><li>使用OS模型时，需输入图片尺寸为: 1280x720、720x1280。</li></ol>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>模型将以此参数传入的图片作为尾帧画面来生成视频。<br>支持此参数的模型：</p><ol><li>GV，传入尾帧图片时，必须同时传入ImageUrl作为首帧。</li><li>Kling， 在Resolution:1080P的情况下 2.1版本支持首尾帧。</li><li>Vidu, q2-pro, q2-turbo 支持首尾帧。</li></ol><p>注意：</p><ol><li>推荐图片大小不超过10M，各模型限制不同。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// <p>最多包含三张素材资源图片的列表，用于描述模型在生成视频时要使用的资源图片。</p><p>支持多图输入的模型：</p><ol><li>GV，使用多图输入时，不可使用ImageUrl和LastImageUrl。</li><li>Vidu，支持多图参考生视频。q2模型1-7张图片，可通过ImageInfos里面的ReferenceType作为主体id来传入。</li></ol><p>注意：</p><ol><li>图片大小不超过10M。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>目前仅Kling O1版本支持参考视频信息传入。<br>可作为特征参考视频，也可作为待编辑视频，默认为待编辑视频；可选择性保留视频原声。</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>生成视频的时长。<br>注意：</p><ol><li>Kling支持 5、10秒。默认: 5秒。</li><li>Hailuo的std模式可支持6、10秒，其他仅6秒。默认：6秒。</li><li>Vidu支持1-10秒。</li><li>GV支持 8秒。 默认：8秒。</li><li>OS支持4、8、12秒。 默认：8秒。</li></ol>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>用于传入要求的额外参数。</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>文件结果指定存储Cos桶信息。 注意：需开通Cos，创建并授权MPS_QcsRole角色。</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>用于传入一些模型需要的特殊场景参数，Json格式序列化成字符串。<br>示例：<br>{"camera_control":{"type":"simple"}}</p>
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// <p>接口操作者名称。</p>
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
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "LastImageUrl", this.LastImageUrl);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

