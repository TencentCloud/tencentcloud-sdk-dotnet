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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SREInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>版本号</p>
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// <p>状态, 枚举值:creating/create_fail/running/updating/update_fail/restarting/restart_fail/destroying/destroy_fail</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>规格ID</p>
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// <p>副本数</p>
        /// </summary>
        [JsonProperty("Replica")]
        public long? Replica{ get; set; }

        /// <summary>
        /// <p>类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Vpc iD</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>是否开启持久化存储</p>
        /// </summary>
        [JsonProperty("EnableStorage")]
        public bool? EnableStorage{ get; set; }

        /// <summary>
        /// <p>数据存储方式</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>云硬盘容量</p>
        /// </summary>
        [JsonProperty("StorageCapacity")]
        public long? StorageCapacity{ get; set; }

        /// <summary>
        /// <p>计费方式</p>
        /// </summary>
        [JsonProperty("Paymode")]
        public string Paymode{ get; set; }

        /// <summary>
        /// <p>EKS集群的ID</p>
        /// </summary>
        [JsonProperty("EKSClusterID")]
        public string EKSClusterID{ get; set; }

        /// <summary>
        /// <p>集群创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>环境配置信息列表</p>
        /// </summary>
        [JsonProperty("EnvInfos")]
        public EnvInfo[] EnvInfos{ get; set; }

        /// <summary>
        /// <p>引擎所在的区域</p>
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// <p>注册引擎是否开启公网</p>
        /// </summary>
        [JsonProperty("EnableInternet")]
        public bool? EnableInternet{ get; set; }

        /// <summary>
        /// <p>私有网络列表信息</p>
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// <p>服务治理相关信息列表</p>
        /// </summary>
        [JsonProperty("ServiceGovernanceInfos")]
        public ServiceGovernanceInfo[] ServiceGovernanceInfos{ get; set; }

        /// <summary>
        /// <p>实例的标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public KVPair[] Tags{ get; set; }

        /// <summary>
        /// <p>引擎实例是否开启控制台公网访问地址</p>
        /// </summary>
        [JsonProperty("EnableConsoleInternet")]
        public bool? EnableConsoleInternet{ get; set; }

        /// <summary>
        /// <p>引擎实例是否开启控制台内网访问地址</p>
        /// </summary>
        [JsonProperty("EnableConsoleIntranet")]
        public bool? EnableConsoleIntranet{ get; set; }

        /// <summary>
        /// <p>引擎实例是否展示参数配置页面</p>
        /// </summary>
        [JsonProperty("ConfigInfoVisible")]
        public bool? ConfigInfoVisible{ get; set; }

        /// <summary>
        /// <p>引擎实例控制台默认密码</p>
        /// </summary>
        [JsonProperty("ConsoleDefaultPwd")]
        public string ConsoleDefaultPwd{ get; set; }

        /// <summary>
        /// <p>交易付费类型，0后付费/1预付费</p>
        /// </summary>
        [JsonProperty("TradeType")]
        public long? TradeType{ get; set; }

        /// <summary>
        /// <p>自动续费标记：0表示默认状态(用户未设置，即初始状态)， 1表示自动续费，2表示明确不自动续费</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>预付费到期时间</p>
        /// </summary>
        [JsonProperty("CurDeadline")]
        public string CurDeadline{ get; set; }

        /// <summary>
        /// <p>隔离开始时间</p>
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// <p>实例地域相关的描述信息</p>
        /// </summary>
        [JsonProperty("RegionInfos")]
        public DescribeInstanceRegionInfo[] RegionInfos{ get; set; }

        /// <summary>
        /// <p>所在EKS环境，分为common和yunti</p>
        /// </summary>
        [JsonProperty("EKSType")]
        public string EKSType{ get; set; }

        /// <summary>
        /// <p>引擎的产品版本</p>
        /// </summary>
        [JsonProperty("FeatureVersion")]
        public string FeatureVersion{ get; set; }

        /// <summary>
        /// <p>引擎实例是否开启客户端内网访问地址</p>
        /// </summary>
        [JsonProperty("EnableClientIntranet")]
        public bool? EnableClientIntranet{ get; set; }

        /// <summary>
        /// <p>存储额外配置选项</p>
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption[] StorageOption{ get; set; }

        /// <summary>
        /// <p>Zookeeper的额外环境数据信息</p>
        /// </summary>
        [JsonProperty("ZookeeperRegionInfo")]
        public ZookeeperRegionInfo ZookeeperRegionInfo{ get; set; }

        /// <summary>
        /// <p>部署架构</p>
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// <p>全局属性</p>
        /// </summary>
        [JsonProperty("GlobalType")]
        public string GlobalType{ get; set; }

        /// <summary>
        /// <p>所属组类型</p>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>组id</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string[] GroupId{ get; set; }

        /// <summary>
        /// <p>是否为主地域</p>
        /// </summary>
        [JsonProperty("IsMainRegion")]
        public bool? IsMainRegion{ get; set; }

        /// <summary>
        /// <p>是否禁止变更</p>
        /// </summary>
        [JsonProperty("MutationEnabled")]
        public bool? MutationEnabled{ get; set; }

        /// <summary>
        /// <p>禁止限流</p>
        /// </summary>
        [JsonProperty("MaxCapacityLimitEnabled")]
        public bool? MaxCapacityLimitEnabled{ get; set; }


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
            this.SetParamObj(map, prefix + "ZookeeperRegionInfo.", this.ZookeeperRegionInfo);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "GlobalType", this.GlobalType);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamArraySimple(map, prefix + "GroupId.", this.GroupId);
            this.SetParamSimple(map, prefix + "IsMainRegion", this.IsMainRegion);
            this.SetParamSimple(map, prefix + "MutationEnabled", this.MutationEnabled);
            this.SetParamSimple(map, prefix + "MaxCapacityLimitEnabled", this.MaxCapacityLimitEnabled);
        }
    }
}

