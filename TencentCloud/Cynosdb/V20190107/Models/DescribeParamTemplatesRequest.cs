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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据库引擎版本号
        /// </summary>
        [JsonProperty("EngineVersions")]
        public string[] EngineVersions{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("TemplateIds")]
        public long?[] TemplateIds{ get; set; }

        /// <summary>
        /// 数据库类型，可选值：NORMAL，SERVERLESS
        /// </summary>
        [JsonProperty("DbModes")]
        public string[] DbModes{ get; set; }

        /// <summary>
        /// 查询偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询限制条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 查询的模板对应的产品类型
        /// </summary>
        [JsonProperty("Products")]
        public string[] Products{ get; set; }

        /// <summary>
        /// 模板类型
        /// </summary>
        [JsonProperty("TemplateTypes")]
        public string[] TemplateTypes{ get; set; }

        /// <summary>
        /// 版本类型
        /// </summary>
        [JsonProperty("EngineTypes")]
        public string[] EngineTypes{ get; set; }

        /// <summary>
        /// 返回结果的排序字段
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式（asc、desc）
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EngineVersions.", this.EngineVersions);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
            this.SetParamArraySimple(map, prefix + "DbModes.", this.DbModes);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "Products.", this.Products);
            this.SetParamArraySimple(map, prefix + "TemplateTypes.", this.TemplateTypes);
            this.SetParamArraySimple(map, prefix + "EngineTypes.", this.EngineTypes);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

