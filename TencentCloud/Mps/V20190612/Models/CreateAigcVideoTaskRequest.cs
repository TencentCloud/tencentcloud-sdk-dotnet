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
        /// <p>模型名称。<br>当前支持的模型列表:<br>Hunyuan，<br>Hailuo，<br>Kling，<br>Vidu，<br>PixVerse，<br>Mingmou，<br>H2。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>指定模型特定版本号。默认使用系统当前所支持的模型稳定版本。</p><ol><li>Hunyuan，可选 [1.5]。</li><li>Hailuo，可选 [02、2.3、2.3-fast]。</li><li>Kling，可选 [1.6、2.0、2.1、2.5、O1、2.6、3.0、3.0-Omni]。</li><li>Vidu，可选 [q2、q2-pro、q2-turbo、q3-pro、q3-turbo、q3、q3-mix]。</li><li>PixVerse，可选 [v5.6、v6、c1]。</li><li>H2，可选 [1.0]。</li></ol>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>指定场景生成视频。<br>注意：仅部分模型支持指定场景。</p><ol><li>Kling支持：动作控制，motion_control；数字人，avatar_i2v；对口型，lip_sync。</li><li>Mingmou支持：横转竖，land2port。</li><li>Vidu支持：特效模板，template_effect。</li><li>Hunyuan支持: 3d世界模型, 3d_scene；涉及的返回文件非视频。</li></ol>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>生成视频的描述。当未传入图片时，此参数必填。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>用于描述您想要阻止模型生成的内容。<br>注意：部分模型支持。<br>例如：<br>顶部照明、明亮的色彩。<br>人物、动物。<br>多辆汽车、风。</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>默认取值为False，模型会严格地遵循指令。<br>如果需要更精细的prompt获得最佳效果，可将此参数设置为True，将自动优化传入的prompt，以提升生成质量。</p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>用于指导视频生成的图片 URL。该URL需外网可访问。<br>注意：</p><ol><li>推荐图片大小不超过10M，不同模型大小限制不相同，可查看相应模型官网获取更完整描述。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>模型将以此参数传入的图片作为尾帧画面来生成视频。<br>支持此参数的模型：</p><ol><li>Kling，2.0、O1、3.0、3.0-Omni 支持首尾帧。</li><li>Kling，1.6、2.1、2.5、2.6 在 Resolution:1080P 的情况下支持首尾帧。</li><li>Vidu，q2-pro、q2-turbo、q3-pro、q3-turbo 支持首尾帧。</li><li>PixVerse，v5.6、v6、c1 支持首尾帧。</li><li>Hailuo，02 支持首尾帧。</li></ol><p>注意：</p><ol><li>推荐图片大小不超过10M，各模型限制不同。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// <p>包含多张素材资源图片的列表，用于描述模型在生成视频时要使用的资源图片。</p><p>支持多图输入的模型：</p><ol><li>Vidu，q2、q2-pro、q3-turbo、q3、q3-mix 支持多图参考生视频。支持上传 1-7 张图片，可通过 ImageInfos 里面的 ReferenceType 作为主体 id 来传入。</li><li>Kling，O1、3.0-Omni、1.6 支持多图参考生视频。<ol><li>Kling 1.6 支持上传 1-4 张图片。</li><li>Kling O1、3.0-Omni 支持上传 1-7 张图片。当有参考视频时，支持上传 0-4 张图片。</li></ol></li><li>PixVerse，v5.6、v6、c1 支持多图参考生视频。支持上传 1-7 张图片，需要通过 ImageInfos 里面的 Text 字段传入图片名称。</li><li>H2，1.0 支持多图参数生视频。支持上传 1-9 张图片。当有参考视频时，支持上传 0-5 张图片。</li></ol><p>注意：</p><ol><li>图片大小不超过10M。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// <p>目前仅 Kling O1、Kling 3.0-Omni、Vidu q2-pro、H2 1.0 支持参考视频信息传入。</p><ol><li>Kling O1、3.0-Omni 可作为特征参考视频，也可作为待编辑视频，默认为待编辑视频；可选择性保留视频原声。</li><li>Vidu q2-pro 支持视频参考。</li><li>H2 1.0 支持视频参考。</li></ol>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcVideoReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>部分模型支持参考音频传入，使用URL传入。</p>
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcVideoReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// <p>生成视频的时长。<br>注意：</p><ol><li>Kling，默认：5 秒。<ul><li>O1 支持 3-10 秒。</li><li>3.0-Omni 支持 3-15 秒，当使用视频参考时只支持 3-10 秒。</li><li>3.0 支持 3-15 秒。</li><li>其他版本支持 5、10 秒。</li></ul></li><li>Hailuo 的 std 模式可支持 6、10 秒，其他仅 6 秒。默认：6 秒。</li><li>Vidu，默认：5 秒。<ul><li>q3-pro、q3-turbo、q3、q3-mix 支持 3-16 秒。</li><li>q2-pro、q2-turbo、q2 支持 1-10 秒。 </li></ul></li><li>PixVerse，默认：5 秒。<ul><li>v5.6 支持 5、8、10 秒。</li><li>v6、c1 支持 1-15 秒。</li></ul></li><li>H2，支持 3-15 秒，默认 ：5 秒。</li></ol>
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
        /// <p>用于传入一些模型需要的特殊场景参数、分镜prompt等，Json格式序列化成字符串。<br>示例：<br>{"camera_control":{"type":"simple"}}</p>
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
            this.SetParamArrayObj(map, prefix + "AudioInfos.", this.AudioInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

