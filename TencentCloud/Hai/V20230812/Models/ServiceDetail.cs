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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceDetail : AbstractModel
    {
        
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 服务状态
        /// </summary>
        [JsonProperty("ServiceState")]
        public string ServiceState{ get; set; }

        /// <summary>
        /// 运行中的副本数
        /// </summary>
        [JsonProperty("RunningReplicas")]
        public ulong? RunningReplicas{ get; set; }

        /// <summary>
        /// 期望的副本总数
        /// </summary>
        [JsonProperty("TotalReplicas")]
        public ulong? TotalReplicas{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 算力套餐详情
        /// </summary>
        [JsonProperty("ComputeSet")]
        public ComputeDetail[] ComputeSet{ get; set; }

        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 服务部署信息
        /// </summary>
        [JsonProperty("DeploymentConfigs")]
        public DeploymentConfig[] DeploymentConfigs{ get; set; }

        /// <summary>
        /// 服务超参数配置
        /// </summary>
        [JsonProperty("HyperParam")]
        public HyperParam HyperParam{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SecurityType")]
        public string SecurityType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RoleComputeSet")]
        public ComputeDetail[] RoleComputeSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TargetReplicas")]
        public ulong? TargetReplicas{ get; set; }

        /// <summary>
        /// 计费类型：POSTPAID_BY_HOUR(按量)/PREPAID_BY_MONTH(包月)
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 到期时间(包月)，按量为空
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 自动续费标识(包月)
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 受限状态(如欠费隔离)
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// 是否自定义部署：1是 0否
        /// </summary>
        [JsonProperty("IsCustomDeploy")]
        public long? IsCustomDeploy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceState", this.ServiceState);
            this.SetParamSimple(map, prefix + "RunningReplicas", this.RunningReplicas);
            this.SetParamSimple(map, prefix + "TotalReplicas", this.TotalReplicas);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "ComputeSet.", this.ComputeSet);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArrayObj(map, prefix + "DeploymentConfigs.", this.DeploymentConfigs);
            this.SetParamObj(map, prefix + "HyperParam.", this.HyperParam);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamArrayObj(map, prefix + "RoleComputeSet.", this.RoleComputeSet);
            this.SetParamSimple(map, prefix + "TargetReplicas", this.TargetReplicas);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "IsCustomDeploy", this.IsCustomDeploy);
        }
    }
}

