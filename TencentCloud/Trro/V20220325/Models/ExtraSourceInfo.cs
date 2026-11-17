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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtraSourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>伴生文件的引用名。只允许 [A-Za-z0-9._-] 路径段，可含子目录（深度 ≤3 层）；不能以 / 开头，不能包含 ..；同一请求内不重复</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>伴生文件相对主视频所在目录（含文件名）的 COS 相对路径。必须为相对路径（不能以 / 开头），长度 ≤128 字节，允许 ../ 上溯最多 2 层；批量接口支持 ${FileName} 占位符（替换为该处理项主视频文件名，不含扩展名</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Path", this.Path);
        }
    }
}

