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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteFoldersRequest : AbstractModel
    {
        
        /// <summary>
        /// 需删除的文件夹唯一ID
        /// </summary>
        [JsonProperty("FolderIds")]
        public string[] FolderIds{ get; set; }

        /// <summary>
        /// 文件夹类型，0是任务文件夹，1是依赖文件夹
        /// </summary>
        [JsonProperty("FolderType")]
        public long? FolderType{ get; set; }

        /// <summary>
        /// 工作空间 SerialId
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FolderIds.", this.FolderIds);
            this.SetParamSimple(map, prefix + "FolderType", this.FolderType);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
        }
    }
}

