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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceFolder : AbstractModel
    {
        
        /// <summary>
        /// 资源文件夹ID
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("CreateUserName")]
        public string CreateUserName{ get; set; }

        /// <summary>
        /// 文件夹路径
        /// </summary>
        [JsonProperty("FolderPath")]
        public string FolderPath{ get; set; }

        /// <summary>
        /// 文件夹名称
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CreateUserName", this.CreateUserName);
            this.SetParamSimple(map, prefix + "FolderPath", this.FolderPath);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
        }
    }
}

