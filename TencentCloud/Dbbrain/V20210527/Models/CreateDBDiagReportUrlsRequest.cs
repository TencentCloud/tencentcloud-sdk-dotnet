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

    public class CreateDBDiagReportUrlsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>服务产品类型，支持值包括：&quot;mysql&quot; - 云数据库 MySQL，&quot;redis&quot; - 云数据库 Redis，&quot;cynosdb&quot; - 云数据库 TDSQL-C for MySQL，&quot;mongodb&quot; - 云数据库 MongoDB，&quot;postgres&quot; - 云数据库 PostgreSQL。</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>异步任务ID列表。</p>
        /// </summary>
        [JsonProperty("AsyncRequestIds")]
        public long?[] AsyncRequestIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "AsyncRequestIds.", this.AsyncRequestIds);
        }
    }
}

