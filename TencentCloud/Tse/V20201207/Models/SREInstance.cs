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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SREInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 状态, 枚举值:creating/create_fail/running/updating/update_fail/restarting/restart_fail/destroying/destroy_fail
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("Replica")]
        public long? Replica{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Vpc iD
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 是否开启持久化存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableStorage")]
        public bool? EnableStorage{ get; set; }

        /// <summary>
        /// 数据存储方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 云硬盘容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageCapacity")]
        public long? StorageCapacity{ get; set; }

        /// <summary>
        /// 计费方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Paymode")]
        public string Paymode{ get; set; }

        /// <summary>
        /// EKS集群的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EKSClusterID")]
        public string EKSClusterID{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 环境配置信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }

        /// <summary>
        /// 引擎所在的区域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// 注册引擎是否开启公网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableInternet")]
        public bool? EnableInternet{ get; set; }

        /// <summary>
        /// 私有网络列表信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// 服务治理相关信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceGovernanceInfos")]
        public ServiceGovernanceInfo[] ServiceGovernanceInfos{ get; set; }

        /// <summary>
        /// 实例的标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public KVPair[] Tags{ get; set; }

        /// <summary>
        /// 引擎实例是否开启控制台公网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableConsoleInternet")]
        public bool? EnableConsoleInternet{ get; set; }

        /// <summary>
        /// 引擎实例是否开启控制台内网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableConsoleIntranet")]
        public bool? EnableConsoleIntranet{ get; set; }

        /// <summary>
        /// 引擎实例是否展示参数配置页面
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigInfoVisible")]
        public bool? ConfigInfoVisible{ get; set; }

        /// <summary>
        /// 引擎实例控制台默认密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsoleDefaultPwd")]
        public string ConsoleDefaultPwd{ get; set; }

        /// <summary>
        /// 交易付费类型，0后付费/1预付费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// 自动续费标记：0表示默认状态(用户未设置，即初始状态)， 1表示自动续费，2表示明确不自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 预付费到期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// 隔离开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// 实例地域相关的描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegionInfos")]
        public DescribeInstanceRegionInfo[] RegionInfos{ get; set; }

        /// <summary>
        /// 所在EKS环境，分为common和yunti
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EKSType")]
        public string EKSType{ get; set; }

        /// <summary>
        /// 引擎的产品版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// 引擎实例是否开启客户端内网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableClientIntranet")]
        public bool? EnableClientIntranet{ get; set; }

        /// <summary>
        /// 存储额外配置选项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption[] StorageOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "EnableStorage", this.EnableStorage);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "StorageCapacity", this.StorageCapacity);
            this.SetParamSimple(map, prefix + "Paymode", this.Paymode);
            this.SetParamSimple(map, prefix + "EKSClusterID", this.EKSClusterID);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "EnvInfos.", this.EnvInfos);
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "EnableInternet", this.EnableInternet);
            this.SetParamArrayObj(map, prefix + "VpcInfos.", this.VpcInfos);
            this.SetParamArrayObj(map, prefix + "ServiceGovernanceInfos.", this.ServiceGovernanceInfos);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableConsoleInternet", this.EnableConsoleInternet);
            this.SetParamSimple(map, prefix + "EnableConsoleIntranet", this.EnableConsoleIntranet);
            this.SetParamSimple(map, prefix + "ConfigInfoVisible", this.ConfigInfoVisible);
            this.SetParamSimple(map, prefix + "ConsoleDefaultPwd", this.ConsoleDefaultPwd);
            this.SetParamSimple(map, prefix + "TradeType", this.TradeType);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CurDeadline", this.CurDeadline);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamArrayObj(map, prefix + "RegionInfos.", this.RegionInfos);
            this.SetParamSimple(map, prefix + "EKSType", this.EKSType);
            this.SetParamSimple(map, prefix + "FeatureVersion", this.FeatureVersion);
            this.SetParamSimple(map, prefix + "EnableClientIntranet", this.EnableClientIntranet);
            this.SetParamArrayObj(map, prefix + "StorageOption.", this.StorageOption);
        }
    }
}

