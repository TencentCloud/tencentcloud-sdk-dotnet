/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 模板类型，可选值：
        /// <li>Preset：系统预置模板；</li>
        /// <li>Custom：用户自定义模板。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 截帧间隔，单位为秒。
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// 视频画面抖动重影检测的控制参数。
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfo JitterConfigure{ get; set; }

        /// <summary>
        /// 视频画面模糊检测的控制参数。
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfo BlurConfigure{ get; set; }

        /// <summary>
        /// 视频画面低光、过曝检测的控制参数。
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfo AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// 视频画面花屏检测的控制参数。
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfo CrashScreenConfigure{ get; set; }

        /// <summary>
        /// 视频画面黑边、白边、黑屏、白屏检测的控制参数。
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfo BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// 视频画面噪点检测的控制参数。
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfo NoiseConfigure{ get; set; }

        /// <summary>
        /// 视频画面马赛克检测的控制参数。
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfo MosaicConfigure{ get; set; }

        /// <summary>
        /// 视频画面二维码检测的控制参数。
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfo QRCodeConfigure{ get; set; }

        /// <summary>
        /// 视频画面质量评价的控制参数。
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfo QualityEvaluationConfigure{ get; set; }

        /// <summary>
        /// 音频（静音、低音、爆音）检测的控制参数。
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfo VoiceConfigure{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
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
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

