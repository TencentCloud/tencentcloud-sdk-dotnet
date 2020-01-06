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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncOption : AbstractModel
    {
        
        /// <summary>
        /// 同步对象，1-整个实例，2-指定库表
        /// </summary>
        [JsonProperty("SyncObject")]
        public ulong? SyncObject{ get; set; }

        /// <summary>
        /// 同步开始设置，1-立即开始
        /// </summary>
        [JsonProperty("RunMode")]
        public ulong? RunMode{ get; set; }

        /// <summary>
        /// 同步模式， 3-全量且增量同步
        /// </summary>
        [JsonProperty("SyncType")]
        public ulong? SyncType{ get; set; }

        /// <summary>
        /// 数据一致性检测， 1-无需配置
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public ulong? ConsistencyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SyncObject", this.SyncObject);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
        }
    }
}

