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

    public class MediaProcessTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，可以取的值有：
        /// <li>Transcode：转码</li>
        /// <li>AnimatedGraphics：转动图</li>
        /// <li>SnapshotByTimeOffset：时间点截图</li>
        /// <li>SampleSnapshot：采样截图</li>
        /// <li>ImageSprites：雪碧图</li>
        /// <li>CoverBySnapshot：截图做封面</li>
        /// <li>AdaptiveDynamicStreaming：自适应码流</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频转码任务的查询结果，当任务类型为 Transcode 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranscodeTask")]
        public MediaProcessTaskTranscodeResult TranscodeTask{ get; set; }

        /// <summary>
        /// 视频转动图任务的查询结果，当任务类型为 AnimatedGraphics 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnimatedGraphicTask")]
        public MediaProcessTaskAnimatedGraphicResult AnimatedGraphicTask{ get; set; }

        /// <summary>
        /// 对视频按时间点截图任务的查询结果，当任务类型为 SnapshotByTimeOffset 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetTask")]
        public MediaProcessTaskSnapshotByTimeOffsetResult SnapshotByTimeOffsetTask{ get; set; }

        /// <summary>
        /// 对视频采样截图任务的查询结果，当任务类型为 SampleSnapshot 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleSnapshotTask")]
        public MediaProcessTaskSampleSnapshotResult SampleSnapshotTask{ get; set; }

        /// <summary>
        /// 对视频截雪碧图任务的查询结果，当任务类型为 ImageSprite 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageSpriteTask")]
        public MediaProcessTaskImageSpriteResult ImageSpriteTask{ get; set; }

        /// <summary>
        /// 对视频截图做封面任务的查询结果，当任务类型为 CoverBySnapshot 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverBySnapshotTask")]
        public MediaProcessTaskCoverBySnapshotResult CoverBySnapshotTask{ get; set; }

        /// <summary>
        /// 对视频转自适应码流任务的查询结果，当任务类型为 AdaptiveDynamicStreaming 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingTask")]
        public MediaProcessTaskAdaptiveDynamicStreamingResult AdaptiveDynamicStreamingTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "TranscodeTask.", this.TranscodeTask);
            this.SetParamObj(map, prefix + "AnimatedGraphicTask.", this.AnimatedGraphicTask);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetTask.", this.SnapshotByTimeOffsetTask);
            this.SetParamObj(map, prefix + "SampleSnapshotTask.", this.SampleSnapshotTask);
            this.SetParamObj(map, prefix + "ImageSpriteTask.", this.ImageSpriteTask);
            this.SetParamObj(map, prefix + "CoverBySnapshotTask.", this.CoverBySnapshotTask);
            this.SetParamObj(map, prefix + "AdaptiveDynamicStreamingTask.", this.AdaptiveDynamicStreamingTask);
        }
    }
}

