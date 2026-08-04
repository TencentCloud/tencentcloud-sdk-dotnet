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

    public class DescribeDeviceWorkOrderDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>工单ID</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// <p>服务类型</p>
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
        /// <p>工单流程状态</p>
        /// </summary>
        [JsonProperty("StepSet")]
        public OrderStep[] StepSet{ get; set; }

        /// <summary>
        /// <p>工单设备信息</p>
        /// </summary>
        [JsonProperty("DeviceSet")]
        public DeviceHistory[] DeviceSet{ get; set; }

        /// <summary>
        /// <p>工单的入参信息</p>
        /// </summary>
        [JsonProperty("BaseInfo")]
        public DeviceOrderBaseInfo BaseInfo{ get; set; }

        /// <summary>
        /// <p>工单的拒绝原因，工单状态为reject的时候返回</p>
        /// </summary>
        [JsonProperty("RejectReason")]
        public string RejectReason{ get; set; }

        /// <summary>
        /// <p>工单 SLA 信息</p>
        /// </summary>
        [JsonProperty("SLAInfo")]
        public SLAInfo SLAInfo{ get; set; }

        /// <summary>
        /// <p>前序未完成的工单号</p>
        /// </summary>
        [JsonProperty("PreOrderSet")]
        public string[] PreOrderSet{ get; set; }

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
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamArrayObj(map, prefix + "StepSet.", this.StepSet);
            this.SetParamArrayObj(map, prefix + "DeviceSet.", this.DeviceSet);
            this.SetParamObj(map, prefix + "BaseInfo.", this.BaseInfo);
            this.SetParamSimple(map, prefix + "RejectReason", this.RejectReason);
            this.SetParamObj(map, prefix + "SLAInfo.", this.SLAInfo);
            this.SetParamArraySimple(map, prefix + "PreOrderSet.", this.PreOrderSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

