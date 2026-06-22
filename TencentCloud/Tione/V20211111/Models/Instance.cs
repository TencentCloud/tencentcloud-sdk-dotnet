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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// <p>资源组节点id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>节点已用资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedResource")]
        public ResourceInfo UsedResource{ get; set; }

        /// <summary>
        /// <p>节点总资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalResource")]
        public ResourceInfo TotalResource{ get; set; }

        /// <summary>
        /// <p>节点状态<br>注意：此字段为枚举值<br>说明:<br>DEPLOYING: 部署中<br>RUNNING: 运行中<br>DEPLOY_FAILED: 部署失败<br>RELEASING 释放中<br>RELEASED：已释放<br>EXCEPTION：异常<br>DEBT_OR_EXPIRED: 欠费过期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// <p>创建时间:<br>注意：北京时间，比如: 2021-12-01 12:00:00</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>到期时间<br>注意：北京时间，比如：2021-12-11 12:00:00</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>自动续费标识<br>注意：此字段为枚举值<br>说明：<br>NOTIFY_AND_MANUAL_RENEW：手动续费(取消自动续费)且到期通知<br>NOTIFY_AND_AUTO_RENEW：自动续费且到期通知<br>DISABLE_NOTIFY_AND_MANUAL_RENEW：手动续费(取消自动续费)且到期不通知</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public string AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>计费项ID</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// <p>计费项别名</p>
        /// </summary>
        [JsonProperty("SpecAlias")]
        public string SpecAlias{ get; set; }

        /// <summary>
        /// <p>计费项特性列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecFeatures")]
        public string[] SpecFeatures{ get; set; }

        /// <summary>
        /// <p>纳管cvmid</p>
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// <p>部署失败错误码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>部署失败错误信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// <p>节点可用资源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableResource")]
        public ResourceInfo AvailableResource{ get; set; }

        /// <summary>
        /// <p>资源组节点的IP</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceIP")]
        public string InstanceIP{ get; set; }

        /// <summary>
        /// <p>资源组节点的名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>cvm机型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CvmInstanceType")]
        public string CvmInstanceType{ get; set; }

        /// <summary>
        /// <p>是否自动续买</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenew")]
        public bool? AutoRenew{ get; set; }

        /// <summary>
        /// <p>是否被隔离</p>
        /// </summary>
        [JsonProperty("Isolated")]
        public bool? Isolated{ get; set; }

        /// <summary>
        /// <p>维修任务信息</p>
        /// </summary>
        [JsonProperty("RepairTaskInfo")]
        public RepairTaskInfo RepairTaskInfo{ get; set; }

        /// <summary>
        /// <p>节点可用区名称</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "UsedResource.", this.UsedResource);
            this.SetParamObj(map, prefix + "TotalResource.", this.TotalResource);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "SpecAlias", this.SpecAlias);
            this.SetParamArraySimple(map, prefix + "SpecFeatures.", this.SpecFeatures);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamObj(map, prefix + "AvailableResource.", this.AvailableResource);
            this.SetParamSimple(map, prefix + "InstanceIP", this.InstanceIP);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "CvmInstanceType", this.CvmInstanceType);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "Isolated", this.Isolated);
            this.SetParamObj(map, prefix + "RepairTaskInfo.", this.RepairTaskInfo);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
        }
    }
}

