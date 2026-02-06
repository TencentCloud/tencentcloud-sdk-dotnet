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

    public class AigcVideoTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 模型名称。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型版本。
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// AIGC生图任务输入文件信息。
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 用于作为尾帧画面来生成视频的媒体文件 ID。该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 [视频上传完成事件通知](/document/product/266/7830) 或 [云点播控制台](https://console.cloud.tencent.com/vod/media) 获取该字段。
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// 用于作为尾帧画面来生成视频的媒体文件 URL。说明：
        /// 1. 只支持模型 GV 、Kling、Vidu，其他模型暂不支持。当 ModelName 为 GV 时，如果指定该参数，则需同时指定 FileInfos 作为待生成视频的首帧。当 ModelName 为 Kling 、ModelVersion 为 2.1 并且指定输出分辨率 Resolution 为 1080P 时，才能指定该参数。当 ModelName 为 Vidu、ModelVersion 为 q2-pro、q2-turbo 时，才能指定该参数。
        /// 2. 图片大小需小于5M。
        /// 3. 3. 图片格式的取值为：jpeg，jpg, png, webp。
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// 生成视频的提示词。最大支持1000字符，当 FileInfos 为空时，此参数必填。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 要阻止模型生成视频的提示词。最大支持1000字符。
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 是否自动优化提示词。开启时将自动优化传入的Prompt，以提升生成质量。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li> 
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// 生成模式。取值有： <li>Standard：标准模式；</li> <li>Professional：高品质模式；</li> 
        /// </summary>
        [JsonProperty("GenerationMode")]
        public string GenerationMode{ get; set; }

        /// <summary>
        /// AIGC 生图输出结果文件输出。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// 输入文件的区域信息。当文件url是国外地址时候，可选Oversea。默认Mainland。
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// 场景类型。取值如下：<li>当 ModelName 为 Kling 时，取值 motion_control 表示动作控制；</li><li>其他 ModelName 暂不支持。</li>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "LastFrameUrl", this.LastFrameUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamSimple(map, prefix + "GenerationMode", this.GenerationMode);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
        }
    }
}

