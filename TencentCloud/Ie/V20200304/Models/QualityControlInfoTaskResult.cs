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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityControlInfoTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 质检任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 质检任务状态。
        /// 1：执行中；2：成功；3：失败
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 表示处理进度百分比
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 处理时长(s)
        /// </summary>
        [JsonProperty("UsedTime")]
        public ulong? UsedTime{ get; set; }

        /// <summary>
        /// 计费时长(s)
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 为true时表示视频无音频轨
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NoAudio")]
        public bool? NoAudio{ get; set; }

        /// <summary>
        /// 为true时表示视频无视频轨
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NoVideo")]
        public bool? NoVideo{ get; set; }

        /// <summary>
        /// 视频无参考质量打分，百分制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityEvaluationScore")]
        public ulong? QualityEvaluationScore{ get; set; }

        /// <summary>
        /// 视频画面无参考评分低于阈值的时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityEvaluationResults")]
        public QualityControlResultItems[] QualityEvaluationResults{ get; set; }

        /// <summary>
        /// 视频画面抖动时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JitterResults")]
        public QualityControlResultItems[] JitterResults{ get; set; }

        /// <summary>
        /// 视频画面模糊时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlurResults")]
        public QualityControlResultItems[] BlurResults{ get; set; }

        /// <summary>
        /// 视频画面低光、过曝时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AbnormalLightingResults")]
        public QualityControlResultItems[] AbnormalLightingResults{ get; set; }

        /// <summary>
        /// 视频画面花屏时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrashScreenResults")]
        public QualityControlResultItems[] CrashScreenResults{ get; set; }

        /// <summary>
        /// 视频画面黑边、白边、黑屏、白屏、纯色屏时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BlackWhiteEdgeResults")]
        public QualityControlResultItems[] BlackWhiteEdgeResults{ get; set; }

        /// <summary>
        /// 视频画面有噪点时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NoiseResults")]
        public QualityControlResultItems[] NoiseResults{ get; set; }

        /// <summary>
        /// 视频画面有马赛克时间段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MosaicResults")]
        public QualityControlResultItems[] MosaicResults{ get; set; }

        /// <summary>
        /// 视频画面有二维码的时间段，包括小程序码、条形码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QRCodeResults")]
        public QualityControlResultItems[] QRCodeResults{ get; set; }

        /// <summary>
        /// 视频音频异常时间段，包括静音、低音、爆音
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VoiceResults")]
        public QualityControlResultItems[] VoiceResults{ get; set; }

        /// <summary>
        /// 任务错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 任务错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "UsedTime", this.UsedTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "NoAudio", this.NoAudio);
            this.SetParamSimple(map, prefix + "NoVideo", this.NoVideo);
            this.SetParamSimple(map, prefix + "QualityEvaluationScore", this.QualityEvaluationScore);
            this.SetParamArrayObj(map, prefix + "QualityEvaluationResults.", this.QualityEvaluationResults);
            this.SetParamArrayObj(map, prefix + "JitterResults.", this.JitterResults);
            this.SetParamArrayObj(map, prefix + "BlurResults.", this.BlurResults);
            this.SetParamArrayObj(map, prefix + "AbnormalLightingResults.", this.AbnormalLightingResults);
            this.SetParamArrayObj(map, prefix + "CrashScreenResults.", this.CrashScreenResults);
            this.SetParamArrayObj(map, prefix + "BlackWhiteEdgeResults.", this.BlackWhiteEdgeResults);
            this.SetParamArrayObj(map, prefix + "NoiseResults.", this.NoiseResults);
            this.SetParamArrayObj(map, prefix + "MosaicResults.", this.MosaicResults);
            this.SetParamArrayObj(map, prefix + "QRCodeResults.", this.QRCodeResults);
            this.SetParamArrayObj(map, prefix + "VoiceResults.", this.VoiceResults);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
        }
    }
}

