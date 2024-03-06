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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmAnalysisConfig : AbstractModel
    {
        
        /// <summary>
        /// 键。支持以下key：
        /// SyntaxRule：语法规则，value支持 0：Lucene语法；1： CQL语法。
        /// QueryIndex：执行语句序号。value支持  -1：自定义； 1：执行语句1； 2：执行语句2。
        /// CustomQuery：检索语句。 QueryIndex为-1时有效且必填，value示例： "* | select count(*) as count"。
        /// Fields：字段。value支持 __SOURCE__；__FILENAME__；__HOSTNAME__；__TIMESTAMP__；__INDEX_STATUS__；__PKG_LOGID__；__TOPIC__。
        /// Format：显示形式。value支持 1：每条日志一行；2：每条日志每个字段一行。
        /// Limit：最大日志条数。 value示例： 5。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 值。
        /// 键对应值如下：
        /// SyntaxRule：语法规则，value支持 0：Lucene语法；1： CQL语法。
        /// QueryIndex：执行语句序号。value支持  -1：自定义； 1：执行语句1； 2：执行语句2。
        /// CustomQuery：检索语句。 QueryIndex为-1时有效且必填，value示例： "* | select count(*) as count"。
        /// Fields：字段。value支持 __SOURCE__；__FILENAME__；__HOSTNAME__；__TIMESTAMP__；__INDEX_STATUS__；__PKG_LOGID__；__TOPIC__。
        /// Format：显示形式。value支持 1：每条日志一行；2：每条日志每个字段一行。
        /// Limit：最大日志条数。 value示例： 5。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

