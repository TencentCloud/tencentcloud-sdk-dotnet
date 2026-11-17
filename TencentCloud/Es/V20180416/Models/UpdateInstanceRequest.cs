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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称（1-50 个英文、汉字、数字、连接线-或下划线_）</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>节点个数（2-50个）</p>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>ES配置项（JSON格式字符串）</p>
        /// </summary>
        [JsonProperty("EsConfig")]
        public string EsConfig{ get; set; }

        /// <summary>
        /// <p>默认用户elastic的密码（8到16位，至少包括两项（[a-z,A-Z],[0-9]和[-!@#$%&amp;^*+=_:;,.?]的特殊符号）</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>可视化组件（Kibana、Cerebro）的公网访问策略</p>
        /// </summary>
        [JsonProperty("EsAcl")]
        public EsAcl EsAcl{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>磁盘大小（单位GB）</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li></p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>专用主节点个数（只支持3个或5个）</p>
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>专用主节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE32：16核32G</li><li>ES.S1.4XLARGE64：16核64G</li></p>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// <p>已废弃请使用NodeInfoList<br>专用主节点磁盘大小（单位GB系统默认配置为50GB,暂不支持自定义）</p>
        /// </summary>
        [JsonProperty("MasterNodeDiskSize")]
        public ulong? MasterNodeDiskSize{ get; set; }

        /// <summary>
        /// <p>更新配置时是否强制重启<li>true强制重启</li><li>false不强制重启</li>当前仅更新EsConfig时需要设置，默认值为false</p>
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// <p>COS自动备份信息</p>
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// <p>节点信息列表，可以只传递要更新的节点及其对应的规格信息。支持的操作包括<li>修改一种节点的个数</li><li>修改一种节点的节点规格及磁盘大小</li><li>增加一种节点类型（需要同时指定该节点的类型，个数，规格，磁盘等信息）</li>上述操作一次只能进行一种，且磁盘类型不支持修改</p>
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// <p>ES集群公网访问状态<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("PublicAccess")]
        public string PublicAccess{ get; set; }

        /// <summary>
        /// <p>公网访问控制列表</p>
        /// </summary>
        [JsonProperty("EsPublicAcl")]
        public EsPublicAcl EsPublicAcl{ get; set; }

        /// <summary>
        /// <p>Kibana公网访问状态<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("KibanaPublicAccess")]
        public string KibanaPublicAccess{ get; set; }

        /// <summary>
        /// <p>Kibana内网访问状态<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("KibanaPrivateAccess")]
        public string KibanaPrivateAccess{ get; set; }

        /// <summary>
        /// <p>ES 6.8及以上版本基础版开启或关闭用户认证</p>
        /// </summary>
        [JsonProperty("BasicSecurityType")]
        public long? BasicSecurityType{ get; set; }

        /// <summary>
        /// <p>Kibana内网端口</p>
        /// </summary>
        [JsonProperty("KibanaPrivatePort")]
        public ulong? KibanaPrivatePort{ get; set; }

        /// <summary>
        /// <p>0: 蓝绿变更方式扩容，集群不重启 （默认） 1: 磁盘解挂载扩容，集群滚动重启</p>
        /// </summary>
        [JsonProperty("ScaleType")]
        public long? ScaleType{ get; set; }

        /// <summary>
        /// <p>多可用区部署</p>
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// <p>场景化模板类型 -1：不启用 1：通用 2：日志 3：搜索</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public long? SceneType{ get; set; }

        /// <summary>
        /// <p>Kibana配置项（JSON格式字符串）</p>
        /// </summary>
        [JsonProperty("KibanaConfig")]
        public string KibanaConfig{ get; set; }

        /// <summary>
        /// <p>可视化节点配置</p>
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// <p>切换到新网络架构</p>
        /// </summary>
        [JsonProperty("SwitchPrivateLink")]
        public string SwitchPrivateLink{ get; set; }

        /// <summary>
        /// <p>启用Cerebro</p>
        /// </summary>
        [JsonProperty("EnableCerebro")]
        public bool? EnableCerebro{ get; set; }

        /// <summary>
        /// <p>Cerebro公网访问状态<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("CerebroPublicAccess")]
        public string CerebroPublicAccess{ get; set; }

        /// <summary>
        /// <p>Cerebro内网访问状态<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("CerebroPrivateAccess")]
        public string CerebroPrivateAccess{ get; set; }

        /// <summary>
        /// <p>新增或修改的配置组信息</p>
        /// </summary>
        [JsonProperty("EsConfigSet")]
        public EsConfigSetInfo EsConfigSet{ get; set; }

        /// <summary>
        /// <p>可维护时间段</p>
        /// </summary>
        [JsonProperty("OperationDuration")]
        public OperationDurationUpdated OperationDuration{ get; set; }

        /// <summary>
        /// <p>是否开启Alerting 外网告警输出：<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("KibanaAlteringPublicAccess")]
        public string KibanaAlteringPublicAccess{ get; set; }

        /// <summary>
        /// <p>kibana内网自定义域名</p>
        /// </summary>
        [JsonProperty("KibanaPrivateDomain")]
        public string KibanaPrivateDomain{ get; set; }

        /// <summary>
        /// <p>cerebro内网自定义域名</p>
        /// </summary>
        [JsonProperty("CerebroPrivateDomain")]
        public string CerebroPrivateDomain{ get; set; }

        /// <summary>
        /// <p>变更为https集群，默认是http</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>节点出站访问详细信息</p>
        /// </summary>
        [JsonProperty("OutboundPublicAcls")]
        public OutboundPublicAcl[] OutboundPublicAcls{ get; set; }

        /// <summary>
        /// <p>节点出站访问操作<br>OPEN 开启<br>CLOSE 关闭</p>
        /// </summary>
        [JsonProperty("OutboundPublicAccess")]
        public string OutboundPublicAccess{ get; set; }

        /// <summary>
        /// <p>cvm延迟上架参数</p>
        /// </summary>
        [JsonProperty("CvmDelayOnlineTime")]
        public ulong? CvmDelayOnlineTime{ get; set; }

        /// <summary>
        /// <p>分片迁移并发数</p>
        /// </summary>
        [JsonProperty("ShardAllocationConcurrents")]
        public ulong? ShardAllocationConcurrents{ get; set; }

        /// <summary>
        /// <p>分片迁移并发速度</p>
        /// </summary>
        [JsonProperty("ShardAllocationBytes")]
        public ulong? ShardAllocationBytes{ get; set; }

        /// <summary>
        /// <p>读写分离模式：-1-不开启，1-本地读写分离，2-远端读写分离</p>
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }

        /// <summary>
        /// <p>是否开启置放群组异步任务</p>
        /// </summary>
        [JsonProperty("EnableScheduleRecoverGroup")]
        public bool? EnableScheduleRecoverGroup{ get; set; }

        /// <summary>
        /// <p>置放群组异步任务可维护时间段</p>
        /// </summary>
        [JsonProperty("EnableScheduleOperationDuration")]
        public EnableScheduleOperationDuration EnableScheduleOperationDuration{ get; set; }

        /// <summary>
        /// <p>开启集群保护：OPEN-开启，CLOSE-关闭</p>
        /// </summary>
        [JsonProperty("EnableDestroyProtection")]
        public string EnableDestroyProtection{ get; set; }

        /// <summary>
        /// <p>自动扩盘参数</p>
        /// </summary>
        [JsonProperty("AutoScaleDiskInfoList")]
        public AutoScaleDiskInfo[] AutoScaleDiskInfoList{ get; set; }

        /// <summary>
        /// <p>自动扩盘删除参数</p>
        /// </summary>
        [JsonProperty("AutoScaleDiskDeleteNodeTypeList")]
        public string[] AutoScaleDiskDeleteNodeTypeList{ get; set; }

        /// <summary>
        /// <p>其他附加配置，jvm或者yml</p>
        /// </summary>
        [JsonProperty("OtherConfig")]
        public OtherConfig OtherConfig{ get; set; }

        /// <summary>
        /// <p>滚动升降配时是否等待集群恢复Green再滚动下一个节点</p>
        /// </summary>
        [JsonProperty("WaitGreen")]
        public string WaitGreen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "EsConfig", this.EsConfig);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamObj(map, prefix + "EsAcl.", this.EsAcl);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "MasterNodeNum", this.MasterNodeNum);
            this.SetParamSimple(map, prefix + "MasterNodeType", this.MasterNodeType);
            this.SetParamSimple(map, prefix + "MasterNodeDiskSize", this.MasterNodeDiskSize);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamObj(map, prefix + "CosBackup.", this.CosBackup);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamSimple(map, prefix + "PublicAccess", this.PublicAccess);
            this.SetParamObj(map, prefix + "EsPublicAcl.", this.EsPublicAcl);
            this.SetParamSimple(map, prefix + "KibanaPublicAccess", this.KibanaPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateAccess", this.KibanaPrivateAccess);
            this.SetParamSimple(map, prefix + "BasicSecurityType", this.BasicSecurityType);
            this.SetParamSimple(map, prefix + "KibanaPrivatePort", this.KibanaPrivatePort);
            this.SetParamSimple(map, prefix + "ScaleType", this.ScaleType);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "KibanaConfig", this.KibanaConfig);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamSimple(map, prefix + "SwitchPrivateLink", this.SwitchPrivateLink);
            this.SetParamSimple(map, prefix + "EnableCerebro", this.EnableCerebro);
            this.SetParamSimple(map, prefix + "CerebroPublicAccess", this.CerebroPublicAccess);
            this.SetParamSimple(map, prefix + "CerebroPrivateAccess", this.CerebroPrivateAccess);
            this.SetParamObj(map, prefix + "EsConfigSet.", this.EsConfigSet);
            this.SetParamObj(map, prefix + "OperationDuration.", this.OperationDuration);
            this.SetParamSimple(map, prefix + "KibanaAlteringPublicAccess", this.KibanaAlteringPublicAccess);
            this.SetParamSimple(map, prefix + "KibanaPrivateDomain", this.KibanaPrivateDomain);
            this.SetParamSimple(map, prefix + "CerebroPrivateDomain", this.CerebroPrivateDomain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "OutboundPublicAcls.", this.OutboundPublicAcls);
            this.SetParamSimple(map, prefix + "OutboundPublicAccess", this.OutboundPublicAccess);
            this.SetParamSimple(map, prefix + "CvmDelayOnlineTime", this.CvmDelayOnlineTime);
            this.SetParamSimple(map, prefix + "ShardAllocationConcurrents", this.ShardAllocationConcurrents);
            this.SetParamSimple(map, prefix + "ShardAllocationBytes", this.ShardAllocationBytes);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
            this.SetParamSimple(map, prefix + "EnableScheduleRecoverGroup", this.EnableScheduleRecoverGroup);
            this.SetParamObj(map, prefix + "EnableScheduleOperationDuration.", this.EnableScheduleOperationDuration);
            this.SetParamSimple(map, prefix + "EnableDestroyProtection", this.EnableDestroyProtection);
            this.SetParamArrayObj(map, prefix + "AutoScaleDiskInfoList.", this.AutoScaleDiskInfoList);
            this.SetParamArraySimple(map, prefix + "AutoScaleDiskDeleteNodeTypeList.", this.AutoScaleDiskDeleteNodeTypeList);
            this.SetParamObj(map, prefix + "OtherConfig.", this.OtherConfig);
            this.SetParamSimple(map, prefix + "WaitGreen", this.WaitGreen);
        }
    }
}

