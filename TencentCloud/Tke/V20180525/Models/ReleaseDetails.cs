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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReleaseDetails : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 应用所在命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 应用当前版本
        /// </summary>
        [JsonProperty("Version")]
        public ulong? Version{ get; set; }

        /// <summary>
        /// 应用状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 应用提示
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// 用户自定义参数
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 应用资源详情
        /// </summary>
        [JsonProperty("Manifest")]
        public string Manifest{ get; set; }

        /// <summary>
        /// 应用制品版本
        /// </summary>
        [JsonProperty("ChartVersion")]
        public string ChartVersion{ get; set; }

        /// <summary>
        /// 应用制品名称
        /// </summary>
        [JsonProperty("ChartName")]
        public string ChartName{ get; set; }

        /// <summary>
        /// 应用制品描述
        /// </summary>
        [JsonProperty("ChartDescription")]
        public string ChartDescription{ get; set; }

        /// <summary>
        /// 应用制品app版本
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 应用首次部署时间
        /// </summary>
        [JsonProperty("FirstDeployedTime")]
        public string FirstDeployedTime{ get; set; }

        /// <summary>
        /// 应用最近部署时间
        /// </summary>
        [JsonProperty("LastDeployedTime")]
        public string LastDeployedTime{ get; set; }

        /// <summary>
        /// 应用参数
        /// </summary>
        [JsonProperty("ComputedValues")]
        public string ComputedValues{ get; set; }

        /// <summary>
        /// chart 的来源， tke-market, others
        /// </summary>
        [JsonProperty("ChartFrom")]
        public string ChartFrom{ get; set; }

        /// <summary>
        /// 第三方chart 的安装地址
        /// </summary>
        [JsonProperty("ChartURL")]
        public string ChartURL{ get; set; }

        /// <summary>
        /// 通过chart 创建的资源
        /// </summary>
        [JsonProperty("Resources")]
        public string Resources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Manifest", this.Manifest);
            this.SetParamSimple(map, prefix + "ChartVersion", this.ChartVersion);
            this.SetParamSimple(map, prefix + "ChartName", this.ChartName);
            this.SetParamSimple(map, prefix + "ChartDescription", this.ChartDescription);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "FirstDeployedTime", this.FirstDeployedTime);
            this.SetParamSimple(map, prefix + "LastDeployedTime", this.LastDeployedTime);
            this.SetParamSimple(map, prefix + "ComputedValues", this.ComputedValues);
            this.SetParamSimple(map, prefix + "ChartFrom", this.ChartFrom);
            this.SetParamSimple(map, prefix + "ChartURL", this.ChartURL);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
        }
    }
}

