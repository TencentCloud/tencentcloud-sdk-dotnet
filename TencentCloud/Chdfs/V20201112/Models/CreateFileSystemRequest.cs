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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件系统名称
        /// </summary>
        [JsonProperty("FileSystemName")]
        public string FileSystemName{ get; set; }

        /// <summary>
        /// 文件系统容量（byte），下限为1GB，上限为1PB，且必须是1GB的整数倍
        /// </summary>
        [JsonProperty("CapacityQuota")]
        public ulong? CapacityQuota{ get; set; }

        /// <summary>
        /// 是否校验POSIX ACL
        /// </summary>
        [JsonProperty("PosixAcl")]
        public bool? PosixAcl{ get; set; }

        /// <summary>
        /// 文件系统描述，默认为空字符串
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 超级用户名列表，默认为空数组
        /// </summary>
        [JsonProperty("SuperUsers")]
        public string[] SuperUsers{ get; set; }

        /// <summary>
        /// 根目录Inode用户名，默认为hadoop
        /// </summary>
        [JsonProperty("RootInodeUser")]
        public string RootInodeUser{ get; set; }

        /// <summary>
        /// 根目录Inode组名，默认为supergroup
        /// </summary>
        [JsonProperty("RootInodeGroup")]
        public string RootInodeGroup{ get; set; }

        /// <summary>
        /// 是否打开Ranger地址校验
        /// </summary>
        [JsonProperty("EnableRanger")]
        public bool? EnableRanger{ get; set; }

        /// <summary>
        /// Ranger地址列表，默认为空数组
        /// </summary>
        [JsonProperty("RangerServiceAddresses")]
        public string[] RangerServiceAddresses{ get; set; }

        /// <summary>
        /// 多个资源标签，可以为空数组
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemName", this.FileSystemName);
            this.SetParamSimple(map, prefix + "CapacityQuota", this.CapacityQuota);
            this.SetParamSimple(map, prefix + "PosixAcl", this.PosixAcl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "SuperUsers.", this.SuperUsers);
            this.SetParamSimple(map, prefix + "RootInodeUser", this.RootInodeUser);
            this.SetParamSimple(map, prefix + "RootInodeGroup", this.RootInodeGroup);
            this.SetParamSimple(map, prefix + "EnableRanger", this.EnableRanger);
            this.SetParamArraySimple(map, prefix + "RangerServiceAddresses.", this.RangerServiceAddresses);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

