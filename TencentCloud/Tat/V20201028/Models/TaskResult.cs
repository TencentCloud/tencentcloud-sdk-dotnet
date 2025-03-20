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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskResult : AbstractModel
    {
        
        /// <summary>
        /// 命令执行ExitCode。
        /// </summary>
        [JsonProperty("ExitCode")]
        public long? ExitCode{ get; set; }

        /// <summary>
        /// Base64编码后的命令输出。最大长度24KB。
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 命令执行开始时间。格式为：YYYY-MM-DDThh:mm:ssZ
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecStartTime")]
        public string ExecStartTime{ get; set; }

        /// <summary>
        /// 命令执行结束时间。格式为：YYYY-MM-DDThh:mm:ssZ
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecEndTime")]
        public string ExecEndTime{ get; set; }

        /// <summary>
        /// 命令最终输出被截断的字节数。
        /// </summary>
        [JsonProperty("Dropped")]
        public ulong? Dropped{ get; set; }

        /// <summary>
        /// 日志在cos中的地址
        /// </summary>
        [JsonProperty("OutputUrl")]
        public string OutputUrl{ get; set; }

        /// <summary>
        /// 日志上传cos的错误信息。
        /// </summary>
        [JsonProperty("OutputUploadCOSErrorInfo")]
        public string OutputUploadCOSErrorInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExitCode", this.ExitCode);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "ExecStartTime", this.ExecStartTime);
            this.SetParamSimple(map, prefix + "ExecEndTime", this.ExecEndTime);
            this.SetParamSimple(map, prefix + "Dropped", this.Dropped);
            this.SetParamSimple(map, prefix + "OutputUrl", this.OutputUrl);
            this.SetParamSimple(map, prefix + "OutputUploadCOSErrorInfo", this.OutputUploadCOSErrorInfo);
        }
    }
}

