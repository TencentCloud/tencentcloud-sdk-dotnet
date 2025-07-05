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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMountPointsRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统ID
        /// 备注：入参只能指定AccessGroupId、FileSystemId和OwnerUin的其中一个
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 权限组ID
        /// </summary>
        [JsonProperty("AccessGroupId")]
        public string AccessGroupId{ get; set; }

        /// <summary>
        /// 资源所属者Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "AccessGroupId", this.AccessGroupId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
        }
    }
}

