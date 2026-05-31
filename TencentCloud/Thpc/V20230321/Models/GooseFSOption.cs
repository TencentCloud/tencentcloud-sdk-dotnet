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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GooseFSOption : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统本地挂载路径。</p>
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }

        /// <summary>
        /// <p>文件系统远程挂载路径; 远端路径为GooseFS控制台看到的命名空间的url;命名空间文档参考https://cloud.tencent.com/document/product/1424/117877</p>
        /// </summary>
        [JsonProperty("RemotePath")]
        public string RemotePath{ get; set; }

        /// <summary>
        /// <p>文件系统master的ip和端口，此参数和FileSystemId互斥。</p>
        /// </summary>
        [JsonProperty("Masters")]
        public string[] Masters{ get; set; }

        /// <summary>
        /// <p>GooseFS的文件ID；此参数和Masters 互斥。</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
            this.SetParamSimple(map, prefix + "RemotePath", this.RemotePath);
            this.SetParamArraySimple(map, prefix + "Masters.", this.Masters);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
        }
    }
}

