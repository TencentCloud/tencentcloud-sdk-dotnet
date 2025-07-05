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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateScriptRequest : AbstractModel
    {
        
        /// <summary>
        /// 脚本名称，最大不能超过255个字符。
        /// </summary>
        [JsonProperty("ScriptName")]
        public string ScriptName{ get; set; }

        /// <summary>
        /// base64编码后的sql语句
        /// </summary>
        [JsonProperty("SQLStatement")]
        public string SQLStatement{ get; set; }

        /// <summary>
        /// 脚本描述， 不能超过50个字符
        /// </summary>
        [JsonProperty("ScriptDesc")]
        public string ScriptDesc{ get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScriptName", this.ScriptName);
            this.SetParamSimple(map, prefix + "SQLStatement", this.SQLStatement);
            this.SetParamSimple(map, prefix + "ScriptDesc", this.ScriptDesc);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
        }
    }
}

