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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MarketComponentInfo : AbstractModel
    {
        
        /// <summary>
        /// 组件ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 组件名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 发布者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("ReleaseTime")]
        public string ReleaseTime{ get; set; }

        /// <summary>
        /// 组件简介
        /// </summary>
        [JsonProperty("Outline")]
        public string Outline{ get; set; }

        /// <summary>
        /// 指向详细描述的url
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 图标链接
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 组件版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 组件可视化信息
        /// </summary>
        [JsonProperty("WorkloadVisualConfig")]
        public string WorkloadVisualConfig{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("DetailUrl")]
        public string DetailUrl{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Installed")]
        public bool? Installed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "ReleaseTime", this.ReleaseTime);
            this.SetParamSimple(map, prefix + "Outline", this.Outline);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "WorkloadVisualConfig", this.WorkloadVisualConfig);
            this.SetParamSimple(map, prefix + "DetailUrl", this.DetailUrl);
            this.SetParamSimple(map, prefix + "Installed", this.Installed);
        }
    }
}

