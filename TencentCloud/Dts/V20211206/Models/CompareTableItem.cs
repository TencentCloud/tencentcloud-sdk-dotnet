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

    public class CompareTableItem : AbstractModel
    {
        
        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// column 模式，all 为全部，partial 表示部分(该参数仅对数据同步任务有效)
        /// </summary>
        [JsonProperty("ColumnMode")]
        public string ColumnMode{ get; set; }

        /// <summary>
        /// 当 ColumnMode 为 partial 时必填(该参数仅对数据同步任务有效)
        /// </summary>
        [JsonProperty("Columns")]
        public CompareColumnItem[] Columns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "ColumnMode", this.ColumnMode);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
        }
    }
}

