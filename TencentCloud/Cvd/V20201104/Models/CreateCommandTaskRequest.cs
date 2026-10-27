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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCommandTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 脚本任务，需要 Base64 编码
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 脚本任务类型：windows 桌面可选有：    PowerShellScript — powershell脚本    BatScript — Bat 脚本
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 执行脚本任务的实例列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 是否以绑定用户身份执行，默认 System身份运行false： System身份运行，默认行为true：以绑定用户身份执行
        /// </summary>
        [JsonProperty("RunAsBoundUser")]
        public bool? RunAsBoundUser{ get; set; }

        /// <summary>
        /// 是否前台运行false：后台运行，默认行为true：前台运行
        /// </summary>
        [JsonProperty("RunForeground")]
        public bool? RunForeground{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "RunAsBoundUser", this.RunAsBoundUser);
            this.SetParamSimple(map, prefix + "RunForeground", this.RunForeground);
        }
    }
}

