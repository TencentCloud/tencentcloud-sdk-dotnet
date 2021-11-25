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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 项目名称，不可超过30个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 项目归属者。
        /// 注：云转推项目，仅支持个人归属。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 项目类别，取值有：
        /// <li>VIDEO_EDIT：视频编辑。</li>
        /// <li>SWITCHER：导播台。</li>
        /// <li>VIDEO_SEGMENTATION：视频拆条。</li>
        /// <li>STREAM_CONNECT：云转推。</li>
        /// <li>RECORD_REPLAY：录制回放。</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 项目模式，一个项目可以有多种模式并相互切换。
        /// 当 Category 为 VIDEO_EDIT 时，可选模式有：
        /// <li>Default：默认模式。</li>
        /// <li>VideoEditTemplate：视频编辑模板制作模式。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 画布宽高比。
        /// 该字段已经废弃，请使用具体项目输入中的 AspectRatio 字段。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// 项目描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 导播台信息，仅当项目类型为 SWITCHER 时必填。
        /// </summary>
        [JsonProperty("SwitcherProjectInput")]
        public SwitcherProjectInput SwitcherProjectInput{ get; set; }

        /// <summary>
        /// 直播剪辑信息，暂未开放，请勿使用。
        /// </summary>
        [JsonProperty("LiveStreamClipProjectInput")]
        public LiveStreamClipProjectInput LiveStreamClipProjectInput{ get; set; }

        /// <summary>
        /// 视频编辑信息，仅当项目类型为 VIDEO_EDIT 时必填。
        /// </summary>
        [JsonProperty("VideoEditProjectInput")]
        public VideoEditProjectInput VideoEditProjectInput{ get; set; }

        /// <summary>
        /// 视频拆条信息，仅当项目类型为 VIDEO_SEGMENTATION  时必填。
        /// </summary>
        [JsonProperty("VideoSegmentationProjectInput")]
        public VideoSegmentationProjectInput VideoSegmentationProjectInput{ get; set; }

        /// <summary>
        /// 云转推项目信息，仅当项目类型为 STREAM_CONNECT 时必填。
        /// </summary>
        [JsonProperty("StreamConnectProjectInput")]
        public StreamConnectProjectInput StreamConnectProjectInput{ get; set; }

        /// <summary>
        /// 录制回放项目信息，仅当项目类型为 RECORD_REPLAY 时必填。
        /// </summary>
        [JsonProperty("RecordReplayProjectInput")]
        public RecordReplayProjectInput RecordReplayProjectInput{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "SwitcherProjectInput.", this.SwitcherProjectInput);
            this.SetParamObj(map, prefix + "LiveStreamClipProjectInput.", this.LiveStreamClipProjectInput);
            this.SetParamObj(map, prefix + "VideoEditProjectInput.", this.VideoEditProjectInput);
            this.SetParamObj(map, prefix + "VideoSegmentationProjectInput.", this.VideoSegmentationProjectInput);
            this.SetParamObj(map, prefix + "StreamConnectProjectInput.", this.StreamConnectProjectInput);
            this.SetParamObj(map, prefix + "RecordReplayProjectInput.", this.RecordReplayProjectInput);
        }
    }
}

