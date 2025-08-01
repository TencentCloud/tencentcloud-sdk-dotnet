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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandardEngineResourceGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 标准引擎资源组ID
        /// </summary>
        [JsonProperty("EngineResourceGroupId")]
        public string EngineResourceGroupId{ get; set; }

        /// <summary>
        /// 标准引擎资源组名称，支持1-50个英文、汉字、数字、连接线-或下划线_
        /// </summary>
        [JsonProperty("EngineResourceGroupName")]
        public string EngineResourceGroupName{ get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 资源组 状态，-1--删除、0--启动中、2--运行、3--暂停、4--暂停中、7--切换引擎中、8--配置修改中。9--资源组重启中，10--因为变配导致资源组启动、11--因为隔离导致资源组挂起、12- 资源配置下发中、 13-接入点隔离导致资源组挂起中
        /// </summary>
        [JsonProperty("ResourceGroupState")]
        public long? ResourceGroupState{ get; set; }

        /// <summary>
        /// 自动启动，（任务提交自动拉起资源组）0-自动启动，1-不自动启动
        /// </summary>
        [JsonProperty("AutoLaunch")]
        public long? AutoLaunch{ get; set; }

        /// <summary>
        /// 自动挂起资源组。0-自动挂起，1-不自动挂起
        /// </summary>
        [JsonProperty("AutoPause")]
        public long? AutoPause{ get; set; }

        /// <summary>
        /// 自动挂起时间，单位分钟，取值范围在1-999（在无任务AutoPauseTime后，资源组自动挂起）
        /// </summary>
        [JsonProperty("AutoPauseTime")]
        public long? AutoPauseTime{ get; set; }

        /// <summary>
        /// driver的cu规格：
        /// 当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu），内存型cu为cpu：men=1:8，m.small（1cu内存型）、m.medium（2cu内存型）、m.large（4cu内存型）、m.xlarge（8cu内存型）
        /// </summary>
        [JsonProperty("DriverCuSpec")]
        public string DriverCuSpec{ get; set; }

        /// <summary>
        /// executor的cu规格：
        /// 当前支持：small（默认，1cu）、medium（2cu）、large（4cu）、xlarge（8cu），内存型cu为cpu：men=1:8，m.small（1cu内存型）、m.medium（2cu内存型）、m.large（4cu内存型）、m.xlarge（8cu内存型）
        /// </summary>
        [JsonProperty("ExecutorCuSpec")]
        public string ExecutorCuSpec{ get; set; }

        /// <summary>
        /// 任务并发数
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// executor最小数量，
        /// </summary>
        [JsonProperty("MinExecutorNums")]
        public long? MinExecutorNums{ get; set; }

        /// <summary>
        /// executor最大数量，
        /// </summary>
        [JsonProperty("MaxExecutorNums")]
        public long? MaxExecutorNums{ get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 是否待重启，作为有资源参数，静态参数修改未重启生效的标识；0-- 不需要重启、1--因为资源参数待重启、2--因静态参数重启、3--因资源和静态参数而待重启、4--因网络配置而待重启、5--因网络配置和资源配置而待重启、6--因网络配置和静态参数而待重启、7--因网络配置，资源参数和静态参数而待重启、
        /// </summary>
        [JsonProperty("NeedRestart")]
        public long? NeedRestart{ get; set; }

        /// <summary>
        /// 绑定的引擎名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 绑定的引擎ID
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// 绑定的引擎状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataEngineState")]
        public long? DataEngineState{ get; set; }

        /// <summary>
        /// 接入点ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// 接入点名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessPointName")]
        public string AccessPointName{ get; set; }

        /// <summary>
        /// 接入点状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessPointState")]
        public long? AccessPointState{ get; set; }

        /// <summary>
        /// 资源组类型，console/ default
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupType")]
        public string ResourceGroupType{ get; set; }

        /// <summary>
        /// 引擎网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// 网络配置名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkConfigNames")]
        public string[] NetworkConfigNames{ get; set; }

        /// <summary>
        /// AI类型资源组的框架类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameType")]
        public string FrameType{ get; set; }

        /// <summary>
        /// AI类型资源组的镜像类型，内置：bulit-in，自定义：custom
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 镜像名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// AI资源组的可用资源上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 是否是默认资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 资源组场景
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupScene")]
        public string ResourceGroupScene{ get; set; }

        /// <summary>
        /// python类型资源组python单机节点资源上限，该值要小于资源组的资源上限.small:1cu medium:2cu large:4cu xlarge:8cu 4xlarge:16cu 8xlarge:32cu 16xlarge:64cu，如果是高内存型资源，在类型前面加上m.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PythonCuSpec")]
        public string PythonCuSpec{ get; set; }

        /// <summary>
        /// Spark类型资源组资源配置模式，fast：快速模式，custom：自定义模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkSpecMode")]
        public string SparkSpecMode{ get; set; }

        /// <summary>
        /// Spark类型资源组资源上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkSize")]
        public long? SparkSize{ get; set; }

        /// <summary>
        /// Spark类型资源组资源最小值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparkMinSize")]
        public long? SparkMinSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineResourceGroupId", this.EngineResourceGroupId);
            this.SetParamSimple(map, prefix + "EngineResourceGroupName", this.EngineResourceGroupName);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "ResourceGroupState", this.ResourceGroupState);
            this.SetParamSimple(map, prefix + "AutoLaunch", this.AutoLaunch);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseTime", this.AutoPauseTime);
            this.SetParamSimple(map, prefix + "DriverCuSpec", this.DriverCuSpec);
            this.SetParamSimple(map, prefix + "ExecutorCuSpec", this.ExecutorCuSpec);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "MinExecutorNums", this.MinExecutorNums);
            this.SetParamSimple(map, prefix + "MaxExecutorNums", this.MaxExecutorNums);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "DataEngineState", this.DataEngineState);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "AccessPointName", this.AccessPointName);
            this.SetParamSimple(map, prefix + "AccessPointState", this.AccessPointState);
            this.SetParamSimple(map, prefix + "ResourceGroupType", this.ResourceGroupType);
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamArraySimple(map, prefix + "NetworkConfigNames.", this.NetworkConfigNames);
            this.SetParamSimple(map, prefix + "FrameType", this.FrameType);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "ResourceGroupScene", this.ResourceGroupScene);
            this.SetParamSimple(map, prefix + "PythonCuSpec", this.PythonCuSpec);
            this.SetParamSimple(map, prefix + "SparkSpecMode", this.SparkSpecMode);
            this.SetParamSimple(map, prefix + "SparkSize", this.SparkSize);
            this.SetParamSimple(map, prefix + "SparkMinSize", this.SparkMinSize);
        }
    }
}

