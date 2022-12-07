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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterReleaseRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 应用命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 制品名称或从第三方repo 安装chart时，制品压缩包下载地址, 不支持重定向类型chart 地址，结尾为*.tgz
        /// </summary>
        [JsonProperty("Chart")]
        public string Chart{ get; set; }

        /// <summary>
        /// 自定义参数
        /// </summary>
        [JsonProperty("Values")]
        public ReleaseValues Values{ get; set; }

        /// <summary>
        /// 制品来源，范围：tke 应用市场/第三方chart
        /// </summary>
        [JsonProperty("ChartFrom")]
        public string ChartFrom{ get; set; }

        /// <summary>
        /// 制品版本
        /// </summary>
        [JsonProperty("ChartVersion")]
        public string ChartVersion{ get; set; }

        /// <summary>
        /// 制品仓库URL地址
        /// </summary>
        [JsonProperty("ChartRepoURL")]
        public string ChartRepoURL{ get; set; }

        /// <summary>
        /// 制品访问用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 制品访问密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 制品命名空间
        /// </summary>
        [JsonProperty("ChartNamespace")]
        public string ChartNamespace{ get; set; }

        /// <summary>
        /// 集群类型，支持传 tke, eks, tkeedge, exernal(注册集群）
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Chart", this.Chart);
            this.SetParamObj(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "ChartFrom", this.ChartFrom);
            this.SetParamSimple(map, prefix + "ChartVersion", this.ChartVersion);
            this.SetParamSimple(map, prefix + "ChartRepoURL", this.ChartRepoURL);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ChartNamespace", this.ChartNamespace);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
        }
    }
}

