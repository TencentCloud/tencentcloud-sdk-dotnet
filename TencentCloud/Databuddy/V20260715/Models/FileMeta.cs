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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileMeta : AbstractModel
    {
        
        /// <summary>
        /// <p>文件id</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>文件/文件夹名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件类型</p>
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// <p>创建时间，毫秒秒级时间戳</p><p>参数格式：时间戳</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：时间戳字符串</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>acl权限类型</p>
        /// </summary>
        [JsonProperty("AllowActions")]
        public string[] AllowActions{ get; set; }

        /// <summary>
        /// <p>是否收藏</p>
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// <p>文件path</p>
        /// </summary>
        [JsonProperty("PathName")]
        public string PathName{ get; set; }

        /// <summary>
        /// <p>是否系统创建</p>
        /// </summary>
        [JsonProperty("IsSystemGenerated")]
        public bool? IsSystemGenerated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "AllowActions.", this.AllowActions);
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamSimple(map, prefix + "PathName", this.PathName);
            this.SetParamSimple(map, prefix + "IsSystemGenerated", this.IsSystemGenerated);
        }
    }
}

