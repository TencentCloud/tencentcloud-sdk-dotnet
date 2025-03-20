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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Database : AbstractModel
    {
        
        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 数据库所有者
        /// </summary>
        [JsonProperty("DatabaseOwner")]
        public string DatabaseOwner{ get; set; }

        /// <summary>
        /// 数据库字符编码
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// 数据库排序规则
        /// </summary>
        [JsonProperty("Collate")]
        public string Collate{ get; set; }

        /// <summary>
        /// 数据库字符分类
        /// </summary>
        [JsonProperty("Ctype")]
        public string Ctype{ get; set; }

        /// <summary>
        /// 数据库是否允许连接
        /// </summary>
        [JsonProperty("AllowConn")]
        public bool? AllowConn{ get; set; }

        /// <summary>
        /// 数据库最大连接数，-1表示无限制
        /// </summary>
        [JsonProperty("ConnLimit")]
        public long? ConnLimit{ get; set; }

        /// <summary>
        /// 数据库权限列表
        /// </summary>
        [JsonProperty("Privileges")]
        public string Privileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "DatabaseOwner", this.DatabaseOwner);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "Collate", this.Collate);
            this.SetParamSimple(map, prefix + "Ctype", this.Ctype);
            this.SetParamSimple(map, prefix + "AllowConn", this.AllowConn);
            this.SetParamSimple(map, prefix + "ConnLimit", this.ConnLimit);
            this.SetParamSimple(map, prefix + "Privileges", this.Privileges);
        }
    }
}

