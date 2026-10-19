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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRules : AbstractModel
    {
        
        /// <summary>
        /// <p>进程</p>
        /// </summary>
        [JsonProperty("Process")]
        public CommandLine Process{ get; set; }

        /// <summary>
        /// <p>父进程</p>
        /// </summary>
        [JsonProperty("PProcess")]
        public CommandLine PProcess{ get; set; }

        /// <summary>
        /// <p>祖先进程</p>
        /// </summary>
        [JsonProperty("AProcess")]
        public CommandLine AProcess{ get; set; }

        /// <summary>
        /// <p>目标文件路径（匹配类型=文件操作时有效）</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>动作列表（匹配类型=文件操作时有效，多选为或关系）：read-读 write-写 rename-重命名 delete-删除 truncate-清空内容</p>
        /// </summary>
        [JsonProperty("FileActions")]
        public string[] FileActions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Process.", this.Process);
            this.SetParamObj(map, prefix + "PProcess.", this.PProcess);
            this.SetParamObj(map, prefix + "AProcess.", this.AProcess);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamArraySimple(map, prefix + "FileActions.", this.FileActions);
        }
    }
}

