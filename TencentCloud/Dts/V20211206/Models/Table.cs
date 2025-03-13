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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Table : AbstractModel
    {
        
        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 新表名
        /// </summary>
        [JsonProperty("NewTableName")]
        public string NewTableName{ get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("FilterCondition")]
        public string FilterCondition{ get; set; }

        /// <summary>
        /// 是否同步表中所有列，All：当前表下的所有列,Partial(ModifySyncJobConfig接口里的对应字段ColumnMode暂不支持Partial)：当前表下的部分列，通过填充Columns字段详细表信息
        /// </summary>
        [JsonProperty("ColumnMode")]
        public string ColumnMode{ get; set; }

        /// <summary>
        /// 同步的列信息，当ColumnMode为Partial时，必填
        /// </summary>
        [JsonProperty("Columns")]
        public Column[] Columns{ get; set; }

        /// <summary>
        /// 同步临时表，注意此配置与NewTableName互斥，只能使用其中一种。当配置的同步对象为表级别且TableEditMode为pt时此项有意义，针对pt-osc等工具在同步过程中产生的临时表进行同步，需要提前将可能的临时表配置在这里，否则不会同步任何临时表。示例，如要对t1进行pt-osc操作，此项配置应该为["\_t1\_new","\_t1\_old"]；如要对t1进行gh-ost操作，此项配置应该为["\_t1\_ghc","\_t1\_gho","\_t1\_del"]，pt-osc与gh-ost产生的临时表可同时配置。
        /// </summary>
        [JsonProperty("TmpTables")]
        public string[] TmpTables{ get; set; }

        /// <summary>
        /// 编辑表类型，rename(表映射)，pt(同步附加表)
        /// </summary>
        [JsonProperty("TableEditMode")]
        public string TableEditMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "NewTableName", this.NewTableName);
            this.SetParamSimple(map, prefix + "FilterCondition", this.FilterCondition);
            this.SetParamSimple(map, prefix + "ColumnMode", this.ColumnMode);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArraySimple(map, prefix + "TmpTables.", this.TmpTables);
            this.SetParamSimple(map, prefix + "TableEditMode", this.TableEditMode);
        }
    }
}

