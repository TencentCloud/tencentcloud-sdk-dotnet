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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceType : AbstractModel
    {
        
        /// <summary>
        /// 资源组类型
        /// 
        /// - Schedule --- 调度资源组
        /// - Integration --- 集成资源组
        /// - DataService -- 数据服务资源组
        /// </summary>
        [JsonProperty("ResourceGroupType")]
        public string ResourceGroupType{ get; set; }

        /// <summary>
        /// 集成资源组，细分实时资源组和离线资源组(集成、调度、数据服务资源组不可以同时购买)
        /// </summary>
        [JsonProperty("Integration")]
        public IntegrationResource Integration{ get; set; }

        /// <summary>
        /// 调度资源组(集成、调度、数据服务资源组不可以同时购买)
        /// 
        /// - s_test(测试规格)
        /// - s_small(基础规格)
        /// - s_medium(普及规格)
        /// - s_large(专业规格)
        /// 
        /// 
        /// </summary>
        [JsonProperty("Schedule")]
        public ResourceGroupSpecification Schedule{ get; set; }

        /// <summary>
        /// 数据服务资源组(集成、调度、数据服务资源组不可以同时购买)
        /// 
        /// - ds_t(测试规格)
        /// - ds_s(基础规格)
        /// - ds_m(普及规格)
        /// - ds_l(专业规格)
        /// </summary>
        [JsonProperty("DataService")]
        public ResourceGroupSpecification DataService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGroupType", this.ResourceGroupType);
            this.SetParamObj(map, prefix + "Integration.", this.Integration);
            this.SetParamObj(map, prefix + "Schedule.", this.Schedule);
            this.SetParamObj(map, prefix + "DataService.", this.DataService);
        }
    }
}

