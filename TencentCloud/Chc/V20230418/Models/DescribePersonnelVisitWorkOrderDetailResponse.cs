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

    public class DescribePersonnelVisitWorkOrderDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 工单进度	
        /// </summary>
        [JsonProperty("StepSet")]
        public OrderStep[] StepSet{ get; set; }

        /// <summary>
        /// 工单详情
        /// </summary>
        [JsonProperty("BaseInfo")]
        public PersonnelVisitBaseInfo BaseInfo{ get; set; }

        /// <summary>
        /// 到访人员详情
        /// </summary>
        [JsonProperty("PersonnelSet")]
        public Personnel[] PersonnelSet{ get; set; }

        /// <summary>
        /// 工单状态 订单状态, processing 处理中 ，reject 已拒绝 ，finish 已完成，exception 异常
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "StepSet.", this.StepSet);
            this.SetParamObj(map, prefix + "BaseInfo.", this.BaseInfo);
            this.SetParamArrayObj(map, prefix + "PersonnelSet.", this.PersonnelSet);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

