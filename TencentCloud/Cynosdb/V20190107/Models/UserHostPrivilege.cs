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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserHostPrivilege : AbstractModel
    {
        
        /// <summary>
        /// 授权用户
        /// </summary>
        [JsonProperty("DbUserName")]
        public string DbUserName{ get; set; }

        /// <summary>
        /// 客户端ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbHost")]
        public string DbHost{ get; set; }

        /// <summary>
        /// 用户权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbPrivilege")]
        public string DbPrivilege{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbUserName", this.DbUserName);
            this.SetParamSimple(map, prefix + "DbHost", this.DbHost);
            this.SetParamSimple(map, prefix + "DbPrivilege", this.DbPrivilege);
        }
    }
}

