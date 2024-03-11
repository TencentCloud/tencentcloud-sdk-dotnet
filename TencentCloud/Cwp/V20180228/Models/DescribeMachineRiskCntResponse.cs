/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeMachineRiskCntResponse : AbstractModel
    {
        
        /// <summary>
        /// 异地登录
        /// </summary>
        [JsonProperty("HostLogin")]
        public ulong? HostLogin{ get; set; }

        /// <summary>
        /// 密码破解
        /// </summary>
        [JsonProperty("BruteAttack")]
        public ulong? BruteAttack{ get; set; }

        /// <summary>
        /// 恶意请求
        /// </summary>
        [JsonProperty("MaliciousRequest")]
        public ulong? MaliciousRequest{ get; set; }

        /// <summary>
        /// 反弹shell
        /// </summary>
        [JsonProperty("ReverseShell")]
        public ulong? ReverseShell{ get; set; }

        /// <summary>
        /// 高危命令
        /// </summary>
        [JsonProperty("Bash")]
        public ulong? Bash{ get; set; }

        /// <summary>
        /// 本地提权
        /// </summary>
        [JsonProperty("PrivilegeEscalation")]
        public ulong? PrivilegeEscalation{ get; set; }

        /// <summary>
        /// 木马
        /// </summary>
        [JsonProperty("Malware")]
        public ulong? Malware{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostLogin", this.HostLogin);
            this.SetParamSimple(map, prefix + "BruteAttack", this.BruteAttack);
            this.SetParamSimple(map, prefix + "MaliciousRequest", this.MaliciousRequest);
            this.SetParamSimple(map, prefix + "ReverseShell", this.ReverseShell);
            this.SetParamSimple(map, prefix + "Bash", this.Bash);
            this.SetParamSimple(map, prefix + "PrivilegeEscalation", this.PrivilegeEscalation);
            this.SetParamSimple(map, prefix + "Malware", this.Malware);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

