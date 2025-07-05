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

    public class SubscribeObject : AbstractModel
    {
        
        /// <summary>
        /// 订阅数据的类型，枚举值：database-数据库，table-数据库的表(如果 DatabaseType 为 mongodb，则表示集合)
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 订阅的数据库名称
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// 订阅数据库中表的名称。如果 DatabaseType 为 mongodb，填集合名。mongodb只支持订阅单库或者单集合。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tables")]
        public string[] Tables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamArraySimple(map, prefix + "Tables.", this.Tables);
        }
    }
}

