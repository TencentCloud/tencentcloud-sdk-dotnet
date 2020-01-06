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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 实例所属项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 启动配置ID。
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 启动配置名称。
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// 实例机型。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例系统盘配置信息。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// 实例数据盘配置信息。
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// 实例登录设置。
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LimitedLoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 公网带宽相关信息设置。
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 实例所属安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 启动配置关联的伸缩组。
        /// </summary>
        [JsonProperty("AutoScalingGroupAbstractSet")]
        public AutoScalingGroupAbstract[] AutoScalingGroupAbstractSet{ get; set; }

        /// <summary>
        /// 自定义数据。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 启动配置创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 实例的增强服务启用情况与其设置。
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 启动配置当前状态。取值范围：<br><li>NORMAL：正常<br><li>IMAGE_ABNORMAL：启动配置镜像异常<br><li>CBS_SNAP_ABNORMAL：启动配置数据盘快照异常<br><li>SECURITY_GROUP_ABNORMAL：启动配置安全组异常<br>
        /// </summary>
        [JsonProperty("LaunchConfigurationStatus")]
        public string LaunchConfigurationStatus{ get; set; }

        /// <summary>
        /// 实例计费类型，CVM默认值按照POSTPAID_BY_HOUR处理。
        /// <br><li>POSTPAID_BY_HOUR：按小时后付费
        /// <br><li>SPOTPAID：竞价付费
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例的市场相关选项，如竞价实例相关参数，若指定实例的付费模式为竞价付费则该参数必传。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// 实例机型列表。
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTag[] InstanceTags{ get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("VersionNumber")]
        public long? VersionNumber{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// CAM角色名称。可通过DescribeRoleList接口返回值中的roleName获取。
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// 上次操作时，InstanceTypesCheckPolicy 取值。
        /// </summary>
        [JsonProperty("LastOperationInstanceTypesCheckPolicy")]
        public string LastOperationInstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// 云服务器主机名（HostName）的相关设置。
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "AutoScalingGroupAbstractSet.", this.AutoScalingGroupAbstractSet);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationStatus", this.LaunchConfigurationStatus);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "LastOperationInstanceTypesCheckPolicy", this.LastOperationInstanceTypesCheckPolicy);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
        }
    }
}

