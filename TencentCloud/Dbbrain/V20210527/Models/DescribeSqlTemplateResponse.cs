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

    public class DescribeSqlTemplateResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据库名。
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// SQL语句。
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// SQL类型。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// SQL模板内容。
        /// </summary>
        [JsonProperty("SqlTemplate")]
        public string SqlTemplate{ get; set; }

        /// <summary>
        /// SQL模板ID。
        /// </summary>
        [JsonProperty("SqlId")]
        public long? SqlId{ get; set; }

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
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "SqlTemplate", this.SqlTemplate);
            this.SetParamSimple(map, prefix + "SqlId", this.SqlId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

