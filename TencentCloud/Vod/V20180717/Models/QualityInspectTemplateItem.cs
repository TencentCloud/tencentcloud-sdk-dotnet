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

    public class QualityInspectTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// <p>模板 ID。</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>模板类型，可选值：</p><li>Preset：系统预置模板；</li><li>Custom：用户自定义模板。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>模板名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模板描述。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>音画质检测的配置参数。</p>
        /// </summary>
        [JsonProperty("Configs")]
        public QualityInspectConfig[] Configs{ get; set; }

        /// <summary>
        /// <p>音画质检测的抽检策略。</p>
        /// </summary>
        [JsonProperty("Strategy")]
        public QualityInspectStrategy Strategy{ get; set; }

        /// <summary>
        /// <p>模板创建时间，使用 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>模板最后修改时间，使用 <a href="https://cloud.tencent.com/document/product/266/11732#I">ISO 日期格式</a>。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）截帧间隔，单位为秒。</p>
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面抖动重影检测的控制参数。</p>
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfo JitterConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面模糊检测的控制参数。</p>
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfo BlurConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面低光、过曝检测的控制参数。</p>
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfo AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面花屏检测的控制参数。</p>
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfo CrashScreenConfigure{ get; set; }

        /// <summary>
        /// <p>视频画面黑边、白边、黑屏、白屏检测的控制参数。</p>
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfo BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面噪点检测的控制参数。</p>
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfo NoiseConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面马赛克检测的控制参数。</p>
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfo MosaicConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面二维码检测的控制参数。</p>
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfo QRCodeConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）视频画面质量评价的控制参数。</p>
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfo QualityEvaluationConfigure{ get; set; }

        /// <summary>
        /// <p>（不推荐，使用 Configs 替代）音频（静音、低音、爆音）检测的控制参数。</p>
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfo VoiceConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Configs.", this.Configs);
            this.SetParamObj(map, prefix + "Strategy.", this.Strategy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamObj(map, prefix + "JitterConfigure.", this.JitterConfigure);
            this.SetParamObj(map, prefix + "BlurConfigure.", this.BlurConfigure);
            this.SetParamObj(map, prefix + "AbnormalLightingConfigure.", this.AbnormalLightingConfigure);
            this.SetParamObj(map, prefix + "CrashScreenConfigure.", this.CrashScreenConfigure);
            this.SetParamObj(map, prefix + "BlackWhiteEdgeConfigure.", this.BlackWhiteEdgeConfigure);
            this.SetParamObj(map, prefix + "NoiseConfigure.", this.NoiseConfigure);
            this.SetParamObj(map, prefix + "MosaicConfigure.", this.MosaicConfigure);
            this.SetParamObj(map, prefix + "QRCodeConfigure.", this.QRCodeConfigure);
            this.SetParamObj(map, prefix + "QualityEvaluationConfigure.", this.QualityEvaluationConfigure);
            this.SetParamObj(map, prefix + "VoiceConfigure.", this.VoiceConfigure);
        }
    }
}

