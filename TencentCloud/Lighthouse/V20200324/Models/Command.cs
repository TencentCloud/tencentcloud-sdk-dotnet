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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Command : AbstractModel
    {
        
        /// <summary>
        /// Base64编码后的命令内容，长度不可超过64KB。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 命令超时时间，默认60秒。取值范围[1, 86400]。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 命令执行路径，对于 SHELL 命令默认为 /root，对于 POWERSHELL 命令默认为 C:\Program Files\qcloud\tat_agent\workdir。
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// 在 Lighthouse 实例中执行命令的用户名称。
        /// 默认情况下，在 Linux 实例中以 root 用户执行命令；在Windows 实例中以 System 用户执行命令。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "Username", this.Username);
        }
    }
}

