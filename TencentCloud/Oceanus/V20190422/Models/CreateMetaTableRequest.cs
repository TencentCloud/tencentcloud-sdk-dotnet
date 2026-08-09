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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMetaTableRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Catalog Id</p>
        /// </summary>
        [JsonProperty("CatalogId")]
        public long? CatalogId{ get; set; }

        /// <summary>
        /// <p>库Id</p>
        /// </summary>
        [JsonProperty("DatabaseId")]
        public long? DatabaseId{ get; set; }

        /// <summary>
        /// <p>建表语句</p><p>参数格式：需要base64加密</p>
        /// </summary>
        [JsonProperty("SqlCode")]
        public string SqlCode{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>引用资源</p>
        /// </summary>
        [JsonProperty("ResourceRefs")]
        public ResourceRef[] ResourceRefs{ get; set; }

        /// <summary>
        /// <p>Flink版本</p>
        /// </summary>
        [JsonProperty("FlinkVersion")]
        public string FlinkVersion{ get; set; }

        /// <summary>
        /// <p>工作空间 SerialId</p>
        /// </summary>
        [JsonProperty("WorkSpaceId")]
        public string WorkSpaceId{ get; set; }

        /// <summary>
        /// <p>异步id</p>
        /// </summary>
        [JsonProperty("AsyncTaskId")]
        public string AsyncTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CatalogId", this.CatalogId);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "SqlCode", this.SqlCode);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "ResourceRefs.", this.ResourceRefs);
            this.SetParamSimple(map, prefix + "FlinkVersion", this.FlinkVersion);
            this.SetParamSimple(map, prefix + "WorkSpaceId", this.WorkSpaceId);
            this.SetParamSimple(map, prefix + "AsyncTaskId", this.AsyncTaskId);
        }
    }
}

