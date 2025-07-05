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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagementCommand : AbstractModel
    {
        
        /// <summary>
        /// Agent 安装命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Install")]
        public string Install{ get; set; }

        /// <summary>
        /// Agent 重启命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Restart")]
        public string Restart{ get; set; }

        /// <summary>
        /// Agent 停止命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Stop")]
        public string Stop{ get; set; }

        /// <summary>
        /// Agent 状态检测命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusCheck")]
        public string StatusCheck{ get; set; }

        /// <summary>
        /// Agent 日志检测命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogCheck")]
        public string LogCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Install", this.Install);
            this.SetParamSimple(map, prefix + "Restart", this.Restart);
            this.SetParamSimple(map, prefix + "Stop", this.Stop);
            this.SetParamSimple(map, prefix + "StatusCheck", this.StatusCheck);
            this.SetParamSimple(map, prefix + "LogCheck", this.LogCheck);
        }
    }
}

