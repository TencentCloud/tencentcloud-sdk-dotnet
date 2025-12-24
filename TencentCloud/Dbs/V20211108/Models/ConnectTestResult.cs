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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectTestResult : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// <p>任务状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>是否通过。0 表示未通过，1 表示通过。</p>
        /// </summary>
        [JsonProperty("IsPass")]
        public long? IsPass{ get; set; }

        /// <summary>
        /// <p>源端地址</p>
        /// </summary>
        [JsonProperty("Addr")]
        public string Addr{ get; set; }

        /// <summary>
        /// <p>源地址转换IP</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SNatIp")]
        public string SNatIp{ get; set; }

        /// <summary>
        /// <p>检测结果集</p>
        /// </summary>
        [JsonProperty("TestItems")]
        public TestItem[] TestItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "Addr", this.Addr);
            this.SetParamSimple(map, prefix + "SNatIp", this.SNatIp);
            this.SetParamArrayObj(map, prefix + "TestItems.", this.TestItems);
        }
    }
}

