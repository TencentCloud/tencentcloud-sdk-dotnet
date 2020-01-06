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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceLog : AbstractModel
    {
        
        /// <summary>
        /// 任务实例
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public ulong? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// 标准输出日志（Base64编码）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StdoutLog")]
        public string StdoutLog{ get; set; }

        /// <summary>
        /// 标准错误日志（Base64编码）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StderrLog")]
        public string StderrLog{ get; set; }

        /// <summary>
        /// 标准输出重定向路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StdoutRedirectPath")]
        public string StdoutRedirectPath{ get; set; }

        /// <summary>
        /// 标准错误重定向路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StderrRedirectPath")]
        public string StderrRedirectPath{ get; set; }

        /// <summary>
        /// 标准输出重定向文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StdoutRedirectFileName")]
        public string StdoutRedirectFileName{ get; set; }

        /// <summary>
        /// 标准错误重定向文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StderrRedirectFileName")]
        public string StderrRedirectFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "StdoutLog", this.StdoutLog);
            this.SetParamSimple(map, prefix + "StderrLog", this.StderrLog);
            this.SetParamSimple(map, prefix + "StdoutRedirectPath", this.StdoutRedirectPath);
            this.SetParamSimple(map, prefix + "StderrRedirectPath", this.StderrRedirectPath);
            this.SetParamSimple(map, prefix + "StdoutRedirectFileName", this.StdoutRedirectFileName);
            this.SetParamSimple(map, prefix + "StderrRedirectFileName", this.StderrRedirectFileName);
        }
    }
}

