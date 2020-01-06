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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBSyncModeResponse : AbstractModel
    {
        
        /// <summary>
        /// 同步模式：0 异步，1 强同步， 2 强同步可退化
        /// </summary>
        [JsonProperty("SyncMode")]
        public long? SyncMode{ get; set; }

        /// <summary>
        /// 是否有修改流程在执行中：1 是， 0 否。
        /// </summary>
        [JsonProperty("IsModifying")]
        public long? IsModifying{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "IsModifying", this.IsModifying);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

