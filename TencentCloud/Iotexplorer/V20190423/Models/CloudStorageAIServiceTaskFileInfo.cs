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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudStorageAIServiceTaskFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 文件名称（含扩展名）
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件大小（单位：bytes）
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// 文件下载 URL
        /// </summary>
        [JsonProperty("DownloadURL")]
        public string DownloadURL{ get; set; }

        /// <summary>
        /// 文件的 MIME Type
        /// </summary>
        [JsonProperty("MimeType")]
        public string MimeType{ get; set; }

        /// <summary>
        /// 视频文件元数据（仅当文件为视频类型时包含该字段）
        /// </summary>
        [JsonProperty("VideoMetaInfo")]
        public CloudStorageAIServiceTaskVideoMetaInfo VideoMetaInfo{ get; set; }

        /// <summary>
        /// 文件标签
        /// </summary>
        [JsonProperty("Labels")]
        public CloudStorageAIServiceTaskFileLabel[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "DownloadURL", this.DownloadURL);
            this.SetParamSimple(map, prefix + "MimeType", this.MimeType);
            this.SetParamObj(map, prefix + "VideoMetaInfo.", this.VideoMetaInfo);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

