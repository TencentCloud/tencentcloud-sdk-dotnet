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

    public class Database : AbstractModel
    {
        
        /// <summary>
        /// <p>需要迁移或同步的库名，当ObjectMode为Partial时，此项必填</p>
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// <p>迁移或同步后的库名，默认与源库相同</p>
        /// </summary>
        [JsonProperty("NewDbName")]
        public string NewDbName{ get; set; }

        /// <summary>
        /// <p>DB选择模式: All(为当前对象下的所有对象)，Partial(部分对象)，当Mode为Partial时，此项必填。注意，高级对象的同步不依赖此值，如果整库同步此处应该为All。</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>迁移或同步的 schema</p>
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// <p>迁移或同步后的 schema name</p>
        /// </summary>
        [JsonProperty("NewSchemaName")]
        public string NewSchemaName{ get; set; }

        /// <summary>
        /// <p>schema选择模式，pg和sqlserver需要使用</p><p>枚举值：</p><ul><li>All： 当前对象下的所有对象</li><li>Partial： 部分对象</li></ul>
        /// </summary>
        [JsonProperty("SchemaMode")]
        public string SchemaMode{ get; set; }

        /// <summary>
        /// <p>表选择模式: All(为当前对象下的所有对象)，Partial(部分对象)，当DBMode为Partial时此项必填，如果整库同步此处应该为All。</p>
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }

        /// <summary>
        /// <p>表图对象集合，当 TableMode 为 Partial 时，此项需要填写</p>
        /// </summary>
        [JsonProperty("Tables")]
        public Table[] Tables{ get; set; }

        /// <summary>
        /// <p>视图选择模式: All 为当前对象下的所有视图对象,Partial 为部分视图对象，如果整库同步此处应该为All。</p>
        /// </summary>
        [JsonProperty("ViewMode")]
        public string ViewMode{ get; set; }

        /// <summary>
        /// <p>视图对象集合，当 ViewMode 为 Partial 时， 此项需要填写</p>
        /// </summary>
        [JsonProperty("Views")]
        public View[] Views{ get; set; }

        /// <summary>
        /// <p>选择要同步的模式，Partial为部分，All为整选，如果整库同步此处应该为All。</p>
        /// </summary>
        [JsonProperty("FunctionMode")]
        public string FunctionMode{ get; set; }

        /// <summary>
        /// <p>FunctionMode取值为Partial时需要填写</p>
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// <p>选择要同步的模式，Partial为部分，All为整选，如果整库同步此处应该为All。</p>
        /// </summary>
        [JsonProperty("ProcedureMode")]
        public string ProcedureMode{ get; set; }

        /// <summary>
        /// <p>ProcedureMode取值为Partial时需要填写</p>
        /// </summary>
        [JsonProperty("Procedures")]
        public string[] Procedures{ get; set; }

        /// <summary>
        /// <p>触发器迁移模式，All(为当前对象下的所有对象)，Partial(部分对象)，如果整库同步此处应该为All。数据同步暂不支持此高级对象。</p>
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// <p>当TriggerMode为partial，指定要迁移的触发器名称</p>
        /// </summary>
        [JsonProperty("Triggers")]
        public string[] Triggers{ get; set; }

        /// <summary>
        /// <p>事件迁移模式，All(为当前对象下的所有对象)，Partial(部分对象)，如果整库同步此处应该为All。数据同步暂不支持此高级对象。</p>
        /// </summary>
        [JsonProperty("EventMode")]
        public string EventMode{ get; set; }

        /// <summary>
        /// <p>当EventMode为partial，指定要迁移的事件名称</p>
        /// </summary>
        [JsonProperty("Events")]
        public string[] Events{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "NewDbName", this.NewDbName);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "NewSchemaName", this.NewSchemaName);
            this.SetParamSimple(map, prefix + "SchemaMode", this.SchemaMode);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamSimple(map, prefix + "ViewMode", this.ViewMode);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamSimple(map, prefix + "FunctionMode", this.FunctionMode);
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "ProcedureMode", this.ProcedureMode);
            this.SetParamArraySimple(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
            this.SetParamArraySimple(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "EventMode", this.EventMode);
            this.SetParamArraySimple(map, prefix + "Events.", this.Events);
        }
    }
}

