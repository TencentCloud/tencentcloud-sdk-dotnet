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

namespace TencentCloud.Chdfs.V20190718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMountPointRequest : AbstractModel
    {
        
        /// <summary>
        /// 挂载点名称
        /// </summary>
        [JsonProperty("MountPointName")]
        public string MountPointName{ get; set; }

        /// <summary>
        /// 文件系统ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 权限组ID
        /// </summary>
        [JsonProperty("AccessGroupId")]
        public string AccessGroupId{ get; set; }

        /// <summary>
        /// VPC网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 挂载点状态（1：打开；2：关闭）
        /// </summary>
        [JsonProperty("MountPointStatus")]
        public ulong? MountPointStatus{ get; set; }

        /// <summary>
        /// VPC网络类型（1：CVM；2：黑石1.0；3：黑石2.0）
        /// </summary>
        [JsonProperty("VpcType")]
        public ulong? VpcType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MountPointName", this.MountPointName);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "AccessGroupId", this.AccessGroupId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "MountPointStatus", this.MountPointStatus);
            this.SetParamSimple(map, prefix + "VpcType", this.VpcType);
        }
    }
}

