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

    public class DBOpFilter : AbstractModel
    {
        
        /// <summary>
        /// 规则生效的库名
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 库级 DDL/DML 过滤规则
        /// </summary>
        [JsonProperty("OpFilter")]
        public OpFilter OpFilter{ get; set; }

        /// <summary>
        /// 表级 DDL/DML 过滤信息
        /// </summary>
        [JsonProperty("Tables")]
        public TableFilter[] Tables{ get; set; }

        /// <summary>
        /// 视图级 DDL/DML 过滤信息
        /// </summary>
        [JsonProperty("Views")]
        public ViewFilter[] Views{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamObj(map, prefix + "OpFilter.", this.OpFilter);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
        }
    }
}

