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

    public class CreateStandardEngineResourceGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 标准引擎资源组名称
        /// </summary>
        [JsonProperty("EngineResourceGroupName")]
        public string EngineResourceGroupName{ get; set; }

        /// <summary>
        /// 标准引擎名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

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
        /// executor最小数量，
        /// </summary>
        [JsonProperty("MinExecutorNums")]
        public long? MinExecutorNums{ get; set; }

        /// <summary>
        /// executor最大数量
        /// </summary>
        [JsonProperty("MaxExecutorNums")]
        public long? MaxExecutorNums{ get; set; }

        /// <summary>
        /// 创建资源组后是否直接拉起，0-拉起，1-不拉起
        /// </summary>
        [JsonProperty("IsLaunchNow")]
        public long? IsLaunchNow{ get; set; }

        /// <summary>
        /// 自动挂起时间，单位分钟，取值范围在1-999（在无任务AutoPauseTime后，资源组自动挂起）
        /// </summary>
        [JsonProperty("AutoPauseTime")]
        public long? AutoPauseTime{ get; set; }

        /// <summary>
        /// 资源组静态参数，需要重启资源组生效
        /// </summary>
        [JsonProperty("StaticConfigPairs")]
        public EngineResourceGroupConfigPair[] StaticConfigPairs{ get; set; }

        /// <summary>
        /// 资源组动态参数，下一个任务生效。
        /// </summary>
        [JsonProperty("DynamicConfigPairs")]
        public EngineResourceGroupConfigPair[] DynamicConfigPairs{ get; set; }

        /// <summary>
        /// 任务并发数，默人是5个
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// 网络配置名称
        /// </summary>
        [JsonProperty("NetworkConfigNames")]
        public string[] NetworkConfigNames{ get; set; }

        /// <summary>
        /// 自定义镜像域名
        /// </summary>
        [JsonProperty("PublicDomain")]
        public string PublicDomain{ get; set; }

        /// <summary>
        /// 自定义镜像实例id
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// AI类型资源组的框架类型，machine-learning，python，spark-ml，不填默认为machine-learning
        /// </summary>
        [JsonProperty("FrameType")]
        public string FrameType{ get; set; }

        /// <summary>
        /// 镜像类型，bulit-in：内置，custom：自定义，不填默认为bulit-in
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// AI资源组有效，资源组可用资源上限，该值需要小于引擎资源上限
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 资源组场景
        /// </summary>
        [JsonProperty("ResourceGroupScene")]
        public string ResourceGroupScene{ get; set; }

        /// <summary>
        /// 自定义镜像所在地域
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// python类型资源组python单机节点资源上限，该值要小于资源组的资源上限.small:1cu medium:2cu large:4cu xlarge:8cu 4xlarge:16cu 8xlarge:32cu 16xlarge:64cu，如果是高内存型资源，在类型前面加上m.
        /// </summary>
        [JsonProperty("PythonCuSpec")]
        public string PythonCuSpec{ get; set; }

        /// <summary>
        /// 仅SQL资源组资源配置模式，fast：快速模式，custom：自定义模式
        /// </summary>
        [JsonProperty("SparkSpecMode")]
        public string SparkSpecMode{ get; set; }

        /// <summary>
        /// 仅SQL资源组资源上限，仅用于快速模块
        /// </summary>
        [JsonProperty("SparkSize")]
        public long? SparkSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineResourceGroupName", this.EngineResourceGroupName);
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "AutoLaunch", this.AutoLaunch);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "DriverCuSpec", this.DriverCuSpec);
            this.SetParamSimple(map, prefix + "ExecutorCuSpec", this.ExecutorCuSpec);
            this.SetParamSimple(map, prefix + "MinExecutorNums", this.MinExecutorNums);
            this.SetParamSimple(map, prefix + "MaxExecutorNums", this.MaxExecutorNums);
            this.SetParamSimple(map, prefix + "IsLaunchNow", this.IsLaunchNow);
            this.SetParamSimple(map, prefix + "AutoPauseTime", this.AutoPauseTime);
            this.SetParamArrayObj(map, prefix + "StaticConfigPairs.", this.StaticConfigPairs);
            this.SetParamArrayObj(map, prefix + "DynamicConfigPairs.", this.DynamicConfigPairs);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamArraySimple(map, prefix + "NetworkConfigNames.", this.NetworkConfigNames);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "FrameType", this.FrameType);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ResourceGroupScene", this.ResourceGroupScene);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "PythonCuSpec", this.PythonCuSpec);
            this.SetParamSimple(map, prefix + "SparkSpecMode", this.SparkSpecMode);
            this.SetParamSimple(map, prefix + "SparkSize", this.SparkSize);
        }
    }
}

