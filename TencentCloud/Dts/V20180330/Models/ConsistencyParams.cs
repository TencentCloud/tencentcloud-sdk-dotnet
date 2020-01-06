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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsistencyParams : AbstractModel
    {
        
        /// <summary>
        /// 数据内容检测参数。表中选出用来数据对比的行，占表的总行数的百分比。取值范围是整数[1-100]
        /// </summary>
        [JsonProperty("SelectRowsPerTable")]
        public long? SelectRowsPerTable{ get; set; }

        /// <summary>
        /// 数据内容检测参数。迁移库表中，要进行数据内容检测的表，占所有表的百分比。取值范围是整数[1-100]
        /// </summary>
        [JsonProperty("TablesSelectAll")]
        public long? TablesSelectAll{ get; set; }

        /// <summary>
        /// 数据数量检测，检测表行数是否一致。迁移库表中，要进行数据数量检测的表，占所有表的百分比。取值范围是整数[1-100]
        /// </summary>
        [JsonProperty("TablesSelectCount")]
        public long? TablesSelectCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelectRowsPerTable", this.SelectRowsPerTable);
            this.SetParamSimple(map, prefix + "TablesSelectAll", this.TablesSelectAll);
            this.SetParamSimple(map, prefix + "TablesSelectCount", this.TablesSelectCount);
        }
    }
}

