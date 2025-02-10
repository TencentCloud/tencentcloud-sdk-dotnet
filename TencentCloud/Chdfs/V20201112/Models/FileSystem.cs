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

    public class FileSystem : AbstractModel
    {
        
        /// <summary>
        /// 资源所属用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

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
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 文件系统ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 文件系统块大小（byte）
        /// </summary>
        [JsonProperty("BlockSize")]
        public ulong? BlockSize{ get; set; }

        /// <summary>
        /// 文件系统容量（byte）
        /// </summary>
        [JsonProperty("CapacityQuota")]
        public ulong? CapacityQuota{ get; set; }

        /// <summary>
        /// 文件系统状态（1：创建中；2：创建成功；3：创建失败）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 超级用户名列表
        /// </summary>
        [JsonProperty("SuperUsers")]
        public string[] SuperUsers{ get; set; }

        /// <summary>
        /// POSIX权限控制
        /// </summary>
        [JsonProperty("PosixAcl")]
        public bool? PosixAcl{ get; set; }

        /// <summary>
        /// 是否打开Ranger地址校验
        /// </summary>
        [JsonProperty("EnableRanger")]
        public bool? EnableRanger{ get; set; }

        /// <summary>
        /// Ranger地址列表
        /// </summary>
        [JsonProperty("RangerServiceAddresses")]
        public string[] RangerServiceAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "FileSystemName", this.FileSystemName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BlockSize", this.BlockSize);
            this.SetParamSimple(map, prefix + "CapacityQuota", this.CapacityQuota);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SuperUsers.", this.SuperUsers);
            this.SetParamSimple(map, prefix + "PosixAcl", this.PosixAcl);
            this.SetParamSimple(map, prefix + "EnableRanger", this.EnableRanger);
            this.SetParamArraySimple(map, prefix + "RangerServiceAddresses.", this.RangerServiceAddresses);
        }
    }
}

