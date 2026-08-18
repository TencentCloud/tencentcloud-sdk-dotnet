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

    public class DoDirectoryOperationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件系统 ID。当前仅 Turbo 系列文件系统支持调用此接口，通用系列文件系统（含增强型）不支持调用。</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>create：创建目录，等同于mkdir。<br>check：确认目录是否存在，等同于stat。<br>move：对文件/目录进行重命名，等同于mv。</p>
        /// </summary>
        [JsonProperty("OpetationType")]
        public string OpetationType{ get; set; }

        /// <summary>
        /// <p>系统会默认递归创建路径中的所有父级目录。路径必须从 /cfs/ 开始，代表文件存储实例内部的逻辑路径，而非本地挂载点路径。<br>示例：</p><ul><li><p>若操作为 create/check</p><ul><li>若挂载的是CFS根目录 /，需在挂载路径下创建/检查是否存在 test1/test2，则入参值为 /cfs/test1/test2</li><li>若挂载的是CFS子目录 /subdir，需在挂载路径下创建/检查是否存在 test1/test2，则入参值为 /cfs/subdir/test1/test2</li></ul></li><li><p>若操作为 move</p><ul><li>若挂载的是CFS根目录 /，需在挂载路径下移动 test1/test2 下的文件到 DestPath，则入参值为 /cfs/test1/test2</li><li>若挂载的是CFS子目录 /subdir，需在挂载路径下挂载路径下移动 test1/test2 下的文件到 DestPath，则入参值为 /cfs/subdir/test1/test2</li></ul></li></ul>
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }

        /// <summary>
        /// <p>创建目录的权限，若不传，默认为0755。若OperationType为 check，此值无实际意义。</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>mv 操作的目标目录路径，必须以 /cfs/ 开头，代表文件存储实例内部的逻辑路径，而非本地挂载点路径。<br>示例：</p><ul><li>若挂载的是CFS根目录 /，需将 DirectoryPath 下的文件移动到挂载路径下的 test3/test4，则入参值为 /cfs/test3/test4</li><li>若挂载的是CFS子目录 /subdir，需将 DirectoryPath 下的文件移动到挂载路径下的 test3/test4，则入参值为 /cfs/subdir/ test3/test4</li></ul>
        /// </summary>
        [JsonProperty("DestPath")]
        public string DestPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "OpetationType", this.OpetationType);
            this.SetParamSimple(map, prefix + "DirectoryPath", this.DirectoryPath);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "DestPath", this.DestPath);
        }
    }
}

