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

    public class WorkOrderData : AbstractModel
    {
        
        /// <summary>
        /// <p>工单号</p>
        /// </summary>
        [JsonProperty("WorkOrderId")]
        public string WorkOrderId{ get; set; }

        /// <summary>
        /// <p>服务类型，一个服务可能会产生多个工单</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>工单类型</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>工单状态</p>
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// <p>工单创建人</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>工单创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>工单完成时间</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>工单关联的dcops单号</p>
        /// </summary>
        [JsonProperty("TicketId")]
        public string TicketId{ get; set; }

        /// <summary>
        /// <p>SLA</p>
        /// </summary>
        [JsonProperty("SLAInfo")]
        public SLAInfo SLAInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkOrderId", this.WorkOrderId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "TicketId", this.TicketId);
            this.SetParamObj(map, prefix + "SLAInfo.", this.SLAInfo);
        }
    }
}

