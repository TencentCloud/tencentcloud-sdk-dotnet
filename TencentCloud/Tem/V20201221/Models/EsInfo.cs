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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsInfo : AbstractModel
    {
        
        /// <summary>
        /// 最小实例数
        /// </summary>
        [JsonProperty("MinAliveInstances")]
        public long? MinAliveInstances{ get; set; }

        /// <summary>
        /// 最大实例数
        /// </summary>
        [JsonProperty("MaxAliveInstances")]
        public long? MaxAliveInstances{ get; set; }

        /// <summary>
        /// 弹性策略,1:cpu，2:内存
        /// </summary>
        [JsonProperty("EsStrategy")]
        public long? EsStrategy{ get; set; }

        /// <summary>
        /// 弹性扩缩容条件值
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// 版本Id
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinAliveInstances", this.MinAliveInstances);
            this.SetParamSimple(map, prefix + "MaxAliveInstances", this.MaxAliveInstances);
            this.SetParamSimple(map, prefix + "EsStrategy", this.EsStrategy);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
        }
    }
}

