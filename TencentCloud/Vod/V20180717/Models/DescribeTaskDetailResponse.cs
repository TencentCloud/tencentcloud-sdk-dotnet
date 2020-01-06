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

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，取值：
        /// <li>Procedure：视频处理任务；</li>
        /// <li>EditMedia：视频编辑任务；</li>
        /// <li>WechatPublish：微信发布任务；</li>
        /// <li>WechatMiniProgramPublish：微信小程序视频发布任务；</li>
        /// <li>ComposeMedia：制作媒体文件任务；</li>
        /// <li>PullUpload：拉取上传媒体文件任务。</li>
        /// 
        /// 兼容 2017 版的任务类型：
        /// <li>Transcode：视频转码任务；</li>
        /// <li>SnapshotByTimeOffset：视频截图任务；</li>
        /// <li>Concat：视频拼接任务；</li>
        /// <li>Clip：视频剪辑任务；</li>
        /// <li>ImageSprites：截取雪碧图任务。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务状态，取值：
        /// <li>WAITING：等待中；</li>
        /// <li>PROCESSING：处理中；</li>
        /// <li>FINISH：已完成。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务的创建时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务开始执行的时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("BeginProcessTime")]
        public string BeginProcessTime{ get; set; }

        /// <summary>
        /// 任务执行完毕的时间，采用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
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
        /// 视频指定时间点截图任务信息，仅当 TaskType 为 SnapshotByTimeOffset，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public SnapshotByTimeOffsetTask2017 SnapshotByTimeOffsetTask{ get; set; }

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
        /// 微信小程序发布任务信息，仅当 TaskType 为 WechatMiniProgramPublish，该字段有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatMiniProgramPublishTask")]
        public WechatMiniProgramPublishTask WechatMiniProgramPublishTask{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamObj(map, prefix + "PullUploadTask.", this.PullUploadTask);
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "ConcatTask.", this.ConcatTask);
            this.SetParamObj(map, prefix + "ClipTask.", this.ClipTask);
            this.SetParamObj(map, prefix + "CreateImageSpriteTask.", this.CreateImageSpriteTask);
            this.SetParamObj(map, prefix + "WechatMiniProgramPublishTask.", this.WechatMiniProgramPublishTask);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

