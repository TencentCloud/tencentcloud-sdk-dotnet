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

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，取值：<li>Procedure：视频处理任务；</li><li>EditMedia：视频编辑任务；</li><li>SplitMedia：视频拆条任务；</li><li>ComposeMedia：制作媒体文件任务；</li><li>WechatPublish：微信发布任务；</li><li>WechatMiniProgramPublish：微信小程序视频发布任务；</li><li>PullUpload：拉取上传媒体文件任务；</li><li>FastClipMedia：快速剪辑任务；</li><li>RemoveWatermarkTask：智能去除水印任务；</li><li>DescribeFileAttributesTask：获取文件属性任务；</li><li>RebuildMedia：音画质重生任务（不推荐使用）；</li><li>ReviewAudioVideo：音视频审核任务；</li><li>ExtractTraceWatermark：提取溯源水印任务；</li><li>ExtractCopyRightWatermark：提取版权水印任务；</li><li>QualityInspect：音画质检测任务；</li><li>QualityEnhance：音画质重生任务；</li><li>ComplexAdaptiveDynamicStreaming：复杂自适应码流任务；</li><li>ProcessMediaByMPS：MPS 视频处理任务；</li><li>AigcImageTask：AIGC 生图任务；</li><li>AigcVideoTask：AIGC 生视频任务。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务状态，取值：
        /// <li>WAITING：等待中；</li>
        /// <li>PROCESSING：处理中；</li>
        /// <li>FINISH：已完成；</li>
        /// <li>ABORTED：已终止。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务的创建时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务开始执行的时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// 任务执行完毕的时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 视频处理任务信息，仅当 TaskType 为 Procedure，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcedureTask")]
        public ProcedureTask ProcedureTask{ get; set; }

        /// <summary>
        /// 视频编辑任务信息，仅当 TaskType 为 EditMedia，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EditMediaTask")]
        public EditMediaTask EditMediaTask{ get; set; }

        /// <summary>
        /// 微信发布任务信息，仅当 TaskType 为 WechatPublish，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatPublishTask")]
        public WechatPublishTask WechatPublishTask{ get; set; }

        /// <summary>
        /// 制作媒体文件任务信息，仅当 TaskType 为 ComposeMedia，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComposeMediaTask")]
        public ComposeMediaTask ComposeMediaTask{ get; set; }

        /// <summary>
        /// 视频拆条任务信息，仅当 TaskType 为 SplitMedia，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitMediaTask")]
        public SplitMediaTask SplitMediaTask{ get; set; }

        /// <summary>
        /// 微信小程序发布任务信息，仅当 TaskType 为 WechatMiniProgramPublish，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// 拉取上传媒体文件任务信息，仅当 TaskType 为 PullUpload，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullUploadTask")]
        public PullUploadTask PullUploadTask{ get; set; }

        /// <summary>
        /// 视频转码任务信息，仅当 TaskType 为 Transcode，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public TranscodeTask2017 TranscodeTask{ get; set; }

        /// <summary>
        /// 视频拼接任务信息，仅当 TaskType 为 Concat，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcatTask")]
        public ConcatTask2017 ConcatTask{ get; set; }

        /// <summary>
        /// 视频剪辑任务信息，仅当 TaskType 为 Clip，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClipTask")]
        public ClipTask2017 ClipTask{ get; set; }

        /// <summary>
        /// 截取雪碧图任务信息，仅当 TaskType 为 ImageSprite，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateImageSpriteTask")]
        public CreateImageSpriteTask2017 CreateImageSpriteTask{ get; set; }

        /// <summary>
        /// 视频指定时间点截图任务信息，仅当 TaskType 为 SnapshotByTimeOffset，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// 智能去除水印任务信息，仅当 TaskType 为 RemoveWatermark，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoveWatermarkTask")]
        public RemoveWatermarkTask RemoveWatermarkTask{ get; set; }

        /// <summary>
        /// 音画质重生任务信息，仅当 TaskType 为 RebuildMedia，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RebuildMediaTask")]
        public RebuildMediaTask RebuildMediaTask{ get; set; }

        /// <summary>
        /// 提取溯源水印任务信息，仅当 TaskType 为 ExtractTraceWatermark，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkTask")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkTask{ get; set; }

        /// <summary>
        /// 提取版权水印任务信息，仅当 TaskType 为 ExtractCopyRightWatermark，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkTask")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkTask{ get; set; }

        /// <summary>
        /// 音视频审核任务信息，仅当 TaskType 为 ReviewAudioVideo，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ReviewAudioVideoTask ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// 该字段已无效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReduceMediaBitrateTask")]
        public ReduceMediaBitrateTask ReduceMediaBitrateTask{ get; set; }

        /// <summary>
        /// 获取文件属性任务信息，仅当 TaskType 为 DescribeFileAttributes，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescribeFileAttributesTask")]
        public DescribeFileAttributesTask DescribeFileAttributesTask{ get; set; }

        /// <summary>
        /// 音画质检测任务信息，仅当 TaskType 为 QualityInspect 时该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityInspectTask")]
        public QualityInspectTask QualityInspectTask{ get; set; }

        /// <summary>
        /// 音画质重生任务信息，仅当 TaskType 为 QualityEnhance，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityEnhanceTask")]
        public QualityEnhanceTask QualityEnhanceTask{ get; set; }

        /// <summary>
        /// 复杂自适应码流任务信息，仅当 TaskType 为 ComplexAdaptiveDynamicStreaming，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingTask")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingTask{ get; set; }

        /// <summary>
        /// MPS 视频处理任务信息，仅当 TaskType 为 ProcessMediaByMPS，该字段有值。
        /// </summary>
        [JsonProperty("ProcessMediaByMPSTask")]
        public ProcessMediaByMPS ProcessMediaByMPSTask{ get; set; }

        /// <summary>
        /// AIGC 生图任务信息，仅当 TaskType 为 AigcImageTask，该字段有值。
        /// </summary>
        [JsonProperty("AigcImageTask")]
        public AigcImageTask AigcImageTask{ get; set; }

        /// <summary>
        /// AIGC 生视频任务信息，仅当 TaskType 为 AigcVideoTask，该字段有值。
        /// </summary>
        [JsonProperty("AigcVideoTask")]
        public AigcVideoTask AigcVideoTask{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BeginProcessTime", this.BeginProcessTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamObj(map, prefix + "ProcedureTask.", this.ProcedureTask);
            this.SetParamObj(map, prefix + "EditMediaTask.", this.EditMediaTask);
            this.SetParamObj(map, prefix + "WechatPublishTask.", this.WechatPublishTask);
            this.SetParamObj(map, prefix + "ComposeMediaTask.", this.ComposeMediaTask);
            this.SetParamObj(map, prefix + "SplitMediaTask.", this.SplitMediaTask);
            this.SetParamObj(map, prefix + "WechatMiniProgramPublishTask.", this.WechatMiniProgramPublishTask);
            this.SetParamObj(map, prefix + "PullUploadTask.", this.PullUploadTask);
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "ConcatTask.", this.ConcatTask);
            this.SetParamObj(map, prefix + "ClipTask.", this.ClipTask);
            this.SetParamObj(map, prefix + "CreateImageSpriteTask.", this.CreateImageSpriteTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "RemoveWatermarkTask.", this.RemoveWatermarkTask);
            this.SetParamObj(map, prefix + "RebuildMediaTask.", this.RebuildMediaTask);
            this.SetParamObj(map, prefix + "ExtractTraceWatermarkTask.", this.ExtractTraceWatermarkTask);
            this.SetParamObj(map, prefix + "ExtractCopyRightWatermarkTask.", this.ExtractCopyRightWatermarkTask);
            this.SetParamObj(map, prefix + "ReviewAudioVideoTask.", this.ReviewAudioVideoTask);
            this.SetParamObj(map, prefix + "ReduceMediaBitrateTask.", this.ReduceMediaBitrateTask);
            this.SetParamObj(map, prefix + "DescribeFileAttributesTask.", this.DescribeFileAttributesTask);
            this.SetParamObj(map, prefix + "QualityInspectTask.", this.QualityInspectTask);
            this.SetParamObj(map, prefix + "QualityEnhanceTask.", this.QualityEnhanceTask);
            this.SetParamObj(map, prefix + "ComplexAdaptiveDynamicStreamingTask.", this.ComplexAdaptiveDynamicStreamingTask);
            this.SetParamObj(map, prefix + "ProcessMediaByMPSTask.", this.ProcessMediaByMPSTask);
            this.SetParamObj(map, prefix + "AigcImageTask.", this.AigcImageTask);
            this.SetParamObj(map, prefix + "AigcVideoTask.", this.AigcVideoTask);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

