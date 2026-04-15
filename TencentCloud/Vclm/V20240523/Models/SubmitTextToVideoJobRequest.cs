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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitTextToVideoJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>正向文本提示词。不能超过2500个字符</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>模型名称。<br>v1.6：Kling-V1-6<br>v2.0：Kling-V2-Master<br>v2.5：Kling-V2-5-Turbo<br>v2.6：Kling-V2-6<br>v3.0：kling-v3</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>负向文本提示词。不能超过2500个字符</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>生成视频时长，单位s。默认值为5。<br>枚举值：3，4，5，6，7，8，9，10，11，12，13，14，15</p><p>不同模型支持时长不同</p><ul><li>模型v1.6、v2.0、v2.5、v2.6：支持5、10</li><li>模型v3.0：支持3～15s</li></ul>
        /// </summary>
        [JsonProperty("Duration")]
        public string Duration{ get; set; }

        /// <summary>
        /// <p>生成视频的模式；</p><p>枚举值：std，pro</p><ul><li>其中std：标准模式（标准），基础模式，性价比高</li><li>其中pro：专家模式（高品质），高表现模式，生成视频质量更佳</li></ul><p>不同模型版本、视频模式支持范围不同</p><ul><li>v1.6：std、pro。</li><li>v2.0、v3.0：模型无需配置。</li><li>v2.5：首尾帧情况下支持pro。</li><li>v2.6：仅支持pro，选择v2.6模型时，默认自动生成高品质pro视频。</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>生成视频的自由度；值越大，模型自由度越小，与用户输入的提示词相关性越强。<br>取值范围：[0, 1]<br>v2.0、v2.5、v2.6 模型不支持当前参数<br>默认值：0.5。</p>
        /// </summary>
        [JsonProperty("CfgScale")]
        public float? CfgScale{ get; set; }

        /// <summary>
        /// <p>生成视频的画面纵横比（宽:高）<br>枚举值：16:9, 9:16, 1:1<br>默认值：16:9</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>生成视频时是否同时生成声音</p><ul><li>枚举值：on，off</li></ul><p>仅V2.6及后续版本模型支持当前参数，v2.6模型的std模式只能生成无声的视频</p>
        /// </summary>
        [JsonProperty("Sound")]
        public string Sound{ get; set; }

        /// <summary>
        /// <p>为生成视频添加标识的开关，默认为1。<br>1：添加标识。<br>0：不添加标识。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示，该视频是 AI 生成的视频。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成视频的右下角添加“视频由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// <p>是否生成多镜头视频</p><ul><li>当前参数为true时，prompt参数无效</li><li>当前参数为false时，shot_type参数及multi_prompt参数无效</li></ul>
        /// </summary>
        [JsonProperty("MultiShot")]
        public bool? MultiShot{ get; set; }

        /// <summary>
        /// <p>分镜方式</p><p>枚举值：customize，intelligence<br>当MultiShot参数为true时，当前参数必填</p>
        /// </summary>
        [JsonProperty("ShotType")]
        public string ShotType{ get; set; }

        /// <summary>
        /// <p>各分镜提示词，可包含正向描述和负向描述</p><p>通过index、prompt、duration参数定义分镜序号及相应提示词和时长，其中：</p><ul><li>最多支持6个分镜，最小支持1个分镜</li><li>每个分镜相关内容的最大长度不超过512</li><li>每个分镜的时长不大于当前任务的总时长，不小于1</li><li>所有分镜的时长之和等于当前任务的总时长</li><li>当MultiShot参数为true且ShotType参数为customize时，当前参数不得为空<br>用key:value承载，如下：<pre><code> &quot;MultiPrompt&quot;:[              {                &quot;Index&quot;:int,              &quot;Prompt&quot;: &quot;string&quot;,              &quot;Duration&quot;: &quot;5&quot;            }  ]</code></pre></li></ul>
        /// </summary>
        [JsonProperty("MultiPrompt")]
        public MultiPrompt[] MultiPrompt{ get; set; }

        /// <summary>
        /// <p>控制摄像机运动的协议（如未指定，模型将根据输入的文本/图片进行智能匹配）</p>
        /// </summary>
        [JsonProperty("CameraControl")]
        public CameraControl CameraControl{ get; set; }

        /// <summary>
        /// <p>本次任务结果回调通知地址，如果配置，服务端会在任务状态发生变更时主动通知</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "CfgScale", this.CfgScale);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Sound", this.Sound);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamSimple(map, prefix + "MultiShot", this.MultiShot);
            this.SetParamSimple(map, prefix + "ShotType", this.ShotType);
            this.SetParamArrayObj(map, prefix + "MultiPrompt.", this.MultiPrompt);
            this.SetParamObj(map, prefix + "CameraControl.", this.CameraControl);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

