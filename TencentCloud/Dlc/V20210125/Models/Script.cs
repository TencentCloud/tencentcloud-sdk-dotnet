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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Script : AbstractModel
    {
        
        /// <summary>
        /// 脚本Id，长度36字节。
        /// </summary>
        [JsonProperty("ScriptId")]
        public string ScriptId{ get; set; }

        /// <summary>
        /// 脚本名称，长度0-25。
        /// </summary>
        [JsonProperty("ScriptName")]
        public string ScriptName{ get; set; }

        /// <summary>
        /// 脚本描述，长度0-50。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptDesc")]
        public string ScriptDesc{ get; set; }

        /// <summary>
        /// 默认关联数据库。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// SQL描述，长度0-10000。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SQLStatement")]
        public string SQLStatement{ get; set; }

        /// <summary>
        /// 更新时间戳， 单位：ms。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScriptId", this.ScriptId);
            this.SetParamSimple(map, prefix + "ScriptName", this.ScriptName);
            this.SetParamSimple(map, prefix + "ScriptDesc", this.ScriptDesc);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SQLStatement", this.SQLStatement);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

