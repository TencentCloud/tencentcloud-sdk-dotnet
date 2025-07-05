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

namespace TencentCloud.Thpc.V20220401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CFSOption : AbstractModel
    {
        
        /// <summary>
        /// 文件系统本地挂载路径。
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }

        /// <summary>
        /// 文件系统远程挂载ip及路径。
        /// </summary>
        [JsonProperty("RemotePath")]
        public string RemotePath{ get; set; }

        /// <summary>
        /// 文件系统协议类型，默认值NFS 3.0。
        /// <li>NFS 3.0。
        /// <li>NFS 4.0。
        /// <li>TURBO。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 文件系统存储类型，默认值SD；其中 SD 为通用标准型标准型存储， HP为通用性能型存储， TB为turbo标准型， TP 为turbo性能型。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
            this.SetParamSimple(map, prefix + "RemotePath", this.RemotePath);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

