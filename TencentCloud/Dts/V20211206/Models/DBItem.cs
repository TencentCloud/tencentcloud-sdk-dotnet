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

    public class DBItem : AbstractModel
    {
        
        /// <summary>
        /// 需要迁移或同步的库名，当ObjectMode为partial时，此项必填
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 迁移或同步后的库名，默认与源库相同
        /// </summary>
        [JsonProperty("NewDbName")]
        public string NewDbName{ get; set; }

        /// <summary>
        /// 迁移或同步的 schema
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 迁移或同步后的 schema name
        /// </summary>
        [JsonProperty("NewSchemaName")]
        public string NewSchemaName{ get; set; }

        /// <summary>
        /// DB选择模式: all(为当前对象下的所有对象)，partial(部分对象)，当ObjectMode为partial时，此项必填
        /// </summary>
        [JsonProperty("DBMode")]
        public string DBMode{ get; set; }

        /// <summary>
        /// schema选择模式: all(为当前对象下的所有对象)，partial(部分对象)
        /// </summary>
        [JsonProperty("SchemaMode")]
        public string SchemaMode{ get; set; }

        /// <summary>
        /// 表选择模式: all(为当前对象下的所有对象)，partial(部分对象)，当DBMode为partial时此项必填
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }

        /// <summary>
        /// 表图对象集合，当 TableMode 为 partial 时，此项需要填写
        /// </summary>
        [JsonProperty("Tables")]
        public TableItem[] Tables{ get; set; }

        /// <summary>
        /// 视图选择模式: all 为当前对象下的所有视图对象,partial 为部分视图对象
        /// </summary>
        [JsonProperty("ViewMode")]
        public string ViewMode{ get; set; }

        /// <summary>
        /// 视图对象集合，当 ViewMode 为 partial 时， 此项需要填写
        /// </summary>
        [JsonProperty("Views")]
        public ViewItem[] Views{ get; set; }

        /// <summary>
        /// postgresql独有参数，角色选择模式: all 为当前对象下的所有角色对象,partial 为部分角色对象
        /// </summary>
        [JsonProperty("RoleMode")]
        public string RoleMode{ get; set; }

        /// <summary>
        /// postgresql独有参数，当 RoleMode 为 partial 时， 此项需要填写
        /// </summary>
        [JsonProperty("Roles")]
        public RoleItem[] Roles{ get; set; }

        /// <summary>
        /// 选择要同步的模式，partial为部分，all为整选
        /// </summary>
        [JsonProperty("FunctionMode")]
        public string FunctionMode{ get; set; }

        /// <summary>
        /// 选择要同步的模式，partial为部分，all为整选
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// 选择要同步的模式，partial为部分，all为整选
        /// </summary>
        [JsonProperty("EventMode")]
        public string EventMode{ get; set; }

        /// <summary>
        /// 选择要同步的模式，partial为部分，all为整选
        /// </summary>
        [JsonProperty("ProcedureMode")]
        public string ProcedureMode{ get; set; }

        /// <summary>
        /// FunctionMode取值为partial时需要填写
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// ProcedureMode取值为partial时需要填写
        /// </summary>
        [JsonProperty("Procedures")]
        public string[] Procedures{ get; set; }

        /// <summary>
        /// EventMode取值为partial时需要填写
        /// </summary>
        [JsonProperty("Events")]
        public string[] Events{ get; set; }

        /// <summary>
        /// TriggerMode取值为partial时需要填写
        /// </summary>
        [JsonProperty("Triggers")]
        public string[] Triggers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "NewDbName", this.NewDbName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "NewSchemaName", this.NewSchemaName);
            this.SetParamSimple(map, prefix + "DBMode", this.DBMode);
            this.SetParamSimple(map, prefix + "SchemaMode", this.SchemaMode);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamSimple(map, prefix + "ViewMode", this.ViewMode);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamSimple(map, prefix + "RoleMode", this.RoleMode);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamSimple(map, prefix + "FunctionMode", this.FunctionMode);
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
            this.SetParamSimple(map, prefix + "EventMode", this.EventMode);
            this.SetParamSimple(map, prefix + "ProcedureMode", this.ProcedureMode);
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamArraySimple(map, prefix + "Procedures.", this.Procedures);
            this.SetParamArraySimple(map, prefix + "Events.", this.Events);
            this.SetParamArraySimple(map, prefix + "Triggers.", this.Triggers);
        }
    }
}

