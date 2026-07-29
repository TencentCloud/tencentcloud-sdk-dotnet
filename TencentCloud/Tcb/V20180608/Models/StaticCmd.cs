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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StaticCmd : AbstractModel
    {
        
        /// <summary>
        /// 构建命令
        /// </summary>
        [JsonProperty("BuildCmd")]
        public string BuildCmd{ get; set; }

        /// <summary>
        /// 安装命令
        /// </summary>
        [JsonProperty("InstallCmd")]
        public string InstallCmd{ get; set; }

        /// <summary>
        /// 部署命令
        /// </summary>
        [JsonProperty("DeployCmd")]
        public string DeployCmd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BuildCmd", this.BuildCmd);
            this.SetParamSimple(map, prefix + "InstallCmd", this.InstallCmd);
            this.SetParamSimple(map, prefix + "DeployCmd", this.DeployCmd);
        }
    }
}

