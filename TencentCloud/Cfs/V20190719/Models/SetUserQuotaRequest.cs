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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetUserQuotaRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统 ID,通过查询文件系统列表获取
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 指定配额类型，包括Uid、Gid，Dir，分别代表用户配额，用户组配额，目录配额
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// UID/GID信息
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 容量硬限制，单位GiB。设置范围10-10000000。
        /// </summary>
        [JsonProperty("CapacityHardLimit")]
        public ulong? CapacityHardLimit{ get; set; }

        /// <summary>
        /// 文件硬限制，单位个。设置范围1000-100000000
        /// </summary>
        [JsonProperty("FileHardLimit")]
        public ulong? FileHardLimit{ get; set; }

        /// <summary>
        /// 需设置目录配额的目录绝对路径，不同目录不可存在包含关系
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

