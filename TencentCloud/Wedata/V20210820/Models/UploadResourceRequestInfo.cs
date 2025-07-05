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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadResourceRequestInfo : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 资源路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 桶名称
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 所属地区
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 是否为新资源
        /// </summary>
        [JsonProperty("NewFile")]
        public bool? NewFile{ get; set; }

        /// <summary>
        /// 资源列表
        /// </summary>
        [JsonProperty("FileList")]
        public string[] FileList{ get; set; }

        /// <summary>
        /// 资源大小列表
        /// </summary>
        [JsonProperty("FileSizeList")]
        public string[] FileSizeList{ get; set; }

        /// <summary>
        /// File Md5（适配私有化，公有云可以不传）
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "NewFile", this.NewFile);
            this.SetParamArraySimple(map, prefix + "FileList.", this.FileList);
            this.SetParamArraySimple(map, prefix + "FileSizeList.", this.FileSizeList);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
        }
    }
}

