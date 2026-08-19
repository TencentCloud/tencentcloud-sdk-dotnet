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

    public class ModifyRaspLicenseBindsRequest : AbstractModel
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
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// 计费项类型
        /// - sv_yunjing_vas_small 小型包
        /// - sv_yunjing_vas_medium 中型包
        /// - sv_yunjing_vas_large 大型包
        /// - sv_yunjing_vas_expansion 扩展包
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// 实例ID数组
        /// </summary>
        [JsonProperty("QUUID")]
        public string[] QUUID{ get; set; }

        /// <summary>
        /// 是否全部机器实例
        /// </summary>
        [JsonProperty("IsALL")]
        public bool? IsALL{ get; set; }

        /// <summary>
        /// 过滤参数,该参数需要IsALL=true时生效,表示筛选的结果作用到QUUID里
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamArraySimple(map, prefix + "QUUID.", this.QUUID);
            this.SetParamSimple(map, prefix + "IsALL", this.IsALL);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

