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

    public class UpdateClusterVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群 Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 需要升级到的版本
        /// </summary>
        [JsonProperty("DstVersion")]
        public string DstVersion{ get; set; }

        /// <summary>
        /// 集群自定义参数
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public ClusterExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// 可容忍的最大不可用pod数目
        /// </summary>
        [JsonProperty("MaxNotReadyPercent")]
        public float? MaxNotReadyPercent{ get; set; }

        /// <summary>
        /// 是否跳过预检查阶段
        /// </summary>
        [JsonProperty("SkipPreCheck")]
        public bool? SkipPreCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DstVersion", this.DstVersion);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamSimple(map, prefix + "MaxNotReadyPercent", this.MaxNotReadyPercent);
            this.SetParamSimple(map, prefix + "SkipPreCheck", this.SkipPreCheck);
        }
    }
}

