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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEipsRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP实例ID列表
        /// </summary>
        [JsonProperty("EipIds")]
        public string[] EipIds{ get; set; }

        /// <summary>
        /// EIP IP 列表
        /// </summary>
        [JsonProperty("Eips")]
        public string[] Eips{ get; set; }

        /// <summary>
        /// 主机实例ID 列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// EIP名称,模糊匹配
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 状态列表, 默认所有
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// 偏移量，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回EIP数量，默认 20, 最大值 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序字段，支持： EipId,Eip,Status, InstanceId,CreatedAt
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方式 0:递增 1:递减(默认)
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 计费模式,流量：flow，带宽：bandwidth
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// EIP归属VpcId，例如vpc-k7j1t2x1
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 绑定类型，-1：未绑定，0：物理机，1：nat网关，2：虚拟IP, 3:托管机器
        /// </summary>
        [JsonProperty("BindTypes")]
        public long?[] BindTypes{ get; set; }

        /// <summary>
        /// 独占标志，0：共享，1：独占
        /// </summary>
        [JsonProperty("ExclusiveTag")]
        public long? ExclusiveTag{ get; set; }

        /// <summary>
        /// EIP ACL实例ID
        /// </summary>
        [JsonProperty("AclId")]
        public string AclId{ get; set; }

        /// <summary>
        /// 搜索条件，是否绑定了EIP ACL， 0：未绑定，1：绑定
        /// </summary>
        [JsonProperty("BindAcl")]
        public long? BindAcl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EipIds.", this.EipIds);
            this.SetParamArraySimple(map, prefix + "Eips.", this.Eips);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "BindTypes.", this.BindTypes);
            this.SetParamSimple(map, prefix + "ExclusiveTag", this.ExclusiveTag);
            this.SetParamSimple(map, prefix + "AclId", this.AclId);
            this.SetParamSimple(map, prefix + "BindAcl", this.BindAcl);
        }
    }
}

