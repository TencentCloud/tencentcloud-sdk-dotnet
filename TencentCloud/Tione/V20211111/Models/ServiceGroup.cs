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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceGroup : AbstractModel
    {
        
        /// <summary>
        /// 服务组id
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// 服务组名
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 主账号
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 服务组下服务总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// 服务组下在运行的服务数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningServiceCount")]
        public ulong? RunningServiceCount{ get; set; }

        /// <summary>
        /// 服务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Services")]
        public Service[] Services{ get; set; }

        /// <summary>
        /// 服务组状态，与服务一致
        ///  CREATING 创建中
        ///      CREATE_FAILED 创建失败
        ///      Normal	正常运行中
        ///      Stopped  已停止
        ///      Stopping 停止中
        ///      Abnormal 异常
        ///      Pending 启动中
        ///      Waiting 就绪中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 服务组标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 服务组下最高版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// 服务的业务状态
        /// CREATING 创建中
        ///      CREATE_FAILED 创建失败
        ///      ARREARS_STOP 因欠费被强制停止
        ///      BILLING 计费中
        ///      WHITELIST_USING 白名单试用中
        ///      WHITELIST_STOP 白名单额度不足
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// 服务的计费信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// 服务的创建来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

        /// <summary>
        /// 服务组的权重更新状态 
        /// UPDATING 更新中
        ///      UPDATED 更新成功
        ///      UPDATE_FAILED 更新失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeightUpdateStatus")]
        public string WeightUpdateStatus{ get; set; }

        /// <summary>
        /// 服务组下运行的pod数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicasCount")]
        public ulong? ReplicasCount{ get; set; }

        /// <summary>
        /// 服务组下期望的pod数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableReplicasCount")]
        public ulong? AvailableReplicasCount{ get; set; }

        /// <summary>
        /// 服务组的subuin
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 服务组的app_id
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 是否开启鉴权
        /// </summary>
        [JsonProperty("AuthorizationEnable")]
        public bool? AuthorizationEnable{ get; set; }

        /// <summary>
        /// 限流鉴权 token 列表
        /// </summary>
        [JsonProperty("AuthTokens")]
        public AuthToken[] AuthTokens{ get; set; }

        /// <summary>
        /// 用于监控的创建来源字段
        /// </summary>
        [JsonProperty("MonitorSource")]
        public string MonitorSource{ get; set; }

        /// <summary>
        /// 子用户的 nickname
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "RunningServiceCount", this.RunningServiceCount);
            this.SetParamArrayObj(map, prefix + "Services.", this.Services);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "WeightUpdateStatus", this.WeightUpdateStatus);
            this.SetParamSimple(map, prefix + "ReplicasCount", this.ReplicasCount);
            this.SetParamSimple(map, prefix + "AvailableReplicasCount", this.AvailableReplicasCount);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AuthorizationEnable", this.AuthorizationEnable);
            this.SetParamArrayObj(map, prefix + "AuthTokens.", this.AuthTokens);
            this.SetParamSimple(map, prefix + "MonitorSource", this.MonitorSource);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
        }
    }
}

