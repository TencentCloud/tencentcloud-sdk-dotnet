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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetUserQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统 ID,通过<a href="https://cloud.tencent.com/document/api/582/38170">查询文件系统列表</a>获取</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>指定配额类型，包括Uid、Gid，Dir，分别代表用户配额，用户组配额，目录配额</p>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// <p>UID/GID信息</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>容量硬限制，单位GiB。设置范围10-10000000。</p>
        /// </summary>
        [JsonProperty("CapacityHardLimit")]
        public ulong? CapacityHardLimit{ get; set; }

        /// <summary>
        /// <p>文件硬限制，单位个。设置范围1000-100000000</p>
        /// </summary>
        [JsonProperty("FileHardLimit")]
        public ulong? FileHardLimit{ get; set; }

        /// <summary>
        /// <p>需设置配额的目录路径，必须以 /cfs/ 开头，代表文件存储实例内部的逻辑路径，而非本地挂载点路径。不同目录之间不可存在包含关系。<br>示例：</p><ul><li>若挂载的是CFS根目录 /，需对挂载路径下的 test1/test2 设置配额，则入参值为 /cfs/test1/test2</li><li>若挂载的是CFS子目录 /subdir，需对挂载路径下的 test1/test2 设置配额，则入参值为 /cfs/subdir/test1/test2</li></ul>
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "CapacityHardLimit", this.CapacityHardLimit);
            this.SetParamSimple(map, prefix + "FileHardLimit", this.FileHardLimit);
            this.SetParamSimple(map, prefix + "DirectoryPath", this.DirectoryPath);
        }
    }
}

