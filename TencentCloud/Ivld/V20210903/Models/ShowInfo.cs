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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShowInfo : AbstractModel
    {
        
        /// <summary>
        /// 节目日期(只在新闻有效)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 台标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// 节目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Column")]
        public string Column{ get; set; }

        /// <summary>
        /// 来源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 节目封面
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverImageURL")]
        public string CoverImageURL{ get; set; }

        /// <summary>
        /// 节目内容概要列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SummarySet")]
        public string[] SummarySet{ get; set; }

        /// <summary>
        /// 节目片段标题列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TitleSet")]
        public string[] TitleSet{ get; set; }

        /// <summary>
        /// 音频识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioInfoSet")]
        public AudioInfo[] AudioInfoSet{ get; set; }

        /// <summary>
        /// 可视文字识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextInfoSet")]
        public TextInfo[] TextInfoSet{ get; set; }

        /// <summary>
        /// 文本标签列表，包含标签内容和出现信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextTagSet")]
        public MultiLevelTag TextTagSet{ get; set; }

        /// <summary>
        /// 帧标签列表，包括人物信息，场景信息等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameTagSet")]
        public MultiLevelTag FrameTagSet{ get; set; }

        /// <summary>
        /// 视频下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebMediaURL")]
        public string WebMediaURL{ get; set; }

        /// <summary>
        /// 媒资分类信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaClassifierSet")]
        public string[] MediaClassifierSet{ get; set; }

        /// <summary>
        /// 概要标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SummaryTagSet")]
        public string[] SummaryTagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "Column", this.Column);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "CoverImageURL", this.CoverImageURL);
            this.SetParamArraySimple(map, prefix + "SummarySet.", this.SummarySet);
            this.SetParamArraySimple(map, prefix + "TitleSet.", this.TitleSet);
            this.SetParamArrayObj(map, prefix + "AudioInfoSet.", this.AudioInfoSet);
            this.SetParamArrayObj(map, prefix + "TextInfoSet.", this.TextInfoSet);
            this.SetParamObj(map, prefix + "TextTagSet.", this.TextTagSet);
            this.SetParamObj(map, prefix + "FrameTagSet.", this.FrameTagSet);
            this.SetParamSimple(map, prefix + "WebMediaURL", this.WebMediaURL);
            this.SetParamArraySimple(map, prefix + "MediaClassifierSet.", this.MediaClassifierSet);
            this.SetParamArraySimple(map, prefix + "SummaryTagSet.", this.SummaryTagSet);
        }
    }
}

