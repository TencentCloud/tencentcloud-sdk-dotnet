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

    public class EventContent : AbstractModel
    {
        
        /// <summary>
        /// 事件句柄，调用方必须调用 ConfirmEvents 来确认消息已经收到，确认有效时间 30 秒。失效后，事件可重新被获取。
        /// </summary>
        [JsonProperty("EventHandle")]
        public string EventHandle{ get; set; }

        /// <summary>
        /// <b>支持事件类型：</b>
        /// <li>NewFileUpload：视频上传完成；</li>
        /// <li>ProcedureStateChanged：任务流状态变更；</li>
        /// <li>FileDeleted：视频删除完成；</li>
        /// <li>RestoreMediaComplete：视频取回完成；</li>
        /// <li>PullComplete：视频转拉完成；</li>
        /// <li>EditMediaComplete：视频编辑完成；</li>
        /// <li>SplitMediaComplete：视频拆分完成；</li>
        /// <li>ComposeMediaComplete：制作媒体文件完成；</li>
        /// <li>WechatMiniProgramPublishComplete：微信小程序发布完成。</li>
        /// <li>RemoveWatermark：智能去除水印完成。</li>
        /// <li>RebuildMediaComplete：音画质重生完成事件（不推荐使用）。</li>
        /// <li>ReviewAudioVideoComplete：音视频审核完成；</li>
        /// <li>ExtractTraceWatermarkComplete：提取溯源水印完成；</li>
        /// <li>ExtractCopyRightWatermarkComplete：提取版权水印完成；</li>
        /// <li>DescribeFileAttributesComplete：获取文件属性完成；</li>
        /// <li>QualityInspectComplete：音画质检测完成；</li>
        /// <li>QualityEnhanceComplete：音画质重生任务完成；</li>
        /// <li>PersistenceComplete：剪辑固化完成；</li>
        /// <li>ComplexAdaptiveDynamicStreamingComplete：复杂自适应码流任务完成。</li>
        /// <li>ProcessMediaByMPSComplete：MPS视频处理完成。</li>
        /// <b>兼容 2017 版的事件类型：</b>
        /// <li>TranscodeComplete：视频转码完成；</li>
        /// <li>ConcatComplete：视频拼接完成；</li>
        /// <li>ClipComplete：视频剪辑完成；</li>
        /// <li>CreateImageSpriteComplete：视频截取雪碧图完成；</li>
        /// <li>CreateSnapshotByTimeOffsetComplete：视频按时间点截图完成。</li>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 视频上传完成事件，当事件类型为 NewFileUpload 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileUploadEvent")]
        public FileUploadTask FileUploadEvent{ get; set; }

        /// <summary>
        /// 任务流状态变更事件，当事件类型为 ProcedureStateChanged 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcedureStateChangeEvent")]
        public ProcedureTask ProcedureStateChangeEvent{ get; set; }

        /// <summary>
        /// 文件删除事件，当事件类型为 FileDeleted 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileDeleteEvent")]
        public FileDeleteTask FileDeleteEvent{ get; set; }

        /// <summary>
        /// 视频转拉完成事件，当事件类型为 PullComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PullCompleteEvent")]
        public PullUploadTask PullCompleteEvent{ get; set; }

        /// <summary>
        /// 视频编辑完成事件，当事件类型为 EditMediaComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EditMediaCompleteEvent")]
        public EditMediaTask EditMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 视频拆分完成事件，当事件类型为 SplitMediaComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SplitMediaCompleteEvent")]
        public SplitMediaTask SplitMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 制作媒体文件任务完成事件，当事件类型为 ComposeMediaComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComposeMediaCompleteEvent")]
        public ComposeMediaTask ComposeMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 视频剪辑完成事件，当事件类型为 ClipComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClipCompleteEvent")]
        public ClipTask2017 ClipCompleteEvent{ get; set; }

        /// <summary>
        /// 视频转码完成事件，当事件类型为 TranscodeComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranscodeCompleteEvent")]
        public TranscodeTask2017 TranscodeCompleteEvent{ get; set; }

        /// <summary>
        /// 视频截取雪碧图完成事件，当事件类型为 CreateImageSpriteComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateImageSpriteCompleteEvent")]
        public CreateImageSpriteTask2017 CreateImageSpriteCompleteEvent{ get; set; }

        /// <summary>
        /// 视频拼接完成事件，当事件类型为 ConcatComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcatCompleteEvent")]
        public ConcatTask2017 ConcatCompleteEvent{ get; set; }

        /// <summary>
        /// 视频按时间点截图完成事件，当事件类型为 CreateSnapshotByTimeOffsetComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetCompleteEvent")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetCompleteEvent{ get; set; }

        /// <summary>
        /// 微信发布完成事件，当事件类型为 WechatPublishComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatPublishCompleteEvent")]
        public WechatPublishTask WechatPublishCompleteEvent{ get; set; }

        /// <summary>
        /// 微信小程序发布任务完成事件，当事件类型为 WechatMiniProgramPublishComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishCompleteEvent")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishCompleteEvent{ get; set; }

        /// <summary>
        /// 智能去除水印完成事件，当事件类型为 RemoveWatermark 有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoveWatermarkCompleteEvent")]
        public RemoveWatermarkTask RemoveWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 视频取回完成事件，当事件类型为 RestoreMediaComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RestoreMediaCompleteEvent")]
        public RestoreMediaTask RestoreMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 音画质重生完成事件，当事件类型为 RebuildMediaComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RebuildMediaCompleteEvent")]
        public RebuildMediaTask RebuildMediaCompleteEvent{ get; set; }

        /// <summary>
        /// 溯源水印提取完成事件，当事件类型为 ExtractTraceWatermarkComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtractTraceWatermarkCompleteEvent")]
        public ExtractTraceWatermarkTask ExtractTraceWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 版权水印提取完成事件，当事件类型为 ExtractCopyRightWatermarkComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtractCopyRightWatermarkCompleteEvent")]
        public ExtractCopyRightWatermarkTask ExtractCopyRightWatermarkCompleteEvent{ get; set; }

        /// <summary>
        /// 音视频审核完成事件，当事件类型为 ReviewAudioVideoComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReviewAudioVideoCompleteEvent")]
        public ReviewAudioVideoTask ReviewAudioVideoCompleteEvent{ get; set; }

        /// <summary>
        /// 该字段已无效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReduceMediaBitrateCompleteEvent")]
        public ReduceMediaBitrateTask ReduceMediaBitrateCompleteEvent{ get; set; }

        /// <summary>
        /// 获取文件属性完成事件，当事件类型为 DescribeFileAttributesComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescribeFileAttributesCompleteEvent")]
        public DescribeFileAttributesTask DescribeFileAttributesCompleteEvent{ get; set; }

        /// <summary>
        /// 音画质检测完成事件，当事件类型为 QualityInspectComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityInspectCompleteEvent")]
        public QualityInspectTask QualityInspectCompleteEvent{ get; set; }

        /// <summary>
        /// 音画质重生完成事件，当事件类型为 QualityEnhanceComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityEnhanceCompleteEvent")]
        public QualityEnhanceTask QualityEnhanceCompleteEvent{ get; set; }

        /// <summary>
        /// 媒体转推状态变化事件，当事件类型为 MediaCastStatusChanged 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaCastStatusChangedEvent")]
        public MediaCastEvent MediaCastStatusChangedEvent{ get; set; }

        /// <summary>
        /// 剪辑固化完成事件，当事件类型为 PersistenceComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersistenceCompleteEvent")]
        public PersistenceCompleteTask PersistenceCompleteEvent{ get; set; }

        /// <summary>
        /// 自适应码流任务信息，仅当 EventType 为ComplexAdaptiveDynamicStreamingComplete 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplexAdaptiveDynamicStreamingCompleteEvent")]
        public ComplexAdaptiveDynamicStreamingTask ComplexAdaptiveDynamicStreamingCompleteEvent{ get; set; }

        /// <summary>
        /// MPS 视频处理任务信息，仅当 EventType 为 ProcessMediaByMPSComplete 时有效。
        /// </summary>
        [JsonProperty("ProcessMediaByMPSCompleteEvent")]
        public ProcessMediaByMPS ProcessMediaByMPSCompleteEvent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventHandle", this.EventHandle);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamObj(map, prefix + "FileUploadEvent.", this.FileUploadEvent);
            this.SetParamObj(map, prefix + "ProcedureStateChangeEvent.", this.ProcedureStateChangeEvent);
            this.SetParamObj(map, prefix + "FileDeleteEvent.", this.FileDeleteEvent);
            this.SetParamObj(map, prefix + "PullCompleteEvent.", this.PullCompleteEvent);
            this.SetParamObj(map, prefix + "EditMediaCompleteEvent.", this.EditMediaCompleteEvent);
            this.SetParamObj(map, prefix + "SplitMediaCompleteEvent.", this.SplitMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ComposeMediaCompleteEvent.", this.ComposeMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ClipCompleteEvent.", this.ClipCompleteEvent);
            this.SetParamObj(map, prefix + "TranscodeCompleteEvent.", this.TranscodeCompleteEvent);
            this.SetParamObj(map, prefix + "CreateImageSpriteCompleteEvent.", this.CreateImageSpriteCompleteEvent);
            this.SetParamObj(map, prefix + "ConcatCompleteEvent.", this.ConcatCompleteEvent);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetCompleteEvent.", this.SnapshotByTimeOffsetCompleteEvent);
            this.SetParamObj(map, prefix + "WechatPublishCompleteEvent.", this.WechatPublishCompleteEvent);
            this.SetParamObj(map, prefix + "WechatMiniProgramPublishCompleteEvent.", this.WechatMiniProgramPublishCompleteEvent);
            this.SetParamObj(map, prefix + "RemoveWatermarkCompleteEvent.", this.RemoveWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "RestoreMediaCompleteEvent.", this.RestoreMediaCompleteEvent);
            this.SetParamObj(map, prefix + "RebuildMediaCompleteEvent.", this.RebuildMediaCompleteEvent);
            this.SetParamObj(map, prefix + "ExtractTraceWatermarkCompleteEvent.", this.ExtractTraceWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "ExtractCopyRightWatermarkCompleteEvent.", this.ExtractCopyRightWatermarkCompleteEvent);
            this.SetParamObj(map, prefix + "ReviewAudioVideoCompleteEvent.", this.ReviewAudioVideoCompleteEvent);
            this.SetParamObj(map, prefix + "ReduceMediaBitrateCompleteEvent.", this.ReduceMediaBitrateCompleteEvent);
            this.SetParamObj(map, prefix + "DescribeFileAttributesCompleteEvent.", this.DescribeFileAttributesCompleteEvent);
            this.SetParamObj(map, prefix + "QualityInspectCompleteEvent.", this.QualityInspectCompleteEvent);
            this.SetParamObj(map, prefix + "QualityEnhanceCompleteEvent.", this.QualityEnhanceCompleteEvent);
            this.SetParamObj(map, prefix + "MediaCastStatusChangedEvent.", this.MediaCastStatusChangedEvent);
            this.SetParamObj(map, prefix + "PersistenceCompleteEvent.", this.PersistenceCompleteEvent);
            this.SetParamObj(map, prefix + "ComplexAdaptiveDynamicStreamingCompleteEvent.", this.ComplexAdaptiveDynamicStreamingCompleteEvent);
            this.SetParamObj(map, prefix + "ProcessMediaByMPSCompleteEvent.", this.ProcessMediaByMPSCompleteEvent);
        }
    }
}

