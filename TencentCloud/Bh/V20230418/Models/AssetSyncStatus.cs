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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetSyncStatus : AbstractModel
    {
        
        /// <summary>
        /// 上一次同步完成的时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 上一次同步的结果。 0 - 从未进行, 1 - 成功， 2 - 失败
        /// </summary>
        [JsonProperty("LastStatus")]
        public ulong? LastStatus{ get; set; }

        /// <summary>
        /// 同步任务是否正在进行中
        /// </summary>
        [JsonProperty("InProcess")]
        public bool? InProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "LastStatus", this.LastStatus);
            this.SetParamSimple(map, prefix + "InProcess", this.InProcess);
        }
    }
}

