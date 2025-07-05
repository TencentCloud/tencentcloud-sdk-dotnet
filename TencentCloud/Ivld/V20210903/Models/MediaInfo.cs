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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒资ID
        /// </summary>
        [JsonProperty("MediaId")]
        public string MediaId{ get; set; }

        /// <summary>
        /// 媒资名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 媒资下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownLoadURL")]
        public string DownLoadURL{ get; set; }

        /// <summary>
        /// 媒资状态，取值参看上方表格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 若状态为失败，表示失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// 媒资视频元信息，仅在MediaType=VIDEO时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadata")]
        public MediaMetadata Metadata{ get; set; }

        /// <summary>
        /// 导入视频进度，取值范围为[0,100]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 媒资自定义标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 媒资导入完成后的回调地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackURL")]
        public string CallbackURL{ get; set; }

        /// <summary>
        /// 媒资文件类型，具体参看[MediaPreknownInfo](https://cloud.tencent.com/document/product/1509/65063#MediaPreknownInfo)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaType")]
        public long? MediaType{ get; set; }

        /// <summary>
        /// 媒资音频元信息，仅在MediaType=Audio时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioMetadata")]
        public AudioMetadata AudioMetadata{ get; set; }

        /// <summary>
        /// 媒资图片文件元信息，仅在MediaType=Image时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageMetadata")]
        public ImageMetadata ImageMetadata{ get; set; }

        /// <summary>
        /// 媒资文本文件元信息，仅在MediaType=Text时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextMetadata")]
        public TextMetadata TextMetadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaId", this.MediaId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DownLoadURL", this.DownLoadURL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "CallbackURL", this.CallbackURL);
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamObj(map, prefix + "AudioMetadata.", this.AudioMetadata);
            this.SetParamObj(map, prefix + "ImageMetadata.", this.ImageMetadata);
            this.SetParamObj(map, prefix + "TextMetadata.", this.TextMetadata);
        }
    }
}

