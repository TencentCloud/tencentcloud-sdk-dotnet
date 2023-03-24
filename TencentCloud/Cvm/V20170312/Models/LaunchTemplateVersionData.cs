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

    public class LaunchTemplateVersionData : AbstractModel
    {
        
        /// <summary>
        /// 实例所在的位置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 实例机型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例计费模式。取值范围：<br><li>`PREPAID`：表示预付费，即包年包月<br><li>`POSTPAID_BY_HOUR`：表示后付费，即按量计费<br><li>`CDHPAID`：`专用宿主机`付费，即只对`专用宿主机`计费，不对`专用宿主机`上的实例计费。<br><li>`SPOTPAID`：表示竞价实例付费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例系统盘信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 实例数据盘信息。只包含随实例购买的数据盘。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 实例带宽信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 实例所属虚拟私有网络信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 生产实例所使用的镜像`ID`。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 实例所属安全组。该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的sgId字段来获取。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 实例登录设置。目前只返回实例所关联的密钥。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// CAM角色名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// 高性能计算集群`ID`。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// 购买实例数量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 增强服务。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// 提供给实例使用的用户数据，需要以 base64 方式编码，支持的最大数据大小为 16KB。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 置放群组ID，仅支持指定一个。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 定时任务。通过该参数可以为实例指定定时任务，目前仅支持定时销毁。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionTimer")]
        public ActionTimer ActionTimer{ get; set; }

        /// <summary>
        /// 实例的市场相关选项，如竞价实例相关参数，若指定实例的付费模式为竞价付费则该参数必传。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// 云服务器的主机名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到相应的云服务器、云硬盘实例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// 实例销毁保护标志，表示是否允许通过api接口删除实例。取值范围：
        /// 
        /// TRUE：表示开启实例保护，不允许通过api接口删除实例
        /// FALSE：表示关闭实例保护，允许通过api接口删除实例
        /// 
        /// 默认取值：FALSE。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamObj(map, prefix + "ActionTimer.", this.ActionTimer);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
        }
    }
}

