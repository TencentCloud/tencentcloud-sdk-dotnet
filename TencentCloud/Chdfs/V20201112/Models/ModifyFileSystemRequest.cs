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

    public class ModifyFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统名称
        /// </summary>
        [JsonProperty("FileSystemName")]
        public string FileSystemName{ get; set; }

        /// <summary>
        /// 文件系统描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 文件系统容量（byte），下限为1GB，上限为1PB，且必须是1GB的整数倍
        /// 注意：修改的文件系统容量不能小于当前使用量
        /// </summary>
        [JsonProperty("CapacityQuota")]
        public ulong? CapacityQuota{ get; set; }

        /// <summary>
        /// 超级用户名列表，可以为空数组
        /// </summary>
        [JsonProperty("SuperUsers")]
        public string[] SuperUsers{ get; set; }

        /// <summary>
        /// 是否校验POSIX ACL
        /// </summary>
        [JsonProperty("PosixAcl")]
        public bool? PosixAcl{ get; set; }

        /// <summary>
        /// 是否打开Ranger地址校验
        /// </summary>
        [JsonProperty("EnableRanger")]
        public bool? EnableRanger{ get; set; }

        /// <summary>
        /// Ranger地址列表，可以为空数组
        /// </summary>
        [JsonProperty("RangerServiceAddresses")]
        public string[] RangerServiceAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FileSystemName", this.FileSystemName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CapacityQuota", this.CapacityQuota);
            this.SetParamArraySimple(map, prefix + "SuperUsers.", this.SuperUsers);
            this.SetParamSimple(map, prefix + "PosixAcl", this.PosixAcl);
            this.SetParamSimple(map, prefix + "EnableRanger", this.EnableRanger);
            this.SetParamArraySimple(map, prefix + "RangerServiceAddresses.", this.RangerServiceAddresses);
        }
    }
}

