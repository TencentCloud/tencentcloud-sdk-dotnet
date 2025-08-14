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

    public class MPSOutputFile : AbstractModel
    {
        
        /// <summary>
        /// 文件类型。用于标识 MPS 视频处理任务执行结果中的特定返回文件。
        /// 取值：<li>AiAnalysis.DeLogo.Video: 智能擦除任务中产生的擦除后视频文件，默认以原文件类型存储；</li><li>AiAnalysis.DeLogo.OriginSubtitle: 智能擦除任务中基于画面提取的字幕文件；</li><li>AiAnalysis.DeLogo.TranslateSubtitle: 智能擦除任务中基于画面提取的字幕翻译文件。</li><li>MediaProcess.Transcode.Video: 音视频增强任务中增强后的音视频文件，默认以转码文件类型存储。</li>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 存储形式。用于表示该结果文件的存储形式，取值有：<li> Permanent：永久存储；</li><li> Temporary：临时存储。</li>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// 媒体文件 ID。当 Type 为 Permanent 时有效，表示该结果文件以视频媒资形式存储在点播平台中，字段值为视频媒资的 FileId。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 结果文件的可下载 Url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 转码规格 ID。当 FileType 等于 MediaProcess.Transcode.Video时有效，取值为0表示原始文件。 
        /// </summary>
        [JsonProperty("Definition")]
        public string Definition{ get; set; }

        /// <summary>
        /// 过期时间。当 StorageMode 为 Temporary 时有效，表示 Url 的过期时间，单位为秒。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public ulong? ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

