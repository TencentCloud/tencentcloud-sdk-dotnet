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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleContentFileOperation : AbstractModel
    {
        
        /// <summary>
        /// <p>当前进程命令行信息（可选，未配置时该维度不参与匹配）</p>
        /// </summary>
        [JsonProperty("Process")]
        public RuleContentProcessInfo Process{ get; set; }

        /// <summary>
        /// <p>父进程命令行信息（可选，未配置时该维度不参与匹配）</p>
        /// </summary>
        [JsonProperty("ParentProcess")]
        public RuleContentProcessInfo ParentProcess{ get; set; }

        /// <summary>
        /// <p>目标文件路径（正则）</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>动作列表（多选为或关系）：read-读 write-写 rename-重命名 delete-删除 truncate-清空内容</p>
        /// </summary>
        [JsonProperty("FileActions")]
        public string[] FileActions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Process.", this.Process);
            this.SetParamObj(map, prefix + "ParentProcess.", this.ParentProcess);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamArraySimple(map, prefix + "FileActions.", this.FileActions);
        }
    }
}

