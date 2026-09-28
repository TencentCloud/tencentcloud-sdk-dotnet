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

    public class CreateFolderRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间名称</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>文件夹名称</p>
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// <p>文件夹类型</p><p>枚举值：</p><ul><li>FOLDER： 文件夹</li><li>GIT_FOLDER： git文件夹</li></ul>
        /// </summary>
        [JsonProperty("FolderType")]
        public string FolderType{ get; set; }

        /// <summary>
        /// <p>父节点</p>
        /// </summary>
        [JsonProperty("ParentFolder")]
        public FolderLocator ParentFolder{ get; set; }

        /// <summary>
        /// <p>git配置，FolderType=GIT_FOLDER 时必填</p>
        /// </summary>
        [JsonProperty("GitConfig")]
        public GitRepoConfig GitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "FolderType", this.FolderType);
            this.SetParamObj(map, prefix + "ParentFolder.", this.ParentFolder);
            this.SetParamObj(map, prefix + "GitConfig.", this.GitConfig);
        }
    }
}

