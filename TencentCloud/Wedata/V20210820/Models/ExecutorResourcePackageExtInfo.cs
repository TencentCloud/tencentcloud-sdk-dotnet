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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutorResourcePackageExtInfo : AbstractModel
    {
        
        /// <summary>
        /// 集成资源组：InLong集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InlongGroupId")]
        public string InlongGroupId{ get; set; }

        /// <summary>
        /// 集成资源组：oceanus集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OceanusClusterId")]
        public string OceanusClusterId{ get; set; }

        /// <summary>
        /// 计费相关：产品资源id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductResourceIdList")]
        public string[] ProductResourceIdList{ get; set; }

        /// <summary>
        /// 当前资源包对应订单是否发货成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingSuccess")]
        public bool? BillingSuccess{ get; set; }

        /// <summary>
        /// apigw服务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApigwServiceId")]
        public string ApigwServiceId{ get; set; }

        /// <summary>
        /// apigw服务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApigwServiceName")]
        public string ApigwServiceName{ get; set; }

        /// <summary>
        /// 数据集成相关：dataProxy配置规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataProxySpec")]
        public long? DataProxySpec{ get; set; }

        /// <summary>
        /// dataProxy数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataProxyNum")]
        public long? DataProxyNum{ get; set; }

        /// <summary>
        /// dataProxy状态，同ExecutorGroupStatus
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataProxyStatus")]
        public long? DataProxyStatus{ get; set; }

        /// <summary>
        /// inlongManager地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongManagerUrl")]
        public string InLongManagerUrl{ get; set; }

        /// <summary>
        /// inlong版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InLongVersion")]
        public string InLongVersion{ get; set; }

        /// <summary>
        /// 私有化资源组相关: 执行及机器ip列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorMachineIpList")]
        public string ExecutorMachineIpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InlongGroupId", this.InlongGroupId);
            this.SetParamSimple(map, prefix + "OceanusClusterId", this.OceanusClusterId);
            this.SetParamArraySimple(map, prefix + "ProductResourceIdList.", this.ProductResourceIdList);
            this.SetParamSimple(map, prefix + "BillingSuccess", this.BillingSuccess);
            this.SetParamSimple(map, prefix + "ApigwServiceId", this.ApigwServiceId);
            this.SetParamSimple(map, prefix + "ApigwServiceName", this.ApigwServiceName);
            this.SetParamSimple(map, prefix + "DataProxySpec", this.DataProxySpec);
            this.SetParamSimple(map, prefix + "DataProxyNum", this.DataProxyNum);
            this.SetParamSimple(map, prefix + "DataProxyStatus", this.DataProxyStatus);
            this.SetParamSimple(map, prefix + "InLongManagerUrl", this.InLongManagerUrl);
            this.SetParamSimple(map, prefix + "InLongVersion", this.InLongVersion);
            this.SetParamSimple(map, prefix + "ExecutorMachineIpList", this.ExecutorMachineIpList);
        }
    }
}

