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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IcebergParam : AbstractModel
    {
        
        /// <summary>
        /// <p>Iceberg 连接资源 (EMR 实例)</p>
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// <p>目标数据库名（Hive catalog 下的 namespace），必填</p>
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// <p>目标表名</p>
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// <p>消息解析格式，当前仅支持 JSON</p><p>枚举值：</p><ul><li>JSON： JSON解析格式</li></ul>
        /// </summary>
        [JsonProperty("SchemeType")]
        public string SchemeType{ get; set; }

        /// <summary>
        /// <p>表字段扩展开关</p><p>枚举值：</p><ul><li>true： 开</li><li>false： 关</li></ul>
        /// </summary>
        [JsonProperty("EnableFieldExtension")]
        public bool? EnableFieldExtension{ get; set; }

        /// <summary>
        /// <p>Upset/CDC 模式，默认off</p><p>枚举值：</p><ul><li>Off： Off</li><li>UPSERT： UPSERT</li><li>CDC： CDC</li></ul>
        /// </summary>
        [JsonProperty("UpsertMode")]
        public string UpsertMode{ get; set; }

        /// <summary>
        /// <p>主键字段：UPSERT / CDC 模式必填（多个字段以英文逗号分隔）</p>
        /// </summary>
        [JsonProperty("PrimaryKeys")]
        public string PrimaryKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "SchemeType", this.SchemeType);
            this.SetParamSimple(map, prefix + "EnableFieldExtension", this.EnableFieldExtension);
            this.SetParamSimple(map, prefix + "UpsertMode", this.UpsertMode);
            this.SetParamSimple(map, prefix + "PrimaryKeys", this.PrimaryKeys);
        }
    }
}

