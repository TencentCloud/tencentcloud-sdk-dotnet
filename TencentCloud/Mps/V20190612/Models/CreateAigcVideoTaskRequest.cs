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
        /// 模型名称。
        /// 当前支持的模型列表:
        /// Hunyuan,
        /// Hailuo，
        /// Kling，
        /// Vidu，
        /// OS，
        /// GV。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 指定模型特定版本号。默认使用系统当前所支持的模型稳定版本。
        /// 1. Hailuo， 可选[02、2.3]。
        /// 2. Kling，可选[2.0、2.1、2.5、O1、2.6]。
        /// 3. Vidu,可选[q2、q2-pro、q2-turbo]。
        /// 4. GV, 可选[3.1]。
        /// 5. OS，可选[2.0]。
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// 生成视频的描述。(注：最大支持2000字符)。当未传入图片时，此参数必填。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 用于描述您想要阻止模型生成的内容。
        /// 注意：部分模型支持。
        /// 例如：
        /// 顶部照明、明亮的色彩
        /// 人物、动物
        /// 多辆汽车、风。
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 默认取值为False，模型会严格地遵循指令。如果需要更精细的prompt获得最佳效果，可将此参数设置为True，将自动优化传入的prompt，以提升生成质量。
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public bool? EnhancePrompt{ get; set; }

        /// <summary>
        /// 用于指导视频生成的图片 URL。该URL需外网可访问。
        /// 注意：
        /// 1. 推荐图片大小不超过10M，不同模型大小限制不相同。
        /// 2. 支持的图片格式：jpeg、png。
        /// 3. 使用OS模型时，需输入图片尺寸为: 1280x720、720x1280。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 模型将以此参数传入的图片作为尾帧画面来生成视频。
        /// 支持此参数的模型：
        /// 1. GV，传入尾帧图片时，必须同时传入ImageUrl作为首帧。
        /// 2. Kling， 在Resolution:1080P的情况下 2.1版本支持首位帧。
        /// 3. Vidu, q2-pro, q2-turbo 支持首尾帧。
        /// 
        /// 注意：
        /// 1. 推荐图片大小不超过10M，各模型限制不同。
        /// 2. 支持的图片格式：jpeg、png。
        /// </summary>
        [JsonProperty("LastImageUrl")]
        public string LastImageUrl{ get; set; }

        /// <summary>
        /// 最多包含三张素材资源图片的列表，用于描述模型在生成视频时要使用的资源图片。
        /// 
        /// 支持多图输入的模型：
        /// 1. GV，使用多图输入时，不可使用ImageUrl和LastImageUrl。
        /// 2. Vidu，支持多图参考生视频。q2模型1-7张图片，可通过ImageInfos里面的ReferenceType作为主体id来传入。
        /// 
        /// 注意：
        /// 1. 图片大小不超过10M。
        /// 2. 支持的图片格式：jpeg、png。
        /// </summary>
        [JsonProperty("ImageInfos")]
        public AigcVideoReferenceImageInfo[] ImageInfos{ get; set; }

        /// <summary>
        /// 生成视频的时长。
        /// 注意：
        /// 1. Kling支持 5、10秒。默认: 5秒。
        /// 2. Hailuo的std模式可支持6、10秒，其他仅6秒。默认：6秒。
        /// 3. Vidu支持1-10秒。
        /// 4. GV支持 8秒。 默认：8秒。
        /// 5. OS支持4、8、12秒。 默认：8秒。
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 用于传入要求的额外参数。
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcVideoExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// 文件结果指定存储Cos桶信息。 注意：需开通Cos，创建并授权MPS_QcsRole角色。
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// 用于传入一些模型需要的特殊场景参数，Json格式序列化成字符串。
        /// 示例：
        /// {\"camera_control\":{\"type\":\"simple\"}}
        /// </summary>
        [JsonProperty("AdditionalParameters")]
        public string AdditionalParameters{ get; set; }

        /// <summary>
        /// 接口操作者名称。
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
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "LastImageUrl", this.LastImageUrl);
            this.SetParamArrayObj(map, prefix + "ImageInfos.", this.ImageInfos);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

