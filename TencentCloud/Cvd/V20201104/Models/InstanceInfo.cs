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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>实例状态<br>PENDING：表示创建中<br>LAUNCH_FAILED：表示创建失败<br>RUNNING：表示运行中<br>STOPPED：表示关机<br>STARTING：表示开机中<br>STOPPING：表示关机中<br>REBOOTING：表示重启中<br>SHUTDOWN：表示停止待销毁<br>TERMINATING：表示销毁中<br>DELETED：表示资源已经销毁，这个状态是业务层面的状态，cvm如果销毁了，在cvm侧资源已经不存在了<br>FAILED：表示资源创建失败.这个是业务层面的状态<br>ROLLBACKING：表示回滚中<br>USING：表示使用中<br>RESETTING：表示重置中.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>实例拥有者名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>实例规格<br>S1.LARGE8：4VCPU 2.5GHZ主频 8G内存 无显卡<br>S1.LARGE16：4VCPU 2.5GHZ主频 16G内存 无显卡<br>S2.2XLARGE16：8VCPU 3.2GHZ主频 16G内存 无显卡<br>G1.LARGE16：4VCPU 2.5GHZ主频 16G内存 1/4 NVIDIA T4<br>G1.2XLARGE32：8VCPU 2.5GHZ主频 32G内存 1/2 NVIDIA T4<br>G1.4XLARGE64：16VCPU 2.5GHZ主频 64G内存 1 NVIDIA T4</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>系统盘信息</p>
        /// </summary>
        [JsonProperty("SysDisk")]
        public Disk SysDisk{ get; set; }

        /// <summary>
        /// <p>挂载的数据盘信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDiskList")]
        public Disk[] DataDiskList{ get; set; }

        /// <summary>
        /// <p>桌面实例所在的区域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>桌面计费类型</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>自动续费标识。取值范围：<br>NOTIFY_AND_MANUAL_RENEW：表示通知即将过期，但不自动续费<br>NOTIFY_AND_AUTO_RENEW：表示通知即将过期，而且自动续费<br>DISABLE_NOTIFY_AND_MANUAL_RENEW：表示不通知即将过期，也不自动续费。</p><p>注意：后付费模式本项为null</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public string AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>桌面创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>桌面过期时间</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// <p>桌面描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>桌面hostname</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>桌面拥有者显示名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>桌面绑定状态。取值：<br>UNBOUND - 未绑定<br>BINDING - 绑定中<br>BOUND - 绑定</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindStatus")]
        public string BindStatus{ get; set; }

        /// <summary>
        /// <p>创建桌面的镜像id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>用户桌面vpc id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVpcId")]
        public string UserVpcId{ get; set; }

        /// <summary>
        /// <p>用户桌面子网 id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// <p>用户桌面ip</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserPrivateIp")]
        public string UserPrivateIp{ get; set; }

        /// <summary>
        /// <p>机器回收站到期时间，只有机器状态为SHUTDOWN该值才有意义</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// <p>最近一次状态变更原因, AUTO:被动变更,如欠费,如包月实例到期, MANUAL:主动变更,如主动退还实例，当前只有机器处于ISOLATING、SHUTDOWN、TERMINATING、DELETED该字段有意义</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastStatusChangeReason")]
        public string LastStatusChangeReason{ get; set; }

        /// <summary>
        /// <p>机器最近一次操作</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// <p>机器最近一次操作状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// <p>机器最近一次操作请求ReqId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperationRequestID")]
        public string LatestOperationRequestID{ get; set; }

        /// <summary>
        /// <p>机器操作系统名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>实例逻辑set</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }

        /// <summary>
        /// <p>应用id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>账号id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>关联的安全组ID列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// <p>预付费实例降配次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownGradeTimes")]
        public long? DownGradeTimes{ get; set; }

        /// <summary>
        /// <p>桌面绑定的域名策略ID列表，最多五个</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainControlPolicies")]
        public string[] DomainControlPolicies{ get; set; }

        /// <summary>
        /// <p>桌面绑定的水印策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterMarkPolicy")]
        public string WaterMarkPolicy{ get; set; }

        /// <summary>
        /// <p>桌面绑定的录屏策略ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScreenRecordingPolicy")]
        public string ScreenRecordingPolicy{ get; set; }

        /// <summary>
        /// <p>WHITE --- 白名单策略<br>BLACK --- 黑名单策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainControlPolicyType")]
        public string DomainControlPolicyType{ get; set; }

        /// <summary>
        /// <p>桌面绑定的运行管控策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunControlPolicy")]
        public string RunControlPolicy{ get; set; }

        /// <summary>
        /// <p>桌面绑定的安装管控策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstallControlPolicy")]
        public string InstallControlPolicy{ get; set; }

        /// <summary>
        /// <p>桌面是否绑定匿名用户</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnonymousAccess")]
        public bool? AnonymousAccess{ get; set; }

        /// <summary>
        /// <p>实例绑定的标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SysDisk.", this.SysDisk);
            this.SetParamArrayObj(map, prefix + "DataDiskList.", this.DataDiskList);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "UserVpcId", this.UserVpcId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamSimple(map, prefix + "UserPrivateIp", this.UserPrivateIp);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "LastStatusChangeReason", this.LastStatusChangeReason);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "LatestOperationRequestID", this.LatestOperationRequestID);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "DownGradeTimes", this.DownGradeTimes);
            this.SetParamArraySimple(map, prefix + "DomainControlPolicies.", this.DomainControlPolicies);
            this.SetParamSimple(map, prefix + "WaterMarkPolicy", this.WaterMarkPolicy);
            this.SetParamSimple(map, prefix + "ScreenRecordingPolicy", this.ScreenRecordingPolicy);
            this.SetParamSimple(map, prefix + "DomainControlPolicyType", this.DomainControlPolicyType);
            this.SetParamSimple(map, prefix + "RunControlPolicy", this.RunControlPolicy);
            this.SetParamSimple(map, prefix + "InstallControlPolicy", this.InstallControlPolicy);
            this.SetParamSimple(map, prefix + "AnonymousAccess", this.AnonymousAccess);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

