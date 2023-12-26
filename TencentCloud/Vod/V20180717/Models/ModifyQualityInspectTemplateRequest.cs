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

    public class ModifyQualityInspectTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 截帧间隔，单位为秒，最小值为 1。
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// 视频画面抖动重影检测的控制参数。
        /// </summary>
        [JsonProperty("JitterConfigure")]
        public JitterConfigureInfoForUpdate JitterConfigure{ get; set; }

        /// <summary>
        /// 视频画面模糊检测的控制参数。
        /// </summary>
        [JsonProperty("BlurConfigure")]
        public BlurConfigureInfoForUpdate BlurConfigure{ get; set; }

        /// <summary>
        /// 视频画面低光、过曝检测的控制参数。
        /// </summary>
        [JsonProperty("AbnormalLightingConfigure")]
        public AbnormalLightingConfigureInfoForUpdate AbnormalLightingConfigure{ get; set; }

        /// <summary>
        /// 视频画面花屏检测的控制参数。
        /// </summary>
        [JsonProperty("CrashScreenConfigure")]
        public CrashScreenConfigureInfoForUpdate CrashScreenConfigure{ get; set; }

        /// <summary>
        /// 视频画面黑边、白边、黑屏、白屏检测的控制参数。
        /// </summary>
        [JsonProperty("BlackWhiteEdgeConfigure")]
        public BlackWhiteEdgeConfigureInfoForUpdate BlackWhiteEdgeConfigure{ get; set; }

        /// <summary>
        /// 视频画面噪点检测的控制参数。
        /// </summary>
        [JsonProperty("NoiseConfigure")]
        public NoiseConfigureInfoForUpdate NoiseConfigure{ get; set; }

        /// <summary>
        /// 视频画面马赛克检测的控制参数。
        /// </summary>
        [JsonProperty("MosaicConfigure")]
        public MosaicConfigureInfoForUpdate MosaicConfigure{ get; set; }

        /// <summary>
        /// 视频画面二维码检测的控制参数。
        /// </summary>
        [JsonProperty("QRCodeConfigure")]
        public QRCodeConfigureInfoForUpdate QRCodeConfigure{ get; set; }

        /// <summary>
        /// 音频（静音、低音、爆音）检测的控制参数。
        /// </summary>
        [JsonProperty("VoiceConfigure")]
        public VoiceConfigureInfoForUpdate VoiceConfigure{ get; set; }

        /// <summary>
        /// 视频画面质量评价的控制参数。
        /// </summary>
        [JsonProperty("QualityEvaluationConfigure")]
        public QualityEvaluationConfigureInfoForUpdate QualityEvaluationConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
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
            this.SetParamObj(map, prefix + "VoiceConfigure.", this.VoiceConfigure);
            this.SetParamObj(map, prefix + "QualityEvaluationConfigure.", this.QualityEvaluationConfigure);
        }
    }
}

