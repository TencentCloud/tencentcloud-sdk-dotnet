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

    public class GetMetaTableResponse : AbstractModel
    {
        
        /// <summary>
        /// 元数据表唯一标识
        /// </summary>
        [JsonProperty("SerialId")]
        public string SerialId{ get; set; }

        /// <summary>
        /// 目录名
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// 库名
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// 表名
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 建表语句,使用 Base64 编码。
        /// 例如
        /// Q1JFQVRFIFRBQkxFIGRhdGFnZW5fc291cmNlX3RhYmxlICggCiAgICBpZCBJTlQsIAogICAgbmFtZSBTVFJJTkcgCikgV0lUSCAoCidjb25uZWN0b3InPSdkYXRhZ2VuJywKJ3Jvd3MtcGVyLXNlY29uZCcgPSAnMScKKTs=
        /// </summary>
        [JsonProperty("DDL")]
        public string DDL{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SerialId", this.SerialId);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "DDL", this.DDL);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

