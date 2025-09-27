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

    public class UpdateStandardEngineResourceGroupResourceInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 引擎资源组名称
        /// </summary>
        [JsonProperty("EngineResourceGroupName")]
        public string EngineResourceGroupName{ get; set; }

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
        /// 是否立即重启资源组生效，0--立即生效，1--只保持不重启生效
        /// </summary>
        [JsonProperty("IsEffectiveNow")]
        public long? IsEffectiveNow{ get; set; }

        /// <summary>
        /// AI资源组资源上限
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 镜像类型，内置镜像：built-in，自定义镜像：custom
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像版本，镜像id
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// 框架类型
        /// </summary>
        [JsonProperty("FrameType")]
        public string FrameType{ get; set; }

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
        /// 自定义镜像所属地域
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
        /// 仅SQL资源组资源上限，仅用于快速模式
        /// </summary>
        [JsonProperty("SparkSize")]
        public long? SparkSize{ get; set; }

        /// <summary>
        /// gpuDriver规格
        /// </summary>
        [JsonProperty("DriverGPUSpec")]
        public long? DriverGPUSpec{ get; set; }

        /// <summary>
        /// gpuExcutor 规格
        /// </summary>
        [JsonProperty("ExecutorGPUSpec")]
        public long? ExecutorGPUSpec{ get; set; }

        /// <summary>
        /// gpu 上限
        /// </summary>
        [JsonProperty("GPULimitSize")]
        public long? GPULimitSize{ get; set; }

        /// <summary>
        /// gpu 规格
        /// </summary>
        [JsonProperty("GPUSize")]
        public long? GPUSize{ get; set; }

        /// <summary>
        /// gpupod 规格
        /// </summary>
        [JsonProperty("PythonGPUSpec")]
        public long? PythonGPUSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineResourceGroupName", this.EngineResourceGroupName);
            this.SetParamSimple(map, prefix + "DriverCuSpec", this.DriverCuSpec);
            this.SetParamSimple(map, prefix + "ExecutorCuSpec", this.ExecutorCuSpec);
            this.SetParamSimple(map, prefix + "MinExecutorNums", this.MinExecutorNums);
            this.SetParamSimple(map, prefix + "MaxExecutorNums", this.MaxExecutorNums);
            this.SetParamSimple(map, prefix + "IsEffectiveNow", this.IsEffectiveNow);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "FrameType", this.FrameType);
            this.SetParamSimple(map, prefix + "PublicDomain", this.PublicDomain);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "PythonCuSpec", this.PythonCuSpec);
            this.SetParamSimple(map, prefix + "SparkSpecMode", this.SparkSpecMode);
            this.SetParamSimple(map, prefix + "SparkSize", this.SparkSize);
            this.SetParamSimple(map, prefix + "DriverGPUSpec", this.DriverGPUSpec);
            this.SetParamSimple(map, prefix + "ExecutorGPUSpec", this.ExecutorGPUSpec);
            this.SetParamSimple(map, prefix + "GPULimitSize", this.GPULimitSize);
            this.SetParamSimple(map, prefix + "GPUSize", this.GPUSize);
            this.SetParamSimple(map, prefix + "PythonGPUSpec", this.PythonGPUSpec);
        }
    }
}

