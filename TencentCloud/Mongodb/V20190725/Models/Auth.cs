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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Auth : AbstractModel
    {
        
        /// <summary>
        /// 当前账号具有的权限信息。
        /// - 0：无权限。
        /// - 1：只读。
        /// - 3：读写。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mask")]
        public long? Mask{ get; set; }

        /// <summary>
        /// 指具有当前账号权限的数据库名。
        /// - \* ：表示所有数据库。
        /// - db.name：表示特定 name 的数据库。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
        }
    }
}

