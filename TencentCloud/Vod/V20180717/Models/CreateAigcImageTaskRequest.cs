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

    public class CreateAigcImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 模型名称。取值：
        /// <li>GEM：Gemini；</li>
        /// <li>Jimeng：即梦；</li>
        /// <li>Qwen：千问。</li>
        /// <li>Hunyuan：混元。</li>
        /// <li>Mingmou：明眸。</li>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型版本。取值：
        /// <li>当 ModelName 是 GEM，可选值为 2.5、3.0；</li>
        /// <li>当 ModelName 是 Jimeng，可选值为 4.0；</li>
        /// <li>当 ModelName 是 Qwen，可选值为 0925；</li>
        /// <li>当 ModelName 是 Hunyuan，可选值为 3.0；</li>
        /// <li>当 ModelName 是 Mingmou，可选值为 1.0；</li>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// AIGC 生图任务的输入图片的文件信息。默认只支持指定1个，使用模型 GEM 时，版本2.5最多指定3个，版本3.0最多指定14个。
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcImageTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 生成图片的提示词。当 FileInfos 为空时，此参数必填。
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 要阻止模型生成图片的提示词。
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 是否自动优化提示词。开启时将自动优化传入的 Prompt，以提升生成质量。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li> 
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// 生图任务的输出媒体文件配置。
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcImageOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，音画质重生完成回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 任务的优先级，数值越大优先级越高，取值范围是 -10 到 10，不填代表 0。
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// 保留字段，特殊用途时使用。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

