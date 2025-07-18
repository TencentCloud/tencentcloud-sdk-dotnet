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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 进程名称
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 进程权限
        /// </summary>
        [JsonProperty("ProcessAuthority")]
        public string ProcessAuthority{ get; set; }

        /// <summary>
        /// 进程pid
        /// </summary>
        [JsonProperty("ProcessId")]
        public ulong? ProcessId{ get; set; }

        /// <summary>
        /// 进程启动用户
        /// </summary>
        [JsonProperty("ProcessStartUser")]
        public string ProcessStartUser{ get; set; }

        /// <summary>
        /// 进程用户组
        /// </summary>
        [JsonProperty("ProcessUserGroup")]
        public string ProcessUserGroup{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 进程树
        /// </summary>
        [JsonProperty("ProcessTree")]
        public string ProcessTree{ get; set; }

        /// <summary>
        /// 进程md5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// 进程命令行参数
        /// </summary>
        [JsonProperty("ProcessParam")]
        public string ProcessParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessAuthority", this.ProcessAuthority);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessStartUser", this.ProcessStartUser);
            this.SetParamSimple(map, prefix + "ProcessUserGroup", this.ProcessUserGroup);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessTree", this.ProcessTree);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "ProcessParam", this.ProcessParam);
        }
    }
}

