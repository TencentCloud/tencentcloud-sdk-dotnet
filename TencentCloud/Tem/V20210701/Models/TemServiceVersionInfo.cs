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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemServiceVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// 主键
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 部署方式
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// jdk版本
        /// </summary>
        [JsonProperty("JdkVersion")]
        public string JdkVersion{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 部署版本
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// 发布方式
        /// </summary>
        [JsonProperty("PublishMode")]
        public string PublishMode{ get; set; }

        /// <summary>
        /// 启动参数
        /// </summary>
        [JsonProperty("JvmOpts")]
        public string JvmOpts{ get; set; }

        /// <summary>
        /// 初始实例
        /// </summary>
        [JsonProperty("InitPodNum")]
        public long? InitPodNum{ get; set; }

        /// <summary>
        /// cpu规格
        /// </summary>
        [JsonProperty("CpuSpec")]
        public float? CpuSpec{ get; set; }

        /// <summary>
        /// 内存规格
        /// </summary>
        [JsonProperty("MemorySpec")]
        public float? MemorySpec{ get; set; }

        /// <summary>
        /// 镜像路径
        /// </summary>
        [JsonProperty("ImgRepo")]
        public string ImgRepo{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImgName")]
        public string ImgName{ get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [JsonProperty("ImgVersion")]
        public string ImgVersion{ get; set; }

        /// <summary>
        /// 弹性配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsInfo")]
        public EsInfo EsInfo{ get; set; }

        /// <summary>
        /// 环境配置
        /// </summary>
        [JsonProperty("EnvConf")]
        public Pair[] EnvConf{ get; set; }

        /// <summary>
        /// 存储配置
        /// </summary>
        [JsonProperty("StorageConfs")]
        public StorageConf[] StorageConfs{ get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 私有网络
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// 子网网络
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyDate")]
        public string ModifyDate{ get; set; }

        /// <summary>
        /// 挂载配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageMountConfs")]
        public StorageMountConf[] StorageMountConfs{ get; set; }

        /// <summary>
        /// 版本名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 日志输出配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogOutputConf")]
        public LogOutputConf LogOutputConf{ get; set; }

        /// <summary>
        /// 服务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 服务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationDescription")]
        public string ApplicationDescription{ get; set; }

        /// <summary>
        /// 环境名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// 环境ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 公网地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// 是否开通公网访问
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnablePublicAccess")]
        public bool? EnablePublicAccess{ get; set; }

        /// <summary>
        /// 现有的实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentInstances")]
        public long? CurrentInstances{ get; set; }

        /// <summary>
        /// 期望的实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpectedInstances")]
        public long? ExpectedInstances{ get; set; }

        /// <summary>
        /// 编程语言
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodingLanguage")]
        public string CodingLanguage{ get; set; }

        /// <summary>
        /// 程序包名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PkgName")]
        public string PkgName{ get; set; }

        /// <summary>
        /// 是否启用弹性伸缩
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsEnable")]
        public long? EsEnable{ get; set; }

        /// <summary>
        /// 弹性策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsStrategy")]
        public long? EsStrategy{ get; set; }

        /// <summary>
        /// 镜像tag
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// 是否启用log
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogEnable")]
        public long? LogEnable{ get; set; }

        /// <summary>
        /// 最小实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinAliveInstances")]
        public string MinAliveInstances{ get; set; }

        /// <summary>
        /// 安全组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 镜像命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageCommand")]
        public string ImageCommand{ get; set; }

        /// <summary>
        /// 镜像命令参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageArgs")]
        public string[] ImageArgs{ get; set; }

        /// <summary>
        /// 是否使用默认注册中心配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseRegistryDefaultConfig")]
        public bool? UseRegistryDefaultConfig{ get; set; }

        /// <summary>
        /// eks 访问设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Service")]
        public EksService Service{ get; set; }

        /// <summary>
        /// 挂载配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettingConfs")]
        public MountedSettingConf[] SettingConfs{ get; set; }

        /// <summary>
        /// log path数组信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogConfs")]
        public string[] LogConfs{ get; set; }

        /// <summary>
        /// 启动后立即执行的脚本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostStart")]
        public string PostStart{ get; set; }

        /// <summary>
        /// 停止前执行的脚本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PreStop")]
        public string PreStop{ get; set; }

        /// <summary>
        /// 存活探针配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Liveness")]
        public HealthCheckConfig Liveness{ get; set; }

        /// <summary>
        /// 就绪探针配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Readiness")]
        public HealthCheckConfig Readiness{ get; set; }

        /// <summary>
        /// 弹性策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HorizontalAutoscaler")]
        public HorizontalAutoscaler[] HorizontalAutoscaler{ get; set; }

        /// <summary>
        /// 定时弹性策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronHorizontalAutoscaler")]
        public CronHorizontalAutoscaler[] CronHorizontalAutoscaler{ get; set; }

        /// <summary>
        /// 应用实际可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 最新部署时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastDeployDate")]
        public string LastDeployDate{ get; set; }

        /// <summary>
        /// 最新部署成功时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastDeploySuccessDate")]
        public string LastDeploySuccessDate{ get; set; }

        /// <summary>
        /// 应用所在node信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodeInfos")]
        public NodeInfo[] NodeInfos{ get; set; }

        /// <summary>
        /// image类型 -0 为demo -1为正常image
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageType")]
        public long? ImageType{ get; set; }

        /// <summary>
        /// 是否启用调用链组件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableTracing")]
        public ulong? EnableTracing{ get; set; }

        /// <summary>
        /// 是否开启调用链上报，只有 EnableTracing=1 时生效（参数已弃用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableTracingReport")]
        public ulong? EnableTracingReport{ get; set; }

        /// <summary>
        /// 镜像类型：0-个人镜像、1-企业镜像、2-公有镜像
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoType")]
        public ulong? RepoType{ get; set; }

        /// <summary>
        /// 分批发布子状态：batch_updating、batch_updating_waiting_confirm
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BatchDeployStatus")]
        public string BatchDeployStatus{ get; set; }

        /// <summary>
        /// APM 资源 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApmInstanceId")]
        public string ApmInstanceId{ get; set; }

        /// <summary>
        /// 工作负载信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkloadInfo")]
        public WorkloadInfo WorkloadInfo{ get; set; }

        /// <summary>
        /// 是否启用应用加速
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpeedUp")]
        public bool? SpeedUp{ get; set; }

        /// <summary>
        /// 启动检测探针配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupProbe")]
        public HealthCheckConfig StartupProbe{ get; set; }

        /// <summary>
        /// 操作系统版本，可选参数：
        /// - ALPINE
        /// - CENTOS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OsFlavour")]
        public string OsFlavour{ get; set; }

        /// <summary>
        /// 镜像仓库server
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RepoServer")]
        public string RepoServer{ get; set; }

        /// <summary>
        /// 是否正在发布中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnderDeploying")]
        public bool? UnderDeploying{ get; set; }

        /// <summary>
        /// 监控业务指标监控
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnablePrometheusConf")]
        public EnablePrometheusConf EnablePrometheusConf{ get; set; }

        /// <summary>
        /// 是否为手动停止
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppedManually")]
        public bool? StoppedManually{ get; set; }

        /// <summary>
        /// tcr实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcrInstanceId")]
        public string TcrInstanceId{ get; set; }

        /// <summary>
        /// 1：开始自动metrics采集（open-telemetry）；
        /// 0：关闭metrics采集；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableMetrics")]
        public long? EnableMetrics{ get; set; }

        /// <summary>
        /// 用户AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户SubAccountUin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 用户Uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 应用分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 是否启用注册中心
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRegistry")]
        public long? EnableRegistry{ get; set; }

        /// <summary>
        /// 弹性伸缩数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoscalerList")]
        public Autoscaler[] AutoscalerList{ get; set; }

        /// <summary>
        /// 修改人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Modifier")]
        public string Modifier{ get; set; }

        /// <summary>
        /// 创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 部署策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployStrategyConf")]
        public DeployStrategyConf DeployStrategyConf{ get; set; }

        /// <summary>
        /// 实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodList")]
        public DescribeRunPodPage PodList{ get; set; }

        /// <summary>
        /// 发布时配置是否有修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfEdited")]
        public bool? ConfEdited{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "JdkVersion", this.JdkVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PublishMode", this.PublishMode);
            this.SetParamSimple(map, prefix + "JvmOpts", this.JvmOpts);
            this.SetParamSimple(map, prefix + "InitPodNum", this.InitPodNum);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "ImgRepo", this.ImgRepo);
            this.SetParamSimple(map, prefix + "ImgName", this.ImgName);
            this.SetParamSimple(map, prefix + "ImgVersion", this.ImgVersion);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamArrayObj(map, prefix + "EnvConf.", this.EnvConf);
            this.SetParamArrayObj(map, prefix + "StorageConfs.", this.StorageConfs);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "ModifyDate", this.ModifyDate);
            this.SetParamArrayObj(map, prefix + "StorageMountConfs.", this.StorageMountConfs);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamObj(map, prefix + "LogOutputConf.", this.LogOutputConf);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationDescription", this.ApplicationDescription);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "EnablePublicAccess", this.EnablePublicAccess);
            this.SetParamSimple(map, prefix + "CurrentInstances", this.CurrentInstances);
            this.SetParamSimple(map, prefix + "ExpectedInstances", this.ExpectedInstances);
            this.SetParamSimple(map, prefix + "CodingLanguage", this.CodingLanguage);
            this.SetParamSimple(map, prefix + "PkgName", this.PkgName);
            this.SetParamSimple(map, prefix + "EsEnable", this.EsEnable);
            this.SetParamSimple(map, prefix + "EsStrategy", this.EsStrategy);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamSimple(map, prefix + "MinAliveInstances", this.MinAliveInstances);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "ImageCommand", this.ImageCommand);
            this.SetParamArraySimple(map, prefix + "ImageArgs.", this.ImageArgs);
            this.SetParamSimple(map, prefix + "UseRegistryDefaultConfig", this.UseRegistryDefaultConfig);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamArrayObj(map, prefix + "SettingConfs.", this.SettingConfs);
            this.SetParamArraySimple(map, prefix + "LogConfs.", this.LogConfs);
            this.SetParamSimple(map, prefix + "PostStart", this.PostStart);
            this.SetParamSimple(map, prefix + "PreStop", this.PreStop);
            this.SetParamObj(map, prefix + "Liveness.", this.Liveness);
            this.SetParamObj(map, prefix + "Readiness.", this.Readiness);
            this.SetParamArrayObj(map, prefix + "HorizontalAutoscaler.", this.HorizontalAutoscaler);
            this.SetParamArrayObj(map, prefix + "CronHorizontalAutoscaler.", this.CronHorizontalAutoscaler);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "LastDeployDate", this.LastDeployDate);
            this.SetParamSimple(map, prefix + "LastDeploySuccessDate", this.LastDeploySuccessDate);
            this.SetParamArrayObj(map, prefix + "NodeInfos.", this.NodeInfos);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "EnableTracing", this.EnableTracing);
            this.SetParamSimple(map, prefix + "EnableTracingReport", this.EnableTracingReport);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
            this.SetParamSimple(map, prefix + "BatchDeployStatus", this.BatchDeployStatus);
            this.SetParamSimple(map, prefix + "ApmInstanceId", this.ApmInstanceId);
            this.SetParamObj(map, prefix + "WorkloadInfo.", this.WorkloadInfo);
            this.SetParamSimple(map, prefix + "SpeedUp", this.SpeedUp);
            this.SetParamObj(map, prefix + "StartupProbe.", this.StartupProbe);
            this.SetParamSimple(map, prefix + "OsFlavour", this.OsFlavour);
            this.SetParamSimple(map, prefix + "RepoServer", this.RepoServer);
            this.SetParamSimple(map, prefix + "UnderDeploying", this.UnderDeploying);
            this.SetParamObj(map, prefix + "EnablePrometheusConf.", this.EnablePrometheusConf);
            this.SetParamSimple(map, prefix + "StoppedManually", this.StoppedManually);
            this.SetParamSimple(map, prefix + "TcrInstanceId", this.TcrInstanceId);
            this.SetParamSimple(map, prefix + "EnableMetrics", this.EnableMetrics);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "EnableRegistry", this.EnableRegistry);
            this.SetParamArrayObj(map, prefix + "AutoscalerList.", this.AutoscalerList);
            this.SetParamSimple(map, prefix + "Modifier", this.Modifier);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamObj(map, prefix + "DeployStrategyConf.", this.DeployStrategyConf);
            this.SetParamObj(map, prefix + "PodList.", this.PodList);
            this.SetParamSimple(map, prefix + "ConfEdited", this.ConfEdited);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

