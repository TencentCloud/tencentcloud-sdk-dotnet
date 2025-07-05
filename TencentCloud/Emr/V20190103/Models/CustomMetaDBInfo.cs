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
        /// 自定义MetaDB的JDBC连接，示例: jdbc:mysql://10.10.10.10:3306/dbname
        /// </summary>
        [JsonProperty("MetaDataJdbcUrl")]
        public string MetaDataJdbcUrl{ get; set; }

        /// <summary>
        /// 自定义MetaDB用户名
        /// </summary>
        [JsonProperty("MetaDataUser")]
        public string MetaDataUser{ get; set; }

        /// <summary>
        /// 自定义MetaDB密码
        /// </summary>
        [JsonProperty("MetaDataPass")]
        public string MetaDataPass{ get; set; }

        /// <summary>
        /// hive共享元数据库类型。取值范围：
        /// <li>EMR_DEFAULT_META：表示集群默认创建</li>
        /// <li>EMR_EXIST_META：表示集群使用指定EMR-MetaDB。</li>
        /// <li>USER_CUSTOM_META：表示集群使用自定义MetaDB。</li>
        /// </summary>
        [JsonProperty("MetaType")]
        public string MetaType{ get; set; }

        /// <summary>
        /// EMR-MetaDB实例
        /// </summary>
        [JsonProperty("UnifyMetaInstanceId")]
        public string UnifyMetaInstanceId{ get; set; }


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
        }
    }
}

