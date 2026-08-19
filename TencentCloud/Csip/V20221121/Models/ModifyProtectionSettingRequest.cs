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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProtectionSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 资产类型
        /// - CWP 主机安全资产
        /// - TCSS_HOST 容器主机节点
        /// - TCSS_EKS 容器超级节点
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 防护配置
        /// </summary>
        [JsonProperty("Config")]
        public ModifyProtectionSetting[] Config{ get; set; }

        /// <summary>
        /// 是否全部,这里需要配合筛选条件Filters
        /// </summary>
        [JsonProperty("IsALL")]
        public bool? IsALL{ get; set; }

        /// <summary>
        /// 过滤参数,这里IsALL=true生效,结果作用到Config里
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamArrayObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "IsALL", this.IsALL);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

