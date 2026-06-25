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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomMetaDBInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义MetaDB的JDBC连接，示例: jdbc:mysql://10.10.10.10:3306/dbname</p>
        /// </summary>
        [JsonProperty("MetaDataJdbcUrl")]
        public string MetaDataJdbcUrl{ get; set; }

        /// <summary>
        /// <p>自定义MetaDB用户名</p>
        /// </summary>
        [JsonProperty("MetaDataUser")]
        public string MetaDataUser{ get; set; }

        /// <summary>
        /// <p>自定义MetaDB密码</p>
        /// </summary>
        [JsonProperty("MetaDataPass")]
        public string MetaDataPass{ get; set; }

        /// <summary>
        /// <p>hive共享元数据库类型。取值范围：</p><li>EMR_DEFAULT_META：表示集群默认创建</li><li>EMR_EXIST_META：表示集群使用指定EMR-MetaDB。</li><li>USER_CUSTOM_META：表示集群使用自定义MetaDB。</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// <p>EMR-MetaDB实例</p>
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }

        /// <summary>
        /// <p>组件</p>
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// <p>metadb版本</p>
        /// </summary>
        [JsonProperty("DefaultMetaVersion")]
        public string DefaultMetaVersion{ get; set; }

        /// <summary>
        /// <p>CDBId</p>
        /// </summary>
        [JsonProperty("LinkInstanceId")]
        public string LinkInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetaDataJdbcUrl", this.MetaDataJdbcUrl);
            this.SetParamSimple(map, prefix + "MetaDataUser", this.MetaDataUser);
            this.SetParamSimple(map, prefix + "MetaDataPass", this.MetaDataPass);
            this.SetParamSimple(map, prefix + "MetaType", this.MetaType);
            this.SetParamSimple(map, prefix + "UnifyMetaInstanceId", this.UnifyMetaInstanceId);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "DefaultMetaVersion", this.DefaultMetaVersion);
            this.SetParamSimple(map, prefix + "LinkInstanceId", this.LinkInstanceId);
        }
    }
}

