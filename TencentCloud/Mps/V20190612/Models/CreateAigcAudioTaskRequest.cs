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

    public class CreateAigcAudioTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称。生音乐当前支持的模型: GL、MiniMaxMusic。</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>指定模型特定版本号。默认使用系统当前所支持的模型稳定版本。<br>模型GL支持的版本号：3.0-clip、3.0-pro。<br>模型MiniMaxMusic支持的版本号：2.0、2.5、2.6。</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>指定场景生音频。音乐: music。</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>生成视频的描述。(注：最大支持2000字符)。当未传入图片时，此参数必填。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>参考视频信息。仅部分模型支持。</p>
        /// </summary>
        [JsonProperty("VideoInfos")]
        public AigcAudioReferenceVideoInfo[] VideoInfos{ get; set; }

        /// <summary>
        /// <p>传入参考音频信息。</p><p>比如传入音频生成音乐时需要传入。</p>
        /// </summary>
        [JsonProperty("AudioInfos")]
        public AigcAudioReferenceAudioInfo[] AudioInfos{ get; set; }

        /// <summary>
        /// <p>输出音频格式，默认不填。mp3、wav。</p>
        /// </summary>
        [JsonProperty("OutputAudioFormat")]
        public string OutputAudioFormat{ get; set; }

        /// <summary>
        /// <p>文件结果指定存储Cos桶信息。 注意：需开通Cos，创建并授权MPS_QcsRole角色。</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AigcStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>用于传入要求的额外参数。</p>
        /// </summary>
        [JsonProperty("ExtraParameters")]
        public AigcAudioExtraParam ExtraParameters{ get; set; }

        /// <summary>
        /// <p>用于传入一些模型需要的特殊场景参数，Json格式序列化成字符串。<br>示例MinimaxMusic模型传入歌词时：<br>{"lyric":{"小马在快乐奔跑，花儿在开放"}}</p>
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
            this.SetParamArrayObj(map, prefix + "VideoInfos.", this.VideoInfos);
            this.SetParamArrayObj(map, prefix + "AudioInfos.", this.AudioInfos);
            this.SetParamSimple(map, prefix + "OutputAudioFormat", this.OutputAudioFormat);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamObj(map, prefix + "ExtraParameters.", this.ExtraParameters);
            this.SetParamSimple(map, prefix + "AdditionalParameters", this.AdditionalParameters);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

