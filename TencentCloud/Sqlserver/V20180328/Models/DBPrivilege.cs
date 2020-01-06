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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBPrivilege : AbstractModel
    {
        
        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("DBName")]
        public string DBName{ get; set; }

        /// <summary>
        /// 数据库权限，ReadWrite表示可读写，ReadOnly表示只读
        /// </summary>
        [JsonProperty("Privilege")]
        public string Privilege{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBName", this.DBName);
            this.SetParamSimple(map, prefix + "Privilege", this.Privilege);
        }
    }
}

