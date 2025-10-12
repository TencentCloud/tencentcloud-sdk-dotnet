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

    public class UpdateResourceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源组id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// **变更配置(变配、续费、修改资源包数量 不能同时操作), 变配无法修改资源组类型**
        /// 
        /// 实时集成资源组  
        /// - i32c(实时数据同步-16C64G)
        /// 
        /// 离线集成资源组
        /// - integrated(离线数据同步-8C16G)
        /// - i16(离线数据同步-8C32G)
        /// 
        /// 调度资源组
        /// - s_test(测试规格)
        /// - s_small(基础规格)
        /// - s_medium(普及规格)
        /// - s_large(专业规格)
        /// 
        /// 数据服务资源组
        /// - ds_t(测试规格)
        /// - ds_s(基础规格)
        /// - ds_m(普及规格)
        /// - ds_l(专业规格)
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 续费时长，单位月(变配、续费、修改资源包数量 不能同时操作)
        /// </summary>
        [JsonProperty("PurchasePeriod")]
        public long? PurchasePeriod{ get; set; }

        /// <summary>
        /// 增加/减少资源包的数量(变配、续费、修改资源包数量 不能同时操作)
        /// </summary>
        [JsonProperty("Number")]
        public ResourceNumber Number{ get; set; }

        /// <summary>
        /// 是否自动续费，续费参数PurchasePeriod不为空时可以生效
        /// </summary>
        [JsonProperty("AutoRenewEnabled")]
        public bool? AutoRenewEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PurchasePeriod", this.PurchasePeriod);
            this.SetParamObj(map, prefix + "Number.", this.Number);
            this.SetParamSimple(map, prefix + "AutoRenewEnabled", this.AutoRenewEnabled);
        }
    }
}

