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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterOrderItem : AbstractModel
    {
        
        /// <summary>
        /// 专用集群类型id
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// 支持的存储类型列表
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// 支持的上连交换机的链路传输速率(GiB)
        /// </summary>
        [JsonProperty("SupportedUplinkSpeed")]
        public long?[] SupportedUplinkSpeed{ get; set; }

        /// <summary>
        /// 支持的实例族列表
        /// </summary>
        [JsonProperty("SupportedInstanceFamily")]
        public string[] SupportedInstanceFamily{ get; set; }

        /// <summary>
        /// 地板承重要求(KG)
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 功率要求(KW)
        /// </summary>
        [JsonProperty("PowerDraw")]
        public float? PowerDraw{ get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("SubOrderStatus")]
        public string SubOrderStatus{ get; set; }

        /// <summary>
        /// 订单创建的时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 子订单ID
        /// </summary>
        [JsonProperty("SubOrderId")]
        public string SubOrderId{ get; set; }

        /// <summary>
        /// 关联的集群规格数量
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 规格简单描述
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规格详细描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CPU数
        /// </summary>
        [JsonProperty("TotalCpu")]
        public long? TotalCpu{ get; set; }

        /// <summary>
        /// 内存数
        /// </summary>
        [JsonProperty("TotalMem")]
        public long? TotalMem{ get; set; }

        /// <summary>
        /// GPU数
        /// </summary>
        [JsonProperty("TotalGpu")]
        public long? TotalGpu{ get; set; }

        /// <summary>
        /// 规格英文名
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 规格展示
        /// </summary>
        [JsonProperty("ComputeFormat")]
        public string ComputeFormat{ get; set; }

        /// <summary>
        /// 规格类型
        /// </summary>
        [JsonProperty("TypeFamily")]
        public string TypeFamily{ get; set; }

        /// <summary>
        /// 0未支付，1已支付
        /// </summary>
        [JsonProperty("SubOrderPayStatus")]
        public long? SubOrderPayStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkSpeed.", this.SupportedUplinkSpeed);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDraw", this.PowerDraw);
            this.SetParamSimple(map, prefix + "SubOrderStatus", this.SubOrderStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SubOrderId", this.SubOrderId);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "TotalGpu", this.TotalGpu);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "ComputeFormat", this.ComputeFormat);
            this.SetParamSimple(map, prefix + "TypeFamily", this.TypeFamily);
            this.SetParamSimple(map, prefix + "SubOrderPayStatus", this.SubOrderPayStatus);
        }
    }
}

