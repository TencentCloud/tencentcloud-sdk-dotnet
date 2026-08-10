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

    public class HostVulComponent : AbstractModel
    {
        
        /// <summary>
        /// <p>主机简要信息</p>
        /// </summary>
        [JsonProperty("HostInfo")]
        public HostBriefInfo HostInfo{ get; set; }

        /// <summary>
        /// <p>受影响组件版本</p>
        /// </summary>
        [JsonProperty("EffectVersion")]
        public string EffectVersion{ get; set; }

        /// <summary>
        /// <p>组件在主机上的安装路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>关联进程 ID</p>
        /// </summary>
        [JsonProperty("ProcessID")]
        public string ProcessID{ get; set; }

        /// <summary>
        /// <p>修复命令（仅展示）</p>
        /// </summary>
        [JsonProperty("FixCommand")]
        public string FixCommand{ get; set; }

        /// <summary>
        /// <p>组件名字</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HostInfo.", this.HostInfo);
            this.SetParamSimple(map, prefix + "EffectVersion", this.EffectVersion);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "ProcessID", this.ProcessID);
            this.SetParamSimple(map, prefix + "FixCommand", this.FixCommand);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

