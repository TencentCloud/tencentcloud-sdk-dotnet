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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkipDdlOnError : AbstractModel
    {
        
        /// <summary>
        /// <p>按表名跳过，支持精确 &quot;db.tbl&quot;、库通配 &quot;db.*&quot;、表通配 &quot;<em>.tbl&quot;、全通配 &quot;</em>&quot;</p>
        /// </summary>
        [JsonProperty("Tables")]
        public string[] Tables{ get; set; }

        /// <summary>
        /// <p>按 MySQL 错误码（1~65535）跳过</p><p>取值范围：[1, 65535]</p>
        /// </summary>
        [JsonProperty("ErrorCodes")]
        public long?[] ErrorCodes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Tables.", this.Tables);
            this.SetParamArraySimple(map, prefix + "ErrorCodes.", this.ErrorCodes);
        }
    }
}

