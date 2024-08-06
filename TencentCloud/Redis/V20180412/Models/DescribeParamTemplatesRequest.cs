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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeParamTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品类型数组。
        /// - 2：Redis 2.8 内存版（标准架构）。
        /// - 3：CKV 3.2 内存版（标准架构）。
        /// - 4：CKV 3.2 内存版（集群架构）。
        /// - 6：Redis 4.0 内存版（标准架构）。
        /// - 7：Redis 4.0 内存版（集群架构）。
        /// - 8：Redis 5.0 内存版（标准架构）。
        /// - 9：Redis 5.0 内存版（集群架构）。
        /// - 15：Redis 6.2 内存版（标准架构）。
        /// - 16：Redis 6.2 内存版（集群架构）。
        /// - 17：Redis 7.0 内存版（标准架构）。
        /// - 18：Redis 7.0 内存版（集群架构）。
        /// </summary>
        [JsonProperty("ProductTypes")]
        public long?[] ProductTypes{ get; set; }

        /// <summary>
        /// 模板名称数组。数组最大长度限制为50
        /// </summary>
        [JsonProperty("TemplateNames")]
        public string[] TemplateNames{ get; set; }

        /// <summary>
        /// 模板ID数组。数组最大长度限制为50
        /// </summary>
        [JsonProperty("TemplateIds")]
        public string[] TemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProductTypes.", this.ProductTypes);
            this.SetParamArraySimple(map, prefix + "TemplateNames.", this.TemplateNames);
            this.SetParamArraySimple(map, prefix + "TemplateIds.", this.TemplateIds);
        }
    }
}

