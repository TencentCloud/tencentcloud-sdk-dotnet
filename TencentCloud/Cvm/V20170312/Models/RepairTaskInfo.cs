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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RepairTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 维修任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 任务类型ID，与任务类型中文名的对应关系如下：
        /// 
        /// - `101`：实例运行隐患
        /// - `102`：实例运行异常
        /// - `103`：实例硬盘异常
        /// - `104`：实例网络连接异常
        /// - `105`：实例运行预警
        /// - `106`：实例硬盘预警
        /// - `107`：实例维护升级
        /// 
        /// 各任务类型的具体含义，可参考 [维修任务分类](https://cloud.tencent.com/document/product/213/67789#.E7.BB.B4.E4.BF.AE.E4.BB.BB.E5.8A.A1.E5.88.86.E7.B1.BB)。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public ulong? TaskTypeId{ get; set; }

        /// <summary>
        /// 任务类型中文名
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// 任务状态ID，与任务状态中文名的对应关系如下：
        /// 
        /// - `1`：待授权
        /// - `2`：处理中
        /// - `3`：已结束
        /// - `4`：已预约
        /// - `5`：已取消
        /// - `6`：已避免
        /// 
        /// 各任务状态的具体含义，可参考 [任务状态](https://cloud.tencent.com/document/product/213/67789#.E4.BB.BB.E5.8A.A1.E7.8A.B6.E6.80.81)。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }

        /// <summary>
        /// 设备状态ID，与设备状态中文名的对应关系如下：
        /// 
        /// - `1`：故障中
        /// - `2`：处理中
        /// - `3`：正常
        /// - `4`：已预约
        /// - `5`：已取消
        /// - `6`：已避免
        /// </summary>
        [JsonProperty("DeviceStatus")]
        public ulong? DeviceStatus{ get; set; }

        /// <summary>
        /// 操作状态ID，与操作状态中文名的对应关系如下：
        /// 
        /// - `1`：未授权
        /// - `2`：已授权
        /// - `3`：已处理
        /// - `4`：已预约
        /// - `5`：已取消
        /// - `6`：已避免
        /// </summary>
        [JsonProperty("OperateStatus")]
        public ulong? OperateStatus{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务授权时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthTime")]
        public string AuthTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskDetail")]
        public string TaskDetail{ get; set; }

        /// <summary>
        /// 可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 所在私有网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 所在私有网络名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 所在子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 所在子网名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 实例公网IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 实例内网IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// 产品类型，支持取值：
        /// 
        /// - `CVM`：云服务器
        /// - `CDH`：专用宿主机
        /// - `CPM2.0`：裸金属云服务器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 任务子类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskSubType")]
        public string TaskSubType{ get; set; }

        /// <summary>
        /// 任务授权类型，当前`AuthType`和维修任务提供的授权选项的对应关系如下：
        /// 
        /// - `"1"`：仅提供【在线迁移授权】
        /// - `"2"`：仅提供【停机授权】
        /// - `"3"`：仅提供【在线换盘授权】
        /// - `"4"`：提供【停机换盘授权】（默认）、【弃盘迁移授权】（可选）
        /// - `"5"`：提供【停机授权】（默认）、【弃盘迁移授权】（可选）
        /// - `"6"`：仅提供【在线维护授权】
        /// - `"7"`：提供【在线维护授权】（默认）、【停机授权】（可选）
        /// - `"8"`：仅提供【弃盘迁移授权】
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 授权渠道，支持取值：
        /// 
        /// - `Waiting_auth`：待授权
        /// - `Customer_auth`：客户操作授权
        /// - `System_mandatory_auth`：系统默认授权
        /// - `Pre_policy_auth`：预置策略授权
        /// </summary>
        [JsonProperty("AuthSource")]
        public string AuthSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "DeviceStatus", this.DeviceStatus);
            this.SetParamSimple(map, prefix + "OperateStatus", this.OperateStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AuthTime", this.AuthTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskDetail", this.TaskDetail);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "TaskSubType", this.TaskSubType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "AuthSource", this.AuthSource);
        }
    }
}

