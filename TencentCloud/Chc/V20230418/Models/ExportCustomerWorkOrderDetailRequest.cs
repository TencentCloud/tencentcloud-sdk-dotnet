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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportCustomerWorkOrderDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务工单类型
        /// </summary>
        [JsonProperty("WorkOrderType")]
        public string[] WorkOrderType{ get; set; }

        /// <summary>
        /// 要导出的工单的起始时间
        /// </summary>
        [JsonProperty("BeginDateTime")]
        public string BeginDateTime{ get; set; }

        /// <summary>
        /// 要导出的工单的结束时间
        /// </summary>
        [JsonProperty("EndDateTime")]
        public string EndDateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WorkOrderType.", this.WorkOrderType);
            this.SetParamSimple(map, prefix + "BeginDateTime", this.BeginDateTime);
            this.SetParamSimple(map, prefix + "EndDateTime", this.EndDateTime);
        }
    }
}

