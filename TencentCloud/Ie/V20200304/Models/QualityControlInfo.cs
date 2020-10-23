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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityControlInfo : AbstractModel
    {
        
        /// <summary>
        /// 对流进行截图的间隔ms，默认1000ms
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 是否保存截图
        /// </summary>
        [JsonProperty("VideoShot")]
        public bool? VideoShot{ get; set; }

        /// <summary>
        /// 是否检测抖动重影
        /// </summary>
        [JsonProperty("Jitter")]
        public bool? Jitter{ get; set; }

        /// <summary>
        /// 是否检测模糊
        /// </summary>
        [JsonProperty("Blur")]
        public bool? Blur{ get; set; }

        /// <summary>
        /// 是否检测低光照、过曝
        /// </summary>
        [JsonProperty("AbnormalLighting")]
        public bool? AbnormalLighting{ get; set; }

        /// <summary>
        /// 是否检测花屏
        /// </summary>
        [JsonProperty("CrashScreen")]
        public bool? CrashScreen{ get; set; }

        /// <summary>
        /// 是否检测黑边、白边、黑屏、白屏、绿屏
        /// </summary>
        [JsonProperty("BlackWhiteEdge")]
        public bool? BlackWhiteEdge{ get; set; }

        /// <summary>
        /// 是否检测噪点
        /// </summary>
        [JsonProperty("Noise")]
        public bool? Noise{ get; set; }

        /// <summary>
        /// 是否检测马赛克
        /// </summary>
        [JsonProperty("Mosaic")]
        public bool? Mosaic{ get; set; }

        /// <summary>
        /// 是否检测二维码，包括小程序码、条形码
        /// </summary>
        [JsonProperty("QRCode")]
        public bool? QRCode{ get; set; }

        /// <summary>
        /// 是否开启画面质量评价
        /// </summary>
        [JsonProperty("QualityEvaluation")]
        public bool? QualityEvaluation{ get; set; }

        /// <summary>
        /// 画面质量评价过滤阈值，结果只返回低于阈值的时间段，默认60
        /// </summary>
        [JsonProperty("QualityEvalScore")]
        public ulong? QualityEvalScore{ get; set; }

        /// <summary>
        /// 是否检测视频音频，包含静音、低音、爆音
        /// </summary>
        [JsonProperty("Voice")]
        public bool? Voice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "VideoShot", this.VideoShot);
            this.SetParamSimple(map, prefix + "Jitter", this.Jitter);
            this.SetParamSimple(map, prefix + "Blur", this.Blur);
            this.SetParamSimple(map, prefix + "AbnormalLighting", this.AbnormalLighting);
            this.SetParamSimple(map, prefix + "CrashScreen", this.CrashScreen);
            this.SetParamSimple(map, prefix + "BlackWhiteEdge", this.BlackWhiteEdge);
            this.SetParamSimple(map, prefix + "Noise", this.Noise);
            this.SetParamSimple(map, prefix + "Mosaic", this.Mosaic);
            this.SetParamSimple(map, prefix + "QRCode", this.QRCode);
            this.SetParamSimple(map, prefix + "QualityEvaluation", this.QualityEvaluation);
            this.SetParamSimple(map, prefix + "QualityEvalScore", this.QualityEvalScore);
            this.SetParamSimple(map, prefix + "Voice", this.Voice);
        }
    }
}

