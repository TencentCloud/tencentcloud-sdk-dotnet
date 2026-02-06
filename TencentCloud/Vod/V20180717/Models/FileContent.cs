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

    public class FileContent : AbstractModel
    {
        
        /// <summary>
        /// 对象键。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 对象最后修改时间，为 ISO8601格式，例如2019-05-24T10:56:40Z。
        /// </summary>
        [JsonProperty("LastModified")]
        public string LastModified{ get; set; }

        /// <summary>
        /// 对象的实体标签（Entity Tag），是对象被创建时标识对象内容的信息标签，可用于检查对象的内容是否发生变化。
        /// </summary>
        [JsonProperty("ETag")]
        public string ETag{ get; set; }

        /// <summary>
        /// 对象大小，单位为Byte。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 枚举值请参见[存储类型](https://cloud.tencent.com/document/product/436/33417)文档，例如 STANDARD_IA，ARCHIVE。
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }

        /// <summary>
        /// 此文件对应的媒体文件的唯一标识。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 文件分类： <li>Video: 视频文件</li> <li>Audio: 音频文件</li> <li>Image: 图片文件</li> <li>Other: 其他文件</li>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 可选值有：
        ///  - OriginalFiles：原文件
        /// - TranscodeFiles：转码文件
        /// - AdaptiveDynamicStreamingFiles：转自适应码流文件
        /// - SubtitleFiles：字幕文件
        /// - SampleSnapshotFiles：采样截图文件
        /// - ImageSpriteFiles：雪碧图截图文件
        /// - SnapshotByTimeOffsetFiles：时间点截图文件
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 视频模板号，模板定义参见转码模板。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 字幕ID。
        /// 仅当FileType=SubtitleFiles时有值。
        /// </summary>
        [JsonProperty("SubtitleID")]
        public string SubtitleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "LastModified", this.LastModified);
            this.SetParamSimple(map, prefix + "ETag", this.ETag);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubtitleID", this.SubtitleID);
        }
    }
}

