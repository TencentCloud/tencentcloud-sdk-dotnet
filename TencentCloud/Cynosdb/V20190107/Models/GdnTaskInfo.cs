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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GdnTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 全球数据库唯一标识
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// 全球数据库唯一别名
        /// </summary>
        [JsonProperty("GdnName")]
        public string GdnName{ get; set; }

        /// <summary>
        /// 主集群ID
        /// </summary>
        [JsonProperty("PrimaryClusterId")]
        public string PrimaryClusterId{ get; set; }

        /// <summary>
        /// 主集群所在地域
        /// </summary>
        [JsonProperty("PrimaryClusterRegion")]
        public string PrimaryClusterRegion{ get; set; }

        /// <summary>
        /// 从集群所在地域
        /// </summary>
        [JsonProperty("StandbyClusterRegion")]
        public string StandbyClusterRegion{ get; set; }

        /// <summary>
        /// 从集群ID
        /// </summary>
        [JsonProperty("StandbyClusterId")]
        public string StandbyClusterId{ get; set; }

        /// <summary>
        /// 从集群别名
        /// </summary>
        [JsonProperty("StandbyClusterName")]
        public string StandbyClusterName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
            this.SetParamSimple(map, prefix + "GdnName", this.GdnName);
            this.SetParamSimple(map, prefix + "PrimaryClusterId", this.PrimaryClusterId);
            this.SetParamSimple(map, prefix + "PrimaryClusterRegion", this.PrimaryClusterRegion);
            this.SetParamSimple(map, prefix + "StandbyClusterRegion", this.StandbyClusterRegion);
            this.SetParamSimple(map, prefix + "StandbyClusterId", this.StandbyClusterId);
            this.SetParamSimple(map, prefix + "StandbyClusterName", this.StandbyClusterName);
        }
    }
}

