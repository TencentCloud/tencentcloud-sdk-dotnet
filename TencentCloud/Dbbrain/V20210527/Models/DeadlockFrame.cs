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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeadlockFrame : AbstractModel
    {
        
        /// <summary>
        /// <p>帧对应的行号（存储过程内的行号）。</p>
        /// </summary>
        [JsonProperty("Line")]
        public long? Line{ get; set; }

        /// <summary>
        /// <p>语句在存储过程文本内的起始字节偏移。</p>
        /// </summary>
        [JsonProperty("StatementStart")]
        public long? StatementStart{ get; set; }

        /// <summary>
        /// <p>存储过程名。adhoc 表示动态 SQL、非存过。</p>
        /// </summary>
        [JsonProperty("ProcName")]
        public string ProcName{ get; set; }

        /// <summary>
        /// <p>SQL 句柄（0x 十六进制字节），用于拉取具体语句文本和关联执行计划。</p>
        /// </summary>
        [JsonProperty("SqlHandle")]
        public string SqlHandle{ get; set; }

        /// <summary>
        /// <p>语句在存储过程文本内的结束字节偏移。StatementStart/StatementEnd 组合用于精确切片。</p>
        /// </summary>
        [JsonProperty("StatementEnd")]
        public long? StatementEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Line", this.Line);
            this.SetParamSimple(map, prefix + "StatementStart", this.StatementStart);
            this.SetParamSimple(map, prefix + "ProcName", this.ProcName);
            this.SetParamSimple(map, prefix + "SqlHandle", this.SqlHandle);
            this.SetParamSimple(map, prefix + "StatementEnd", this.StatementEnd);
        }
    }
}

