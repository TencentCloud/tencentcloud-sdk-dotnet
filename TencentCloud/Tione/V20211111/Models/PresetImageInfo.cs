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

    public class PresetImageInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>镜像仓库名称</p>
        /// </summary>
        [JsonProperty("ImageRepo")]
        public string ImageRepo{ get; set; }

        /// <summary>
        /// <p>镜像标签</p>
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// <p>镜像url地址</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>镜像的大小</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public string ImageSize{ get; set; }

        /// <summary>
        /// <p>镜像描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>适用模块</p>
        /// </summary>
        [JsonProperty("ApplicableModuleList")]
        public string[] ApplicableModuleList{ get; set; }

        /// <summary>
        /// <p>使用场景</p>
        /// </summary>
        [JsonProperty("Scenario")]
        public string Scenario{ get; set; }

        /// <summary>
        /// <p>框架名称</p>
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>框架版本</p>
        /// </summary>
        [JsonProperty("FrameworkVersion")]
        public string FrameworkVersion{ get; set; }

        /// <summary>
        /// <p>芯片类型</p>
        /// </summary>
        [JsonProperty("ChipTypeList")]
        public string[] ChipTypeList{ get; set; }

        /// <summary>
        /// <p>运行库版本</p>
        /// </summary>
        [JsonProperty("ComputeLibVersion")]
        public string ComputeLibVersion{ get; set; }

        /// <summary>
        /// <p>python版本</p>
        /// </summary>
        [JsonProperty("PythonVersion")]
        public string PythonVersion{ get; set; }

        /// <summary>
        /// <p>操作系统</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>运行库列表</p>
        /// </summary>
        [JsonProperty("RuntimeLibList")]
        public RuntimeLib[] RuntimeLibList{ get; set; }

        /// <summary>
        /// <p>支持的gpu列表</p>
        /// </summary>
        [JsonProperty("SupportGpuList")]
        public string[] SupportGpuList{ get; set; }

        /// <summary>
        /// <p>扩展属性</p>
        /// </summary>
        [JsonProperty("ExtraAttributeList")]
        public Attribute[] ExtraAttributeList{ get; set; }

        /// <summary>
        /// <p>是否支持分布式部署</p>
        /// </summary>
        [JsonProperty("SupportDistributedDeploy")]
        public bool? SupportDistributedDeploy{ get; set; }

        /// <summary>
        /// <p>是否最新稳定版本</p>
        /// </summary>
        [JsonProperty("IsLatestStable")]
        public bool? IsLatestStable{ get; set; }

        /// <summary>
        /// <p>镜像的名称</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>镜像版本号（内部）</p>
        /// </summary>
        [JsonProperty("Version")]
        public ulong? Version{ get; set; }

        /// <summary>
        /// <p>录入时间</p><p>参数格式：YYYY-MM-DDThh:mm:ssZ</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p><p>参数格式：YYYY-MM-DDThh:mm:ssZ</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>镜像类型</p><p>枚举值：</p><ul><li>TCR： TCR类型的镜像</li></ul>
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageRepo", this.ImageRepo);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "ApplicableModuleList.", this.ApplicableModuleList);
            this.SetParamSimple(map, prefix + "Scenario", this.Scenario);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "FrameworkVersion", this.FrameworkVersion);
            this.SetParamArraySimple(map, prefix + "ChipTypeList.", this.ChipTypeList);
            this.SetParamSimple(map, prefix + "ComputeLibVersion", this.ComputeLibVersion);
            this.SetParamSimple(map, prefix + "PythonVersion", this.PythonVersion);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamArrayObj(map, prefix + "RuntimeLibList.", this.RuntimeLibList);
            this.SetParamArraySimple(map, prefix + "SupportGpuList.", this.SupportGpuList);
            this.SetParamArrayObj(map, prefix + "ExtraAttributeList.", this.ExtraAttributeList);
            this.SetParamSimple(map, prefix + "SupportDistributedDeploy", this.SupportDistributedDeploy);
            this.SetParamSimple(map, prefix + "IsLatestStable", this.IsLatestStable);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
        }
    }
}

