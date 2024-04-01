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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrUpdateResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID，必填项
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 文件名，必填项
        /// </summary>
        [JsonProperty("Files")]
        public string[] Files{ get; set; }

        /// <summary>
        /// 必填项，文件所属路径，资源管理根路径为 /datastudio/resource/项目ID/文件夹名
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// cos存储桶名字
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// cos所属地域
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 是否为新文件，新增为 true，更新为 false
        /// </summary>
        [JsonProperty("NewFile")]
        public bool? NewFile{ get; set; }

        /// <summary>
        /// 必填项，文件大小，与 Files 字段对应
        /// </summary>
        [JsonProperty("FilesSize")]
        public string[] FilesSize{ get; set; }

        /// <summary>
        /// 必填项，资源的Md5值（COS中的ETag）
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "Files.", this.Files);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "NewFile", this.NewFile);
            this.SetParamArraySimple(map, prefix + "FilesSize.", this.FilesSize);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
        }
    }
}

