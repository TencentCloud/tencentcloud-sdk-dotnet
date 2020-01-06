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

    public class CreateCfsFileSystemResponse : AbstractModel
    {
        
        /// <summary>
        /// 文件系统创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 用户自定义文件系统名称
        /// </summary>
        [JsonProperty("CreationToken")]
        public string CreationToken{ get; set; }

        /// <summary>
        /// 文件系统 ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统状态
        /// </summary>
        [JsonProperty("LifeCycleState")]
        public string LifeCycleState{ get; set; }

        /// <summary>
        /// 文件系统已使用容量大小
        /// </summary>
        [JsonProperty("SizeByte")]
        public ulong? SizeByte{ get; set; }

        /// <summary>
        /// 可用区 ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 用户自定义文件系统名称
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// 文件系统是否加密
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "CreationToken", this.CreationToken);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "LifeCycleState", this.LifeCycleState);
            this.SetParamSimple(map, prefix + "SizeByte", this.SizeByte);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

