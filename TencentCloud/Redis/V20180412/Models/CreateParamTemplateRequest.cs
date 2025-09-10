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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateParamTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数模板名称。字符长度要求为[2,64]。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数模板描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 产品类型。
        /// - 6：Redis 4.0 内存版（标准架构）。
        /// - 7：Redis 4.0 内存版（集群架构）。
        /// - 8：Redis 5.0 内存版（标准架构）。
        /// - 9：Redis 5.0 内存版（集群架构）。
        /// - 15：Redis 6.2 内存版（标准架构）。
        /// - 16：Redis 6.2 内存版（集群架构）。
        /// - 17：Redis 7.0 内存版（标准架构）。
        /// - 18：Redis 7.0 内存版（集群架构）。
        /// </summary>
        [JsonProperty("ProductType")]
        public ulong? ProductType{ get; set; }

        /// <summary>
        /// 源参数模板 ID。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 参数列表。
        /// </summary>
        [JsonProperty("ParamList")]
        public InstanceParam[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}

