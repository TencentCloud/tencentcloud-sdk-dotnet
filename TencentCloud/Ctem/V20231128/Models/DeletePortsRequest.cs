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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeletePortsRequest : AbstractModel
    {
        
        /// <summary>
        /// ID列表
        /// </summary>
        [JsonProperty("Ids")]
        public long?[] Ids{ get; set; }

        /// <summary>
        /// 企业ID列表，可多选
        /// </summary>
        [JsonProperty("CustomerIdList")]
        public long?[] CustomerIdList{ get; set; }

        /// <summary>
        /// 是否聚合数据
        /// </summary>
        [JsonProperty("IsAggregation")]
        public bool? IsAggregation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamArraySimple(map, prefix + "CustomerIdList.", this.CustomerIdList);
            this.SetParamSimple(map, prefix + "IsAggregation", this.IsAggregation);
        }
    }
}

