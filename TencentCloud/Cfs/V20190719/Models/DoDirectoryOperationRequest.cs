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
        /// 文件系统Id
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// create：创建目录，等同于mkdir。
        /// check：确认目录是否存在，等同于stat。
        /// move：对文件/目录进行重命名，等同于mv。
        /// </summary>
        [JsonProperty("OpetationType")]
        public string OpetationType{ get; set; }

        /// <summary>
        /// 目录的绝对路径  默认递归创建（即如果目录中有子目录不存在，则先创建出对应子目录）
        /// </summary>
        [JsonProperty("DirectoryPath")]
        public string DirectoryPath{ get; set; }

        /// <summary>
        /// 创建目录的权限，若不传，默认为0755  若Operation Type为check，此值无实际意义
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// mv操作的目标目录名称；如果是turbo文件系统必须以/cfs/开头
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

