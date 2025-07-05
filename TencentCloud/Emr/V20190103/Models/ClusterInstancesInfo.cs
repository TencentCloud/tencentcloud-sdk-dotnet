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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInstancesInfo : AbstractModel
    {
        
        /// <summary>
        /// ID号
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 标题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ftitle")]
        [System.Obsolete]
        public string Ftitle{ get; set; }

        /// <summary>
        /// 集群名
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 地区ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 用户APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 用户UIN
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 集群VPCID
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// 实例的状态码。取值范围：
        /// <li>2：表示集群运行中。</li>
        /// <li>3：表示集群创建中。</li>
        /// <li>4：表示集群扩容中。</li>
        /// <li>5：表示集群增加router节点中。</li>
        /// <li>6：表示集群安装组件中。</li>
        /// <li>7：表示集群执行命令中。</li>
        /// <li>8：表示重启服务中。</li>
        /// <li>9：表示进入维护中。</li>
        /// <li>10：表示服务暂停中。</li>
        /// <li>11：表示退出维护中。</li>
        /// <li>12：表示退出暂停中。</li>
        /// <li>13：表示配置下发中。</li>
        /// <li>14：表示销毁集群中。</li>
        /// <li>15：表示销毁core节点中。</li>
        /// <li>16：销毁task节点中。</li>
        /// <li>17：表示销毁router节点中。</li>
        /// <li>18：表示更改webproxy密码中。</li>
        /// <li>19：表示集群隔离中。</li>
        /// <li>20：表示集群冲正中。</li>
        /// <li>21：表示集群回收中。</li>
        /// <li>22：表示变配等待中。</li>
        /// <li>23：表示集群已隔离。</li>
        /// <li>24：表示缩容节点中。</li>
        /// <li>33：表示集群等待退费中。</li>
        /// <li>34：表示集群已退费。</li>
        /// <li>301：表示创建失败。</li>
        /// <li>302：表示扩容失败。</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 已经运行时间
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// 集群产品配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Config")]
        [System.Obsolete]
        public EmrProductConfigOutter Config{ get; set; }

        /// <summary>
        /// 主节点外网IP
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// EMR版本
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// 交易版本
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// 资源订单ID
        /// </summary>
        [JsonProperty("ResourceOrderId")]
        public long? ResourceOrderId{ get; set; }

        /// <summary>
        /// 是否计费集群
        /// </summary>
        [JsonProperty("IsTradeCluster")]
        public long? IsTradeCluster{ get; set; }

        /// <summary>
        /// 集群错误状态告警信息
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// 是否采用新架构
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public long? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// 元数据库信息
        /// </summary>
        [JsonProperty("MetaDb")]
        public string MetaDb{ get; set; }

        /// <summary>
        /// 标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Hive元数据信息
        /// </summary>
        [JsonProperty("HiveMetaDb")]
        public string HiveMetaDb{ get; set; }

        /// <summary>
        /// 集群类型:EMR,CLICKHOUSE,DRUID
        /// </summary>
        [JsonProperty("ServiceClass")]
        public string ServiceClass{ get; set; }

        /// <summary>
        /// 集群所有节点的别名序列化
        /// </summary>
        [JsonProperty("AliasInfo")]
        public string AliasInfo{ get; set; }

        /// <summary>
        /// 集群版本Id
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 地区ID
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }

        /// <summary>
        /// 场景化集群类型
        /// </summary>
        [JsonProperty("SceneServiceClass")]
        public string SceneServiceClass{ get; set; }

        /// <summary>
        /// 场景化EMR版本
        /// </summary>
        [JsonProperty("SceneEmrVersion")]
        public string SceneEmrVersion{ get; set; }

        /// <summary>
        /// 场景化集群类型
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// vpc name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// subnet name
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 集群依赖关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterExternalServiceInfo")]
        public ClusterExternalServiceInfo[] ClusterExternalServiceInfo{ get; set; }

        /// <summary>
        /// 集群vpcid 字符串类型
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 子网id 字符串类型
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 节点信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopologyInfoList")]
        public TopologyInfo[] TopologyInfoList{ get; set; }

        /// <summary>
        /// 是否是跨AZ集群
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// 是否开通异常节点自动补偿
        /// </summary>
        [JsonProperty("IsCvmReplace")]
        public bool? IsCvmReplace{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("ClusterTitle")]
        public string ClusterTitle{ get; set; }

        /// <summary>
        /// 集群产品配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigDetail")]
        public EmrProductConfigDetail ConfigDetail{ get; set; }

        /// <summary>
        /// 集群绑定的文件系统数
        /// </summary>
        [JsonProperty("BindFileSystemNum")]
        public long? BindFileSystemNum{ get; set; }

        /// <summary>
        /// rss集群的绑定列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterRelationInfoList")]
        public ClusterRelationMeta[] ClusterRelationInfoList{ get; set; }

        /// <summary>
        /// Redis信息
        /// </summary>
        [JsonProperty("RedisId")]
        public string RedisId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Ftitle", this.Ftitle);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "RunTime", this.RunTime);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "MasterIp", this.MasterIp);
            this.SetParamSimple(map, prefix + "EmrVersion", this.EmrVersion);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "TradeVersion", this.TradeVersion);
            this.SetParamSimple(map, prefix + "ResourceOrderId", this.ResourceOrderId);
            this.SetParamSimple(map, prefix + "IsTradeCluster", this.IsTradeCluster);
            this.SetParamSimple(map, prefix + "AlarmInfo", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "IsWoodpeckerCluster", this.IsWoodpeckerCluster);
            this.SetParamSimple(map, prefix + "MetaDb", this.MetaDb);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HiveMetaDb", this.HiveMetaDb);
            this.SetParamSimple(map, prefix + "ServiceClass", this.ServiceClass);
            this.SetParamSimple(map, prefix + "AliasInfo", this.AliasInfo);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
            this.SetParamSimple(map, prefix + "SceneServiceClass", this.SceneServiceClass);
            this.SetParamSimple(map, prefix + "SceneEmrVersion", this.SceneEmrVersion);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamArrayObj(map, prefix + "ClusterExternalServiceInfo.", this.ClusterExternalServiceInfo);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamArrayObj(map, prefix + "TopologyInfoList.", this.TopologyInfoList);
            this.SetParamSimple(map, prefix + "IsMultiZoneCluster", this.IsMultiZoneCluster);
            this.SetParamSimple(map, prefix + "IsCvmReplace", this.IsCvmReplace);
            this.SetParamSimple(map, prefix + "ClusterTitle", this.ClusterTitle);
            this.SetParamObj(map, prefix + "ConfigDetail.", this.ConfigDetail);
            this.SetParamSimple(map, prefix + "BindFileSystemNum", this.BindFileSystemNum);
            this.SetParamArrayObj(map, prefix + "ClusterRelationInfoList.", this.ClusterRelationInfoList);
            this.SetParamSimple(map, prefix + "RedisId", this.RedisId);
        }
    }
}

