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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceModel : AbstractModel
    {
        
        /// <summary>
        /// 源CVM ID
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// 实例计费模式
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例所在的位置。通过该参数可以指定实例所属可用区，所属项目等属性。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 指定系统盘规格
        /// </summary>
        [JsonProperty("SystemDisk")]
        public DiskModel SystemDisk{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 指定数据盘规格列表
        /// </summary>
        [JsonProperty("DataDisks")]
        public DiskModel[] DataDisks{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 公网带宽相关信息设置
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// 实例显示名称。不传则新实例名为"未命名"。最大长度不能超60个字节。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例登录设置
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 增强服务配置
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// 竞价实例最高出价
        /// </summary>
        [JsonProperty("SpotPrice")]
        public string SpotPrice{ get; set; }

        /// <summary>
        /// 实例主机名
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 提供给实例使用的用户数据
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 放置群组ID
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 关机计费模式，默认关机收费（KEEP_CHARGING / STOP_CHARGING），仅 CreateInstanceCopyPair 场景生效
        /// </summary>
        [JsonProperty("StoppedMode")]
        public string StoppedMode{ get; set; }

        /// <summary>
        /// 容灾演练使用的复制对ID，仅 CreateInstanceDrillPairs 场景生效
        /// </summary>
        [JsonProperty("CopyPairId")]
        public string CopyPairId{ get; set; }

        /// <summary>
        /// 容灾演练的恢复时间点，仅 CreateInstanceDrillPairs 场景生效
        /// </summary>
        [JsonProperty("RecoveryTime")]
        public string RecoveryTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "SpotPrice", this.SpotPrice);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "StoppedMode", this.StoppedMode);
            this.SetParamSimple(map, prefix + "CopyPairId", this.CopyPairId);
            this.SetParamSimple(map, prefix + "RecoveryTime", this.RecoveryTime);
        }
    }
}

