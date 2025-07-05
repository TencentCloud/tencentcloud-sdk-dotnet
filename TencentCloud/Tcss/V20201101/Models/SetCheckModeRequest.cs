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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetCheckModeRequest : AbstractModel
    {
        
        /// <summary>
        /// 要设置的集群ID列表
        /// </summary>
        [JsonProperty("ClusterIds")]
        public string[] ClusterIds{ get; set; }

        /// <summary>
        /// 集群检查模式(正常模式"Cluster_Normal"、主动模式"Cluster_Actived"、不设置"Cluster_Unset")
        /// </summary>
        [JsonProperty("ClusterCheckMode")]
        public string ClusterCheckMode{ get; set; }

        /// <summary>
        /// 0不设置 1打开 2关闭
        /// </summary>
        [JsonProperty("ClusterAutoCheck")]
        public ulong? ClusterAutoCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ClusterIds.", this.ClusterIds);
            this.SetParamSimple(map, prefix + "ClusterCheckMode", this.ClusterCheckMode);
            this.SetParamSimple(map, prefix + "ClusterAutoCheck", this.ClusterAutoCheck);
        }
    }
}

