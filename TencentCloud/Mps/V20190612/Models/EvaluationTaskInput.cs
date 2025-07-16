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

    public class EvaluationTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 评测任务类型，可选 NORMAL、BD_RATE
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 评测类型，可选 PSNR、SSIM、VMAF、VMAF_NEG
        /// </summary>
        [JsonProperty("EvaluationTypeSet")]
        public string[] EvaluationTypeSet{ get; set; }

        /// <summary>
        /// 评测范围类型，可选 ALL（全部时长）、TIME（指定时长范围）、FRAME（指定帧数范围）
        /// </summary>
        [JsonProperty("EvaluationRangeType")]
        public string EvaluationRangeType{ get; set; }

        /// <summary>
        /// 对比视频信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContrastInfoSet")]
        [System.Obsolete]
        public MediaInputInfo[] ContrastInfoSet{ get; set; }

        /// <summary>
        /// 对比视频信息。
        /// </summary>
        [JsonProperty("ContrastMediaSet")]
        public EvaluationMediaInputInfo[] ContrastMediaSet{ get; set; }

        /// <summary>
        /// 对比转码模板信息。
        /// </summary>
        [JsonProperty("ContrastTemplateSet")]
        public EvaluationTemplateInputInfo[] ContrastTemplateSet{ get; set; }

        /// <summary>
        /// 开始评测时间，单位秒，当 EvaluationRangeType 为 TIME 时有效。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束评测时间，单位秒，当 EvaluationRangeType 为 TIME 时有效。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 评测开始帧，默认从0开始，当 EvaluationRangeType 为FRAME 时有效。
        /// </summary>
        [JsonProperty("StartFrameIndex")]
        public ulong? StartFrameIndex{ get; set; }

        /// <summary>
        /// 评测结束帧，默认为视频中可以参与评测的最后一帧，当 EvaluationRangeType 为 FRAME 时有效。
        /// </summary>
        [JsonProperty("EndFrameIndex")]
        public ulong? EndFrameIndex{ get; set; }

        /// <summary>
        /// 分辨率对齐模式，默认对齐到低分辨率的视频，可选 ALIGN_HIGH_RESOLUTION、ALIGN_LOW_RESOLUTION
        /// </summary>
        [JsonProperty("ResolutionAlignmentMode")]
        public string ResolutionAlignmentMode{ get; set; }

        /// <summary>
        /// 指定码率评测，当评测任务类型为 BD_RATE 有效。
        /// </summary>
        [JsonProperty("BitrateSet")]
        public long?[] BitrateSet{ get; set; }

        /// <summary>
        /// 指定 vcrf 评测，当评测任务类型为 BD_RATE 有效。
        /// </summary>
        [JsonProperty("VCRFSet")]
        public long?[] VCRFSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EvaluationTypeSet.", this.EvaluationTypeSet);
            this.SetParamSimple(map, prefix + "EvaluationRangeType", this.EvaluationRangeType);
            this.SetParamArrayObj(map, prefix + "ContrastInfoSet.", this.ContrastInfoSet);
            this.SetParamArrayObj(map, prefix + "ContrastMediaSet.", this.ContrastMediaSet);
            this.SetParamArrayObj(map, prefix + "ContrastTemplateSet.", this.ContrastTemplateSet);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartFrameIndex", this.StartFrameIndex);
            this.SetParamSimple(map, prefix + "EndFrameIndex", this.EndFrameIndex);
            this.SetParamSimple(map, prefix + "ResolutionAlignmentMode", this.ResolutionAlignmentMode);
            this.SetParamArraySimple(map, prefix + "BitrateSet.", this.BitrateSet);
            this.SetParamArraySimple(map, prefix + "VCRFSet.", this.VCRFSet);
        }
    }
}

