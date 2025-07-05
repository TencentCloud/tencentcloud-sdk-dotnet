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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatabaseObject : AbstractModel
    {
        
        /// <summary>
        /// 支持使用的数据库对象类型有：account,database,schema,sequence,procedure,type,function,table,view,matview,column。
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// 所描述的数据库对象名称
        /// </summary>
        [JsonProperty("ObjectName")]
        public string ObjectName{ get; set; }

        /// <summary>
        /// 所要描述的数据库对象，所属的数据库名称。当描述对象类型不为database时，此参数必选。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 所要描述的数据库对象，所属的模式名称。当描述对象不为database、schema时，此参数必选。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 所要描述的数据库对象，所属的表名称。当描述的对象类型为column时，此参数必填。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "ObjectName", this.ObjectName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
        }
    }
}

