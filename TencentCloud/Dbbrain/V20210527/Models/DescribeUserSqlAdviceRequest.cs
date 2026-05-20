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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserSqlAdviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。可通过 <a href="https://cloud.tencent.com/document/api/1130/57798">DescribeDiagDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>SQL语句。</p>
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// <p>库名。</p>
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// <p>服务产品类型，支持值&quot;dcdb&quot; - 云数据库TDSQL MySQL；&quot;mysql&quot; - 云数据库 MySQL；&quot;cynosdb&quot; - 云数据库 TDSQL-C for MySQL；&quot;dbbrain-mysql&quot; - 自建 MySQL，默认为&quot;mysql&quot;。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

