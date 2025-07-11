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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDataBaseTuple : AbstractModel
    {
        
        /// <summary>
        /// 要修改的订阅关系
        /// </summary>
        [JsonProperty("DatabaseTuple")]
        public DatabaseTuple DatabaseTuple{ get; set; }

        /// <summary>
        /// 修改后的订阅关系。DeleteDataBasesTuple为false时有效
        /// </summary>
        [JsonProperty("NewDatabaseTuple")]
        public DatabaseTuple NewDatabaseTuple{ get; set; }

        /// <summary>
        /// 是否删除订阅关系。此选项为true时，NewDatabaseTuple无效
        /// </summary>
        [JsonProperty("DeleteDataBasesTuple")]
        public bool? DeleteDataBasesTuple{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DatabaseTuple.", this.DatabaseTuple);
            this.SetParamObj(map, prefix + "NewDatabaseTuple.", this.NewDatabaseTuple);
            this.SetParamSimple(map, prefix + "DeleteDataBasesTuple", this.DeleteDataBasesTuple);
        }
    }
}

