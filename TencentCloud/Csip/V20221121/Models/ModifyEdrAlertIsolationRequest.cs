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

    public class ModifyEdrAlertIsolationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>告警定位列表（1-500）</p>
        /// </summary>
        [JsonProperty("Targets")]
        public EdrAlertTarget[] Targets{ get; set; }

        /// <summary>
        /// <p>操作类型：Isolate（隔离）/ RestoreIsolate（恢复隔离）/ KillProcess（进程查杀）枚举值：Isolate： 隔离RestoreIsolate： 恢复隔离KillProcess： 进程查杀</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>是否终止关联进程，仅 Status=Isolate 有效，Status=KillProcess 时忽略</p>
        /// </summary>
        [JsonProperty("KillProcess")]
        public bool? KillProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "KillProcess", this.KillProcess);
        }
    }
}

