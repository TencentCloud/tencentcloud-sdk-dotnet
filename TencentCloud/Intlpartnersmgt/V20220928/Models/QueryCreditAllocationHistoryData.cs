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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryCreditAllocationHistoryData : AbstractModel
    {
        
        /// <summary>
        /// 分配时间
        /// </summary>
        [JsonProperty("AllocatedTime")]
        public string AllocatedTime{ get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 分配的信用值
        /// </summary>
        [JsonProperty("Credit")]
        public float? Credit{ get; set; }

        /// <summary>
        /// 分配的总金额
        /// </summary>
        [JsonProperty("AllocatedCredit")]
        public float? AllocatedCredit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllocatedTime", this.AllocatedTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Credit", this.Credit);
            this.SetParamSimple(map, prefix + "AllocatedCredit", this.AllocatedCredit);
        }
    }
}

