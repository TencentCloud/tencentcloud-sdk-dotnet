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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrainingTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// 训练任务ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 训练任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 主账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 子账号uin
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 创建者名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 训练框架名称，eg：SPARK、PYSARK、TENSORFLOW、PYTORCH
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameworkName")]
        public string FrameworkName{ get; set; }

        /// <summary>
        /// 训练框架版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// 框架运行环境
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameworkEnvironment")]
        public string FrameworkEnvironment{ get; set; }

        /// <summary>
        /// 计费模式
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 预付费专用资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 资源配置
        /// </summary>
        [JsonProperty("ResourceConfigInfos")]
        public ResourceConfigInfo[] ResourceConfigInfos{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 训练模式，eg：PS_WORKER、DDP、MPI、HOROVOD
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrainingMode")]
        public string TrainingMode{ get; set; }

        /// <summary>
        /// 代码包
        /// </summary>
        [JsonProperty("CodePackagePath")]
        public CosPathInfo CodePackagePath{ get; set; }

        /// <summary>
        /// 启动命令信息
        /// </summary>
        [JsonProperty("StartCmdInfo")]
        public StartCmdInfo StartCmdInfo{ get; set; }

        /// <summary>
        /// 数据来源，eg：DATASET、COS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// 数据配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataConfigs")]
        public DataConfig[] DataConfigs{ get; set; }

        /// <summary>
        /// 调优参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TuningParameters")]
        public string TuningParameters{ get; set; }

        /// <summary>
        /// 训练输出
        /// </summary>
        [JsonProperty("Output")]
        public CosPathInfo Output{ get; set; }

        /// <summary>
        /// 是否上报日志
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 日志配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// VPC ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 自定义镜像信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 运行时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeInSeconds")]
        public ulong? RuntimeInSeconds{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 训练开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 计费状态，eg：BILLING计费中，ARREARS_STOP欠费停止，NOT_BILLING不在计费中
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public string ChargeStatus{ get; set; }

        /// <summary>
        /// 最近一次实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestInstanceId")]
        public string LatestInstanceId{ get; set; }

        /// <summary>
        /// TensorBoard ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TensorBoardId")]
        public string TensorBoardId{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 训练结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 计费金额信息，eg：2.00元/小时 (按量计费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// 预付费专用资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// 任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 任务状态，eg：STARTING启动中、RUNNING运行中、STOPPING停止中、STOPPED已停止、FAILED异常、SUCCEED已完成
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 回调地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 任务关联的代码仓库配置
        /// </summary>
        [JsonProperty("CodeRepos")]
        public CodeRepoConfig[] CodeRepos{ get; set; }

        /// <summary>
        /// 暴露网络配置
        /// </summary>
        [JsonProperty("ExposeNetworkConfig")]
        public ExposeNetworkConfig ExposeNetworkConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FrameworkName", this.FrameworkName);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamSimple(map, prefix + "FrameworkEnvironment", this.FrameworkEnvironment);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamArrayObj(map, prefix + "ResourceConfigInfos.", this.ResourceConfigInfos);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TrainingMode", this.TrainingMode);
            this.SetParamObj(map, prefix + "CodePackagePath.", this.CodePackagePath);
            this.SetParamObj(map, prefix + "StartCmdInfo.", this.StartCmdInfo);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamArrayObj(map, prefix + "DataConfigs.", this.DataConfigs);
            this.SetParamSimple(map, prefix + "TuningParameters", this.TuningParameters);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "RuntimeInSeconds", this.RuntimeInSeconds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "LatestInstanceId", this.LatestInstanceId);
            this.SetParamSimple(map, prefix + "TensorBoardId", this.TensorBoardId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArrayObj(map, prefix + "CodeRepos.", this.CodeRepos);
            this.SetParamObj(map, prefix + "ExposeNetworkConfig.", this.ExposeNetworkConfig);
        }
    }
}

