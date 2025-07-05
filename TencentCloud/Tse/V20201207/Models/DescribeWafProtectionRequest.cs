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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWafProtectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        ///  防护资源的类型。
        /// - Global  实例
        /// - Service  服务
        /// - Route  路由
        /// - Object  对象
        /// </summary>
        [JsonProperty("Type")]
        [System.Obsolete]
        public string Type{ get; set; }

        /// <summary>
        /// 防护资源类型列表，支持查询多个类型（Global、Service、Route、Object）。为空时，默认查询Global类型。
        /// </summary>
        [JsonProperty("TypeList")]
        public string[] TypeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "TypeList.", this.TypeList);
        }
    }
}

