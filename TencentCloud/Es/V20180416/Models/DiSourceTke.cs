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

    public class DiSourceTke : AbstractModel
    {
        
        /// <summary>
        /// 数据源所属vpc id，创建后不允许修改
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// tke实例id，创建后不允许修改
        /// </summary>
        [JsonProperty("TkeId")]
        public string TkeId{ get; set; }

        /// <summary>
        /// tke包含的命名空间
        /// </summary>
        [JsonProperty("IncludeNamespaces")]
        public string[] IncludeNamespaces{ get; set; }

        /// <summary>
        /// tke不包含的命名空间
        /// </summary>
        [JsonProperty("ExcludeNamespaces")]
        public string[] ExcludeNamespaces{ get; set; }

        /// <summary>
        /// tke容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// tke日志内容过滤
        /// </summary>
        [JsonProperty("LogFilters")]
        public string LogFilters{ get; set; }

        /// <summary>
        /// tke beats配置项
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// tke pod标签
        /// </summary>
        [JsonProperty("PodLabel")]
        public DiSourceTkePodLabel[] PodLabel{ get; set; }

        /// <summary>
        /// /
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// tke 日志采集路径
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TkeId", this.TkeId);
            this.SetParamArraySimple(map, prefix + "IncludeNamespaces.", this.IncludeNamespaces);
            this.SetParamArraySimple(map, prefix + "ExcludeNamespaces.", this.ExcludeNamespaces);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "LogFilters", this.LogFilters);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamArrayObj(map, prefix + "PodLabel.", this.PodLabel);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
        }
    }
}

