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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserSqlAdviceResponse : AbstractModel
    {
        
        /// <summary>
        /// SQL优化建议，可解析为JSON数组，无需优化时输出为空。
        /// </summary>
        [JsonProperty("Advices")]
        public string Advices{ get; set; }

        /// <summary>
        /// SQL优化建议备注，可解析为String数组，无需优化时输出为空。
        /// </summary>
        [JsonProperty("Comments")]
        public string Comments{ get; set; }

        /// <summary>
        /// SQL语句。
        /// </summary>
        [JsonProperty("SqlText")]
        public string SqlText{ get; set; }

        /// <summary>
        /// 库名。
        /// </summary>
        [JsonProperty("Schema")]
        public string Schema{ get; set; }

        /// <summary>
        /// 相关表的DDL信息，可解析为JSON数组。
        /// </summary>
        [JsonProperty("Tables")]
        public string Tables{ get; set; }

        /// <summary>
        /// SQL执行计划，可解析为JSON，无需优化时输出为空。
        /// </summary>
        [JsonProperty("SqlPlan")]
        public string SqlPlan{ get; set; }

        /// <summary>
        /// SQL优化后的成本节约详情，可解析为JSON，无需优化时输出为空。
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Advices", this.Advices);
            this.SetParamSimple(map, prefix + "Comments", this.Comments);
            this.SetParamSimple(map, prefix + "SqlText", this.SqlText);
            this.SetParamSimple(map, prefix + "Schema", this.Schema);
            this.SetParamSimple(map, prefix + "Tables", this.Tables);
            this.SetParamSimple(map, prefix + "SqlPlan", this.SqlPlan);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

